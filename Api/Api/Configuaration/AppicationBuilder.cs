namespace Api.Configuaration
{
    public interface IWebApplicationConfig
    {
        void Install(WebApplication app);
    }
    class SwaggerConfig : IWebApplicationConfig
    {
        public void Install(WebApplication app)
        {
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }
        }
    }
    class AuthorizationConfig : IWebApplicationConfig
    {
        public void Install(WebApplication app)
        {
            app.UseAuthorization();
        }
    }
    class ControllerConfig : IWebApplicationConfig
    {
        public void Install(WebApplication app)
        {
            app.MapControllers();
        }
    }
}
