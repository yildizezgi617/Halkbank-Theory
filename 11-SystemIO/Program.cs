using System.IO;

namespace _11_SystemIO
{
    internal class Program
    {
        const string filePath = @"C:\Users\fatih.alkan\Desktop\Products";
        static List<string> productCodes = new List<string>();
        static List<string> productNames = new List<string>();
        static List<double> productPrices = new List<double>();
        static List<string> customers = new List<string>();
        static List<string> orders = new List<string>();
        static void Main(string[] args)
        {

            #region File
            //Dosya işlemleri için kullanılan statik bir sınıftır.

            string filePath = @"C:\Users\fatih.alkan\Desktop\new.txt";

            //if (File.Exists(filePath))
            //{
            //    File.WriteAllText(filePath, "Merhaba Dünya! \n\tFatih Alkan");
            //}
            //else 
            //{
            //    File.Create(filePath);
            //    Console.WriteLine("TXT Oluşturuldu.");
            //}


            //string[] content = File.ReadAllLines(filePath);

            //foreach (var item in content)
            //{
            //    Console.WriteLine(item);
            //}


            //File.Copy(filePath, "C:\\Users\\fatih.alkan\\Desktop\\KD-26\\example.txt");


            //File.Delete("C:\\Users\\fatih.alkan\\Desktop\\KD-26\\example.txt");

            //File.WriteAllText(filePath,"Deneme");
            //File.AppendAllText(filePath, "Merhaba");
            #endregion

            #region FileInfo

            //FileInfo fileInfo = new FileInfo(filePath);

            //Console.WriteLine("Dosya Var mı: " + fileInfo.Exists);
            //Console.WriteLine("Dosya oluşturma tarihi: " + fileInfo.CreationTime);
            //Console.WriteLine("Dosyanın Tam İsmi: " + fileInfo.FullName);
            //Console.WriteLine("Dostanın Ismi: " + fileInfo.Name);
            //Console.WriteLine("Dosyanın Uzantısı: " + fileInfo.Extension);
            //Console.WriteLine("Dosyanın Değişiiklik Tarihi: " + fileInfo.LastWriteTime);
            //Console.WriteLine("Dosyanın Boyutu: " + fileInfo.Length);
            //Console.WriteLine("Dosyanın Adresi: " + fileInfo.DirectoryName);

            #endregion

            #region Directory
            //string folderPath = @"C:\Users\fatih.alkan\Desktop\new3";

            //Directory.CreateDirectory(folderPath);
            //Directory.Exists(folderPath);
            //Directory.Delete(folderPath);
            //Directory.Move(folderPath, "");
            #endregion

            #region DirectoryInfo
            //DirectoryInfo fi = new DirectoryInfo(folderPath);
            //Console.WriteLine("Klasörün Adı: " + fi.Name);
            //Console.WriteLine("Klasörün Tam Adı: " + fi.FullName);
            //Console.WriteLine("Klasörün Oluşma Tarihi: " + fi.CreationTime);
            //Console.WriteLine("Klasörün En Son Erişim Tarihi: " + fi.LastAccessTime);
            //Console.WriteLine("Klasörün Var mı: " + fi.Exists);
            //Console.WriteLine("Klasörün Kök Dizini: " + fi.Root);
            #endregion

            #region DriveInfo
            //DriveInfo info = new DriveInfo("C");

            //Console.WriteLine("Kulanılabilir: " + info.AvailableFreeSpace);
            //Console.WriteLine("Boş: " + info.TotalFreeSpace);
            //Console.WriteLine("Toplam: " + info.TotalSize);
            //Console.WriteLine("Format: " + info.DriveFormat);
            //Console.WriteLine("Tipi: " + info.DriveType);
            //Console.WriteLine("ismi: " + info.Name);
            //Console.WriteLine("Kök: " + info.RootDirectory);
            //Console.WriteLine("etiketi: " + info.VolumeLabel);

            //Console.WriteLine();
            #endregion

            #region Path
            Console.WriteLine("Dizin: " + Path.GetDirectoryName(filePath));
            Console.WriteLine("Dosya Adı: " + Path.GetFileName(filePath));
            Console.WriteLine("Uzantısız Dosya Adı: " + Path.GetFileNameWithoutExtension(filePath));
            Console.WriteLine("Uzantı: " + Path.GetExtension(filePath));

            string relativePath = @"..\..\readme.txt";
            Console.WriteLine(Path.GetFullPath(relativePath));

            string folder = @"D:\temp";
            string filename = "readme.txt";

            Console.WriteLine(Path.Combine(folder, filename));
            Console.WriteLine(Path.ChangeExtension(filePath, ".pdf"));

            #endregion

            #region FileStream
            //using (FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read)) 
            //{
            //    byte[] buffer = new byte[1024];
            //    int bytesRead = fileStream.Read(buffer, 0, buffer.Length);

            //    Console.WriteLine($"Okunan Bayt Sayısı: {bytesRead}");
            //    Console.WriteLine("İçerik: " + System.Text.Encoding.UTF8.GetString(buffer, 0, bytesRead));
            //}

            ////StreamReader

            //using (StreamReader reader = new StreamReader(filePath))
            //{
            //    string line;
            //    while ((line = reader.ReadLine()) != null) 
            //    {
            //        Console.WriteLine(line);
            //    }
            //}

            ////StreamWriter

            //using (StreamWriter writer = new StreamWriter(filePath)) 
            //{
            //    writer.WriteLine("Merhaba");
            //}


            #endregion


            while (true)
            {
                Console.WriteLine("[1] Müşteriler [2] Ürünler [3] Satış");
                string secim = Console.ReadLine();
                switch (secim)
                {
                    case "1":
                        GetCustomers();
                        break;
                    case "2":
                        GetProducts();
                        break;
                    case "3":
                        bool isContinue = true;
                        while (isContinue)
                        {
                            Orders();
                            Console.WriteLine("Devam mı? [Evet] [Hayır]");
                            isContinue = Console.ReadLine().ToLower() == "hayır" ? false : true;

                        }
                        Completed();
                        break;
                    default:
                        break;
                }
            }

        }

