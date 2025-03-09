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
        public static WebApplication SetupApplication(this WebApplication app)
        {
            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseAuthorization();

            app.MapControllers();
            return app;
        }
    }
}
