using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.Expando;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using RepositoryProject.Factory;
using RepositoryProject.Models;
using RepositoryProject.Repositories;

namespace RepositoryProject.DITest
{
    public class TestClass
    {
        IRepoFactory factory;
        public TestClass(IRepoFactory factory)
        {
            this.factory = factory;
        }

        public void Run()
        {
            #region Brand
            IRepositories<Brand> repoB = factory.CreateRepo<Brand>();
            
            repoB.AddRange(new Brand[]
            {
             new Brand { Id = 1, Name = "Apple", EstablishYear = 1976, ParentCompany = "Apple Inc", GlobalRanking = 1 },

                new Brand { Id = 2, Name = "Samsung", EstablishYear = 1938, ParentCompany = "Samsung Group", GlobalRanking = 2 },

                new Brand { Id = 3, Name = "Xiaomi", EstablishYear = 2010, ParentCompany = "Xiaomi Corporation", GlobalRanking = 3 },

                new Brand { Id = 4, Name = "Oppo", EstablishYear = 2004, ParentCompany = "BBK Electronics", GlobalRanking = 4 },

                new Brand { Id = 5, Name = "Vivo", EstablishYear = 2009, ParentCompany = "BBK Electronics", GlobalRanking = 5 },

                new Brand { Id = 6, Name = "Huawei", EstablishYear = 1987, ParentCompany = "Huawei Technologies", GlobalRanking = 6 },

                new Brand { Id = 7, Name = "OnePlus", EstablishYear = 2013, ParentCompany = "Oppo (BBK Electronics)", GlobalRanking = 7 },

                new Brand { Id = 8, Name = "Realme", EstablishYear = 2018, ParentCompany = "Oppo (BBK Electronics)", GlobalRanking = 8 },

                new Brand { Id = 9, Name = "Google Pixel", EstablishYear = 2016, ParentCompany = "Alphabet Inc.", GlobalRanking = 9 },

                new Brand { Id = 10, Name = "Sony", EstablishYear = 1946, ParentCompany = "Sony Corporation", GlobalRanking = 10 },
                    new Brand { Id = 11, Name = "Motorola", EstablishYear = 1928, ParentCompany = "Lenovo", GlobalRanking = 11 },
                new Brand { Id = 12, Name = "Nokia", EstablishYear = 1865, ParentCompany = "HMD Global", GlobalRanking = 12 },
                new Brand { Id = 13, Name = "LG", EstablishYear = 1958, ParentCompany = "LG Corporation", GlobalRanking = 13 },
                new Brand { Id = 14, Name = "Asus", EstablishYear = 1989, ParentCompany = "AsusTek Computer Inc.", GlobalRanking = 14 },
                new Brand { Id = 15, Name = "Tecno", EstablishYear = 2006, ParentCompany = "Transsion Holdings", GlobalRanking = 15 },
                new Brand { Id = 16, Name = "Infinix", EstablishYear = 2013, ParentCompany = "Transsion Holdings", GlobalRanking = 16 },
                new Brand { Id = 17, Name = "ZTE", EstablishYear = 1985, ParentCompany = "ZTE Corporation", GlobalRanking = 17 },
                new Brand { Id = 18, Name = "Honor", EstablishYear = 2013, ParentCompany = "Honor Device Co., Ltd.", GlobalRanking = 18 },
                new Brand { Id = 19, Name = "HTC", EstablishYear = 1997, ParentCompany = "HTC Corporation", GlobalRanking = 19 }
            });
            Console.WriteLine();
            Console.WriteLine("************************Brand Info******************************");
            //Get All
            Console.WriteLine();
            Console.WriteLine("=============GetAll===============");
            repoB.GetALl().ToList()
               .ForEach(b => Console.WriteLine($"\nId : {b.Id}\nName :{b.Name}\nEstablish Year :{b.EstablishYear}\nParent Company :{b.ParentCompany}\nGlobal Ranking :{b.GlobalRanking}\n\n*****************"));

            //Get By Id
            Console.WriteLine();
            Console.WriteLine("=============Get by Id===============");

            var gi = repoB.Get(10);
            Console.WriteLine($"\nId : {gi.Id}\nName :{gi.Name}\nEstablish Year :{gi.EstablishYear}\nParent Company :{gi.ParentCompany}\nGlobal Ranking :{gi.GlobalRanking}\n\n***************** ");

            //Update
            Console.WriteLine();
            Console.WriteLine("=============Update===============");
            gi.Name = "Micromax"; gi.EstablishYear = 2000; gi.ParentCompany = "Micromax Informatics"; gi.GlobalRanking = 20;
            repoB.Update(gi);
            repoB.GetALl().ToList()
             .ForEach(b => Console.WriteLine($"\nId : {b.Id}\nName :{b.Name}\nEstablish Year :{b.EstablishYear}\nParent Company :{b.ParentCompany}\nGlobal Ranking :{b.GlobalRanking}\n\n*****************"));

            //Delete
            Console.WriteLine();
            Console.WriteLine("=============Delete===============");
            repoB.Delete(10);
            repoB.GetALl().ToList()
            .ForEach(b => Console.WriteLine($"\nId : {b.Id}\nName :{b.Name}\nEstablish Year :{b.EstablishYear}\nParent Company :{b.ParentCompany}\nGlobal Ranking :{b.GlobalRanking}\n\n***************** "));


            Console.WriteLine("************************Brand End******************************");
#endregion
            Console.WriteLine();
            #region Category
            Console.WriteLine("************************Category Info******************************");

            IRepositories<Category> repoC = factory.CreateRepo<Category>();
            repoC.AddRange(new Category[]
            {
                new Category{Id=1, Name="Smartphones"},
                new Category{Id=2, Name="Tablets"},
                new Category{Id=1, Name="Wearables"},
                new Category{Id=3, Name="Accessories"},
                new Category{Id=4, Name="Smart Home Devices"},
                new Category{Id=5, Name="Gadgets"},
                new Category{Id=6, Name="Networking Equipment"},
            });

            //GetAll
            Console.WriteLine();
            Console.WriteLine("=============GetAll===============");
            repoC.GetALl().ToList()
                .ForEach(p => Console.WriteLine($"\n\n***************** Id : {p.Id}\tName : {p.Name}\n\n***************** "));

             Console.WriteLine("************************Category End******************************");
            #endregion

            #region product
            Console.WriteLine();
            IRepositories<Product> repoP = factory.CreateRepo<Product>();
            repoP.AddRange(new Product[]
            {
                 new Product
                {
                    Id = 1,
                    Name = "iPhone 15 Pro",
                    ModelNumber = "A2890",
                    Color = "Silver",
                    Processor = "A17 Bionic",
                    RAM = "8GB",
                    Storage = "512GB",
                    Price = 1299.99m,
                    Stock = 50,
                    CategoryId = 1, // Smartphones
                    BrandId = 1    // Apple
                },
                new Product
                {
                    Id = 2,
                    Name = "Galaxy Tab S9",
                    ModelNumber = "T970",
                    Color = "Graphite",
                    Processor = "Snapdragon 8 Gen 2",
                    RAM = "12GB",
                    Storage = "256GB",
                    Price = 899.99m,
                    Stock = 30,
                    CategoryId = 2, // Tablets
                    BrandId = 2    // Samsung
                },
                new Product
                {
                    Id = 3,
                    Name = "Mi Smart Band 8",
                    ModelNumber = "M800",
                    Color = "Black",
                    Processor = "Custom Wearable Chip",
                    RAM = "128MB",
                    Storage = "256MB",
                    Price = 49.99m,
                    Stock = 100,
                    CategoryId = 3, // Wearables
                    BrandId = 3    // Xiaomi
                },
                new Product
                {
                    Id = 4,
                    Name = "Pixel Watch 2",
                    ModelNumber = "G123",
                    Color = "Champagne Gold",
                    Processor = "Qualcomm W5+",
                    RAM = "2GB",
                    Storage = "32GB",
                    Price = 349.99m,
                    Stock = 20,
                    CategoryId = 3, // Wearables
                    BrandId = 9    // Google Pixel
                },
                new Product
                {
                    Id = 5,
                    Name = "Sony WH-1000XM5",
                    ModelNumber = "WHXM5",
                    Color = "Black",
                    Processor = "Q1 Noise Canceling Processor",
                    RAM = "N/A",
                    Storage = "N/A",
                    Price = 399.99m,
                    Stock = 25,
                    CategoryId = 4, // Accessories
                    BrandId = 10   // Sony
                },                                                      

               
                new Product
                {
                    Id = 6,
                    Name = "Galaxy S23 Ultra",
                    ModelNumber = "S23U",
                    Color = "Phantom Black",
                    Processor = "Snapdragon 8 Gen 2",
                    RAM = "12GB",
                    Storage = "512GB",
                    Price = 1399.99m,
                    Stock = 40,
                    CategoryId = 1, // Smartphones
                    BrandId = 2    // Samsung
                },
                new Product
                {
                    Id = 7,
                    Name = "Xiaomi Pad 6 Pro",
                    ModelNumber = "P6Pro",
                    Color = "Blue",
                    Processor = "Snapdragon 8+ Gen 1",
                    RAM = "8GB",
                    Storage = "256GB",
                    Price = 599.99m,
                    Stock = 30,
                    CategoryId = 2, // Tablets
                    BrandId = 3    // Xiaomi
                },
                new Product
                {
                    Id = 7,
                    Name = "Oppo Watch 4 Pro",
                    ModelNumber = "OW4P",
                    Color = "Black",
                    Processor = "Qualcomm W5",
                    RAM = "2GB",
                    Storage = "32GB",
                    Price = 329.99m,
                    Stock = 50,
                    CategoryId = 3, // Wearables
                    BrandId = 4    // Oppo
                },
                new Product
                {
                    Id = 9,
                    Name = "Vivo X90 Pro",
                    ModelNumber = "VX90P",
                    Color = "Legendary Black",
                    Processor = "MediaTek Dimensity 9200",
                    RAM = "12GB",
                    Storage = "512GB",
                    Price = 1199.99m,
                    Stock = 35,
                    CategoryId = 1, // Smartphones
                    BrandId = 5    // Vivo
                },
                new Product
                {
                    Id = 10,
                    Name = "Huawei Mate 60 Pro",
                    ModelNumber = "HM60P",
                    Color = "White",
                    Processor = "Kirin 9000S",
                    RAM = "12GB",
                    Storage = "512GB",
                    Price = 1299.99m,
                    Stock = 20,
                    CategoryId = 1, // Smartphones
                    BrandId = 6    // Huawei
                },
                new Product
                {
                    Id = 11,
                    Name = "OnePlus 11",
                    ModelNumber = "OP11",
                    Color = "Titan Black",
                    Processor = "Snapdragon 8 Gen 2",
                    RAM = "16GB",
                    Storage = "256GB",
                    Price = 799.99m,
                    Stock = 45,
                    CategoryId = 1, // Smartphones
                    BrandId = 7    // OnePlus
                },
                new Product
                {
                    Id = 12,
                    Name = "Realme GT Neo 5",
                    ModelNumber = "GTN5",
                    Color = "Purple",
                    Processor = "Snapdragon 8+ Gen 1",
                    RAM = "16GB",
                    Storage = "512GB",
                    Price = 599.99m,
                    Stock = 60,
                    CategoryId = 1, // Smartphones
                    BrandId = 8    // Realme
                },
                new Product
                {
                    Id = 13,
                    Name = "Google Pixel 8 Pro",
                    ModelNumber = "GP8P",
                    Color = "Obsidian",
                    Processor = "Google Tensor G3",
                    RAM = "12GB",
                    Storage = "128GB",
                    Price = 999.99m,
                    Stock = 25,
                    CategoryId = 1, // Smartphones
                    BrandId = 9    // Google Pixel
                },
                new Product
                {
                    Id = 15,
                    Name = "Sony Xperia 5 V",
                    ModelNumber = "SX5V",
                    Color = "Blue",
                    Processor = "Snapdragon 8 Gen 2",
                    RAM = "8GB",
                    Storage = "128GB",
                    Price = 899.99m,
                    Stock = 15,
                    CategoryId = 1, // Smartphones
                    BrandId = 10   // Sony
                },
                new Product
                {
                    Id = 15,
                    Name = "Moto Edge 40 Pro",
                    ModelNumber = "ME40P",
                    Color = "White",
                    Processor = "Snapdragon 8 Gen 2",
                    RAM = "12GB",
                    Storage = "256GB",
                    Price = 799.99m,
                    Stock = 20,
                    CategoryId = 1, // Smartphones
                    BrandId = 11   // Motorola
                },
                new Product
                {
                    Id = 16,
                    Name = "Nokia XR21",
                    ModelNumber = "NXR21",
                    Color = "Green",
                    Processor = "Snapdragon 695",
                    RAM = "6GB",
                    Storage = "128GB",
                    Price = 499.99m,
                    Stock = 25,
                    CategoryId = 1, // Smartphones
                    BrandId = 12   // Nokia
                },
                new Product
                {
                    Id = 17,
                    Name = "LG Gram Laptop 16",
                    ModelNumber = "LG16G",
                    Color = "White",
                    Processor = "Intel Core i7",
                    RAM = "16GB",
                    Storage = "1TB SSD",
                    Price = 1499.99m,
                    Stock = 10,
                    CategoryId = 6, // Gadgets
                    BrandId = 13   // LG
                },
                new Product
                {
                    Id = 18,
                    Name = "Asus ROG Phone 7",
                    ModelNumber = "RGP7",
                    Color = "Black",
                    Processor = "Snapdragon 8 Gen 2",
                    RAM = "16GB",
                    Storage = "512GB",
                    Price = 999.99m,
                    Stock = 30,
                    CategoryId = 1, // Smartphones
                    BrandId = 14   // Asus
                },
            });
            Console.WriteLine();
            //GetAll
            Console.WriteLine();
            Console.WriteLine("=============GetAll===============");
            Console.WriteLine();
            repoP.GetALl().ToList()
                 .ForEach(p => Console.WriteLine($"\nId: {p.Id},\nName: {p.Name},\nModel Number: {p.ModelNumber},\nColor:{p.Color},\n Processor: {p.Processor},\nRAM:{p.RAM},\nStorage: {p.Storage},\nPrice: {p.Price},\nStock: {p.Stock},\nCetegory Id: {p.CategoryId},\nBrand Id: {p.BrandId}\n\n******************"));
            Console.WriteLine();

            //Get By Id
            Console.WriteLine();
            Console.WriteLine("=============Get by Id===============");
            var product = repoP.Get(17);
            Console.WriteLine($"\nId: {product.Id}\nName: {product.Name}\nModel Number: {product.ModelNumber}\nColor:{product.Color}\nProcessor: {product.Processor}\tRAM:{product.RAM}\nStorage: {product.Storage}\nPrice: {product.Price}\nStock: {product.Stock}\nCetegory Id: {product.CategoryId}\nBrand Id: {product.BrandId}\n\n******************");
            Console.WriteLine();


            //Update
            Console.WriteLine();
            Console.WriteLine("=============Update===============");
            Console.WriteLine();
            product.Price = 1300M;
            repoP.Update(product);
            repoP.GetALl().ToList()
                 .ForEach(p => Console.WriteLine($"\nId: {p.Id}\nName: {p.Name}\nModel Number: {p.ModelNumber}\nColor:{p.Color}\nProcessor: {p.Processor}\nRAM:{p.RAM}\nStorage: {p.Storage}\nPrice: {p.Price}\nStock: {p.Stock}\nCetegory Id: {p.CategoryId}\nBrand Id: {p.BrandId}\n\n******************"));
            Console.WriteLine();

            //Delete
            Console.WriteLine();
            Console.WriteLine("=============Delete===============");
            repoP.Delete(16);
            repoP.GetALl().ToList()
                .ForEach(p => Console.WriteLine($"\nId: {p.Id}\nName: {p.Name}\nModel Number: {p.ModelNumber}\nColor:{p.Color}\nProcessor: {p.Processor}\nRAM:{p.RAM}\nStorage: {p.Storage}\nPrice: {p.Price}\nStock: {p.Stock}\nCetegory Id: {p.CategoryId}\nBrand Id: {p.BrandId}\n\n******************"));
            #endregion
        }
    }
}