        private static void GetProducts()     //dosyadan ürün bilg okuyup konsola bastırma
        {
            string path = Path.Combine(filePath, "products.txt");

            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    var items = line.Split('-');
                    productCodes.Add(items[0]);
                    productNames.Add(items[1]);
                    productPrices.Add(double.Parse(items[2]));
                    Console.WriteLine(line);
                }
            }
        }

        private static void GetCustomers()   // Müşterileri okuma işlemi
        {
            string path = Path.Combine(filePath, "customers.txt");

            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                int i = 1;
                while ((line = reader.ReadLine()) != null)
                {
                    customers.Add(line);
                    Console.WriteLine($"{i} - " + line);
                }
            }
        }

        private static void Orders()
        {
            Console.WriteLine("Ürün Kodu");
            string kod = Console.ReadLine();

            if (orders.Contains(kod))
            {
                Console.WriteLine("Bu ürün zaten ekli");
            }
            else
            {
                orders.Add(kod);
                Console.WriteLine("Ürün eklendi");
            }
        }
        /// <summary>
        /// bu bir denemedir
        /// </summary>
        private static void Completed()
        {
            int say = 0;
            foreach (var item in customers)
            {
                Console.WriteLine(say + " " + item);
                say++;
            }
            Console.Write("Müşteri No: ");
            int customerNo = int.Parse(Console.ReadLine());
            string customer = "";
            if (customers.Count >= customerNo)
            {
                customer = customers[customerNo];
            }

            string dPath = Path.Combine(filePath, customer);

            if (Directory.Exists(dPath))
            {
                CreateTax();
            }
            else
            {
                Directory.CreateDirectory(dPath);
                CreateTax();
            }

            void CreateTax()
            {
                string fPath = Path.Combine(dPath, Guid.NewGuid().ToString() + ".txt");
                File.WriteAllLines(fPath, orders.ToArray());
            }
        }



















        //AÇIKLAMALI
