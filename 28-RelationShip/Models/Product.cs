using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28_RelationShip.Models
{
    public class Product //1e çok bir ilişki tanımladık
    {
        public int Id { get; set; }  //Primary Key
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; }  //Foreign Key

        public Category Category { get; set; }
        public virtual ProductDetail ProductDetail { get; set; }
        public virtual  ICollection<Tag> Tags { get; set; }

    }
}
