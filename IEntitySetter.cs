namespace EntityDefaults
{
    using System;
    using System.Collections.Generic;

    public interface IEntitySetter
    {
        void Set<TKey>(EntityTransaction entityTransaction) where TKey : IEquatable<TKey>;
        void SetRange<TKey>(IEnumerable<EntityTransaction> entities) where TKey : IEquatable<TKey>;
    }
}