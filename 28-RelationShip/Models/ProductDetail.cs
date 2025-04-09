using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28_RelationShip.Models
{
    public class ProductDetail //one to one
    {
        public int Id { get; set; }
        public string Descriiption { get; set; }
        public int ProductId { get; set; }
        public virtual Product Product { get; set; } //virtual olmasının sebebi lazy loading
    }
}
