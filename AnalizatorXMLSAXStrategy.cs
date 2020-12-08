using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Lab2
{
    class AnalizatorXMLSAXStrategy : IAnalizatorXMLStrategy
    {
        public List<Artists> Search(Artists artist)
        {

            List<Artists> AllResult = new List<Artists>();
            var xmlReader = new XmlTextReader(@"Z:\Lab2\ExampleFile.xml");

            while (xmlReader.Read())
            {
                if (xmlReader.HasAttributes)
                {
                    while (xmlReader.MoveToNextAttribute())
                    {
                        string Name = artist.Name;
                        string CountryOfOrigin = artist.CountryOfOrigin;
                        string DebutY = artist.DebutY;
                        string ArtType = artist.ArtType;
                        string Style = artist.Style;
                        string FamousWork = artist.FamousWork;

                        if ((xmlReader.Name.Equals("Name") && (xmlReader.Value.Equals(artist.Name) || artist.Name.Equals(string.Empty))))
                        {
                            Name = xmlReader.Value;

                            xmlReader.MoveToNextAttribute();
                            if ((xmlReader.Name.Equals("CountryOfOrigin") && (xmlReader.Value.Equals(artist.CountryOfOrigin) || artist.CountryOfOrigin.Equals(string.Empty))))
                            {
                                CountryOfOrigin = xmlReader.Value;

                                xmlReader.MoveToNextAttribute();
                                if ((xmlReader.Name.Equals("DebutY") && (xmlReader.Value.Equals(artist.DebutY) || artist.DebutY.Equals(string.Empty))))
                                {
                                    DebutY = xmlReader.Value;

                                    xmlReader.MoveToNextAttribute();
                                    if ((xmlReader.Name.Equals("ArtType") && (xmlReader.Value.Equals(artist.ArtType) || artist.ArtType.Equals(string.Empty))))
                                    {
                                        ArtType = xmlReader.Value;

                                        xmlReader.MoveToNextAttribute();
                                        if ((xmlReader.Name.Equals("Style") && (xmlReader.Value.Equals(artist.Style) || artist.Style.Equals(string.Empty))))
                                        {
                                            Style = xmlReader.Value;

                                            xmlReader.MoveToNextAttribute();
                                            if ((xmlReader.Name.Equals("FamousWork") && (xmlReader.Value.Equals(artist.FamousWork) || artist.FamousWork.Equals(string.Empty))))
                                            {
                                                FamousWork = xmlReader.Value;
                                            }
                                        }
                                    }
                                }
                            }
                        }

                        if (Name != "" && CountryOfOrigin != "" && DebutY != "" && ArtType != "" && Style != "" && FamousWork != "")
                        {
                            Artists myArtist = new Artists();
                            myArtist.Name = Name;
                            myArtist.CountryOfOrigin = CountryOfOrigin;
                            myArtist.DebutY = DebutY;
                            myArtist.ArtType = ArtType;
                            myArtist.Style = Style;
                            myArtist.FamousWork = FamousWork;

                            AllResult.Add(myArtist);
                        }
                    }
                }
            }

            xmlReader.Close();
            return AllResult;
        }
    }
}
