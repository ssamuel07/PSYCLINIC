using Autofac;

namespace PSYCLINIC.Infra.CrossCutting.IOC {
    public class ModuleIOC : Module {
        protected override void Load(ContainerBuilder containerBuilder) {
            ConfigurationIOC.Load(containerBuilder);
        }
    }
}
