using Bogus;
using TrueOnion.DOMAIN.Entities;

namespace TrueOnion.PERSISTINCE.Seeds
{
    public static class FakeDataGenerator
    {
        static  FakeDataGenerator()
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
            .RuleFor(x => x.Status, x => DOMAIN.Enums.DataStatus.Inserted);

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
        }

        public static List<Product> Products { get; set; }
        public static List<Category> Categories { get; set; }

    }
}