namespace EntityDefaults
{
    using System;
    using EntityModels;

    public class LastUpdatedUserIdSetter<TKey> : IDefaultEntitySetter where TKey : IEquatable<TKey>
    {
        private readonly TKey _userId;

        public LastUpdatedUserIdSetter(TKey userId)
        {
            _userId = userId;
        }

        public void Set(EntityTransaction entityTransaction)
        {
            if (entityTransaction.Entity is ILastUpdatedUserId<TKey> lastUpdatedUserId)
            {
                lastUpdatedUserId.LastUpdatedUserId = _userId;
            }
        }
    }
}