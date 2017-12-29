using RentCoder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RentCoder.Repository
{
    public class EmployerRepository
    {
        private IDBOperations _dbConnect = null;
        public void CreateEmployer(RegistrationViewModel register)
        {
            var SQL = "INSERT INTO `employer`(`Name`,`Technologies`,`Experience`,`PhoneNo`,`Email`,`EmployementType`)" +
                       string.Format ("VALUES('{0}','{1}','{2}','{3}','{4}','{5}');",register.Name,register.Technology,register.Experiance,register.Contact,register.Email,register.EmployementType);
            _dbConnect = new MySqlDBOperations();
            _dbConnect.Insert(SQL);

        }
    }
}