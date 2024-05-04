using Microsoft.AspNetCore.Mvc;
using NswagDemo.Interface;
using NswagDemo.Models;

namespace NswagDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerImplController : ICustomerController
    {
        readonly ICustomerService _service;

        public CustomerImplController(ICustomerService service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task<SwaggerResponse<AddCustomerResponse>> AddCustomerAsync(AddCustomerRequest body)
        {
            try
            {
                var model = new Models.AddCustomerRequest
                {
                    FirstName = body.FirstName,
                    LastName = body.LastName,
                    DOB = body.DOB.Date,
                    Gender = body.Gender,
                    Email = body.Email,
                };

                var result = await _service.AddCustomerAsync(model);

                return SwaggerResponse.Ok(new AddCustomerResponse
                {
                    IsError = false,
                    Success = result.Success,
                    Message = "Customer Added"
                });
            }
            catch (Exception ex)
            {
                return SwaggerResponse.BadRequest(new AddCustomerResponse
                {
                    IsError = true,
                    Success = false,
                    Message = ex.Message.ToString()
                });
            }
        }

        [HttpGet]
        public async Task<SwaggerResponse<GetCustomerDetailResponse>> GetCustomerDetailAsync(string customerId)
        {
            try
            {
                var result = await _service.GetCustomerDetailAsync(customerId);

                return SwaggerResponse.Ok(new GetCustomerDetailResponse
                {
                    IsError = false,
                    Result = new CustomerSummary
                    {
                        CustomerId = result.Result.CustomerId,
                        FirstName = result.Result.FirstName,
                        LastName = result.Result.LastName,
                        Email = result.Result.Email,
                        Gender = result.Result.Gender
                    }
                });

            }
            catch (Exception ex)
            {
                return SwaggerResponse.BadRequest(new GetCustomerDetailResponse
                {
                    IsError = true,
                    Message = ex.Message.ToString()
                });
            }
        }

        [HttpDelete]
        public async Task<SwaggerResponse<DeleteCustomerResponse>> DeleteCustomerByIdAsync(string customerId)
        {
            try
            {
                var result = await _service.DeleteCustomerAsync(customerId);

                if (result.Success)
                {
                    return SwaggerResponse.Ok(new DeleteCustomerResponse
                    {
                        IsError = false,
                        Success = true,
                        Message = "Customer Deleted",
                    });
                }

                return SwaggerResponse.BadRequest(new DeleteCustomerResponse
                {
                    IsError = true,
                    Success = false,
                    Message = "Unable to Delete Customer",
                });
            }
            catch (Exception ex)
            {
                return SwaggerResponse.BadRequest(new DeleteCustomerResponse
                {
                    IsError = true,
                    Success = false,
                    Message = "Unable to Delete Customer",
                    ExceptionMessage = ex.Message.ToString()
                });
            }
        }

        [HttpPut]
        public async Task<SwaggerResponse<EditCustomerResponse>> EditCustomerAsync(string customerId, EditCustomerRequest body)
        {
            try
            {
                var model = new Models.EditCustomerRequest
                {
                    FirstName = body.FirstName,
                    LastName = body.LastName,
                    DOB = body.DOB,
                    Gender = body.Gender,
                    Email = body.Email,
                };
                var result = await _service.EditCustomerAsync(customerId, model);

                if (result.Success)
                {
                    return SwaggerResponse.BadRequest(new EditCustomerResponse
                    {
                        IsError = false,
                        Success = true,
                        Message = "Customer Updated",
                    });
                }
                return SwaggerResponse.BadRequest(new EditCustomerResponse
                {
                    IsError = false,
                    Success = true,
                    Message = "Unable To Update Customer",
                });
            }
            catch (Exception ex)
            {
                return SwaggerResponse.BadRequest(new EditCustomerResponse
                {
                    IsError = true,
                    Success = false,
                    Message = "Unable to Update Customer",
                    ExceptionMessage = ex.Message.ToString()
                });
            }
        }
    }
}
