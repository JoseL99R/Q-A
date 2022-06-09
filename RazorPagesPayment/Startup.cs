using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using RazorPagesPayment.Data;

namespace RazorPagesPayment
{
    public class Startup
 {
    public Startup(IConfiguration configuration, IWebHostEnvironment env)
    {
        Environment = env;
        Configuration = configuration;
    }

    public IConfiguration Configuration { get; }
    public IWebHostEnvironment Environment { get; }

    public void ConfigureServices(IServiceCollection services)
    {
        if (Environment.IsDevelopment())
        {
            services.AddDbContext<RazorPagesPaymentContext>(options =>
            options.UseSqlite(
                Configuration.GetConnectionString("RazorPagesPaymentContext")));
        }
        else
        {
            services.AddDbContext<RazorPagesPaymentContext>(options =>
            options.UseSqlServer(
                Configuration.GetConnectionString("PaymentContext")));
        }

        services.AddRazorPages();
    }

    public void Configure(IApplicationBuilder app)
    {
        if (Environment.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
        }
        else
        {
            app.UseExceptionHandler("/Error");
            app.UseHsts();
        }

        app.UseHttpsRedirection();
        app.UseStaticFiles();

        app.UseRouting();

        app.UseEndpoints(endpoints =>
        {
            endpoints.MapRazorPages();
        });
    }
 }
}

