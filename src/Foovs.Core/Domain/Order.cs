using System;

namespace Foovs.Core.Domain
{
    public class Order
    {
        public Guid Id { get; private set; }
        public string Folio { get; private set; }
        public OrderStatus OrderStatus { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public DateTime UpdatedAt { get; private set; }

        public Order(Guid id, string folio, DateTime createdAt)
        {
            Id = id;
            Folio = folio;
            CreatedAt = createdAt;
        }
    }
}