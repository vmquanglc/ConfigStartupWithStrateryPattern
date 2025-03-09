namespace Api.Configuaration
{
    public interface IBuilderService
    {
        void Install(IServiceCollection services);
    }
    public class SetupUseController : IBuilderService
    {
        public void Install(IServiceCollection services)
        {

            services.AddControllers();
        }
    }
    public class SetupEndpointsApi : IBuilderService
    {
        public void Install(IServiceCollection services)
        {
            services.AddEndpointsApiExplorer();
        }
    }
    public class SetupSwagger : IBuilderService
    {
        public void Install(IServiceCollection services)
        {
            services.AddSwaggerGen();
        }
    }
}
