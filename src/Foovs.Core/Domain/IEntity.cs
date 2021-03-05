using System;

namespace Foovs.Core.Domain
{
    public interface IEntity
    {
        Guid Id { get; }
    }
}