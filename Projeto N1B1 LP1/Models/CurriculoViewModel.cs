using Projeto_N1B1_LP1.Enums;
using System;

namespace Projeto_N1B1_LP1.Models
{
    public class CurriculoViewModel
    {
        #region Dados Básicos
        public int Id { get; set; }
        public string CPF { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public double PretensaoSalarial { get; set; }
        public string CargoPretendido { get; set; }
        #endregion

        #region Formacao

        public EnumTipoFormacao TipoFormacao1 { get; set; }
        public string TituloFormacao1 { get; set; }
        public string DescricaoFormacao1 { get; set; }
        public DateTime DataInicioFormacao1 { get; set; }
        public DateTime DataTerminoFormacao1 { get; set; }

        public EnumTipoFormacao? TipoFormacao2 { get; set; }
        public string TituloFormacao2 { get; set; }
        public string DescricaoFormacao2 { get; set; }
        public DateTime? DataInicioFormacao2 { get; set; }
        public DateTime? DataTerminoFormacao2 { get; set; }

        public EnumTipoFormacao? TipoFormacao3 { get; set; }
        public string TituloFormacao3 { get; set; }
        public string DescricaoFormacao3 { get; set; }
        public DateTime? DataInicioFormacao3 { get; set; }
        public DateTime? DataTerminoFormacao3 { get; set; }

        public EnumTipoFormacao? TipoFormacao4 { get; set; }
        public string TituloFormacao4 { get; set; }
        public string DescricaoFormacao4 { get; set; }
        public DateTime? DataInicioFormacao4 { get; set; }
        public DateTime? DataTerminoFormacao4 { get; set; }

        public EnumTipoFormacao? TipoFormacao5 { get; set; }
        public string TituloFormacao5 { get; set; }
        public string DescricaoFormacao5 { get; set; }
        public DateTime? DataInicioFormacao5 { get; set; }
        public DateTime? DataTerminoFormacao5 { get; set; }

        #endregion

        #region Experiencia Profissional

        public string CargoOcupadoExp1 { get; set; }
        public DateTime? DataInicioExp1 { get; set; }
        public DateTime? DataTerminoExp1 { get; set; }

        public string CargoOcupadoExp2 { get; set; }
        public DateTime? DataInicioExp2 { get; set; }
        public DateTime? DataTerminoExp2 { get; set; }

        public string CargoOcupadoExp3 { get; set; }
        public DateTime? DataInicioExp3 { get; set; }
        public DateTime? DataTerminoExp3 { get; set; }
        #endregion

        #region Idioma

        public EnumIdiomas? Idioma1 { get; set; }
        public EnumProeficienciaLingua? LeituraIdioma1 { get; set; }
        public EnumProeficienciaLingua? EscutarIdioma1 { get; set; }
        public EnumProeficienciaLingua? FalarIdioma1 { get; set; }

        public EnumIdiomas? Idioma2 { get; set; }
        public EnumProeficienciaLingua? LeituraIdioma2 { get; set; }
        public EnumProeficienciaLingua? EscutarIdioma2 { get; set; }
        public EnumProeficienciaLingua? FalarIdioma2 { get; set; }

        public EnumIdiomas? Idioma3 { get; set; }
        public EnumProeficienciaLingua? LeituraIdioma3 { get; set; }
        public EnumProeficienciaLingua? EscutarIdioma3 { get; set; }
        public EnumProeficienciaLingua? FalarIdioma3 { get; set; }

        public EnumIdiomas? Idioma4 { get; set; }
        public EnumProeficienciaLingua? LeituraIdioma4 { get; set; }
        public EnumProeficienciaLingua? EscutarIdioma4 { get; set; }
        public EnumProeficienciaLingua? FalarIdioma4 { get; set; }

        public EnumIdiomas? Idioma5 { get; set; }
        public EnumProeficienciaLingua? LeituraIdioma5 { get; set; }
        public EnumProeficienciaLingua? EscutarIdioma5 { get; set; }
        public EnumProeficienciaLingua? FalarIdioma5 { get; set; }
        #endregion
    }
}
