using Castle.Windsor;

namespace MyApp.Common
{
    public class AppHelper
    {
        public static bool IsDebugMode
        {
            get
            {
#if DEBUG
                return true;
#else
            return false;
#endif
            }
        }

        public static IWindsorContainer CastleWindsorContainer
        {
            get
            {
                  return CastleWindsorContext.Instance.Container;
            }
        }
    }
}