namespace Skymate
{
    using System.Reflection;

    using Abp;
    using Abp.Modules;
    
    [DependsOn(typeof(AbpKernelModule))]
    public class Log4NetModule:AbpModule
    {
        public override void PreInitialize()
        {

        }

        public override void Initialize()
        {
            this.IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}