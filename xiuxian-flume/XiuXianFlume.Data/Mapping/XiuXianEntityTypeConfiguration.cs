using System.Data.Entity.ModelConfiguration;

namespace XiuXianFlume.Data.Mapping
{
    public abstract class XiuXianEntityTypeConfiguration<T> : EntityTypeConfiguration<T> where T : class
    {
        protected XiuXianEntityTypeConfiguration()
        {
            PostInitialize();
        }

        /// <summary>
        /// Developers can override this method in custom partial classes
        /// in order to add some custom initialization code to constructors
        /// </summary>
        protected virtual void PostInitialize()
        {
        }
    }
}