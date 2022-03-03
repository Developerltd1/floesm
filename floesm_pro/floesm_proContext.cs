using floesm_pro.Model;
using Microsoft.EntityFrameworkCore;

namespace floesm_pro
{
    public class floesm_proContext : DbContext
    {
        public floesm_proContext(DbContextOptions<floesm_proContext> options)
            : base(options)
        {
        }
        public virtual DbSet<UploadedImages> UploadedImages { get; set; }
    }
}