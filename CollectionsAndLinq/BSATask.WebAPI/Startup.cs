using AutoMapper;
using BSATask.WebAPI.MappingProfile;
using CollectionsAndLinq.BL.Context;
using CollectionsAndLinq.BL.Interfaces;
using CollectionsAndLinq.BL.MappingProfiles;
using CollectionsAndLinq.BL.Services.CreateServices;
using CollectionsAndLinq.BL.Services.ReaderServices;
using CollectionsAndLinq.BL.Services;
using Microsoft.OpenApi.Models;
using Microsoft.EntityFrameworkCore;
using BSATask.DAL.Context;
using BSATask.DAL.Interfaces;
using BSATask.DAL.Repositories;
using CollectionsAndLinq.BL.Models.Teams;
using BSATask.WebAPI.Filters;

namespace BSATask.WebAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            var migrationAssembly = typeof(BSATaskContext).Assembly.GetName().Name;
            services.AddDbContext<BSATaskContext>(options => options.UseSqlServer(Configuration["ConnectionStrings:DBConnection"], 
                opt => opt.MigrationsAssembly(migrationAssembly)));

            services.AddSwaggerGen(swagger =>
            {
                swagger.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "v1",
                    Title = "BSATask Web API",
                    Description = "ASP.NET Core 6.0 Web API"
                });
            });
            var config = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new BusionessLayerProfile());
                mc.AddProfile(new ViewsMappingProfile());
            });

            IMapper mapper = config.CreateMapper();

            services.AddSingleton(mapper);
            services.AddTransient<IDataProvider, DataProvider>();
            services.AddTransient<IProjectRepository, ProjectRepository>();
            services.AddTransient<IUserRepository, UserRepository>();
            services.AddTransient<ITaskRepository, TaskRepository>();
            services.AddTransient<ITeamRepository, TeamRepository>();
            services.AddTransient<IDataProcessingService, DataProcessingService>();
            services.AddTransient<IProjectReaderService, ProjectReaderService>();
            services.AddTransient<IProjectCreateService, ProjectCreateService>();
            services.AddTransient<ITaskReadService, TaskReadService>();
            services.AddTransient<ITaskCreateService, TaskCreateService>();
            services.AddTransient<ITeamReadService, TeamReadService>();
            services.AddTransient<ITeamCreateService, TeamCreateService>();
            services.AddTransient<IUserReadService, UserReadService>();
            services.AddTransient<IUserCreateService, UserCreateService>();

            services
               .AddMvcCore(options => options.Filters.Add(typeof(CustomExceptionFilterAttribute)));
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "BSATask Web API v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            app.UseSwagger();

            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "BSATask Web API v1");

            });
        }
    }
}
