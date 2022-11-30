using Microsoft.EntityFrameworkCore;

namespace ModuleEmployees.Context
{
    public class AplicationDBContext :DbContext
    {
        public AplicationDBContext(DbContextOptions<AplicationDBContext> options) : base(options)
        {

        }

    }
}
