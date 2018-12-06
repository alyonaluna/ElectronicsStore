using Microsoft.AspNet.Identity.EntityFramework;

namespace ElectronicsStore.DataAccess
{
    public class AppRole : IdentityRole
    {
        public AppRole() : base() { }

        public AppRole(string name)
            : base(name)
        { }
    }
}
