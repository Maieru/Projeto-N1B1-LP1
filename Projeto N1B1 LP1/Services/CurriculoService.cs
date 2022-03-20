using Projeto_N1B1_LP1.Enums;
using Projeto_N1B1_LP1.Models;
using System;
using System.Data;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Projeto_N1B1_LP1.Services
{
    public static class CurriculoService
    {
        public static CurriculoViewModel ConvertRowToCurriculoViewModel(DataRow registro)
        {
            var curriculoViewModel = new CurriculoViewModel();

            curriculoViewModel.Id = Convert.ToInt32(registro["Id"]);
            curriculoViewModel.CPF = registro["CPF"].ToString();
            curriculoViewModel.Nome = registro["NOME"].ToString();
            curriculoViewModel.Endereco = registro["ENDERECO"].ToString();
            curriculoViewModel.Telefone = registro["TELEFONE"].ToString();
            curriculoViewModel.Email = registro["EMAIL"].ToString();
            curriculoViewModel.PretensaoSalarial = Convert.ToDouble(registro["PRETENSAO_SALARIAL"]);
            curriculoViewModel.CargoPretendido = registro["CARGO_PRETENDIDO"].ToString();

            curriculoViewModel.TipoFormacao1 = (EnumTipoFormacao)registro["TIPO_FORMACAO_1"];
            curriculoViewModel.TituloFormacao1 = LeValorRegistro<string>(registro["TITULO_FORMACAO_1"]);
            curriculoViewModel.DataInicioFormacao1 = LeValorRegistro<DateTime>(registro["DATA_INICIO_FORMACAO_1"]);
            curriculoViewModel.DataTerminoFormacao1 = LeValorRegistro<DateTime>(registro["DATA_TERMINO_FORMACAO_1"]);
            
            curriculoViewModel.TipoFormacao2 = (EnumTipoFormacao)registro["TIPO_FORMACAO_2"];
            curriculoViewModel.TituloFormacao2 = LeValorRegistro<string>(registro["TITULO_FORMACAO_2"]);
            curriculoViewModel.DataInicioFormacao2 = LeValorRegistro<DateTime?>(registro["DATA_INICIO_FORMACAO_2"]);
            curriculoViewModel.DataTerminoFormacao2 = LeValorRegistro<DateTime?>(registro["DATA_TERMINO_FORMACAO_2"]);

            curriculoViewModel.TipoFormacao3 = (EnumTipoFormacao)registro["TIPO_FORMACAO_3"];
            curriculoViewModel.TituloFormacao3 = LeValorRegistro<string>(registro["TITULO_FORMACAO_3"]);
            curriculoViewModel.DataInicioFormacao3 = LeValorRegistro<DateTime?>(registro["DATA_INICIO_FORMACAO_3"]);
            curriculoViewModel.DataTerminoFormacao3 = LeValorRegistro<DateTime?>(registro["DATA_TERMINO_FORMACAO_3"]);

            curriculoViewModel.TipoFormacao4 = (EnumTipoFormacao)registro["TIPO_FORMACAO_4"];
            curriculoViewModel.TituloFormacao4 = LeValorRegistro<string>(registro["TITULO_FORMACAO_4"]);
            curriculoViewModel.DataInicioFormacao4 = LeValorRegistro<DateTime?>(registro["DATA_INICIO_FORMACAO_4"]);
            curriculoViewModel.DataTerminoFormacao4 = LeValorRegistro<DateTime?>(registro["DATA_TERMINO_FORMACAO_4"]);

            curriculoViewModel.TipoFormacao5 = (EnumTipoFormacao)registro["TIPO_FORMACAO_5"];
            curriculoViewModel.TituloFormacao5 = LeValorRegistro<string>(registro["TITULO_FORMACAO_5"]);
            curriculoViewModel.DataInicioFormacao5 = LeValorRegistro<DateTime?>(registro["DATA_INICIO_FORMACAO_5"]);
            curriculoViewModel.DataTerminoFormacao5 = LeValorRegistro<DateTime?>(registro["DATA_TERMINO_FORMACAO_5"]);

            curriculoViewModel.CargoOcupadoExp1 = LeValorRegistro<string>(registro["CARGO_OCUPADO_EXP_1"]);
            curriculoViewModel.DataInicioExp1 = LeValorRegistro<DateTime?>(registro["DATA_INICIO_EXP_1"]);
            curriculoViewModel.DataTerminoExp1 = LeValorRegistro<DateTime?>(registro["DATA_TERMINO_EXP_1"]);

            curriculoViewModel.CargoOcupadoExp2 = LeValorRegistro<string>(registro["CARGO_OCUPADO_EXP_2"]);
            curriculoViewModel.DataInicioExp2 = LeValorRegistro<DateTime?>(registro["DATA_INICIO_EXP_2"]);
            curriculoViewModel.DataTerminoExp2 = LeValorRegistro<DateTime?>(registro["DATA_TERMINO_EXP_2"]);

            curriculoViewModel.CargoOcupadoExp3 = LeValorRegistro<string>(registro["CARGO_OCUPADO_EXP_3"]);
            curriculoViewModel.DataInicioExp3 = LeValorRegistro<DateTime?>(registro["DATA_INICIO_EXP_3"]);
            curriculoViewModel.DataTerminoExp3 = LeValorRegistro<DateTime?>(registro["DATA_TERMINO_EXP_3"]);

            curriculoViewModel.Idioma1 = (EnumIdiomas)registro["IDIOMA_1"];
            curriculoViewModel.LeituraIdioma1 = (EnumProeficienciaLingua)registro["NIVEL_LEITURA_IDIOMA_1"];
            curriculoViewModel.EscutarIdioma1 = (EnumProeficienciaLingua)registro["NIVEL_ESCUTAR_IDIOMA_1"];
            curriculoViewModel.FalarIdioma1 = (EnumProeficienciaLingua)registro["NIVEL_FALAR_IDIOMA_1"];

            curriculoViewModel.Idioma2 = (EnumIdiomas)registro["IDIOMA_2"];
            curriculoViewModel.LeituraIdioma2 = (EnumProeficienciaLingua)registro["NIVEL_LEITURA_IDIOMA_2"];
            curriculoViewModel.EscutarIdioma2 = (EnumProeficienciaLingua)registro["NIVEL_ESCUTAR_IDIOMA_2"];
            curriculoViewModel.FalarIdioma2 = (EnumProeficienciaLingua)registro["NIVEL_FALAR_IDIOMA_2"];

            curriculoViewModel.Idioma3 = (EnumIdiomas)registro["IDIOMA_3"];
            curriculoViewModel.LeituraIdioma3 = (EnumProeficienciaLingua)registro["NIVEL_LEITURA_IDIOMA_3"];
            curriculoViewModel.EscutarIdioma3 = (EnumProeficienciaLingua)registro["NIVEL_ESCUTAR_IDIOMA_3"];
            curriculoViewModel.FalarIdioma3 = (EnumProeficienciaLingua)registro["NIVEL_FALAR_IDIOMA_3"];

            curriculoViewModel.Idioma4 = (EnumIdiomas)registro["IDIOMA_4"];
            curriculoViewModel.LeituraIdioma4 = (EnumProeficienciaLingua)registro["NIVEL_LEITURA_IDIOMA_4"];
            curriculoViewModel.EscutarIdioma4 = (EnumProeficienciaLingua)registro["NIVEL_ESCUTAR_IDIOMA_4"];
            curriculoViewModel.FalarIdioma4 = (EnumProeficienciaLingua)registro["NIVEL_FALAR_IDIOMA_4"];
            
            curriculoViewModel.Idioma5 = (EnumIdiomas)registro["IDIOMA_5"];
            curriculoViewModel.LeituraIdioma5 = (EnumProeficienciaLingua)registro["NIVEL_LEITURA_IDIOMA_5"];
            curriculoViewModel.EscutarIdioma5 = (EnumProeficienciaLingua)registro["NIVEL_ESCUTAR_IDIOMA_5"];
            curriculoViewModel.FalarIdioma5 = (EnumProeficienciaLingua)registro["NIVEL_FALAR_IDIOMA_5"];

            return curriculoViewModel;
        }

        private static T LeValorRegistro<T>(object valor)
        {
            if (valor == DBNull.Value)
                return default(T);

            return (T)valor;
        }

    }
}
