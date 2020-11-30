using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Windows.Forms;
using System.Xml.Xsl;

namespace Lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            GetAllArtists();
        }

        public void GetAllArtists()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(@"Z:\Lab2\ExampleFile.xml");

            XmlElement xRoot = doc.DocumentElement;
            XmlNodeList childNodes = xRoot.SelectNodes("Artist");

            for(int i = 0; i < childNodes.Count; i++)
            {
                XmlNode n = childNodes.Item(i);
                addItems(n);
            }

           
        }

        private void addItems(XmlNode n)
        {
            if (!comboboxNames.Items.Contains(n.SelectSingleNode("@Name").Value))
                comboboxNames.Items.Add(n.SelectSingleNode("@Name"));

            if(!comboboxNames.Items.Contains(n.SelectSingleNode("@CountryOfOrigin").Value))
                comboboxNames.Items.Add(n.SelectSingleNode("@CountryOfOrigin"));

            if (!comboboxNames.Items.Contains(n.SelectSingleNode("@Debut").Value))
                comboboxNames.Items.Add(n.SelectSingleNode("@Debut"));

            if (!comboboxNames.Items.Contains(n.SelectSingleNode("@ArtType").Value))
                comboboxNames.Items.Add(n.SelectSingleNode("@ArtType"));

            if(!comboboxNames.Items.Contains(n.SelectSingleNode("@Style").Value))
                comboboxNames.Items.Add(n.SelectSingleNode("@Style"));

            if (!comboboxNames.Items.Contains(n.SelectSingleNode("@FamousWork").Value))
                comboboxNames.Items.Add(n.SelectSingleNode("@FamousWork"));
        }


        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void Search_Click(object sender, EventArgs e)
        {
            search();
        }

        private void search()
        {
            Results.Text = "";
            Artists artist = new Artists();

            if (Name.Checked)
                artist.Name = comboboxNames.SelectedItem.ToString();

            if (CountryOfOrigin.Checked)
                artist.CountryOfOrigin = comboboxCountroforgn.SelectedItem.ToString();

            if (DebutY.Checked)
                artist.DebutY = comboboxDebut.SelectedItem.ToString();

            if (ArtType.Checked)
                artist.ArtType = comboboxArtT.SelectedItem.ToString();

            if (Style.Checked)
                artist.Style = comboboxStyl.SelectedItem.ToString();
            
            if (Famous_work.Checked)
                artist.FamousWork = comboboxFmworks.SelectedItem.ToString();

            IAnalizatorXMLStrategy analizator = new AnalizatorXMLDOMStrategy();

            if (DOM.Checked)
                analizator = new AnalizatorXMLDOMStrategy();

            if (SAX.Checked)
                analizator = new AnalizatorXMLSAXStrategy();

            if (LINQ_TO_XML.Checked)
                analizator = new AnalizatorXMLLINQStrategy();

            List<Artists> searchResult = Search(artist, analizator);

            foreach(Artists artst in searchResult)
            {
                Results.Text += "Name:" + artst.Name + '\n';
                Results.Text += "CountryOfOrigin:" + artst.CountryOfOrigin + '\n';
                Results.Text += "DebutYear:" + artst.DebutY + '\n';
                Results.Text += "ArtType:" + artst.ArtType + '\n';
                Results.Text += "Style:" + artst.Style + '\n';
                Results.Text += "FamousWork:" + artst.FamousWork + '\n';

                Results.Text += "\n\n\n";
            }
        }

        private List<Artists> Search(Artists a, IAnalizatorXMLStrategy ian)
        {
            List<Artists> res = new List<Artists>();
            res = ian.Search(a);
            return res;
        }

        private void Transformation_Click(object sender, EventArgs e)
        {
            transform();
        }

        private void transform()
        {
            XslCompiledTransform xct = new XslCompiledTransform();
            xct.Load(@"Z:\Lab2\ExampleFile.xsl");
            string fMXL = @"Z:\Lab2\ExampleFile.xsl";
            string fHTML = @"Z:\Lab2\ExampleFile.xsl";
            xct.Transform(fMXL, fHTML);

        }
    }
}