//        ﻿using System.IO;

//namespace _11_SystemIO
//    {
//        internal class Program
//        {
//            // Dosya yollarını tutan değişken
//            const string filePath = @"C:\Users\fatih.alkan\Desktop\Products";

//            // Ürünler ve müşteri bilgilerini tutacak listeler
//            static List<string> productCodes = new List<string>();
//            static List<string> productNames = new List<string>();
//            static List<double> productPrices = new List<double>();
//            static List<string> customers = new List<string>();
//            static List<string> orders = new List<string>();

//            static void Main(string[] args)
//            {
//                // Sonsuz döngü başlatılıyor, program çalışmaya devam edecek
//                while (true)
//                {
//                    // Kullanıcıya seçim yapması için seçenekler sunuluyor
//                    Console.WriteLine("[1] Müşteriler [2] Ürünler [3] Satış");

//                    // Kullanıcının seçimini alıyoruz
//                    string secim = Console.ReadLine();

//                    // Seçime göre işlemi yönlendiren switch yapısı
//                    switch (secim)
//                    {
//                        case "1":
//                            // "1" seçeneği seçildiğinde GetCustomers() fonksiyonunu çağırıyoruz
//                            GetCustomers();
//                            break;
//                        case "2":
//                            // "2" seçeneği seçildiğinde GetProducts() fonksiyonunu çağırıyoruz
//                            GetProducts();
//                            break;
//                        case "3":
//                            // "3" seçeneği seçildiğinde Satış işlemi başlatıyoruz
//                            bool isContinue = true;
//                            while (isContinue)
//                            {
//                                // Orders() fonksiyonu ile sipariş alma işlemi yapılacak
//                                Orders();
//                                // Kullanıcıya devam edip etmeyeceğini soruyoruz
//                                Console.WriteLine("Devam mı? [Evet] [Hayır]");
//                                // Eğer kullanıcı "Hayır" derse, döngüden çıkıyoruz
//                                isContinue = Console.ReadLine().ToLower() == "hayır" ? false : true;
//                            }
//                            // Satış tamamlandığında Completed() fonksiyonunu çağırıyoruz
//                            Completed();
//                            break;
//                        default:
//                            break;
//                    }
//                }
//            }

//            // Ürünleri okuma işlemi
//            private static void GetProducts()
//            {
//                // Ürün dosyasının yolu
//                string path = Path.Combine(filePath, "products.txt");

//                // StreamReader ile dosya okuma işlemi
//                using (StreamReader reader = new StreamReader(path))
//                {
//                    string line;
//                    // Dosyadan satır satır okuma yapıyoruz
//                    while ((line = reader.ReadLine()) != null)
//                    {
//                        // Satırı " -" karakterine göre bölüyoruz
//                        var items = line.Split('-');
//                        // Ürün bilgilerini ilgili listelere ekliyoruz
//                        productCodes.Add(items[0]);
//                        productNames.Add(items[1]);
//                        productPrices.Add(double.Parse(items[2]));
//                        // Ürünü ekrana yazdırıyoruz
//                        Console.WriteLine(line);
//                    }
//                }
//            }

//            // Müşterileri okuma işlemi
//            private static void GetCustomers()
//            {
//                // Müşteri dosyasının yolu
//                string path = Path.Combine(filePath, "customers.txt");

//                // StreamReader ile dosya okuma işlemi
//                using (StreamReader reader = new StreamReader(path))
//                {
//                    string line;
//                    int i = 1;
//                    // Dosyadan satır satır okuma yapıyoruz
//                    while ((line = reader.ReadLine()) != null)
//                    {
//                        // Müşteri isimlerini listeye ekliyoruz
//                        customers.Add(line);
//                        // Müşteri numarası (i) ve adı yazdırılıyor
//                        Console.WriteLine($"{i} - " + line);
//                        i++;
//                    }
//                }
//            }

