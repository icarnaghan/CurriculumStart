using System.Configuration;

namespace Mapper21.Site.Config
{
    public class SiteConfig
    {
        public static readonly string CurrentYear = ConfigurationManager.AppSettings["CurrentYear"];
    }
}