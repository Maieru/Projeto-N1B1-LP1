using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Projeto_N1B1_LP1.DAO;
using Projeto_N1B1_LP1.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_N1B1_LP1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CurriculoDAO curriculoDAO = new CurriculoDAO();
            var registrosNoBanco = curriculoDAO.SelectAll();

            if (registrosNoBanco == null || registrosNoBanco.Count == 0)
                curriculoDAO.Insert(new Models.CurriculoViewModel()
                {
                    CPF = "111.111.111-11",
                    Nome = "Ana Maria Braga",
                    Endereco = "Rua do Silvio Santos, 43",
                    Telefone = "40028922",
                    Email = "AnaMariaBraga@anamaria.com",
                    PretensaoSalarial = 1000000,
                    CargoPretendido = "Chefona",

                    TipoFormacao1 = EnumTipoFormacao.Superior,
                    TituloFormacao1 = "Bacharel Em Ser Ana Maria Braga",
                    DescricaoFormacao1 = "Bacharelada em ser braba",
                    DataInicioFormacao1 = DateTime.Now,
                    DataTerminoFormacao1 = DateTime.Now,

                    CargoOcupadoExp1 = "Gerente",
                    DataInicioExp1 = DateTime.Now,
                    DataTerminoExp1 = DateTime.Now,

                    Idioma1 = EnumIdiomas.Portugues,
                    LeituraIdioma1 = EnumProeficienciaLingua.Intermediario,
                    FalarIdioma1 = EnumProeficienciaLingua.Avancado,
                    EscutarIdioma1 = EnumProeficienciaLingua.Fluente,

                    Idioma2 = EnumIdiomas.None,
                    LeituraIdioma2 = EnumProeficienciaLingua.None,
                    FalarIdioma2 = EnumProeficienciaLingua.None,
                    EscutarIdioma2 = EnumProeficienciaLingua.None,

                    Idioma3 = EnumIdiomas.None,
                    LeituraIdioma3 = EnumProeficienciaLingua.None,
                    FalarIdioma3 = EnumProeficienciaLingua.None,
                    EscutarIdioma3 = EnumProeficienciaLingua.None,

                    Idioma4 = EnumIdiomas.None,
                    LeituraIdioma4 = EnumProeficienciaLingua.None,
                    FalarIdioma4 = EnumProeficienciaLingua.None,
                    EscutarIdioma4 = EnumProeficienciaLingua.None,

                    Idioma5 = EnumIdiomas.None,
                    LeituraIdioma5 = EnumProeficienciaLingua.None,
                    FalarIdioma5 = EnumProeficienciaLingua.None,
                    EscutarIdioma5 = EnumProeficienciaLingua.None,
                });

            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
