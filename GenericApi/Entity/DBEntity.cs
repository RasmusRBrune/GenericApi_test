using Microsoft.EntityFrameworkCore;

namespace GenericApi.Entity
{
    public class DBEntity : DbContext
    {

        public DBEntity(DbContextOptions<DBEntity> options):base(options)
        { }

        #region Table entitys

        #endregion

    }
}
