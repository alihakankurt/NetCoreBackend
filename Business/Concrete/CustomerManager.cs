using Core.Utilities.Results;
using Business.Abstract;
using Business.Constants;
using Entities.Concrete;
using DataAccess.Abstract;

namespace Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
        private readonly ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        public IDataResult<Customer> GetByCustomerId(string customerId)
        {
            return DataResult<Customer>.FromSuccess(_customerDal.Get(c => c.CustomerId == customerId), Messages.ItemsBrought);
        }
    }
}
