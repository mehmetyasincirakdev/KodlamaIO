using Business.Abstracts;
using DataAccess.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes;

public class CategoryManager : ICategoryService
{
    private readonly ICategoryDal _categorDal;

    public CategoryManager(ICategoryDal categorDal)
    {
        _categorDal = categorDal;
    }

    public List<Category> GetAll()
    {
        return _categorDal.GetAll();
    }
}