//            // Siparişleri ekleme işlemi
//            private static void Orders()
//            {
//                // Kullanıcıdan ürün kodu istiyoruz
//                Console.WriteLine("Ürün Kodu");
//                string kod = Console.ReadLine();

//                // Eğer siparişler listesinde bu ürün zaten varsa, kullanıcıya uyarı veriyoruz
//                if (orders.Contains(kod))
//                {
//                    Console.WriteLine("Bu ürün zaten ekli");
//                }
//                else
//                {
//                    // Eğer ürün daha önce eklenmemişse, siparişler listesine ekliyoruz
//                    orders.Add(kod);
//                    Console.WriteLine("Ürün eklendi");
//                }
//            }

//            // Satış tamamlandığında yapılacak işlemler
//            private static void Completed()
//            {
//                // Müşteri listesinde her müşteriyi yazdırıyoruz ve sırasıyla numaralandırıyoruz
//                int say = 0;
//                foreach (var item in customers)
//                {
//                    Console.WriteLine(say + " " + item);
//                    say++;
//                }
//                // Kullanıcıdan müşteri numarasını istiyoruz
//                Console.Write("Müşteri No: ");
//                int customerNo = int.Parse(Console.ReadLine());
//                string customer = "";

//                // Eğer girilen numara geçerli ise, o müşteriyi seçiyoruz
//                if (customers.Count >= customerNo)
//                {
//                    customer = customers[customerNo];
//                }

//                // Seçilen müşteri için bir klasör yolu oluşturuyoruz
//                string dPath = Path.Combine(filePath, customer);

//                // Eğer o müşteri için klasör varsa, yeni vergi dosyasını oluşturuyoruz
//                if (Directory.Exists(dPath))
//                {
//                    CreateTax();
//                }
//                else
//                {
//                    // Müşteri için klasör yoksa, o klasörü oluşturuyoruz
//                    Directory.CreateDirectory(dPath);
//                    CreateTax();
//                }

//                // Vergi dosyasını oluşturma işlemi
//                void CreateTax()
//                {
//                    // Vergi dosyasının adı, her defasında benzersiz olacak şekilde GUID ile belirleniyor
//                    string fPath = Path.Combine(dPath, Guid.NewGuid().ToString() + ".txt");
//                    // Siparişlerin listesini vergi dosyasına yazıyoruz
//                    File.WriteAllLines(fPath, orders.ToArray());
//                }
//            }



        //Kapsamlı Örnek
//        using System;
//using System.IO;
//using System.Collections.Generic;
//using System.Linq;

//namespace ProductManagementSystem
//    {
//        internal class Program
//        {
//            // Dosya yolu ve sabit dosya adları
//            const string filePath = @"C:\Users\fatih.alkan\Desktop\Products";
//            static List<Product> products = new List<Product>();  // Ürün listesi
//            static List<Order> orders = new List<Order>();        // Sipariş listesi

//            static void Main(string[] args)
//            {
//                // Sonsuz döngü başlatılıyor, kullanıcıdan giriş bekleniyor
//                while (true)
//                {
//                    // Kullanıcıya yapılabilecek işlemler sunuluyor
//                    Console.WriteLine("[1] Ürün Ekleme [2] Ürün Çıkarma [3] Sipariş Oluşturma");
//                    Console.WriteLine("[4] En Çok Satılan Ürünleri Listele [5] Tüm Ürünleri Listele");
//                    Console.WriteLine("[6] Stok Listesi [7] Müşteri Fatura Bilgisi [8] Dosya İşlemleri");
//                    Console.WriteLine("[9] Çıkış");
//                    string secim = Console.ReadLine(); // Kullanıcının seçim yapması bekleniyor

