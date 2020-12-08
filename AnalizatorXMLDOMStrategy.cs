using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Lab2
{
    class AnalizatorXMLDOMStrategy : IAnalizatorXMLStrategy
    {
        public List<Artists> Search(Artists artist)
        {
            List<Artists> result = new List<Artists>();
            XmlDocument doc = new XmlDocument();
            doc.Load(@"Z:\Lab2\ExampleFile.xml");

            XmlNode node = doc.DocumentElement;
            //foreach(XmlNode nod in node)
            //{
                string Name = artist.Name;
                string CountryOfOrigin = artist.CountryOfOrigin;
                string DebutY = artist.DebutY;
                string ArtType = artist.ArtType;
                string Style = artist.Style;
                string FamousWork = artist.FamousWork;

                foreach(XmlAttribute attribute in node.Attributes)
                {
                    if (attribute.Name.Equals("Name") && (attribute.Value.Equals(artist.Name) || artist.Name.Equals(String.Empty)))
                        Name = attribute.Value;

                    if (attribute.Name.Equals("CountryOfOrigin") && (attribute.Value.Equals(artist.CountryOfOrigin) || artist.CountryOfOrigin.Equals(String.Empty)))
                        CountryOfOrigin = attribute.Value;

                    if (attribute.Name.Equals("DebutY") && (attribute.Value.Equals(artist.DebutY) || artist.DebutY.Equals(String.Empty)))
                        DebutY = attribute.Value;

                    if (attribute.Name.Equals("ArtType") && (attribute.Value.Equals(artist.ArtType) || artist.ArtType.Equals(String.Empty)))
                        ArtType = attribute.Value;

                    if (attribute.Name.Equals("Style") && (attribute.Value.Equals(artist.Style) || artist.Style.Equals(String.Empty)))
                        Style = attribute.Value;

                    if (attribute.Name.Equals("FamousWork") && (attribute.Value.Equals(artist.FamousWork) || artist.FamousWork.Equals(String.Empty)))
                        FamousWork = attribute.Value;
                }

                if(Name != "" && CountryOfOrigin != "" && DebutY != "" && ArtType != "" && Style != "" && FamousWork != "")
                {
                    Artists myArtist = new Artists();
                    myArtist.Name = Name;
                    myArtist.CountryOfOrigin = CountryOfOrigin;
                    myArtist.DebutY = DebutY;
                    myArtist.ArtType = ArtType;
                    myArtist.Style = Style;
                    myArtist.FamousWork = FamousWork;

                    result.Add(myArtist);
                }

            //}
            return result;
        }
    }
}
