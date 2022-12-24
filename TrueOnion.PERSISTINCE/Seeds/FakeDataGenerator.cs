using Bogus;
using Bogus.DataSets;
using TrueOnion.DOMAIN.Entities.Concrates;
using TrueOnion.DOMAIN.Enums;

namespace TrueOnion.PERSISTINCE.Seeds
{
    public static class FakeDataGenerator
    {
        static FakeDataGenerator()
        {
            Init();
        }
        public static void Init()
        {
            #region Fake Category Datas
            int categoryId = 1;
            Faker<Category> categoryFaker = new Faker<Category>()
            .RuleFor(x => x.CategoryName, x => x.Commerce.Categories(1).First())
            .StrictMode(true)
            .RuleFor(x => x.ID, x => categoryId++)
            .RuleFor(x => x.InsertedDate, x => x.Date.Between(new DateTime(2021, 3, 14), DateTime.Now))
            .RuleFor(x => x.DeletedDate, x => null)
            .RuleFor(x => x.ModifiedDate, x => null)
            .RuleFor(x => x.Products, x => null)
            .RuleFor(x => x.Status, x => DataStatus.Inserted);

            Categories = categoryFaker.Generate(10);
            #endregion

            #region Fake Product Datas
            int productId = 1;
            Faker<Product> productFaker = new Faker<Product>()
            .StrictMode(false)
            .RuleFor(x => x.ID, x => productId++)
            .RuleFor(x => x.InsertedDate, x => x.Date.Between(new DateTime(2021, 3, 14), DateTime.Now))
            .RuleFor(x => x.DeletedDate, x => null)
            .RuleFor(x => x.Name, x => x.Commerce.ProductName())
            .RuleFor(x => x.Price, x => x.Commerce.Price(1).First())
            .RuleFor(x => x.ModifiedDate, x => null)
            .RuleFor(x => x.Status, x => DOMAIN.Enums.DataStatus.Inserted)
            .RuleFor(x => x.Stock, x => x.Random.Int(1, 200))
            .RuleFor(x => x.CategoryID, x => x.PickRandom(Categories).ID);

            Products = productFaker.Generate(30);
            #endregion

            #region Fake ProductFeature Datas
            int productFeatureId = 1;
            Faker<ProductFeature> productFeatureFaker = new Faker<ProductFeature>();
            productFeatureFaker.StrictMode(false);
            productFeatureFaker.RuleFor(x => x.ID, x => productFeatureId++);
            productFeatureFaker.RuleFor(x => x.InsertedDate, x => x.Date.Between(new DateTime(2021, 3, 14), DateTime.Now));
            productFeatureFaker.RuleFor(x => x.DeletedDate, x => null);
            productFeatureFaker.RuleFor(x => x.ModifiedDate, x => null);
            productFeatureFaker.RuleFor(x => x.Status, x => DOMAIN.Enums.DataStatus.Inserted);
            productFeatureFaker.RuleFor(x => x.MadeIn, x => x.Address.Country());
            productFeatureFaker.RuleFor(x => x.RealeseDate, x => x.Date.Between(new DateTime(2021, 3, 14), DateTime.Now));


            ProductFeatures = productFeatureFaker.Generate(30);

            #endregion

            #region Fake Supplier Datas
            int supplierId = 1;
            Faker<Supplier> supplierFaker = new Faker<Supplier>();
            supplierFaker.StrictMode(false);
            supplierFaker.RuleFor(x => x.ID, x => supplierId++);
            supplierFaker.RuleFor(x => x.InsertedDate, x => x.Date.Between(new DateTime(2021, 3, 14), DateTime.Now));
            supplierFaker.RuleFor(x => x.DeletedDate, x => null);
            supplierFaker.RuleFor(x => x.ModifiedDate, x => null);
            supplierFaker.RuleFor(x => x.Status, x => DataStatus.Inserted);
            supplierFaker.RuleFor(x => x.CompanyName, x => x.Company.CompanyName());

            Suppliers = supplierFaker.Generate(10);

            #endregion

            #region Fake ProductSupplier Datas
            //for (int i = 1; i <= Products.Count(); i++)
            //{
            //    for (int j = 1; j <= Suppliers.Count()/2; j++)
            //    {
            //        ProductSupplier productSupplier = new()
            //        {
            //            ProductID = i,
            //            SupplierID=j,
            //            InsertedDate = DateTime.Now,
            //            DeletedDate =null,
            //            ModifiedDate = null,
            //            Status = DataStatus.Inserted,
            //            MaxCountPerShipping=i*j,
            //        };

            //        ProductSuppliers.Add(productSupplier);
            //    }
            //}
            Faker<ProductSupplier> productSupplierFaker = new();
            productSupplierFaker
                .StrictMode(false)
                .RuleFor(x => x.ProductID, x => x.PickRandom(Products).ID)
                .RuleFor(x => x.SupplierID, x => x.PickRandom(Suppliers).ID)
                .RuleFor(x => x.InsertedDate, x => x.Date.Between(new DateTime(2021, 3, 14), DateTime.Now))
                .RuleFor(x => x.DeletedDate, x => null)
                .RuleFor(x => x.ModifiedDate, x => null)
                .RuleFor(x => x.Status, x => DataStatus.Inserted)
                .RuleFor(x => x.MaxCountPerShipping, x => x.Random.Int(1, 200));
            //remove duplicate datas
            ProductSuppliers = productSupplierFaker.Generate(100).GroupBy(x => new { x.ProductID, x.SupplierID }).Select(x => x.First()).ToList();
            #endregion

        }


        public static List<Product> Products { get; set; }
        public static List<Category> Categories { get; set; }
        public static List<ProductFeature> ProductFeatures { get; set; }
        public static List<Supplier> Suppliers { get; set; }
        public static List<ProductSupplier> ProductSuppliers { get; set; } = new List<ProductSupplier>();

    }
}