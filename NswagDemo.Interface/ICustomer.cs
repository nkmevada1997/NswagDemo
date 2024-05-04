using NswagDemo.Models;

namespace NswagDemo.Interface
{
    public interface ICustomerRepository
    {
        Task<AddCustomerResponse> AddCustomerAsync(AddCustomerRequest request);

        Task<GetCustomerDetailResponse> GetCustomerDetailAsync(string customerId);

        Task<EditCustomerResponse> EditCustomerAsync(string customerId, EditCustomerRequest request);

        Task<DeleteCustomerResponse> DeleteCustomerAsync(string customerId);
    }

    public interface ICustomerService
    {
        Task<AddCustomerResponse> AddCustomerAsync(AddCustomerRequest request);

        Task<GetCustomerDetailResponse> GetCustomerDetailAsync(string customerId);

        Task<EditCustomerResponse> EditCustomerAsync(string customerId, EditCustomerRequest request);

        Task<DeleteCustomerResponse> DeleteCustomerAsync(string customerId);
    }
}
