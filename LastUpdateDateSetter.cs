namespace EntityDefaults
{
    using System;
    using EntityModels;

    public class LastUpdateDateSetter : IDefaultEntitySetter
    {
        private readonly DateTime? _dateOverride;

        public LastUpdateDateSetter(DateTime? dateOverride = null)
        {
            _dateOverride = dateOverride;
        }

        public void Set(EntityTransaction entityTransaction)
        {
            if (entityTransaction.Entity is ILastUpdatedDate lastUpdatedDate)
            {
                lastUpdatedDate.LastUpdatedDate = _dateOverride ?? DateTime.UtcNow;
            }
        }
    }
}