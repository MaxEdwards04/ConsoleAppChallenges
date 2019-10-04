using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Challenge_Repository
{
    public class Outing_Repository
    {
        List<Outing> _outingList = new List<Outing>();


        public void AddToList(Outing content)
        {
            _outingList.Add(content);
        }

        public List<Outing> GetList()
        {
            return _outingList;
        }
    }
}
