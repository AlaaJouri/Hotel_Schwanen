using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace Hotel_Schwanen.Models
{
    [BsonIgnoreExtraElements]
    public class AdditionalService
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }
        [BsonElement("name")]
        public string? Name { get; set; }=String.Empty;
        [BsonElement("description")]
        public string? Description { get; set; } = String.Empty;
        [BsonElement("price")]
        public decimal? Price { get; set; }
        [BsonElement("availability")]
        public int? Availability { get; set; }
        [BsonElement("bookings")]
        public List<Booking>? Bookings { get; set; }
        [BsonElement("images")]
        public List<Image>? Images { get; set; }
    }
}
