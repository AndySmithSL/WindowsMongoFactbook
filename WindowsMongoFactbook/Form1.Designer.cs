namespace WindowsMongoFactbook
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonLoadContinentsBasic = new System.Windows.Forms.Button();
            this.textBoxDisplay = new System.Windows.Forms.TextBox();
            this.buttonLoadBasicTerritories = new System.Windows.Forms.Button();
            this.buttonLoadBasicFlags = new System.Windows.Forms.Button();
            this.buttonContinentWithParent = new System.Windows.Forms.Button();
            this.buttonContinentWithParent2 = new System.Windows.Forms.Button();
            this.buttonContinentWithParent3 = new System.Windows.Forms.Button();
            this.buttonContinentsWithChildren = new System.Windows.Forms.Button();
            this.buttonContinentsComplex = new System.Windows.Forms.Button();
            this.buttonContinentComplexWithTerritories = new System.Windows.Forms.Button();
            this.buttonTerritoriesWithFlags = new System.Windows.Forms.Button();
            this.buttonTerritoriesWithFlagTwo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonLoadContinentsBasic
            // 
            this.buttonLoadContinentsBasic.Location = new System.Drawing.Point(12, 12);
            this.buttonLoadContinentsBasic.Name = "buttonLoadContinentsBasic";
            this.buttonLoadContinentsBasic.Size = new System.Drawing.Size(372, 23);
            this.buttonLoadContinentsBasic.TabIndex = 0;
            this.buttonLoadContinentsBasic.Text = "Basic Continents";
            this.buttonLoadContinentsBasic.UseVisualStyleBackColor = true;
            this.buttonLoadContinentsBasic.Click += new System.EventHandler(this.buttonLoadContinentsBasic_Click);
            // 
            // textBoxDisplay
            // 
            this.textBoxDisplay.Location = new System.Drawing.Point(687, 15);
            this.textBoxDisplay.Multiline = true;
            this.textBoxDisplay.Name = "textBoxDisplay";
            this.textBoxDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxDisplay.Size = new System.Drawing.Size(480, 507);
            this.textBoxDisplay.TabIndex = 1;
            // 
            // buttonLoadBasicTerritories
            // 
            this.buttonLoadBasicTerritories.Location = new System.Drawing.Point(12, 41);
            this.buttonLoadBasicTerritories.Name = "buttonLoadBasicTerritories";
            this.buttonLoadBasicTerritories.Size = new System.Drawing.Size(372, 23);
            this.buttonLoadBasicTerritories.TabIndex = 2;
            this.buttonLoadBasicTerritories.Text = "Basic Territories";
            this.buttonLoadBasicTerritories.UseVisualStyleBackColor = true;
            this.buttonLoadBasicTerritories.Click += new System.EventHandler(this.buttonLoadBasicTerritories_Click);
            // 
            // buttonLoadBasicFlags
            // 
            this.buttonLoadBasicFlags.Location = new System.Drawing.Point(12, 70);
            this.buttonLoadBasicFlags.Name = "buttonLoadBasicFlags";
            this.buttonLoadBasicFlags.Size = new System.Drawing.Size(372, 23);
            this.buttonLoadBasicFlags.TabIndex = 3;
            this.buttonLoadBasicFlags.Text = "Basic Flags";
            this.buttonLoadBasicFlags.UseVisualStyleBackColor = true;
            this.buttonLoadBasicFlags.Click += new System.EventHandler(this.buttonLoadBasicFlags_Click);
            // 
            // buttonContinentWithParent
            // 
            this.buttonContinentWithParent.Location = new System.Drawing.Point(12, 109);
            this.buttonContinentWithParent.Name = "buttonContinentWithParent";
            this.buttonContinentWithParent.Size = new System.Drawing.Size(372, 23);
            this.buttonContinentWithParent.TabIndex = 4;
            this.buttonContinentWithParent.Text = "Continent with Parent One";
            this.buttonContinentWithParent.UseVisualStyleBackColor = true;
            this.buttonContinentWithParent.Click += new System.EventHandler(this.buttonContinentWithParent_Click);
            // 
            // buttonContinentWithParent2
            // 
            this.buttonContinentWithParent2.Location = new System.Drawing.Point(12, 138);
            this.buttonContinentWithParent2.Name = "buttonContinentWithParent2";
            this.buttonContinentWithParent2.Size = new System.Drawing.Size(372, 23);
            this.buttonContinentWithParent2.TabIndex = 5;
            this.buttonContinentWithParent2.Text = "Continent with Parent Two";
            this.buttonContinentWithParent2.UseVisualStyleBackColor = true;
            this.buttonContinentWithParent2.Click += new System.EventHandler(this.buttonContinentWithParent2_Click);
            // 
            // buttonContinentWithParent3
            // 
            this.buttonContinentWithParent3.Location = new System.Drawing.Point(12, 167);
            this.buttonContinentWithParent3.Name = "buttonContinentWithParent3";
            this.buttonContinentWithParent3.Size = new System.Drawing.Size(372, 23);
            this.buttonContinentWithParent3.TabIndex = 6;
            this.buttonContinentWithParent3.Text = "Continent with Parent Three";
            this.buttonContinentWithParent3.UseVisualStyleBackColor = true;
            this.buttonContinentWithParent3.Click += new System.EventHandler(this.buttonContinentWithParent3_Click);
            // 
            // buttonContinentsWithChildren
            // 
            this.buttonContinentsWithChildren.Location = new System.Drawing.Point(12, 196);
            this.buttonContinentsWithChildren.Name = "buttonContinentsWithChildren";
            this.buttonContinentsWithChildren.Size = new System.Drawing.Size(372, 23);
            this.buttonContinentsWithChildren.TabIndex = 7;
            this.buttonContinentsWithChildren.Text = "Continents with Children";
            this.buttonContinentsWithChildren.UseVisualStyleBackColor = true;
            this.buttonContinentsWithChildren.Click += new System.EventHandler(this.buttonContinentsWithChildren_Click);
            // 
            // buttonContinentsComplex
            // 
            this.buttonContinentsComplex.Location = new System.Drawing.Point(12, 241);
            this.buttonContinentsComplex.Name = "buttonContinentsComplex";
            this.buttonContinentsComplex.Size = new System.Drawing.Size(199, 23);
            this.buttonContinentsComplex.TabIndex = 8;
            this.buttonContinentsComplex.Text = "Continents Complex";
            this.buttonContinentsComplex.UseVisualStyleBackColor = true;
            this.buttonContinentsComplex.Click += new System.EventHandler(this.buttonContinentsComplex_Click);
            // 
            // buttonContinentComplexWithTerritories
            // 
            this.buttonContinentComplexWithTerritories.Location = new System.Drawing.Point(12, 270);
            this.buttonContinentComplexWithTerritories.Name = "buttonContinentComplexWithTerritories";
            this.buttonContinentComplexWithTerritories.Size = new System.Drawing.Size(199, 23);
            this.buttonContinentComplexWithTerritories.TabIndex = 10;
            this.buttonContinentComplexWithTerritories.Text = "Continents Complex with Territories";
            this.buttonContinentComplexWithTerritories.UseVisualStyleBackColor = true;
            this.buttonContinentComplexWithTerritories.Click += new System.EventHandler(this.buttonContinentComplexWithTerritories_Click);
            // 
            // buttonTerritoriesWithFlags
            // 
            this.buttonTerritoriesWithFlags.Location = new System.Drawing.Point(12, 309);
            this.buttonTerritoriesWithFlags.Name = "buttonTerritoriesWithFlags";
            this.buttonTerritoriesWithFlags.Size = new System.Drawing.Size(199, 23);
            this.buttonTerritoriesWithFlags.TabIndex = 11;
            this.buttonTerritoriesWithFlags.Text = "Territories with Flag";
            this.buttonTerritoriesWithFlags.UseVisualStyleBackColor = true;
            this.buttonTerritoriesWithFlags.Click += new System.EventHandler(this.buttonTerritoriesWithFlags_Click);
            // 
            // buttonTerritoriesWithFlagTwo
            // 
            this.buttonTerritoriesWithFlagTwo.Location = new System.Drawing.Point(12, 338);
            this.buttonTerritoriesWithFlagTwo.Name = "buttonTerritoriesWithFlagTwo";
            this.buttonTerritoriesWithFlagTwo.Size = new System.Drawing.Size(199, 23);
            this.buttonTerritoriesWithFlagTwo.TabIndex = 12;
            this.buttonTerritoriesWithFlagTwo.Text = "Territories with Flag Two";
            this.buttonTerritoriesWithFlagTwo.UseVisualStyleBackColor = true;
            this.buttonTerritoriesWithFlagTwo.Click += new System.EventHandler(this.buttonTerritoriesWithFlagTwo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 534);
            this.Controls.Add(this.buttonTerritoriesWithFlagTwo);
            this.Controls.Add(this.buttonTerritoriesWithFlags);
            this.Controls.Add(this.buttonContinentComplexWithTerritories);
            this.Controls.Add(this.buttonContinentsComplex);
            this.Controls.Add(this.buttonContinentsWithChildren);
            this.Controls.Add(this.buttonContinentWithParent3);
            this.Controls.Add(this.buttonContinentWithParent2);
            this.Controls.Add(this.buttonContinentWithParent);
            this.Controls.Add(this.buttonLoadBasicFlags);
            this.Controls.Add(this.buttonLoadBasicTerritories);
            this.Controls.Add(this.textBoxDisplay);
            this.Controls.Add(this.buttonLoadContinentsBasic);
            this.Name = "Form1";
            this.Text = "Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLoadContinentsBasic;
        private System.Windows.Forms.TextBox textBoxDisplay;
        private System.Windows.Forms.Button buttonLoadBasicTerritories;
        private System.Windows.Forms.Button buttonLoadBasicFlags;
        private System.Windows.Forms.Button buttonContinentWithParent;
        private System.Windows.Forms.Button buttonContinentWithParent2;
        private System.Windows.Forms.Button buttonContinentWithParent3;
        private System.Windows.Forms.Button buttonContinentsWithChildren;
        private System.Windows.Forms.Button buttonContinentsComplex;
        private System.Windows.Forms.Button buttonContinentComplexWithTerritories;
        private System.Windows.Forms.Button buttonTerritoriesWithFlags;
        private System.Windows.Forms.Button buttonTerritoriesWithFlagTwo;
    }
}

