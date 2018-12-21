using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using WindowsMongoFactbook.Data;
using WindowsMongoFactbook.Models;

namespace WindowsMongoFactbook
{
    public partial class Form1 : Form
    {
        private Loader loader = null;

        public Loader Loader => loader ?? (loader = new Loader());

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonLoadContinentsBasic_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Clear();
            DisplayContinent(Loader.Continents.ToList<Continent>());
        }

        private void buttonLoadBasicTerritories_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Clear();
            DisplayData<Territory>(Loader.Territories.ToList<Territory>());
        }

        private void buttonLoadBasicFlags_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Clear();
            DisplayData<Flag>(Loader.Flags.ToList<Flag>());
        }

        private void buttonContinentWithParent_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Clear();
            DisplayContinent(Loader.ContinentsWithParentsOne.ToList<Continent>());
        }

        private void buttonContinentWithParent2_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Clear();
            DisplayContinent(Loader.ContinentsWithParentsTwo.ToList<Continent>());
        }

        private void buttonContinentWithParent3_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Clear();
            DisplayContinent(Loader.ContinentsWithParentsThree.ToList<Continent>());
        }

        private void buttonContinentsWithChildren_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Clear();
            DisplayContinent(Loader.ContinentsWithChildren.ToList<Continent>());
        }

        private void buttonContinentsComplex_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Clear();
            DisplayContinent(Loader.ContinentsComplexTwo.ToList<Continent>());
        }

        private void buttonContinentComplexWithTerritories_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Clear();
            DisplayContinent(Loader.ContinentsComplexWithTerritories3);
        }

        private void buttonTerritoriesWithFlags_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Clear();
            DisplayTerritory(Loader.TerritoriesWithFlags);
        }

        private void buttonTerritoriesWithFlagTwo_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Clear();
            DisplayTerritory(Loader.TerritoriesWithFlagsTwo);
        }



        private void DisplayData<T>(IEnumerable<T> items)
        {
            foreach (var item in items)
            {
                Type type = item.GetType();
                PropertyInfo[] properties = type.GetProperties();

                foreach (PropertyInfo property in properties)
                {
                    textBoxDisplay.Text += "Name: " + property.Name + ", Value: " + property.GetValue(item, null);
                    textBoxDisplay.Text += System.Environment.NewLine;
                }

                textBoxDisplay.Text += "--------------------------------------------------------";
                textBoxDisplay.Text += System.Environment.NewLine;
            }
        }

        private void DisplayContinent(IEnumerable<Continent> items)
        {
            foreach (var item in items)
            {
                textBoxDisplay.Text += "Id: " + item.Id.ToString();
                textBoxDisplay.Text += System.Environment.NewLine;

                textBoxDisplay.Text += "Name: " + item.Name;
                textBoxDisplay.Text += System.Environment.NewLine;

                textBoxDisplay.Text += "Code: " + item.Code;
                textBoxDisplay.Text += System.Environment.NewLine;

                textBoxDisplay.Text += "ParentId: " + item.ParentId.ToString();
                textBoxDisplay.Text += System.Environment.NewLine;

                textBoxDisplay.Text += "Parent: =>";
                textBoxDisplay.Text += System.Environment.NewLine;

                if (item.Parent != null)
                {
                    textBoxDisplay.Text += "\t Id: " + item.Parent.Id.ToString();
                    textBoxDisplay.Text += System.Environment.NewLine;

                    textBoxDisplay.Text += "\t Name: " + item.Parent.Name;
                    textBoxDisplay.Text += System.Environment.NewLine;

                    textBoxDisplay.Text += "\t Code: " + item.Parent.Code;
                    textBoxDisplay.Text += System.Environment.NewLine;
                }

                textBoxDisplay.Text += "SubContinents: =>";
                textBoxDisplay.Text += System.Environment.NewLine;

                if(item.SubContinents != null)
                {
                    foreach (var sub in item.SubContinents)
                    {
                        textBoxDisplay.Text += "\t Id: " + sub.Id.ToString() + " Name:" + sub.Name;
                        textBoxDisplay.Text += System.Environment.NewLine;
                    }
                }

                textBoxDisplay.Text += "Territories: =>";
                textBoxDisplay.Text += System.Environment.NewLine;

                if (item.Territories != null)
                {
                    foreach (var t in item.Territories)
                    {
                        textBoxDisplay.Text += "\t Id: " + t.Id.ToString() + " Name:" + t.Name + " FlagId:" + t.FlagId.ToString();
                        textBoxDisplay.Text += System.Environment.NewLine;
                    }
                }

                textBoxDisplay.Text += "--------------------------------------------------------";
                textBoxDisplay.Text += System.Environment.NewLine;
            }
        }

        private void DisplayTerritory(IEnumerable<Territory> items)
        {
            foreach (var item in items)
            {
                textBoxDisplay.Text += "Id: " + item.Id.ToString();
                textBoxDisplay.Text += System.Environment.NewLine;

                textBoxDisplay.Text += "Name: " + item.Name;
                textBoxDisplay.Text += System.Environment.NewLine;

                textBoxDisplay.Text += "FullName: " + item.FullName;
                textBoxDisplay.Text += System.Environment.NewLine;

                textBoxDisplay.Text += "LocalName: " + item.LocalName;
                textBoxDisplay.Text += System.Environment.NewLine;

                textBoxDisplay.Text += "ParentId: " + item.ParentId.ToString();
                textBoxDisplay.Text += System.Environment.NewLine;

                textBoxDisplay.Text += "Parent: =>";
                textBoxDisplay.Text += System.Environment.NewLine;

                if (item.Parent != null)
                {
                    textBoxDisplay.Text += "\t Id: " + item.Parent.Id.ToString();
                    textBoxDisplay.Text += System.Environment.NewLine;

                    textBoxDisplay.Text += "\t Name: " + item.Parent.Name;
                    textBoxDisplay.Text += System.Environment.NewLine;

                    textBoxDisplay.Text += "\t Code: " + item.Parent.IsoCode;
                    textBoxDisplay.Text += System.Environment.NewLine;
                }

                textBoxDisplay.Text += "ContinentId: " + item.ContinentId.ToString();
                textBoxDisplay.Text += System.Environment.NewLine;

                textBoxDisplay.Text += "Continent: =>";
                textBoxDisplay.Text += System.Environment.NewLine;

                if (item.Continent != null)
                {
                    textBoxDisplay.Text += "\t Id: " + item.Continent.Id.ToString();
                    textBoxDisplay.Text += System.Environment.NewLine;

                    textBoxDisplay.Text += "\t Name: " + item.Continent.Name;
                    textBoxDisplay.Text += System.Environment.NewLine;

                    textBoxDisplay.Text += "\t Code: " + item.Continent.Code;
                    textBoxDisplay.Text += System.Environment.NewLine;
                }

                textBoxDisplay.Text += "FlagId: " + item.FlagId.ToString();
                textBoxDisplay.Text += System.Environment.NewLine;

                textBoxDisplay.Text += "Flag: =>";
                textBoxDisplay.Text += System.Environment.NewLine;

                if (item.Flag != null)
                {
                    textBoxDisplay.Text += "\t Id: " + item.Flag.Id.ToString();
                    textBoxDisplay.Text += System.Environment.NewLine;

                    textBoxDisplay.Text += "\t Name: " + item.Flag.Name;
                    textBoxDisplay.Text += System.Environment.NewLine;

                    textBoxDisplay.Text += "\t Code: " + item.Flag.Code;
                    textBoxDisplay.Text += System.Environment.NewLine;
                }

                textBoxDisplay.Text += "Territories: =>";
                textBoxDisplay.Text += System.Environment.NewLine;

                if (item.Territories != null)
                {
                    foreach (var sub in item.Territories)
                    {
                        textBoxDisplay.Text += "\t Id: " + sub.Id.ToString() + " Name:" + sub.Name;
                        textBoxDisplay.Text += System.Environment.NewLine;
                    }
                }

                textBoxDisplay.Text += "--------------------------------------------------------";
                textBoxDisplay.Text += System.Environment.NewLine;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Clear();

            DisplayData<BsonDocument>(Loader.xxxx);
            //DisplayContinent(Loader.xxxx);


        }

        
    }
}
