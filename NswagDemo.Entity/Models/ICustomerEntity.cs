namespace NswagDemo.Entity.Models
{
    public interface ICustomerEntity
    {
        string CustomerId { get; set; }
        string Email { get; set; }
        string FirstName { get; set; }
        string Gender { get; set; }
        string LastName { get; set; }
    }
}