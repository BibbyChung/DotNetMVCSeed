using Castle.Windsor;

namespace MyApp.Common
{
    /// <summary>
    /// singleton pattern
    /// </summary>
    public class CastleWindsorContext
    {
        private static object _obj = new object();

        private static CastleWindsorContext _Instance;
        public static CastleWindsorContext Instance
        {
            get
            {
                if (_Instance == null)
                {
                    lock (_obj)
                    {
                        if (_Instance == null)
                        {
                            _Instance = new CastleWindsorContext();
                        }
                    }
                }
                return _Instance;
            }
        }

        private IWindsorContainer _container;
        public IWindsorContainer Container
        {
            get
            {
                if (_container == null)
                    _container = new WindsorContainer();
                return _container;
            }
            set
            {
                _container = value;
            }
        }
        public void Reset()
        {
            _Instance = null;
        }
    }
}
