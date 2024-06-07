using BusinessObject;

namespace DataAccessLayer
{
    public class ProductDAO
    {
        public static List<Product> GetProducts()
        {
            var listProducts = new List<Product>();

            try
            {
                using var db = new MyStoreContext();
                listProducts = db.Products.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return listProducts;
        }

        public static void SaveProduct(Product p)
        {
            try
            {
                using var db = new MyStoreContext();
                db.Products.Add(p);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static void UpdateProduct(Product p)
        {
            try
            {
                using var db = new MyStoreContext();
                db.Entry<Product>(p).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static void DeleteProduct(Product p)
        {
            try
            {
                using var db = new MyStoreContext();
                var p1 = db.Products.FirstOrDefault(c => c.ProductId == p.ProductId);
                db.Products.Remove(p1);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static Product? GetProductById(int id)
        {
            using var db = new MyStoreContext();
            return db.Products.FirstOrDefault(p => p.ProductId == id);
        }
    }
}
