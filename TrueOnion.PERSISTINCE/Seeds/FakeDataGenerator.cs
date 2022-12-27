using Bogus;
using Bogus.Bson;
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
            int categoryCount = 10;
            Faker<Category> categoryFaker = new();
            categoryFaker.StrictMode(false)
            .RuleFor(x => x.CategoryName, x => categoryId == 1 ? "All" : x.Commerce.Categories(1).First())
            .RuleFor(x => x.InsertedDate, x => x.Date.Between(new DateTime(2020, 3, 14), DateTime.Now))
            .RuleFor(x => x.LastModifiedDate, x => null)
            .RuleFor(x => x.Products, x => null)
            .RuleFor(x => x.ParentID, x => categoryId == 1 ? null : categoryId == 2 ? 1 : new Random().Next(1, categoryId))
            .RuleFor(x => x.ID, x => categoryId++)
            .RuleFor(x => x.Status, x => DataStatus.Inserted);
            Categories = categoryFaker.Generate(categoryCount);
            #endregion

            #region Fake Product Datas
            int productId = 1;
            Faker<Product> productFaker = new();
            productFaker.StrictMode(false)
            .RuleFor(x => x.ID, x => productId++)
            .RuleFor(x => x.InsertedDate, x => x.Date.Between(new DateTime(2020, 3, 14), DateTime.Now))
            .RuleFor(x => x.Name, x => x.Commerce.ProductName())
            .RuleFor(x => x.Price, x => x.Commerce.Price(1).First())
            .RuleFor(x => x.LastModifiedDate, x => null)
            .RuleFor(x => x.Status, x => DataStatus.Inserted)
            .RuleFor(x => x.Stock, x => x.Random.Int(1, 200))
            .RuleFor(x => x.CategoryID, x => x.PickRandom(Categories).ID);

            Products = productFaker.Generate(30);
            #endregion

            #region Fake ProductFeature Datas
            int productFeatureId = 1;
            Faker<ProductFeature> productFeatureFaker = new();
            productFeatureFaker.StrictMode(false)
            .RuleFor(x => x.ID, x => productFeatureId++)
            .RuleFor(x => x.InsertedDate, x => x.Date.Between(new DateTime(2020, 3, 14), DateTime.Now))
            .RuleFor(x => x.LastModifiedDate, x => null)
            .RuleFor(x => x.Status, x => DataStatus.Inserted)
            .RuleFor(x => x.MadeIn, x => x.Address.Country())
            .RuleFor(x => x.RelaseDate, x => x.Date.Between(new DateTime(2020, 3, 14), DateTime.Now));

            ProductFeatures = productFeatureFaker.Generate(30);

            #endregion

            #region Fake Supplier Datas
            int supplierId = 1;
             Faker<Supplier> supplierFaker = new();

            supplierFaker.StrictMode(false)
            .RuleFor(x => x.ID, x => supplierId++)
            .RuleFor(x => x.InsertedDate, x => x.Date.Between(new DateTime(2020, 3, 14), DateTime.Now))
            .RuleFor(x => x.LastModifiedDate, x => null)
            .RuleFor(x => x.Status, x => DataStatus.Inserted)
            .RuleFor(x => x.CompanyName, x => x.Company.CompanyName());

            Suppliers = supplierFaker.Generate(10);

            #endregion

            #region Fake ProductSupplier Datas
            Faker<ProductSupplier> productSupplierFaker = new();
            productSupplierFaker.StrictMode(false)
            .RuleFor(x => x.ProductID, x => x.PickRandom(Products).ID)
            .RuleFor(x => x.SupplierID, x => x.PickRandom(Suppliers).ID)
            .RuleFor(x => x.InsertedDate, x => x.Date.Between(new DateTime(2020, 3, 14), DateTime.Now))
            .RuleFor(x => x.LastModifiedDate, x => null)
            .RuleFor(x => x.Status, x => DataStatus.Inserted)
            .RuleFor(x => x.MaxCountPerShipping, x => x.Random.Int(1, 200));
            //remove duplicate datas
            ProductSuppliers = productSupplierFaker.Generate(100)
                .GroupBy(x => new { x.ProductID, x.SupplierID })
                .Select(x => x.First())
                .ToList();
            #endregion

        }


        public static List<Product> Products { get; set; }
        public static List<Category> Categories { get; set; }
        public static List<ProductFeature> ProductFeatures { get; set; }
        public static List<Supplier> Suppliers { get; set; }
        public static List<ProductSupplier> ProductSuppliers { get; set; } = new List<ProductSupplier>();

    }
}