using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lab2
{
    class AnalizatorXMLLINQStrategy : IAnalizatorXMLStrategy
    {
        public List<Artists> Search(Artists artist)
        {
            List<Artists> allResult = new List<Artists>();
            var doc = XDocument.Load(@"Z:\Lab2\ExampleFile.xml");
            var result = from obj in doc.Descendants("Artist")
                         where
                         (
                            (obj.Attribute("Name").Value.Equals(artist.Name) || artist.Name.Equals(String.Empty)) &&
                            (obj.Attribute("CountryOfOrigin").Value.Equals(artist.CountryOfOrigin) || artist.CountryOfOrigin.Equals(String.Empty)) &&
                            (obj.Attribute("DebutY").Value.Equals(artist.DebutY) || artist.DebutY.Equals(String.Empty)) &&
                            (obj.Attribute("ArtType").Value.Equals(artist.ArtType) || artist.ArtType.Equals(String.Empty)) &&
                            (obj.Attribute("Style").Value.Equals(artist.Style) || artist.Style.Equals(String.Empty)) &&
                            (obj.Attribute("FamousWork").Value.Equals(artist.FamousWork) || artist.FamousWork.Equals(String.Empty))
                         )
                         select new
                         {
                             name = (string)obj.Attribute("Name"),
                             countryoforigin = (string)obj.Attribute("CountryOfOrigin"),
                             debuty = (string)obj.Attribute("DebutY"),
                             arttype = (string)obj.Attribute("ArtType"),
                             style = (string)obj.Attribute("Style"),
                             famouswork = (string)obj.Attribute("FamousWork")
                         };
            foreach(var n in result)
            {
                Artists myArtist = new Artists();
                myArtist.Name = n.name;
                myArtist.CountryOfOrigin = n.countryoforigin;
                myArtist.DebutY = n.debuty;
                myArtist.ArtType = n.arttype;
                myArtist.Style = n.style;
                myArtist.FamousWork = n.famouswork;

                allResult.Add(myArtist);
            }

            return allResult;
        }
    }
}
