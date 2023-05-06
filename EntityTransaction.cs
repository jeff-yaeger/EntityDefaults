namespace EntityDefaults
{
    using System;
    using EntityModels;

    public class EntityTransaction
    {
        public object Entity { get; set; }
        public TransactionState State { get; set; }

        public void SetDefaults<TKey>(TKey id, params object[] objects) where TKey : IEquatable<TKey>
        {
            switch (State)
            {
                case TransactionState.Add when Entity is IOnAdd<TKey> addEntity:
                    addEntity.OnAdd(id, objects);
                    break;
                case TransactionState.Update when Entity is IOnUpdate<TKey> updateEntity:
                    updateEntity.OnUpdate(id, objects);
                    break;
                case TransactionState.Delete when Entity is IOnDelete<TKey> deleteEntity:
                    deleteEntity.OnDelete(id, objects);
                    break;
            }
        }
    }
}