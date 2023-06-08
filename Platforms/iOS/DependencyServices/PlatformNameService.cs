using HackNightMaui.DependencyServices;

namespace HackNightMaui.Platforms
{
    public class PlatformNameService : IPlatformNameService
    {
        public PlatformNameService()
        {
        }

        public string receiveName()
        {
            return "iOS";
        }
    }
}

