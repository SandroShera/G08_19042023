using G08_19042023.Models;
using Repository;

namespace G08_19042023
{
    public  class NorthwindCategories
    {
        private readonly ApplicationDbContext _context;

        public NorthwindCategories(ApplicationDbContext context)
        {
            _context = context;
        }

        public CategoryModel GetCategoryById(int id)
        {
            
            var category = _context.Categories.Find(id);
            if (category == null)
            {
                throw new Exception("No Category with such id");
            }

            return new CategoryModel()
            {
                CategoryName = category.CategoryName,
                Description= category.Description,
            };
        }
    }
}
