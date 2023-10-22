namespace SmallFormApp.Models
{
    public static class ProductRepository
    {
        private static List<Product> _products;

        static ProductRepository()
        {
            _products = new List<Product>()
            {
                new Product()
                {
                      Id = 1,
                      Name="Polo yaka beyaz tişört",
                      Description="Tişört  1",
                      Price=10,
                      isApproved=true

                },
                  new Product()
                {
                      Id = 2,
                      Name="V yaka beyaz tişört",
                      Description="Tişört  1",
                      Price=10,
                      isApproved=true

                },
                      new Product()
                {
                      Id = 3,
                      Name="Over size beyaz tişört",
                      Description="Tişört 2",
                      Price=30,
                      isApproved=false

                },
                      new Product()
                {
                      Id = 4,
                      Name="Over size siyah tişört",
                      Description="Tişört  2",
                      Price=40,
                      isApproved=false

                },
                      new Product()
                {
                      Id = 5,
                      Name="Siyah kot pantolon",
                      Description="Pantolon  1",
                      Price=50,
                      isApproved=false

                },
                      new Product()
                {
                      Id = 6,
                      Name="Siyah kumaş pantolon",
                      Description="Pantolon  2",
                      Price=80,
                      isApproved=true

                },
            };
        }

        public static List<Product> Products
        {
            get { return _products; }
        }

        public static void AddProduct(Product product)
        {
            _products.Add(product);
        }
        public static void UpdateProduct(Product entity)
        {
            var product = _products.Where(x=> x.Id==entity.Id).Single();
            product.Name=entity.Name;
            product.Price=entity.Price;
            product.isApproved=entity.isApproved;

        }
    }
}