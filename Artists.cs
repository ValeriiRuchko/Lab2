using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Artists
    {
        public Artists()
        {
        }

            /*
         this.Name = "";
         this.CountryOfOrigin = "";
         this.DebutY = "";
         this.ArtType = "";
         this.Style = "";
         this.FamousWork = "";
         */

        public string Name { get; set; }
        public string CountryOfOrigin { get; set; }
        public string DebutY { get; set; }
        public string ArtType { get; set; }
        public string Style { get; set; }
        public string FamousWork { get; set; }
    }

    interface IAnalizatorXMLStrategy
    {
        List<Artists> Search(Artists artist);
    }
}
