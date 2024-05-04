using MongoDB.Bson;

namespace NswagDemo.Entity.Models
{
    [BsonCollection("CustomerData")]
    public class CustomerEntity : Document<ObjectId>
    {
        public string CustomerId { get; set; } = null!;

        public string FirstName { get; set; } = null!;

        public string LastName { get; set; } = null!;

        public DateTime DOB { get; set; }

        public string Gender { get; set; } = null!;

        public string Email { get; set; } = null!;
    }
}
