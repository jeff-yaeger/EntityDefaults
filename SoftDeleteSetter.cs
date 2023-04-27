namespace EntityDefaults
{
    using EntityModels;

    public class SoftDeleteSetter : IDefaultEntitySetter
    {
        public void Set(EntityTransaction entityTransaction)
        {
            if (entityTransaction.State == TransactionState.Add && entityTransaction.Entity is ISoftDelete createdDate)
            {
                createdDate.Active = true;
            }
        }
    }
}