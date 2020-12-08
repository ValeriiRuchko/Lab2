using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Search
    {

        private IAnalizatorXMLStrategy _strategy;
        private Artists _artist;

        public Search() { }

        public Search(IAnalizatorXMLStrategy strategy, Artists artist)
        {
            this._strategy = strategy;
            this._artist = artist;
        }

        public List<Artists> SearchAlgorithm()
        {
            List<Artists> result = _strategy.Search(_artist);
            return result;
        }
    }
}
