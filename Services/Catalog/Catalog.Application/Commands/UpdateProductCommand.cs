﻿using Catalog.Core.Entities;
using MediatR;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace Catalog.Application.Commands
{
    public class UpdateProductCommand:IRequest<bool>
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        [BsonElement("Name")]

        public string Name { get; set; }
        public string Summery { get; set; }
        public string Description { get; set; }
        public string ImageFile { get; set; }
        public decimal Price { get; set; }
        public ProductBrand Brands { get; set; }
        public ProductType Types { get; set; }
    }
}