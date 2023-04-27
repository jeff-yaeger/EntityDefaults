namespace EntityDefaults
{
    using System;
    using EntityModels;

    public class CreatedUserIdSetter<TKey> : IDefaultEntitySetter where TKey : IEquatable<TKey>
    {
        private readonly TKey _userId;

        public CreatedUserIdSetter(TKey userId)
        {
            _userId = userId;
        }

        public void Set(EntityTransaction entityTransaction)
        {
            if (entityTransaction.State == TransactionState.Add && entityTransaction.Entity is ICreatedUserId<TKey> createdUserId)
            {
                createdUserId.CreatedUserId = _userId;
            }
        }
    }
}