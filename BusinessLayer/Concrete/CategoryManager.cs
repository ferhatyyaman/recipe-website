﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Repositories;
using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : IWriteryService
    {
        //GenericRepository<Category> repo = new GenericRepository<Category>();

        ICategoryDal _categorydal;

        public CategoryManager(ICategoryDal categorydal) //constructor
        {
            _categorydal = categorydal;
        }

        public void CategoryAdd(Category category)
        {
            _categorydal.Insert(category);
        }

        public void CategoryDelete(Category category)
        {
            _categorydal.Delete(category);  
        }

        public void CategoryUpdate(Category category)
        {
            _categorydal.Update(category);      
        }

        public Category GetById(int id)
        {
            return _categorydal.Get(x => x.CategoryID == id);
        }

        public List<Category> GetList()
        {
            return _categorydal.List();
        }
    }
}
