using System.ComponentModel.DataAnnotations;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace api.model;

public record Appuser(
  [property: BsonId, BsonRepresentation(BsonType.ObjectId)]
  string? Id,
  [EmailAddress] string Email,
  [MaxLength(15)] [MinLength(2)]string Name
);
