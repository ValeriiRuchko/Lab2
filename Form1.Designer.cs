
namespace Lab2
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
            this.NameL = new System.Windows.Forms.CheckBox();
            this.CountryOfOrigin = new System.Windows.Forms.CheckBox();
            this.DebutY = new System.Windows.Forms.CheckBox();
            this.ArtType = new System.Windows.Forms.CheckBox();
            this.Style = new System.Windows.Forms.CheckBox();
            this.Famous_work = new System.Windows.Forms.CheckBox();
            this.comboboxNames = new System.Windows.Forms.ComboBox();
            this.comboboxCountroforgn = new System.Windows.Forms.ComboBox();
            this.comboboxDebut = new System.Windows.Forms.ComboBox();
            this.comboboxArtT = new System.Windows.Forms.ComboBox();
            this.comboboxStyl = new System.Windows.Forms.ComboBox();
            this.comboboxFmworks = new System.Windows.Forms.ComboBox();
            this.DOM = new System.Windows.Forms.RadioButton();
            this.SAX = new System.Windows.Forms.RadioButton();
            this.LINQ_TO_XML = new System.Windows.Forms.RadioButton();
            this.Results = new System.Windows.Forms.RichTextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.Transformation = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NameL
            // 
            this.NameL.AutoSize = true;
            this.NameL.Location = new System.Drawing.Point(48, 44);
            this.NameL.Name = "NameL";
            this.NameL.Size = new System.Drawing.Size(77, 24);
            this.NameL.TabIndex = 0;
            this.NameL.Text = "Name";
            this.NameL.UseVisualStyleBackColor = true;
            // 
            // CountryOfOrigin
            // 
            this.CountryOfOrigin.AutoSize = true;
            this.CountryOfOrigin.Location = new System.Drawing.Point(48, 82);
            this.CountryOfOrigin.Name = "CountryOfOrigin";
            this.CountryOfOrigin.Size = new System.Drawing.Size(153, 24);
            this.CountryOfOrigin.TabIndex = 0;
            this.CountryOfOrigin.Text = "Country of Origin";
            this.CountryOfOrigin.UseVisualStyleBackColor = true;
            // 
            // DebutY
            // 
            this.DebutY.AutoSize = true;
            this.DebutY.Location = new System.Drawing.Point(49, 125);
            this.DebutY.Name = "DebutY";
            this.DebutY.Size = new System.Drawing.Size(123, 24);
            this.DebutY.TabIndex = 0;
            this.DebutY.Text = "Debut (year)";
            this.DebutY.UseVisualStyleBackColor = true;
            // 
            // ArtType
            // 
            this.ArtType.AutoSize = true;
            this.ArtType.Location = new System.Drawing.Point(50, 168);
            this.ArtType.Name = "ArtType";
            this.ArtType.Size = new System.Drawing.Size(90, 24);
            this.ArtType.TabIndex = 0;
            this.ArtType.Text = "Art type";
            this.ArtType.UseVisualStyleBackColor = true;
            // 
            // Style
            // 
            this.Style.AutoSize = true;
            this.Style.Location = new System.Drawing.Point(50, 211);
            this.Style.Name = "Style";
            this.Style.Size = new System.Drawing.Size(70, 24);
            this.Style.TabIndex = 0;
            this.Style.Text = "Style";
            this.Style.UseVisualStyleBackColor = true;
            // 
            // Famous_work
            // 
            this.Famous_work.AutoSize = true;
            this.Famous_work.Location = new System.Drawing.Point(50, 252);
            this.Famous_work.Name = "Famous_work";
            this.Famous_work.Size = new System.Drawing.Size(130, 24);
            this.Famous_work.TabIndex = 0;
            this.Famous_work.Text = "Famous work";
            this.Famous_work.UseVisualStyleBackColor = true;
            this.Famous_work.CheckedChanged += new System.EventHandler(this.checkBox6_CheckedChanged);
            // 
            // comboboxNames
            // 
            this.comboboxNames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboboxNames.FormattingEnabled = true;
            this.comboboxNames.Location = new System.Drawing.Point(314, 40);
            this.comboboxNames.Name = "comboboxNames";
            this.comboboxNames.Size = new System.Drawing.Size(121, 28);
            this.comboboxNames.TabIndex = 1;
            this.comboboxNames.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboboxCountroforgn
            // 
            this.comboboxCountroforgn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboboxCountroforgn.FormattingEnabled = true;
            this.comboboxCountroforgn.Location = new System.Drawing.Point(314, 82);
            this.comboboxCountroforgn.Name = "comboboxCountroforgn";
            this.comboboxCountroforgn.Size = new System.Drawing.Size(121, 28);
            this.comboboxCountroforgn.TabIndex = 1;
            // 
            // comboboxDebut
            // 
            this.comboboxDebut.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboboxDebut.FormattingEnabled = true;
            this.comboboxDebut.Location = new System.Drawing.Point(314, 121);
            this.comboboxDebut.Name = "comboboxDebut";
            this.comboboxDebut.Size = new System.Drawing.Size(121, 28);
            this.comboboxDebut.TabIndex = 1;
            // 
            // comboboxArtT
            // 
            this.comboboxArtT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboboxArtT.FormattingEnabled = true;
            this.comboboxArtT.Location = new System.Drawing.Point(314, 164);
            this.comboboxArtT.Name = "comboboxArtT";
            this.comboboxArtT.Size = new System.Drawing.Size(121, 28);
            this.comboboxArtT.TabIndex = 1;
            // 
            // comboboxStyl
            // 
            this.comboboxStyl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboboxStyl.FormattingEnabled = true;
            this.comboboxStyl.Location = new System.Drawing.Point(314, 207);
            this.comboboxStyl.Name = "comboboxStyl";
            this.comboboxStyl.Size = new System.Drawing.Size(121, 28);
            this.comboboxStyl.TabIndex = 1;
            // 
            // comboboxFmworks
            // 
            this.comboboxFmworks.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboboxFmworks.FormattingEnabled = true;
            this.comboboxFmworks.Location = new System.Drawing.Point(314, 248);
            this.comboboxFmworks.Name = "comboboxFmworks";
            this.comboboxFmworks.Size = new System.Drawing.Size(121, 28);
            this.comboboxFmworks.TabIndex = 1;
            // 
            // DOM
            // 
            this.DOM.AutoSize = true;
            this.DOM.Location = new System.Drawing.Point(136, 315);
            this.DOM.Name = "DOM";
            this.DOM.Size = new System.Drawing.Size(71, 24);
            this.DOM.TabIndex = 2;
            this.DOM.TabStop = true;
            this.DOM.Text = "DOM";
            this.DOM.UseVisualStyleBackColor = true;
            // 
            // SAX
            // 
            this.SAX.AutoSize = true;
            this.SAX.Location = new System.Drawing.Point(136, 345);
            this.SAX.Name = "SAX";
            this.SAX.Size = new System.Drawing.Size(67, 24);
            this.SAX.TabIndex = 2;
            this.SAX.TabStop = true;
            this.SAX.Text = "SAX";
            this.SAX.UseVisualStyleBackColor = true;
            // 
            // LINQ_TO_XML
            // 
            this.LINQ_TO_XML.AutoSize = true;
            this.LINQ_TO_XML.Location = new System.Drawing.Point(136, 375);
            this.LINQ_TO_XML.Name = "LINQ_TO_XML";
            this.LINQ_TO_XML.Size = new System.Drawing.Size(126, 24);
            this.LINQ_TO_XML.TabIndex = 2;
            this.LINQ_TO_XML.TabStop = true;
            this.LINQ_TO_XML.Text = "LINQ to XML";
            this.LINQ_TO_XML.UseVisualStyleBackColor = true;
            // 
            // Results
            // 
            this.Results.Location = new System.Drawing.Point(474, 40);
            this.Results.Name = "Results";
            this.Results.Size = new System.Drawing.Size(572, 535);
            this.Results.TabIndex = 3;
            this.Results.Text = "";
            this.Results.TextChanged += new System.EventHandler(this.Search_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(49, 444);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(127, 32);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.Search_Click);
            // 
            // Transformation
            // 
            this.Transformation.Location = new System.Drawing.Point(241, 444);
            this.Transformation.Name = "Transformation";
            this.Transformation.Size = new System.Drawing.Size(127, 32);
            this.Transformation.TabIndex = 4;
            this.Transformation.Text = "Transformation";
            this.Transformation.UseVisualStyleBackColor = true;
            this.Transformation.Click += new System.EventHandler(this.Transformation_Click);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(136, 512);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(127, 32);
            this.Clear.TabIndex = 4;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 586);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Transformation);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.Results);
            this.Controls.Add(this.LINQ_TO_XML);
            this.Controls.Add(this.SAX);
            this.Controls.Add(this.DOM);
            this.Controls.Add(this.comboboxFmworks);
            this.Controls.Add(this.comboboxStyl);
            this.Controls.Add(this.comboboxArtT);
            this.Controls.Add(this.comboboxDebut);
            this.Controls.Add(this.comboboxCountroforgn);
            this.Controls.Add(this.comboboxNames);
            this.Controls.Add(this.Famous_work);
            this.Controls.Add(this.Style);
            this.Controls.Add(this.ArtType);
            this.Controls.Add(this.DebutY);
            this.Controls.Add(this.CountryOfOrigin);
            this.Controls.Add(this.NameL);
            this.Name = "Form1";
            this.Text = "XMLArtistsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox NameL;
        private System.Windows.Forms.CheckBox CountryOfOrigin;
        private System.Windows.Forms.CheckBox DebutY;
        private System.Windows.Forms.CheckBox ArtType;
        private System.Windows.Forms.CheckBox Style;
        private System.Windows.Forms.CheckBox Famous_work;
        private System.Windows.Forms.ComboBox comboboxNames;
        private System.Windows.Forms.ComboBox comboboxCountroforgn;
        private System.Windows.Forms.ComboBox comboboxDebut;
        private System.Windows.Forms.ComboBox comboboxArtT;
        private System.Windows.Forms.ComboBox comboboxStyl;
        private System.Windows.Forms.ComboBox comboboxFmworks;
        private System.Windows.Forms.RadioButton DOM;
        private System.Windows.Forms.RadioButton SAX;
        private System.Windows.Forms.RadioButton LINQ_TO_XML;
        private System.Windows.Forms.RichTextBox Results;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button Transformation;
        private System.Windows.Forms.Button Clear;
    }
}

