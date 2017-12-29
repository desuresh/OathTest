using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OT.RentCoder.Business
{
   public class Company : RepositoryBase<RentCoderEntities> , IUser
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

        public CustomerViewModel GetCustomer(int customerId)
        {
            CustomerViewModel customerViewModel = null;
            try
            {
                using (var context = DataContext)
                {
                    var customer = context.TCustomerMaster.Where(item => item.TCM_CustomerID == customerId).FirstOrDefault();
                    if (customer != null)
                    {
                        customerViewModel = new CustomerViewModel
                        {
                            Name = customer.TCM_CustomerName,
                            Address = customer.TCM_CustomerAddress,
                            Email = customer.TCM_CustomerEMail,
                            Mobile = customer.TCM_CustomerMobile,
                            Phone = customer.TCM_CustomerPhone,
                            ID = customer.TCM_CustomerID
                        };
                    }
                }
                return customerViewModel;

            }
            catch (Exception)
            {
                throw;
            }
        }

        public void CreateCustomer(CustomerViewModel customerView)
        {
            try
            {
                TCustomerMaster customer = new TCustomerMaster
                {
                    TCM_CustomerName = customerView.Name,
                    TCM_CustomerAddress = customerView.Address,
                    TCM_CustomerEMail = customerView.Email,
                    TCM_CustomerMobile = customerView.Mobile,
                    TCM_CustomerPhone = customerView.Phone
                };
                using (var context = DataContext)
                {
                    context.Entry(customer).State = EntityState.Added;
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void UpdateCustomer(CustomerViewModel customerView)
        {
            try
            {
                TCustomerMaster customer = new TCustomerMaster
                {
                    TCM_CustomerName = customerView.Name,
                    TCM_CustomerAddress = customerView.Address,
                    TCM_CustomerEMail = customerView.Email,
                    TCM_CustomerMobile = customerView.Mobile,
                    TCM_CustomerPhone = customerView.Phone,
                    TCM_CustomerID = customerView.ID

                };
                using (var context = DataContext)
                {
                    context.Entry(customer).State = EntityState.Modified;
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        /// <summary>
        /// Detele the customer based on customer ID
        /// </summary>
        /// <param name="customerId"></param>
        public void DeleteCustomer(int customerId)
        {
            TCustomerMaster customer = null;
            try
            {
                using (var context = DataContext)
                {
                    customer = context.TCustomerMaster.Where(item => item.TCM_CustomerID == customerId).FirstOrDefault();
                    context.Entry(customer).State = EntityState.Deleted;
                    context.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
