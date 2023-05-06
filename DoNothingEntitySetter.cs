namespace EntityDefaults
{
    using System;
    using System.Collections.Generic;

    public class DoNothingEntitySetter : IEntitySetter
    {
        public void Set<TKey>(EntityTransaction entityTransaction) where TKey : IEquatable<TKey>
        {
        }

        public void SetRange<TKey>(IEnumerable<EntityTransaction> entities) where TKey : IEquatable<TKey>
        {
        }
    }
}