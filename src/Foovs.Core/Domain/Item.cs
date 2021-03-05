using System;

namespace Foovs.Core.Domain
{
    public class Item : IEntity
    {
        public Guid Id { get; private set; }
        public string Description { get; private set; }
        public int Price { get; private set; }
        public ItemStatus ItemStatus { get; private set; }
        public DateTime PublishedAt { get; private set; }
        public decimal PriceInDecimal { get { return Price / 100; } }

        public Item(Guid id, string description, int price)
        {
            Id = id;
            Description = description;
            Price = price;

            PublishedAt = DateTime.UtcNow;
            ItemStatus = ItemStatus.InStock;
        }
    }
}