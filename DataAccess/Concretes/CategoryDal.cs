﻿using DataAccess.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes;

public class CategoryDal : ICategoryDal
{
    List<Category> _categories;
    public CategoryDal()
    {
        _categories = new List<Category>
        {
            // 1. Backend Development
            new Category { CategoryId = 1, CategoryName = "Backend Development" },

            // 2. Frontend Development
            new Category { CategoryId = 2, CategoryName = "Frontend Development" },

            // 3. Mobile Development
            new Category { CategoryId = 3, CategoryName = "Mobile Development" },

            // 4. Data Science & Machine Learning
            new Category { CategoryId = 4, CategoryName = "Data Science & Machine Learning" },

            // 5. Full Stack Development
            new Category { CategoryId = 5, CategoryName = "Full Stack Development" },

        };
    }
    public void Add(Category category)
    {
        _categories.Add(category);
    }

    public void Delete(Category category)
    {
        _categories.Remove(category);
    }

    public void DeleteById(int id)
    {
        _categories.Remove(_categories.SingleOrDefault(x => x.CategoryId == id));
    }

    public List<Category> GetAll()
    {
        return _categories;
    }

    public void Update(Category category)
    {
        throw new NotImplementedException();
    }
}
