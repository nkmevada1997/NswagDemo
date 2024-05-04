using NswagDemo.Interface;
using NswagDemo.Models;

namespace NswagDemo.Service
{
    public class CustomerService : ICustomerService
    {
        readonly ICustomerRepository _customerRepository;

        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public async Task<AddCustomerResponse> AddCustomerAsync(AddCustomerRequest request)
        {
            return await _customerRepository.AddCustomerAsync(request);
        }

        public async Task<DeleteCustomerResponse> DeleteCustomerAsync(string customerId)
        {
            return await _customerRepository.DeleteCustomerAsync(customerId);
        }

        public async Task<EditCustomerResponse> EditCustomerAsync(string customerId,EditCustomerRequest request)
        {
            return await _customerRepository.EditCustomerAsync(customerId, request);
        }

        public async Task<GetCustomerDetailResponse> GetCustomerDetailAsync(string customerId)
        {
            return await _customerRepository.GetCustomerDetailAsync(customerId);
        }
    }
}
