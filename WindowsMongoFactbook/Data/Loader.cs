using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsMongoFactbook.Models;

namespace WindowsMongoFactbook.Data
{
    public class Loader
    {
        #region Private Declarations

        private MongoContext dbContext = null;

        #endregion Private Declarations

        #region Public Properties

        public MongoContext DbContext => dbContext ?? (dbContext = new MongoContext());

        public IQueryable<Continent> Continents => DbContext.Database.GetCollection<Continent>("Continent").AsQueryable<Continent>();
        public IQueryable<Territory> Territories => DbContext.Database.GetCollection<Territory>("Territory").AsQueryable<Territory>();
        public IQueryable<Flag> Flags => DbContext.Database.GetCollection<Flag>("Flag").AsQueryable<Flag>();

        #endregion Public Properties

   

        //Only loads continents with a ParentId, i.e. continents with no Parent ID like Europe / Antartica are not loaded.
        public IQueryable<Continent> ContinentsWithParentsOne => Continents.Join(Continents, c => c.ParentId, p => p.Id, (c, p) => new Continent()
        {
            Id = c.Id,
            Name = c.Name,
            Code = c.Code,
            ParentId = c.ParentId,
            Parent = p
        });

        //Group allows continents with null ParentId's to be loaded but they have to store Parent ID in an Enumerable list
        //rather than just the single parent.
        public IQueryable<Continent> ContinentsWithParentsTwo => Continents.GroupJoin(Continents, c => c.ParentId, p => p.Id, (c, p) => new Continent()
        {
            Id = c.Id,
            Name = c.Name,
            Code = c.Code,
            ParentId = c.ParentId,
            SubContinents = p
        });

        public IQueryable<Continent> ContinentsWithParentsThree => from c in Continents
                                                                     join p in Continents on c.ParentId equals p.Id into cJoin
                                                                     from cj in cJoin.DefaultIfEmpty()
                                                                     select new Continent()
                                                                     {
                                                                         Id = c.Id,
                                                                         Name = c.Name,
                                                                         Code = c.Code,
                                                                         ParentId = c.ParentId,
                                                                         Parent = cj
                                                                     };

        public IQueryable<Continent> ContinentsWithChildren => Continents.GroupJoin(Continents, c => c.Id, p => p.ParentId, (c, p) => new Continent()
                                                                                                                                        {
                                                                                                                                            Id = c.Id,
                                                                                                                                            Name = c.Name,
                                                                                                                                            Code = c.Code,
                                                                                                                                            ParentId = c.ParentId,
                                                                                                                                            SubContinents = p
                                                                                                                                        });

        

        //Really nasty query wich is a combo of two queries
        public IQueryable<Continent> ContinentsComplexOne => (from c in Continents
                                                                   join p in Continents on c.ParentId equals p.Id into cJoin
                                                                   from cj in cJoin.DefaultIfEmpty()
                                                                   select new Continent()
                                                                   {
                                                                       Id = c.Id,
                                                                       Name = c.Name,
                                                                       Code = c.Code,
                                                                       ParentId = c.ParentId,
                                                                       Parent = cj
                                                                   })
            .GroupJoin(Continents, c => c.Id, p => p.ParentId, (c, p) => new Continent()
                                                                   {
                                                                       Id = c.Id,
                                                                       Name = c.Name,
                                                                       Code = c.Code,
                                                                       ParentId = c.ParentId,
                                                                        Parent = c.Parent,
                                                                        SubContinents = p
                                                                   });


        //Nasty query simplified a bit
        public IQueryable<Continent> ContinentsComplexTwo => ContinentsWithParentsThree
                                                .GroupJoin(Continents, c => c.Id, p => p.ParentId, (c, p) => new Continent()
                                                {
                                                    Id = c.Id,
                                                    Name = c.Name,
                                                    Code = c.Code,
                                                    ParentId = c.ParentId,
                                                    Parent = c.Parent,
                                                    SubContinents = p
                                                });


