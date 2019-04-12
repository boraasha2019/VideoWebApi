using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using VideoPlayer.Handlers.Interface;
using VideoPlayer.Handlers.Request;
using VideoPlayer.Handlers.Messages;

namespace VideoPlayerSolution
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
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
            //.AddJsonOptions(option => option.SerializerSettings.ContractResolver = new DefaultContractResolver());
            services.AddScoped<IRequestHandler<MoviesRequest, MoviesResponse>, MoviesRequestHandler>();
            services.AddScoped<IRequestHandler<MovieRequest, MovieResponse>, MovieRequestHandler>();
            // services.AddScoped < IRequestHandler<TReq, TResp>, typeof(RequestHandler) > ();

            // to call an api  from javascript, we need to enable CORS on the api server.
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy",
            builder => builder.AllowAnyOrigin()
                              .AllowAnyMethod()
                              .AllowAnyHeader()
                              .AllowCredentials());
            });
            services.AddScoped<IRequestHandlerFactory, RequestHandlerFactory>();

            //  .AddJsonOptions(option=>option.SerializerSettings.ContractResolver=new DefaultContractResolver());
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseCors("CorsPolicy");
            app.UseMvc();
        }
    }
}
