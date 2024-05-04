//----------------------
// <auto-generated>
//     Generated using the NSwag toolchain v13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0)) (http://NSwag.org)
// </auto-generated>
//----------------------

using System.Linq;

#pragma warning disable 108 // Disable "CS0108 '{derivedDto}.ToJson()' hides inherited member '{dtoBase}.ToJson()'. Use the new keyword if hiding was intended."
#pragma warning disable 114 // Disable "CS0114 '{derivedDto}.RaisePropertyChanged(String)' hides inherited member 'dtoBase.RaisePropertyChanged(String)'. To make the current member override that implementation, add the override keyword. Otherwise add the new keyword."
#pragma warning disable 472 // Disable "CS0472 The result of the expression is always 'false' since a value of type 'Int32' is never equal to 'null' of type 'Int32?'
#pragma warning disable 612 // Disable "CS0612 '...' is obsolete"
#pragma warning disable 1573 // Disable "CS1573 Parameter '...' has no matching param tag in the XML comment for ...
#pragma warning disable 1591 // Disable "CS1591 Missing XML comment for publicly visible type or member ..."
#pragma warning disable 8073 // Disable "CS8073 The result of the expression is always 'false' since a value of type 'T' is never equal to 'null' of type 'T?'"
#pragma warning disable 3016 // Disable "CS3016 Arrays as attribute arguments is not CLS-compliant"
#pragma warning disable 8603 // Disable "CS8603 Possible null reference return"
#pragma warning disable 8604 // Disable "CS8604 Possible null reference argument for parameter"

namespace NswagDemo.Controllers
{
    using System = global::System;

