using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace _13_OOP_Object
{
    public class Product  //public yap
    {
        //fields, nesneye özgü verileri saklar. Yalnızca sınıfın içinde kullanılan bilgiler içerir.
        /* string name;  *///private olduğu için dışardan erişemiyoruz. bu yüzden prop tanımlamalıyız ki güvenlik sorunu olmasın.



        //public string Name { get; set; }  //yazmada set okumada get yapılır.

        private string name;        //dışardan gelen datayı sarmallama yaparak korumaya alıyoruz. aynısını okuma içinde     yapıyoruz. (Kapsülleme)

        private double price;

        public string Name {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public double Price {
            get {
                return price;
            }
            set {
                if (value>0)
                {
                    price = value;
                }
                else
                {
                    throw new Exception("Fiyat 0 dan küçük olamaz");
                }
            }
        
        }

        private string code;     //propfull tab tab

        public string Code
        {
           private get { return code; }        //geti kaldırırsan sadece yazılabilir ama okuma  yapılamaz. aynı zmanda geti private yapabilirim. ve bu sayede içerde bir methodda kullanıyorsam sorun çıkarmaz
            set { code = value; }
        }

        //public string Fullname {
        //    get { return code+ " " + name; }     //sadece okunur ve okurken yanına ekleme yapar

        //}

        public string Fullname => code + " " + name; //bu da aynı yöntem.

        private int stock;

        public int Stock
        {
            private get { return stock; }
            set {
                if (value>=0)
                {
                    stock = value;
                }
                else
                {
                    stock = 0;
                }
            }
        }

       

    }
}
