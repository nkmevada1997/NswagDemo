using Ecommerce.MongoDB.Context;
using Ecommerce.MongoDB.Entity;
using MongoDB.Driver;
using NswagDemo.Interface;
using NswagDemo.Models;

namespace NswagDemo.Repository
{
    public class CustomerRespository : ICustomerRepository
    {
        private readonly IMongoCollection<Customer> _collection;

        public CustomerRespository(MongoDBContext context)
        {
            _collection = context.GetCollection<Customer>();
        }

        public async Task<AddCustomerResponse> AddCustomerAsync(AddCustomerRequest request)
        {
            try
            {
                var customer = new Customer
                {
                    CustomerId = Guid.NewGuid().ToString(),
                    FirstName = request.FirstName,
                    LastName = request.LastName,
                    DOB = request.DOB,
                    Gender = request.Gender,
                    Email = request.Email,
                    Password = string.Empty,
                    PhoneNumber = string.Empty,
                    StateId = Guid.NewGuid().ToString(),
                    CountryId = Guid.NewGuid().ToString(),
                    CityId = Guid.NewGuid().ToString(),
                };
                await _collection.InsertOneAsync(customer);

                return new AddCustomerResponse
                {
                    IsError = false,
                    Message = "Customer Added",
                    Success = false,
                };
            }
            catch (Exception ex)
            {
                return new AddCustomerResponse
                {
                    IsError = true,
                    Message = "Unable To Add Customer",
                    Success = false,
                    ExceptionMessage = ex.Message
                };
            }
        }

        public async Task<DeleteCustomerResponse> DeleteCustomerAsync(string customerId)
        {
            try
            {
                var customer = await _collection.FindOneAndDeleteAsync(x => x.CustomerId == customerId);

                if (customer != null)
                {
                    return new DeleteCustomerResponse
                    {
                        IsError = false,
                        Success = true,
                        Message = $"Customer {customer.FirstName} deleted"
                    };
                }
                return new DeleteCustomerResponse
                {
                    IsError = true,
                    Success = false,
                    Message = "Customer Not Found"
                };
            }
            catch (Exception ex)
            {
                return new DeleteCustomerResponse
                {
                    IsError = true,
                    Success = false,
                    Message = "Unable to Delete Customer",
                    ExceptionMessage = ex.Message.ToString()
                };
            }

        }

        public async Task<EditCustomerResponse> EditCustomerAsync(string customerId, EditCustomerRequest request)
        {
            try
            {
                var entity = new Customer
                {
                    CustomerId = customerId,
                    FirstName = request.FirstName,
                    LastName = request.LastName,
                    DOB = request.DOB,
                    Gender = request.Gender,
                    Email = request.Email,
                    Password = string.Empty,
                    PhoneNumber = string.Empty,
                    StateId = Guid.NewGuid().ToString(),
                    CountryId = Guid.NewGuid().ToString(),
                    CityId = Guid.NewGuid().ToString(),
                };
                var customer = await _collection.FindOneAndReplaceAsync(x => x.CustomerId == customerId, entity);

                if (customer != null)
                {
                    return new EditCustomerResponse
                    {
                        IsError = false,
                        Success = true,
                        Message = $"Customer {customer.FirstName} Updated"
                    };
                }
                return new EditCustomerResponse
                {
                    IsError = false,
                    Success = false,
                    Message = "Customer Not Found"
                };
            }
            catch (Exception ex)
            {
                return new EditCustomerResponse
                {
                    IsError = true,
                    Success = false,
                    Message = "Unable to Update Customer",
                    ExceptionMessage = ex.Message.ToString()
                };
            }

        }

        public async Task<GetCustomerDetailResponse> GetCustomerDetailAsync(string customerId)
        {
            try
            {
                var customer = await _collection.FindAsync(x => x.CustomerId == customerId);

                if (customer != null)
                {
                    var customerDetail = customer.FirstOrDefault();

                    var result = new CustomerSummary
                    {
                        CustomerId = customerDetail.CustomerId,
                        FirstName = customerDetail.FirstName,
                        LastName = customerDetail.LastName,
                        Gender = customerDetail.Gender,
                        DOB = customerDetail.DOB,
                        Email = customerDetail.Email
                    };
                    return new GetCustomerDetailResponse
                    {
                        IsError = false,
                        Result = result
                    };
                }
                return new GetCustomerDetailResponse
                {
                    IsError = false,
                    Message = "Unable To Retrieve Customer",
                };
            }
            catch (Exception ex)
            {
                return new GetCustomerDetailResponse
                {
                    IsError = true,
                    Message = "Unable To Retrieve Customer",
                    ExceptionMessage = ex.Message.ToString()
                };
            }
        }

    }
}
