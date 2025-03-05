using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_Extension
{
  public class MovieCollection
        // Sınıfı indeksleyebilir bir hale getirdik.
    {
        private List<string> movies = new List<string>();




        //Indexer
        public string this[int index]
        {
            get
            {
                if (index>=0 && index< movies.Count)
                {
                    return movies[index];
                }
                return "invalid index";
            }
            set
            {
                if (index >=0 && index< movies.Count)
                {
                    movies[index] = value;
                }
                else if (index == movies.Count)
                {
                    movies.Add(value);
                }
                else Console.WriteLine("invalid index");
            }
        }
    }
}
