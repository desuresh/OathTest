using RentCoder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCoder
{
    public interface IDBOperations 
    {
        void Insert(string query);
    }
}
