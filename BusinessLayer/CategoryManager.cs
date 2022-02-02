using DataAccessLayer.Concrete;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class CategoryManager
    {
        Repository<Category> categoryRepository = new Repository<Category>();

        public List<Category> GetAll()
        {
            return categoryRepository.List();
        }

        public int BLAdd(Category category)
        {
            if (category.CategoryName.Length <= 3)
            {
                return -1;
            }
            else
            {
                return categoryRepository.Insert(category);
            }
        }

        public int BLDelete(int id)
        {
            if (id != 0)
            {
                Category category = categoryRepository.Find(x => x.CategoryID == id);
                return categoryRepository.Delete(category);
            }
            else
            {
                return -1;
            }
        }

        public int BLUpdate(Category category)
        {
            if (category.CategoryName == "" || category.CategoryName.Length <= 3 ||
                category.CategoryName.Length >= 30)
            {
                return -1;
            }
            else
            {
                Category c = categoryRepository.GetById(category.CategoryID);
                c.CategoryName = category.CategoryName;
                return categoryRepository.Update(c);
            }
        }
    }
}
