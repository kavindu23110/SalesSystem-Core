using AutoMapper;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Azure.ServiceBus;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Hosting;
using SalesSystem.BLL.Interfaces;
using SalesSystem.queing;
using SalesSystem.SOAP;
using SalesSystem.SOAP.Services;
using SoapCore;
using System.ServiceModel;

namespace SalesSystem
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
            services.AddControllersWithViews();
            services.AddEntityFrameworkSqlServer();
            services.AddAutoMapper(typeof(Startup));
            services.AddSession();
            services.TryAddSingleton<IPromotionService, PromotionService>();
            services.AddSingleton<IQueueClient>(serviceProvider => new QueueClient(connectionString: Configuration.GetValue<string>
              ("servicebus:connectionstring"), entityPath: Configuration.GetValue<string>("serviceBus:topicname"), receiveMode: ReceiveMode.ReceiveAndDelete));
            services.AddSingleton<IMessagePublisher, MessagePublisher>();

            services.AddMvc().AddFluentValidation(s =>
            {
                s.RegisterValidatorsFromAssemblyContaining<Startup>();
                s.RunDefaultMvcValidationAfterFluentValidationExecutes = false;
            });

            services.AddDbContext<SalesSystem.DAL.SalessystemContext>
                (options => options.UseSqlServer(Configuration["ConnectionStrings:DefaultConnection"]));

            services.Scan(scan => scan.FromCallingAssembly()
          .FromAssemblies(typeof(IDataRetrival).Assembly)
            .AddClasses().AsImplementedInterfaces());



        }


        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseSoapEndpoint<IPromotionService>("/Service.asmx", new BasicHttpBinding(), SoapSerializer.XmlSerializer);
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();
            app.UseSession();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=User}/{action=Index}/{id?}");
            });
        }
    }
}