//                    switch (secim)
//                    {
//                        case "1":
//                            AddProduct(); // Ürün ekleme işlemi
//                            break;
//                        case "2":
//                            RemoveProduct(); // Ürün çıkarma işlemi
//                            break;
//                        case "3":
//                            CreateOrder(); // Sipariş oluşturma işlemi
//                            break;
//                        case "4":
//                            ListTopSellingProducts(); // En çok satılan ürünleri listeleme
//                            break;
//                        case "5":
//                            ListAllProducts(); // Tüm ürünleri listeleme
//                            break;
//                        case "6":
//                            ShowStockList(); // Stok listesini gösterme
//                            break;
//                        case "7":
//                            GenerateInvoice(); // Fatura oluşturma
//                            break;
//                        case "8":
//                            FileOperations(); // Dosya işlemleri
//                            break;
//                        case "9":
//                            return; // Uygulamadan çıkma
//                        default:
//                            Console.WriteLine("Geçersiz seçim! Lütfen geçerli bir seçenek girin."); // Geçersiz seçim mesajı
//                            break;
//                    }
//                }
//            }

//            // Ürün ekleme işlemi
//            private static void AddProduct()
//            {
//                try
//                {
//                    // Kullanıcıdan ürün bilgileri alınır
//                    Console.WriteLine("Ürün Kodu:");
//                    string code = Console.ReadLine();
//                    Console.WriteLine("Ürün Adı:");
//                    string name = Console.ReadLine();
//                    Console.WriteLine("Fiyat:");
//                    double price = double.Parse(Console.ReadLine());
//                    Console.WriteLine("Stok Miktarı:");
//                    int stock = int.Parse(Console.ReadLine());

//                    // Yeni ürün nesnesi oluşturuluyor ve listeye ekleniyor
//                    var product = new Product(code, name, price, stock);
//                    products.Add(product);

//                    // Ürünler dosyaya kaydediliyor
//                    SaveProductsToFile();

//                    Console.WriteLine("Ürün başarıyla eklendi.");
//                }
//                catch (FormatException ex)
//                {
//                    Console.WriteLine($"Hata: {ex.Message}. Lütfen geçerli bir sayı girin.");
//                }
//                catch (Exception ex)
//                {
//                    Console.WriteLine($"Hata: {ex.Message}");
//                }
//            }

//            // Ürün çıkarma işlemi
//            private static void RemoveProduct()
//            {
//                try
//                {
//                    Console.WriteLine("Silmek istediğiniz ürün kodunu girin:");
//                    string code = Console.ReadLine();

//                    // Ürünü buluyoruz
//                    var productToRemove = products.FirstOrDefault(p => p.Code == code);

//                    if (productToRemove != null)
//                    {
//                        // Ürün bulundu, listeden çıkarılıyor
//                        products.Remove(productToRemove);
//                        SaveProductsToFile(); // Güncellenen listeyi dosyaya kaydediyoruz
//                        Console.WriteLine("Ürün başarıyla silindi.");
//                    }
//                    else
//                    {
//                        // Ürün bulunamadı
//                        Console.WriteLine("Ürün bulunamadı.");
//                    }
//                }
//                catch (Exception ex)
//                {
//                    Console.WriteLine($"Hata: {ex.Message}");
//                }
//            }

//            // Sipariş oluşturma işlemi
//            private static void CreateOrder()
//            {
//                try
//                {
//                    // Kullanıcıdan sipariş bilgileri alınır
//                    Console.WriteLine("Müşteri adı:");
//                    string customerName = Console.ReadLine();
//                    Console.WriteLine("Ürün Kodu:");
//                    string productCode = Console.ReadLine();

//                    // Ürün koduna göre ürünü arıyoruz
//                    var product = products.FirstOrDefault(p => p.Code == productCode);

//                    if (product != null && product.Stock > 0)
//                    {
//                        // Ürün bulundu ve stokta var, sipariş oluşturuluyor
//                        product.Stock--;  // Stok biriminden azaltıyoruz
//                        orders.Add(new Order(customerName, product));

