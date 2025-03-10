using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_Extension
{
    public class MovieCollection
    {
        private List<string> movies = new List<string>();

        public int Count => movies.Count;

        //Indexer
        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < movies.Count)
                    return movies[index];
                return "Invalid Index";
            }
            set
            {
                if (index >= 0 && index < movies.Count)
                    movies[index] = value;
                else if (index == movies.Count)
                    movies.Add(value);
                else
                    Console.WriteLine("Invalid Index");
            }
        }
    }
}