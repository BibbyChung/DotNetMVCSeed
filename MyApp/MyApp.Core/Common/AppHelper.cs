namespace MyApp.Core.Common
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
    }
}