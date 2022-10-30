using Entities;

namespace ShopppingDb
{
    //static classlar newlenmez 
    //instance member newleme yaptığımız yerlerdir.
    public static class ProductDb
    {
        public static List<Product> Products { get; set; }
        static ProductDb()
        {
            Products = new List<Product>()
            {
                 new Product(){Id=1, ProductName="HP",Price=15000,  Category=new Category(){CategoryId=1,CategoryName="Electronic"}},
                new Product(){Id=2, ProductName="IPHONE14",Price=18000,  Category=new Category(){CategoryId=2,CategoryName="Telephone"} },
                new Product(){Id=3, ProductName="LENOVA",Price=20000, Category=new Category(){CategoryId=3,CategoryName="Laptop"} }

                 };

        }
    }
}