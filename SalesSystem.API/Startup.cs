using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Azure.ServiceBus;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SalesSystem.API.Helpers;
using SalesSystem.API.queing;

namespace SalesSystem.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<AppSettings>(Configuration.GetSection("AppSettings"));
            services.AddControllers();
            services.AddAutoMapper(typeof(Startup));
            services.AddSingleton<IQueueClient>(serviceProvider => new QueueClient(connectionString: Configuration.GetValue<string>
                ("servicebus:connectionstring"), entityPath: Configuration.GetValue<string>("serviceBus:topicname"),receiveMode:ReceiveMode.ReceiveAndDelete));
            services.AddSingleton<IMessagePublisher, MessagePublisher>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseMiddleware<JwtMiddleware.JwtMiddleware>();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
