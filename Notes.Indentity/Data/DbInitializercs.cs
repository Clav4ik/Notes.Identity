using Notes.Identity.Data;

namespace Notes.Identity.Data
{
    public static class DbInitializercs
    {
        public static void Initialize(AuthDbContext context)
        {
            context.Database.EnsureCreated();
        }
        
    }
}
