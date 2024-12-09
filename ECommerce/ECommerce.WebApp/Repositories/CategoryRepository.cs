using ECommerce.WebApp.Models.Data;
using ECommerce.WebApp.Models.View;

namespace ECommerce.WebApp.Repositories;

public interface ICategoryRepository<S, T> : IRepository<S, T>
{
}

public class CategoryRepository : ICategoryRepository<CategoryView, Category>
{
    private ECommerceDbContext _context;
    public CategoryRepository(ECommerceDbContext context)
    {
        _context = context;
    }
    public Category Create(CategoryView dto)
    {
        throw new NotImplementedException();
    }

    public bool Delete(int id)
    {
        throw new NotImplementedException();
    }

    public Category Get(int id)
    {
        return _context.Categories.Where(x => x.Id == id).FirstOrDefault()!;
    }

    public List<Category> GetAll()
    {
        return _context.Categories.ToList();
    }

    public List<Category> GetByParent(int? id)
    {
        throw new NotImplementedException();
    }

    public Category Update(CategoryView dto)
    {
        throw new NotImplementedException();
    }
}
