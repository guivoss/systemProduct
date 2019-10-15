using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection; //importando para utilizar a Interface IConfiguration
using Projeto.Data.Contracts; //importando para a Interface
using Projeto.Data.Repositories; //importando para o repository

namespace Projeto.Presentation
{
    public class Startup
    {
        //atributo para a configuração ca conenectionstring
        private IConfiguration configuration;

        //construtor com entrada de argumentos do atributo
        public Startup(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            //resgatar a string de conexão mapeada no arquivo appsettings.json
            string connectionString = configuration.GetConnectionString("Aula");

            //mapear a classe ProdutoRepository para que receba a string de conexão
            services.AddTransient<IProdutoRepository, ProdutoRepository>
                (map => new ProdutoRepository(connectionString));

            //configuração do projeto para trabalhar com o MVC
            services.AddMvc();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //Configurando o CORE para reconhecer a pasta /wwwroot
            app.UseStaticFiles();

            //Configurar o padrão de ROTAS do MVC
            //Página inicial -> /Home/Index
            app.UseMvc(
                routes =>
                {
                    routes.MapRoute(
                        name: "default",
                        template: "{controller=Home}/{action=Index}/{id?}"
                        );
                }
            );
        }
    }
}