        public IQueryable<Continent> ContinentsComplexWithTerritories => ContinentsComplexTwo
                                                .GroupJoin(Territories, continent => continent.Id, territory => territory.ContinentId, (continent, territories) => new Continent()
                                                {
                                                    Id = continent.Id,
                                                    Name = continent.Name,
                                                    Code = continent.Code,
                                                    ParentId = continent.ParentId,
                                                    Parent = continent.Parent,
                                                    SubContinents = continent.SubContinents,
                                                    Territories = territories
                                                });

        public IQueryable<Continent> ContinentsComplexWithTerritories2 => from c in Continents
                                                                          join t in TerritoriesWithFlagsTwo on c.Id equals t.ContinentId into territoryJoin
                                                                          select new Continent()
                                                                          {
                                                                              Id = c.Id,
                                                                              Name = c.Name,
                                                                              Code = c.Code,
                                                                              ParentId = c.ParentId,
                                                                              Parent = c.Parent,
                                                                              SubContinents = c.SubContinents,
                                                                              Territories = territoryJoin
                                                                          };


        public IQueryable<Continent> ContinentsComplexWithTerritories3 => from f in Flags
                                                                          join t in Territories on f.Id equals t.FlagId
                                                                          into tJoin from tj in tJoin
                                                                          join c in Continents on tj.ContinentId equals c.Id
                                                                          select new Continent()
                                                                          {
                                                                              Id = c.Id,
                                                                              Name = c.Name,
                                                                              Code = c.Code,
                                                                              ParentId = c.ParentId,
                                                                              Parent = c.Parent,
                                                                              SubContinents = c.SubContinents,
                                                                              Territories = tJoin
                                                                          };



        //Only gets territories which actually have a flag.
        public IQueryable<Territory> TerritoriesWithFlags => Territories
                                                .Join(Flags, t => t.FlagId, f => f.Id, (t, f) => new Territory()
                                                {
                                                    Id = t.Id,
                                                    Name = t.Name,
                                                    FullName = t.FullName,
                                                    LocalName = t.LocalName,
                                                    ContinentId = t.ContinentId,
                                                    FlagId = t.FlagId,
                                                    Flag = f
                                                });

        public IQueryable<Territory> TerritoriesWithFlagsTwo => from t in Territories
                                                                join f in Flags on t.FlagId equals f.Id into cJoin
                                                                from cj in cJoin.DefaultIfEmpty()
                                                                select new Territory()
                                                                {
                                                                    Id = t.Id,
                                                                    Name = t.Name,
                                                                    FullName = t.FullName,
                                                                    LocalName = t.LocalName,
                                                                    Population = t.Population,
                                                                    Area = t.Area,
                                                                    IsoCode = t.IsoCode,
                                                                    ContinentId = t.ContinentId,
                                                                    Continent = t.Continent,
                                                                    ParentId = t.ParentId,
                                                                    Parent = t.Parent,
                                                                    FlagId = t.FlagId,
                                                                    Flag = cj
                                                                };
























        public IEnumerable<BsonDocument> xxxx => GetXXXX();
        

        private IEnumerable<BsonDocument> GetXXXX()
        {
            //var filter = Builders<Continent>.Filter.All(x => x.SubContinents., null);
            //return DbContext.Database.GetCollection<Continent>("Continent").Find(filter).ToList();

            //var filter = Builders<Continent>.Filter.Empty; //=> returns all records in collection
            //var filter = Builders<Continent>.Filter.Eq("SubContinents.Code", "054"); // => this returns Oceania (because it includes Melanesia (054))

            var filter = Builders<BsonDocument>.Filter.Empty;
            var projection = Builders<BsonDocument>.Projection.Include("SubContinents");

            var result = DbContext.Database.GetCollection<BsonDocument>("Continent").Find<BsonDocument>(filter).Project(projection).ToList();
            return result;

            //return DbContext.Database.GetCollection<Continent>("Continent").Find(filter).ToList();
        }



    }
}
