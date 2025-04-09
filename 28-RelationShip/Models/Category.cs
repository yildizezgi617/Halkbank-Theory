using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28_RelationShip.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Product> Product { get; set; } = new List<Product>(); //newlesen de olur newlemesen de olur newlemek de fayda var

    }
}
