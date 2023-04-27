namespace EntityDefaults
{
    using System;
    using EntityModels;

    public class CreateDateSetter : IDefaultEntitySetter
    {
        private readonly DateTime? _dateOverride;

        public CreateDateSetter(DateTime? dateOverride = null)
        {
            _dateOverride = dateOverride;
        }

        public void Set(EntityTransaction entityTransaction)
        {
            if (entityTransaction.State == TransactionState.Add && entityTransaction.Entity is ICreatedDate createdDate)
            {
                createdDate.CreatedDate = _dateOverride ?? DateTime.UtcNow;
            }
        }
    }
}