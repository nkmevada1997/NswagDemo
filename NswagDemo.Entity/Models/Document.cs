using MongoDB.Bson.Serialization.Attributes;

namespace NswagDemo.Entity.Models
{
    public class Document<TKey> where TKey : IEquatable<TKey>
    {
        [BsonId]
        public TKey Id { get; set; }

        public DateTime AddedAtUtc { get; set; }

        public bool Active { get; set; }

        protected Document()
        {
            AddedAtUtc = DateTime.UtcNow;
            Active = true;
        }
    }
}
