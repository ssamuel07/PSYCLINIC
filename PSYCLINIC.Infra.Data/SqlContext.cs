using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace PSYCLINIC.Infra.Data {
    public class SqlContext : IdentityDbContext {
        public SqlContext() {
        }
        public SqlContext(DbContextOptions<SqlContext> options) : base(options) { }
    }
}
