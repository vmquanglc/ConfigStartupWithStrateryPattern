using System.Reflection;

namespace Api.Configuaration
{
    public static class ExtentionsMethod
    {
        public static void Install(this IServiceCollection service)
        {
            var implementors = Assembly.GetExecutingAssembly().GetTypes()
                .Where(type => !type.IsInterface && typeof(IBuilderService).IsAssignableFrom(type));
            foreach (var type in implementors)
            {
                ((IBuilderService)Activator.CreateInstance(type)).Install(service);
            }
        }
        public static void Install(this WebApplication app)
        {
            var implementors = Assembly.GetExecutingAssembly().GetTypes()
                .Where(type => !type.IsInterface && typeof(IWebApplicationConfig).IsAssignableFrom(type));
            foreach (var type in implementors)
            {
                ((IWebApplicationConfig)Activator.CreateInstance(type)).Install(app);
            }
        }
    }
}
