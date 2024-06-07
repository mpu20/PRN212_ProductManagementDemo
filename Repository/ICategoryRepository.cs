using BusinessObject;

namespace Repository
{
    public  interface ICategoryRepository
    {
        List<Category> GetCategories();
    }
}
