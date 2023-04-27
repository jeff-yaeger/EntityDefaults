namespace EntityDefaults
{
    using EntityModels;

    public class NormalizeNameSetter : IDefaultEntitySetter
    {
        public void Set(EntityTransaction entityTransaction)
        {
            if (entityTransaction.Entity is INormalizedName normalizedName)
            {
                if (string.IsNullOrEmpty(normalizedName.Name))
                {
                    return;
                }

                normalizedName.NormalizedName = normalizedName.Name.ToUpper();
            }
        }
    }
}