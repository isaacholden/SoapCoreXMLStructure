using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SoapCore;
using SoapCore_Test.Services;
using System.ServiceModel.Channels;
using SoapCore.Extensibility;
using Microsoft.Extensions.DependencyInjection.Extensions;
using System.Xml;

namespace SoapCore_Test
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IProcessPerson, ProcessPerson>();
            services.TryAddSingleton<IFaultExceptionTransformer, DefaultFaultExceptionTransformer>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.UseSoapEndpoint<IProcessPerson>("/Process", new SoapEncoderOptions()
                {
                    MessageVersion = MessageVersion.Soap11WSAddressingAugust2004
                }, 
                SoapSerializer.DataContractSerializer);
            });
        }
    }
    public class DefaultFaultExceptionTransformer : IFaultExceptionTransformer
    {
        public Message ProvideFault(Exception exception, MessageVersion messageVersion, Message requestMessage, XmlNamespaceManager xmlNamespaceManager)
        {
            return Message.CreateMessage(messageVersion, "Exception", exception.ToString());
        }
    }
}
