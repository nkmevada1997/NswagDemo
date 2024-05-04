namespace NswagDemo.Models
{
    public class AddCustomerRequest
    {
        public string FirstName { get; set; } = null!;

        public string LastName { get; set; } = null!;

        public DateTime DOB { get; set; }

        public string Gender { get; set; } = null!;

        public string Email { get; set; } = null!;
    }

    public class AddCustomerResponse : Wrapper
    {
        public bool Success { get; set; }
    }

    public class GetCustomerDetailResponse : Wrapper
    {
        public CustomerSummary Result { get; set; } = new CustomerSummary();
    }

    public class GetCustomersResponse : Wrapper
    {
        public List<CustomerSummary> Result { get; set; } = new List<CustomerSummary>();
    }

    public class CustomerSummary
    {
        public string CustomerId { get; set; } = null!;

        public string FirstName { get; set; } = null!;

        public string LastName { get; set; } = null!;

        public DateTime DOB { get; set; } 

        public string Gender { get; set; } = null!;

        public string Email { get; set; } = null!;
    }

    public class EditCustomerRequest
    {
        public string FirstName { get; set; } = null!;

        public string LastName { get; set; } = null!;

        public DateTime DOB { get; set; }

        public string Gender { get; set; } = null!;

        public string Email { get; set; } = null!;
    }

    public class EditCustomerResponse : Wrapper
    {
        public bool Success { get; set; }
    }

    public class DeleteCustomerResponse : Wrapper
    {
        public bool Success { get; set; }
    }
}
