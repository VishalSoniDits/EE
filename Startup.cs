using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EE.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;

namespace EE
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

            services.AddControllers();
            services.AddCors();
            services.AddSwaggerGen();
            services.AddTransient<ILoginRepository,LoginRepository>();
            services.AddTransient<ISetRoleRepository,SetRoleRepository>();
            services.AddTransient<IEmployeesRepository,EmployeesRepository>();
            services.AddTransient<IMaterialRepository,MaterialRepository>();
            services.AddTransient<ISignatureRepository,SignatureRepository>();
            services.AddTransient<IQuestionTypeRepository,QuestionTypeRepository>();
            services.AddTransient<ISearchEmployeesRepository,SearchEmployeesRepository>();
            services.AddTransient<IQuestionRepository,QuestionRepository>();
            services.AddTransient<ILableRepository,LableRepository>();
            services.AddTransient<IHelperRepository,HelperRepository>();
            services.AddTransient<ITemplateRepository,TemplateRepository>();
            services.AddTransient<ICategoryRepository,CategoryRepository>();
            services.AddTransient<ISubCategoryRepository,SubCategoryRepository>();
            services.AddTransient<ISupplierRepository,SupplierRepository>();
            services.AddTransient<IFacilitie_ClientsRepository,Facilitie_ClientsRepository>();
            services.AddTransient<IFacilite_Job_SitesRepository,Facilite_Job_SitesRepository>();
            services.AddTransient<IZipcodeRepository,ZipcodeRepository>();
            services.AddTransient<IResidentialJobSiteRepository,ResidentialJobSiteRepository>();
            services.AddTransient<IPricingRepository,PricingRepository>();
            services.AddTransient<ITechnicianRepository,TechnicianRepository>();
            services.AddTransient<IAssignedTemplatesRepository,AssignedTemplatesRepository>();
            services.AddTransient<IAgreementRepository,AgreementRepository>();
            services.AddTransient<IJobFolderRepository,JobFolderRepository>();
            services.AddTransient<ICommercialClientRepository,CommercialClientRepository>();
            services.AddTransient<ICommercialJobSiteRepository,CommercialJobSiteRepository>();
            services.AddTransient<ICommServiceRequestRepository,CommServiceRequestRepository>();
            services.AddTransient<ICommAssignTechnicianRepository,CommAssignTechnicianRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "EE v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();
            app.UseCors(x => x
           .AllowAnyOrigin()
           .AllowAnyMethod()
           .AllowAnyHeader());
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
