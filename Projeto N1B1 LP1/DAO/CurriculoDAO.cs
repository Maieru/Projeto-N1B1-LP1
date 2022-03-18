using Projeto_N1B1_LP1.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_11._1.DAO
{
    public class JogoDAO
    {
        public void Insert(CurriculoViewModel curriculo)
        {
            string sql = @"INSERT INTO tbCurriculo (ID, DESCRICAO, VALOR_LOCACAO, DATA_AQUISICAO, CATEGORIAID) 
                           VALUES (@Id, @Descricao, @ValorLocacao, @DataAquisicao, @Categoria)";

            HelperDAO.ExecuteSQL(sql, GetCurriculoParameters(curriculo));
        }

        public void Edit(CurriculoViewModel curriculo)
        {
            string sql = "UPDATE tbCurriculo " +
                         $"SET DESCRICAO = @Descricao, VALOR_LOCACAO = @ValorLocacao, DATA_AQUISICAO = @DataAquisicao, CATEGORIAID = @Categoria " +
                         $"WHERE Id = @Id";

            HelperDAO.ExecuteSQL(sql, GetCurriculoParameters(curriculo));
        }

        public void Delete(int id)
        {
            string sql = "DELETE tbCurriculo " +
                         $"WHERE Id = @Id";

            HelperDAO.ExecuteSQL(sql, new SqlParameter[] { new SqlParameter("Id", id) });
        }

        public CurriculoViewModel Select(int id)
        {
            string sql = "SELECT * FROM tbCurriculo WHERE Id = " + id.ToString();

            DataTable table = HelperDAO.ExecuteSelect(sql);

            if (table.Rows.Count == 0)
                return null;
            else
            {
                var registro = table.Rows[0];
                return new CurriculoViewModel
                {
                    // Botar dados aqui
                };
            }
        }

        public List<CurriculoViewModel> SelectAll()
        {
            string sql = "SELECT * FROM tbCurriculo";
            List<CurriculoViewModel> curriculoViewModels = new List<CurriculoViewModel>();

            DataTable table = HelperDAO.ExecuteSelect(sql);

            if (table.Rows.Count == 0)
                return null;
            else
            {
                foreach (DataRow registro in table.Rows)
                {
                    curriculoViewModels.Add(new CurriculoViewModel
                    {
                        // Botar dados aqui 
                    });
                }
            }

            return curriculoViewModels;
        }

        private SqlParameter[] GetCurriculoParameters(CurriculoViewModel curriculo)
        {
            return new SqlParameter[]
            {
                new SqlParameter("CPF", curriculo.CPF),
                new SqlParameter("ENDERECO", curriculo.Endereco),
                new SqlParameter("TELEFONE", curriculo.Telefone),
                new SqlParameter("EMAIL", curriculo.Email),
                new SqlParameter("PRETENSAO_SALARIAL", curriculo.PretensaoSalarial),

                new SqlParameter("TIPO_FORMACAO_1", curriculo.TipoFormacao1),
                new SqlParameter("TITULO_FORMACAO_1", curriculo.TituloFormacao1),
                new SqlParameter("DESCRICAO_FORMACAO_1", curriculo.DescricaoFormacao1),
                new SqlParameter("DATA_INICIO_FORMACAO_1", curriculo.DataInicioFormacao1),
                new SqlParameter("DATA_TERMINO_FORMACAO_1", curriculo.DataInicioFormacao1),

                new SqlParameter("TIPO_FORMACAO_2", curriculo.TipoFormacao2),
                new SqlParameter("TITULO_FORMACAO_2", curriculo.TituloFormacao2),
                new SqlParameter("DESCRICAO_FORMACAO_2", curriculo.DescricaoFormacao2),
                new SqlParameter("DATA_INICIO_FORMACAO_2", curriculo.DataInicioFormacao2),
                new SqlParameter("DATA_TERMINO_FORMACAO_2", curriculo.DataInicioFormacao2),

                new SqlParameter("TIPO_FORMACAO_3", curriculo.TipoFormacao3),
                new SqlParameter("TITULO_FORMACAO_3", curriculo.TituloFormacao3),
                new SqlParameter("DESCRICAO_FORMACAO_3", curriculo.DescricaoFormacao3),
                new SqlParameter("DATA_INICIO_FORMACAO_3", curriculo.DataInicioFormacao3),
                new SqlParameter("DATA_TERMINO_FORMACAO_3", curriculo.DataInicioFormacao3),

                new SqlParameter("TIPO_FORMACAO_4", curriculo.TipoFormacao4),
                new SqlParameter("TITULO_FORMACAO_4", curriculo.TituloFormacao4),
                new SqlParameter("DESCRICAO_FORMACAO_4", curriculo.DescricaoFormacao4),
                new SqlParameter("DATA_INICIO_FORMACAO_4", curriculo.DataInicioFormacao4),
                new SqlParameter("DATA_TERMINO_FORMACAO_4", curriculo.DataInicioFormacao4),

                new SqlParameter("TIPO_FORMACAO_5", curriculo.TipoFormacao5),
                new SqlParameter("TITULO_FORMACAO_5", curriculo.TituloFormacao5),
                new SqlParameter("DESCRICAO_FORMACAO_5", curriculo.DescricaoFormacao5),
                new SqlParameter("DATA_INICIO_FORMACAO_5", curriculo.DataInicioFormacao5),
                new SqlParameter("DATA_TERMINO_FORMACAO_5", curriculo.DataInicioFormacao5),

                new SqlParameter("CARGO_OCUPADO_EXP_1", curriculo.CargoOcupadoExp1),
                new SqlParameter("DATA_INICIO_EXP_1", curriculo.DataInicioExp1),
                new SqlParameter("DATA_TERMINO_EXP_1", curriculo.DataTerminoExp1),

                new SqlParameter("CARGO_OCUPADO_EXP_2", curriculo.CargoOcupadoExp2),
                new SqlParameter("DATA_INICIO_EXP_2", curriculo.DataInicioExp2),
                new SqlParameter("DATA_TERMINO_EXP_2", curriculo.DataTerminoExp2),

                new SqlParameter("CARGO_OCUPADO_EXP_3", curriculo.CargoOcupadoExp3),
                new SqlParameter("DATA_INICIO_EXP_3", curriculo.DataInicioExp3),
                new SqlParameter("DATA_TERMINO_EXP_3", curriculo.DataTerminoExp3),

                new SqlParameter("IDIOMA_1", curriculo.Idioma1),
                new SqlParameter("NIVEL_LEITURA_IDIOMA_1", curriculo.LeituraIdioma1),
                new SqlParameter("NIVEL_ESCUTAR_IDIOMA_1", curriculo.EscutarIdioma1),
                new SqlParameter("NIVEL_FALAR_IDIOMA_1", curriculo.FalarIdioma1),

                new SqlParameter("IDIOMA_2", curriculo.Idioma2),
                new SqlParameter("NIVEL_LEITURA_IDIOMA_2", curriculo.LeituraIdioma2),
                new SqlParameter("NIVEL_ESCUTAR_IDIOMA_2", curriculo.EscutarIdioma2),
                new SqlParameter("NIVEL_FALAR_IDIOMA_2", curriculo.FalarIdioma2),

                new SqlParameter("IDIOMA_3", curriculo.Idioma3),
                new SqlParameter("NIVEL_LEITURA_IDIOMA_3", curriculo.LeituraIdioma3),
                new SqlParameter("NIVEL_ESCUTAR_IDIOMA_3", curriculo.EscutarIdioma3),
                new SqlParameter("NIVEL_FALAR_IDIOMA_3", curriculo.FalarIdioma3),

                new SqlParameter("IDIOMA_4", curriculo.Idioma4),
                new SqlParameter("NIVEL_LEITURA_IDIOMA_4", curriculo.LeituraIdioma4),
                new SqlParameter("NIVEL_ESCUTAR_IDIOMA_4", curriculo.EscutarIdioma4),
                new SqlParameter("NIVEL_FALAR_IDIOMA_4", curriculo.FalarIdioma4),

                new SqlParameter("IDIOMA_5", curriculo.Idioma5),
                new SqlParameter("NIVEL_LEITURA_IDIOMA_5", curriculo.LeituraIdioma5),
                new SqlParameter("NIVEL_ESCUTAR_IDIOMA_5", curriculo.EscutarIdioma5),
                new SqlParameter("NIVEL_FALAR_IDIOMA_5", curriculo.FalarIdioma5),
            };
        }
    }
}