    [System.CodeDom.Compiler.GeneratedCode("NSwag", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public interface ICustomerController
    {

        /// <summary>
        /// Add Customer
        /// </summary>

        /// <remarks>
        /// Add Customer
        /// </remarks>

        /// <returns>Success</returns>

        System.Threading.Tasks.Task<SwaggerResponse<AddCustomerResponse>> AddCustomerAsync(AddCustomerRequest body);

        /// <summary>
        /// Customer Details
        /// </summary>

        /// <remarks>
        /// Get Customer Detail
        /// </remarks>

        /// <param name="customerId">customerId required to fetch customer details</param>

        /// <returns>Success</returns>

        System.Threading.Tasks.Task<SwaggerResponse<GetCustomerDetailResponse>> GetCustomerDetailAsync(string customerId);

        /// <summary>
        /// Delete Customer
        /// </summary>

        /// <remarks>
        /// Delete Customer By id
        /// </remarks>

        /// <param name="customerId">customerId required to delete customer details</param>

        /// <returns>Success</returns>

        System.Threading.Tasks.Task<SwaggerResponse<DeleteCustomerResponse>> DeleteCustomerByIdAsync(string customerId);

        /// <summary>
        /// Update Customer
        /// </summary>

        /// <remarks>
        /// Update Customer
        /// </remarks>

        /// <param name="customerId">customerId required to fetch</param>


        /// <returns>Success</returns>

        System.Threading.Tasks.Task<SwaggerResponse<EditCustomerResponse>> EditCustomerAsync(string customerId, EditCustomerRequest body);

    }

    [System.CodeDom.Compiler.GeneratedCode("NSwag", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]

    public partial class CustomerController : Microsoft.AspNetCore.Mvc.ControllerBase
    {
        private ICustomerController _implementation;

        public CustomerController(ICustomerController implementation)
        {
            _implementation = implementation;
        }

        /// <summary>
        /// Add Customer
        /// </summary>
        /// <remarks>
        /// Add Customer
        /// </remarks>
        /// <returns>Success</returns>
        [Microsoft.AspNetCore.Mvc.HttpPost, Microsoft.AspNetCore.Mvc.Route("customer", Name = "AddCustomer")]
        public async System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> AddCustomer([Microsoft.AspNetCore.Mvc.FromBody] AddCustomerRequest body)
        {

            var result = await _implementation.AddCustomerAsync(body).ConfigureAwait(false);

            var status = result.StatusCode;
            Microsoft.AspNetCore.Mvc.ObjectResult response = new Microsoft.AspNetCore.Mvc.ObjectResult(result.Result) { StatusCode = status };

            foreach (var header in result.Headers)
                Request.HttpContext.Response.Headers.Add(header.Key, new Microsoft.Extensions.Primitives.StringValues(header.Value.ToArray()));

            return response;
        }

        /// <summary>
        /// Customer Details
        /// </summary>
        /// <remarks>
        /// Get Customer Detail
        /// </remarks>
        /// <param name="customerId">customerId required to fetch customer details</param>
        /// <returns>Success</returns>
        [Microsoft.AspNetCore.Mvc.HttpGet, Microsoft.AspNetCore.Mvc.Route("customer/{customerId}", Name = "GetCustomerDetail")]
        public async System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> GetCustomerDetail(string customerId)
        {

            var result = await _implementation.GetCustomerDetailAsync(customerId).ConfigureAwait(false);

            var status = result.StatusCode;
            Microsoft.AspNetCore.Mvc.ObjectResult response = new Microsoft.AspNetCore.Mvc.ObjectResult(result.Result) { StatusCode = status };

            foreach (var header in result.Headers)
                Request.HttpContext.Response.Headers.Add(header.Key, new Microsoft.Extensions.Primitives.StringValues(header.Value.ToArray()));

            return response;
        }

        /// <summary>
        /// Delete Customer
        /// </summary>
        /// <remarks>
        /// Delete Customer By id
        /// </remarks>
        /// <param name="customerId">customerId required to delete customer details</param>
        /// <returns>Success</returns>
        [Microsoft.AspNetCore.Mvc.HttpDelete, Microsoft.AspNetCore.Mvc.Route("customer/{customerId}", Name = "DeleteCustomerById")]
        public async System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> DeleteCustomerById(string customerId)
        {

            var result = await _implementation.DeleteCustomerByIdAsync(customerId).ConfigureAwait(false);

            var status = result.StatusCode;
            Microsoft.AspNetCore.Mvc.ObjectResult response = new Microsoft.AspNetCore.Mvc.ObjectResult(result.Result) { StatusCode = status };

            foreach (var header in result.Headers)
                Request.HttpContext.Response.Headers.Add(header.Key, new Microsoft.Extensions.Primitives.StringValues(header.Value.ToArray()));

            return response;
        }

        /// <summary>
        /// Update Customer
        /// </summary>
        /// <remarks>
        /// Update Customer
        /// </remarks>
        /// <param name="customerId">customerId required to fetch</param>
        /// <returns>Success</returns>
        [Microsoft.AspNetCore.Mvc.HttpPut, Microsoft.AspNetCore.Mvc.Route("customer/{customerId}", Name = "EditCustomer")]
        public async System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> EditCustomer(string customerId, [Microsoft.AspNetCore.Mvc.FromBody] EditCustomerRequest body)
        {

            var result = await _implementation.EditCustomerAsync(customerId, body).ConfigureAwait(false);

            var status = result.StatusCode;
            Microsoft.AspNetCore.Mvc.ObjectResult response = new Microsoft.AspNetCore.Mvc.ObjectResult(result.Result) { StatusCode = status };

            foreach (var header in result.Headers)
                Request.HttpContext.Response.Headers.Add(header.Key, new Microsoft.Extensions.Primitives.StringValues(header.Value.ToArray()));

            return response;
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Wrapper
    {
        [Newtonsoft.Json.JsonProperty("isError", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool IsError { get; set; }

        [Newtonsoft.Json.JsonProperty("message", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Message { get; set; }

        [Newtonsoft.Json.JsonProperty("exceptionMessage", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ExceptionMessage { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class AddCustomerRequest
    {
        [Newtonsoft.Json.JsonProperty("FirstName", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string FirstName { get; set; }

        [Newtonsoft.Json.JsonProperty("LastName", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string LastName { get; set; }

        [Newtonsoft.Json.JsonProperty("DOB", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTime DOB { get; set; }

        [Newtonsoft.Json.JsonProperty("Gender", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Gender { get; set; }

        [Newtonsoft.Json.JsonProperty("Email", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Email { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class AddCustomerResponse : Wrapper
    {
        [Newtonsoft.Json.JsonProperty("Success", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool Success { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class GetCustomerDetailResponse : Wrapper
    {
        [Newtonsoft.Json.JsonProperty("result", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public CustomerSummary Result { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class CustomerSummary
    {
        [Newtonsoft.Json.JsonProperty("CustomerId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CustomerId { get; set; }

        [Newtonsoft.Json.JsonProperty("FirstName", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string FirstName { get; set; }

        [Newtonsoft.Json.JsonProperty("LastName", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string LastName { get; set; }

        [Newtonsoft.Json.JsonProperty("Gender", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Gender { get; set; }

        [Newtonsoft.Json.JsonProperty("Email", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Email { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class EditCustomerRequest
    {
        [Newtonsoft.Json.JsonProperty("FirstName", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string FirstName { get; set; }

        [Newtonsoft.Json.JsonProperty("LastName", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string LastName { get; set; }

        [Newtonsoft.Json.JsonProperty("DOB", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTime DOB { get; set; }

        [Newtonsoft.Json.JsonProperty("Gender", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Gender { get; set; }

        [Newtonsoft.Json.JsonProperty("Email", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Email { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class EditCustomerResponse : Wrapper
    {
        [Newtonsoft.Json.JsonProperty("Success", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool Success { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class DeleteCustomerResponse : Wrapper
    {
        [Newtonsoft.Json.JsonProperty("Success", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool Success { get; set; }

    }


    [System.CodeDom.Compiler.GeneratedCode("NSwag", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class SwaggerResponse
    {
        public int StatusCode { get; private set; }

        public System.Collections.Generic.IReadOnlyDictionary<string, System.Collections.Generic.IEnumerable<string>> Headers { get; private set; }

        public SwaggerResponse(int statusCode, System.Collections.Generic.IReadOnlyDictionary<string, System.Collections.Generic.IEnumerable<string>> headers)
        {
            StatusCode = statusCode;
            Headers = headers;
        }
    }

    [System.CodeDom.Compiler.GeneratedCode("NSwag", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class SwaggerResponse<TResult> : SwaggerResponse
    {
        public TResult Result { get; private set; }

        public SwaggerResponse(int statusCode, System.Collections.Generic.IReadOnlyDictionary<string, System.Collections.Generic.IEnumerable<string>> headers, TResult result)
            : base(statusCode, headers)
        {
            Result = result;
        }
    }



}

#pragma warning restore  108
#pragma warning restore  114
#pragma warning restore  472
#pragma warning restore  612
#pragma warning restore 1573
#pragma warning restore 1591
#pragma warning restore 8073
#pragma warning restore 3016
#pragma warning restore 8603
#pragma warning restore 8604