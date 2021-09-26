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
        public String Name{get;init;}
        public Decimal Price{get;init;}

        public DateTimeOffset CreatedDate{get;init;}
    }
}