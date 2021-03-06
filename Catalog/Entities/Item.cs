using System;

namespace Catalog.Entities
{
    ///RECORD TYPE
    ///immutable objects
    ///with expressions support
    ///value-based equality support
    public record Item
    {
        public Guid Id{get;init;}
        public string Name{get;init;}
        public decimal Price{get;init;}

        public DateTimeOffset CreatedDate{get;init;}
    }
}