//                        Console.WriteLine("Sipariş başarıyla oluşturuldu.");
//                        SaveOrdersToFile(); // Siparişi dosyaya kaydediyoruz
//                        SaveProductsToFile(); // Güncellenen ürün stoklarını kaydediyoruz
//                    }
//                    else
//                    {
//                        // Ürün ya bulunamadı ya da stokta yok
//                        Console.WriteLine("Ürün bulunamadı veya stokta yok.");
//                    }
//                }
//                catch (Exception ex)
//                {
//                    Console.WriteLine($"Hata: {ex.Message}");
//                }
//            }

//            // En çok satılan ürünleri listeleme
//            private static void ListTopSellingProducts()
//            {
//                try
//                {
//                    // Siparişler gruplanarak en çok satılan ürünler listeleniyor
//                    var topSellingProducts = orders
//                        .GroupBy(o => o.Product.Code)
//                        .OrderByDescending(g => g.Count())  // En çok satanları sıralıyoruz
//                        .Take(5) // İlk 5 en çok satılan ürünü alıyoruz
//                        .Select(g => new { Product = g.Key, Sales = g.Count() })
//                        .ToList();

//                    // En çok satılan ürünler yazdırılıyor
//                    foreach (var item in topSellingProducts)
//                    {
//                        Console.WriteLine($"Ürün Kodu: {item.Product}, Satış Miktarı: {item.Sales}");
//                    }
//                }
//                catch (Exception ex)
//                {
//                    Console.WriteLine($"Hata: {ex.Message}");
//                }
//            }

//            // Tüm ürünleri listeleme
//            private static void ListAllProducts()
//            {
//                try
//                {
//                    // Tüm ürünler listeleniyor
//                    foreach (var product in products)
//                    {
//                        Console.WriteLine($"Ürün Kodu: {product.Code}, Adı: {product.Name}, Fiyat: {product.Price}, Stok: {product.Stock}");
//                    }
//                }
//                catch (Exception ex)
//                {
//                    Console.WriteLine($"Hata: {ex.Message}");
//                }
//            }

//            // Stok listesi
//            private static void ShowStockList()
//            {
//                try
//                {
//                    Console.WriteLine("Stok Listesi:");
//                    foreach (var product in products)
//                    {
//                        Console.WriteLine($"Ürün Kodu: {product.Code}, Adı: {product.Name}, Stok: {product.Stock}");
//                    }
//                }
//                catch (Exception ex)
//                {
//                    Console.WriteLine($"Hata: {ex.Message}");
//                }
//            }

//            // Fatura oluşturma ve müşteri bilgilerini dosyaya yazma
//            private static void GenerateInvoice()
//            {
//                try
//                {
//                    // Müşteri adı ve fatura adresi alınıyor
//                    Console.WriteLine("Sipariş detaylarını oluşturuyor...");
//                    Console.Write("Müşteri Adı: ");
//                    string customerName = Console.ReadLine();
//                    Console.Write("Fatura Adresi: ");
//                    string address = Console.ReadLine();

//                    string invoicePath = Path.Combine(filePath, customerName);
//                    Directory.CreateDirectory(invoicePath); // Müşteri için klasör oluşturuluyor

//                    string invoiceFile = Path.Combine(invoicePath, $"{Guid.NewGuid()}.txt");
//                    var invoiceDetails = new List<string>
//                {
//                    $"Müşteri Adı: {customerName}",
//                    $"Fatura Adresi: {address}",
//                    "Satış Detayları:",
//                };

//                    // Müşterinin siparişleri dosyaya yazılıyor
//                    foreach (var order in orders.Where(o => o.CustomerName == customerName))
//                    {
//                        invoiceDetails.Add($"Ürün Kodu: {order.Product.Code}, Ürün Adı: {order.Product.Name}, Fiyat: {order.Product.Price}");
//                    }

