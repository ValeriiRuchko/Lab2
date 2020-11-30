
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
            this.Name = new System.Windows.Forms.CheckBox();
            this.CountryOfOrigin = new System.Windows.Forms.CheckBox();
            this.DebutY = new System.Windows.Forms.CheckBox();
            this.ArtType = new System.Windows.Forms.CheckBox();
            this.Style = new System.Windows.Forms.CheckBox();
            this.Famous_work = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.DOM = new System.Windows.Forms.RadioButton();
            this.SAX = new System.Windows.Forms.RadioButton();
            this.LINQ_TO_XML = new System.Windows.Forms.RadioButton();
            this.Results = new System.Windows.Forms.RichTextBox();
            this.Search = new System.Windows.Forms.Button();
            this.Transformation = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Location = new System.Drawing.Point(48, 44);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(77, 24);
            this.Name.TabIndex = 0;
            this.Name.Text = "Name";
            this.Name.UseVisualStyleBackColor = true;
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
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(314, 40);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 28);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(314, 82);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 28);
            this.comboBox2.TabIndex = 1;
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(314, 121);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 28);
            this.comboBox3.TabIndex = 1;
            // 
            // comboBox4
            // 
            this.comboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(314, 164);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 28);
            this.comboBox4.TabIndex = 1;
            // 
            // comboBox5
            // 
            this.comboBox5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(314, 207);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(121, 28);
            this.comboBox5.TabIndex = 1;
            // 
            // comboBox6
            // 
            this.comboBox6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Location = new System.Drawing.Point(314, 248);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(121, 28);
            this.comboBox6.TabIndex = 1;
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
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(49, 444);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(127, 32);
            this.Search.TabIndex = 4;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            // 
            // Transformation
            // 
            this.Transformation.Location = new System.Drawing.Point(241, 444);
            this.Transformation.Name = "Transformation";
            this.Transformation.Size = new System.Drawing.Size(127, 32);
            this.Transformation.TabIndex = 4;
            this.Transformation.Text = "Transformation";
            this.Transformation.UseVisualStyleBackColor = true;
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(136, 512);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(127, 32);
            this.Clear.TabIndex = 4;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 586);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Transformation);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.Results);
            this.Controls.Add(this.LINQ_TO_XML);
            this.Controls.Add(this.SAX);
            this.Controls.Add(this.DOM);
            this.Controls.Add(this.comboBox6);
            this.Controls.Add(this.comboBox5);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Famous_work);
            this.Controls.Add(this.Style);
            this.Controls.Add(this.ArtType);
            this.Controls.Add(this.DebutY);
            this.Controls.Add(this.CountryOfOrigin);
            this.Controls.Add(this.Name);
            this.Name = "Form1";
            this.Text = "XMLArtistsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox Name;
        private System.Windows.Forms.CheckBox CountryOfOrigin;
        private System.Windows.Forms.CheckBox DebutY;
        private System.Windows.Forms.CheckBox ArtType;
        private System.Windows.Forms.CheckBox Style;
        private System.Windows.Forms.CheckBox Famous_work;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.RadioButton DOM;
        private System.Windows.Forms.RadioButton SAX;
        private System.Windows.Forms.RadioButton LINQ_TO_XML;
        private System.Windows.Forms.RichTextBox Results;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Button Transformation;
        private System.Windows.Forms.Button Clear;
    }
}

