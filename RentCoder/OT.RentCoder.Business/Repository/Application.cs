using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OT.RentCoder.Business.Repository
{
    public class Application
    {
        public List<CustomerViewModel> GetCustomers()
        {
            List<CustomerViewModel> customerViewModel = null;
            try
            {

                using (var context = DataContext)
                {
                    var customers = context.TCustomerMaster.ToList();
                    if (customers != null)
                    {
                        customerViewModel = new List<CustomerViewModel>();
                        foreach (var item in customers)
                        {
                            customerViewModel.Add(new CustomerViewModel
                            {
                                Name = item.TCM_CustomerName,
                                Address = item.TCM_CustomerAddress,
                                Email = item.TCM_CustomerEMail,
                                Mobile = item.TCM_CustomerMobile,
                                Phone = item.TCM_CustomerPhone,
                                ID = item.TCM_CustomerID
                            });
                        }
                    }
                }
                return customerViewModel;

            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