//                    File.WriteAllLines(invoiceFile, invoiceDetails);
//                    Console.WriteLine("Fatura başarıyla oluşturuldu.");
//                }
//                catch (Exception ex)
//                {
//                    Console.WriteLine($"Hata: {ex.Message}");
//                }
//            }

//            // Dosya işlemleri (Kopyalama, Silme, Birleştirme, vb.)
//            private static void FileOperations()
//            {
//                try
//                {
//                    // Dosya işlemleri seçeneği
//                    Console.WriteLine("Dosya işlemleri: [1] Kopyala [2] Sil [3] Birleştir");
//                    string fileOp = Console.ReadLine();

//                    switch (fileOp)
//                    {
//                        case "1":
//                            Console.Write("Kaynak dosya yolu: ");
//                            string sourcePath = Console.ReadLine();
//                            Console.Write("Hedef dosya yolu: ");
//                            string targetPath = Console.ReadLine();
//                            File.Copy(sourcePath, targetPath, true); // Dosyayı kopyala
//                            Console.WriteLine("Dosya başarıyla kopyalandı.");
//                            break;
//                        case "2":
//                            Console.Write("Silmek istediğiniz dosya yolu: ");
//                            string deletePath = Console.ReadLine();
//                            File.Delete(deletePath); // Dosyayı sil
//                            Console.WriteLine("Dosya başarıyla silindi.");
//                            break;
//                        case "3":
//                            Console.Write("Birleştirilecek dosya 1: ");
//                            string file1 = Console.ReadLine();
//                            Console.Write("Birleştirilecek dosya 2: ");
//                            string file2 = Console.ReadLine();
//                            Console.Write("Birleştirilmiş dosyanın hedef yolu: ");
//                            string mergedFile = Console.ReadLine();
//                            var allLines = File.ReadAllLines(file1).Concat(File.ReadAllLines(file2));
//                            File.WriteAllLines(mergedFile, allLines); // Dosyaları birleştir
//                            Console.WriteLine("Dosyalar başarıyla birleştirildi.");
//                            break;
//                        default:
//                            Console.WriteLine("Geçersiz işlem!"); // Geçersiz işlem mesajı
//                            break;
//                    }
//                }
//                catch (Exception ex)
//                {
//                    Console.WriteLine($"Hata: {ex.Message}");
//                }
//            }

//            // Ürün verilerini dosyaya kaydetme
//            private static void SaveProductsToFile()
//            {
//                try
//                {
//                    string file = Path.Combine(filePath, "products.txt");
//                    var lines = products.Select(p => $"{p.Code}-{p.Name}-{p.Price}-{p.Stock}");
//                    File.WriteAllLines(file, lines);  // Ürünler dosyaya kaydedilir
//                }
//                catch (Exception ex)
//                {
//                    Console.WriteLine($"Hata: {ex.Message}");
//                }
//            }

//            // Sipariş verilerini dosyaya kaydetme
//            private static void SaveOrdersToFile()
//            {
//                try
//                {
//                    string file = Path.Combine(filePath, "orders.txt");
//                    var lines = orders.Select(o => $"{o.CustomerName}-{o.Product.Code}-{o.Product.Name}");
//                    File.WriteAllLines(file, lines);  // Siparişler dosyaya kaydedilir
//                }
//                catch (Exception ex)
//                {
//                    Console.WriteLine($"Hata: {ex.Message}");
//                }
//            }
//        }

//        // Ürün sınıfı
//        public class Product
//        {
//            public string Code { get; set; }
//            public string Name { get; set; }
//            public double Price { get; set; }
//            public int Stock { get; set; }

//            public Product(string code, string name, double price, int stock)
//            {
//                Code = code;
//                Name = name;
//                Price = price;
//                Stock = stock;
//            }
//        }

//        // Sipariş sınıfı
//        public class Order
//        {
//            public string CustomerName { get; set; }
//            public Product Product { get; set; }

//            public Order(string customerName, Product product)
//            {
//                CustomerName = customerName;
//                Product = product;
//            }
//        }
    }

}
    
