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
    }
}
