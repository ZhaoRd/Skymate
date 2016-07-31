namespace Skymate
{
    using Abp.Dependency;

    using Castle.Facilities.Logging;

    public static class Log4NetBootstrapper
    {
        public static void Start(string configName=null)
        {
            var config = Log4NetFactory.DefaultConfigFileName;

            if (!string.IsNullOrEmpty(configName))
            {
                config = configName;
            }

            if (IocManager.Instance.IsRegistered<LoggingFacility>())
            {
                return;
            }

            IocManager.Instance.IocContainer
                .AddFacility<LoggingFacility>(f => f.LogUsing<Log4NetFactory>()
              .WithConfig(config));

        }
        
    }
}