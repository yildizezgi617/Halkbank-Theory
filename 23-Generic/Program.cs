namespace _23_Generic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kodun veri tipinden bağımsız olmasını sağlar.
            //Kodun yeniden kullanılabilirliğini arttırır.
            //Performans artışı sağlar.
            //Tip güvenliği sağlar.

            Deneme<string> deneme = new Deneme<string>();        //T yerine string yazdık.
            Deneme<int> deneme2 = new Deneme<int>();             //T yerine int yazdık. 

            Denemex<int, string> denemex = new Denemex<int, string>(); //Birden fazla tip alabilir.

            Repository<string> repository = new Repository<string>();   //Repository sınıfı string tipinde çalışacak.
            repository.Add("Fatih");
            Repository<int> repository2 = new Repository<int>();          //Repository sınıfı int tipinde çalışacak.
            repository2.Add(5);





            try
            {

            }
            catch (Exception)
            {

                throw;
            }



        }
    }





    public class Deneme<T>  //T yerine herhangi bir isim verilebilir., T tipi belirtir, artık Deneme deneme = new Deneme() ; şeklinde   kullanılamaz. bir tip vermem gerekir. 
    {
        private T value;
        public void AddItem(T value)
        {
            this.value = value;
        }

        public T GetItem()
        {
            return value;
        }
    }





    public interface CRUD<T>
    {
        void Add(T item);
        void Remove(T item);
        T Get(T item);
        List<T> GetList();
    }





    public class Product : CRUD<Product> //Product sınıfı CRUD interface'inden kalıtım aldı.Generic yapı kullanildi.
    {
        public void Add(Product item)
        {
            throw new NotImplementedException();
        }
        public Product Get(Product item)
        {
            throw new NotImplementedException();
        }
        public List<Product> GetList()
        {
            throw new NotImplementedException();
        }
        public void Remove(Product item)
        {
            throw new NotImplementedException();
        }
    }





    public class Denemex<Tkey, TValue> //Birden fazla tip alabilir.
    {
        public Tkey key;
        public TValue value;
    }




    public class Repository<T>
    {

        private List<T> list = new List<T>();
        public void Add(T item)
        {
            list.Add(item);
        }
        public void Remove(T item)
        {
            list.Remove(item);
        }
        public T GetItem(int index)
        {
            return list[index];
        }



    }
}
