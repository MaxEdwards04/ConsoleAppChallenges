using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Challenge_Repository
{
    public class MenuRepository
    {
        List<Menu> _menuList = new List<Menu>();

        public void AddToList(Menu content)
        {
            _menuList.Add(content);
        }

        public List<Menu> GetMenuList()
        {
            return _menuList;
        }

        public void RemoveFromList(string mealName)
        {
            foreach (Menu name in _menuList)
            {
                if (name.MealName == mealName)
                {
                    _menuList.Remove(name);
                    break;
                }
            }
        }
    }
}
