using Projeto_N1B1_LP1.Enums;
using Projeto_N1B1_LP1.Models;
using Projeto_N1B1_LP1.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_N1B1_LP1.DAO
{
    public class CurriculoDAO
    {
        public void Insert(CurriculoViewModel curriculo)
        {
            #region SQL ( Gigante )
            string sql = @"INSERT INTO tbCurriculo 
                           ([CPF]
                           ,[NOME]
                           ,[ENDERECO]
                           ,[TELEFONE]
                           ,[EMAIL]
                           ,[PRETENSAO_SALARIAL]
                           ,[CARGO_PRETENDIDO]
                           ,[TIPO_FORMACAO_1]
                           ,[TITULO_FORMACAO_1]
                           ,[DESCRICAO_FORMACAO_1]
                           ,[DATA_INICIO_FORMACAO_1]
                           ,[DATA_TERMINO_FORMACAO_1]
                           ,[TIPO_FORMACAO_2]
                           ,[TITULO_FORMACAO_2]
                           ,[DESCRICAO_FORMACAO_2]
                           ,[DATA_INICIO_FORMACAO_2]
                           ,[DATA_TERMINO_FORMACAO_2]
                           ,[TIPO_FORMACAO_3]
                           ,[TITULO_FORMACAO_3]
                           ,[DESCRICAO_FORMACAO_3]
                           ,[DATA_INICIO_FORMACAO_3]
                           ,[DATA_TERMINO_FORMACAO_3]
                           ,[TIPO_FORMACAO_4]
                           ,[TITULO_FORMACAO_4]
                           ,[DESCRICAO_FORMACAO_4]
                           ,[DATA_INICIO_FORMACAO_4]
                           ,[DATA_TERMINO_FORMACAO_4]
                           ,[TIPO_FORMACAO_5]
                           ,[TITULO_FORMACAO_5]
                           ,[DESCRICAO_FORMACAO_5]
                           ,[DATA_INICIO_FORMACAO_5]
                           ,[DATA_TERMINO_FORMACAO_5]
                           ,[CARGO_OCUPADO_EXP_1]
                           ,[DATA_INICIO_EXP_1]
                           ,[DATA_TERMINO_EXP_1]
                           ,[CARGO_OCUPADO_EXP_2]
                           ,[DATA_INICIO_EXP_2]
                           ,[DATA_TERMINO_EXP_2]
                           ,[CARGO_OCUPADO_EXP_3]
                           ,[DATA_INICIO_EXP_3]
                           ,[DATA_TERMINO_EXP_3]
                           ,[IDIOMA_1]
                           ,[NIVEL_LEITURA_IDIOMA_1]
                           ,[NIVEL_ESCUTAR_IDIOMA_1]
                           ,[NIVEL_FALAR_IDIOMA_1]
                           ,[IDIOMA_2]
                           ,[NIVEL_LEITURA_IDIOMA_2]
                           ,[NIVEL_ESCUTAR_IDIOMA_2]
                           ,[NIVEL_FALAR_IDIOMA_2]
                           ,[IDIOMA_3]
                           ,[NIVEL_LEITURA_IDIOMA_3]
                           ,[NIVEL_ESCUTAR_IDIOMA_3]
                           ,[NIVEL_FALAR_IDIOMA_3]
                           ,[IDIOMA_4]
                           ,[NIVEL_LEITURA_IDIOMA_4]
                           ,[NIVEL_ESCUTAR_IDIOMA_4]
                           ,[NIVEL_FALAR_IDIOMA_4]
                           ,[IDIOMA_5]
                           ,[NIVEL_LEITURA_IDIOMA_5]
                           ,[NIVEL_ESCUTAR_IDIOMA_5]
                           ,[NIVEL_FALAR_IDIOMA_5]) 
                           VALUES (@CPF
                                   ,@NOME
                                   ,@ENDERECO
                                   ,@TELEFONE
                                   ,@EMAIL
                                   ,@PRETENSAO_SALARIAL
                                   ,@CARGO_PRETENDIDO
                                   ,@TIPO_FORMACAO_1
                                   ,@TITULO_FORMACAO_1
                                   ,@DESCRICAO_FORMACAO_1
                                   ,@DATA_INICIO_FORMACAO_1
                                   ,@DATA_TERMINO_FORMACAO_1
                                   ,@TIPO_FORMACAO_2
                                   ,@TITULO_FORMACAO_2
                                   ,@DESCRICAO_FORMACAO_2
                                   ,@DATA_INICIO_FORMACAO_2
                                   ,@DATA_TERMINO_FORMACAO_2
                                   ,@TIPO_FORMACAO_3
                                   ,@TITULO_FORMACAO_3
                                   ,@DESCRICAO_FORMACAO_3
                                   ,@DATA_INICIO_FORMACAO_3
                                   ,@DATA_TERMINO_FORMACAO_3
                                   ,@TIPO_FORMACAO_4
                                   ,@TITULO_FORMACAO_4
                                   ,@DESCRICAO_FORMACAO_4
                                   ,@DATA_INICIO_FORMACAO_4
                                   ,@DATA_TERMINO_FORMACAO_4
                                   ,@TIPO_FORMACAO_5
                                   ,@TITULO_FORMACAO_5
                                   ,@DESCRICAO_FORMACAO_5
                                   ,@DATA_INICIO_FORMACAO_5
                                   ,@DATA_TERMINO_FORMACAO_5
                                   ,@CARGO_OCUPADO_EXP_1
                                   ,@DATA_INICIO_EXP_1
                                   ,@DATA_TERMINO_EXP_1
                                   ,@CARGO_OCUPADO_EXP_2
                                   ,@DATA_INICIO_EXP_2
                                   ,@DATA_TERMINO_EXP_2
                                   ,@CARGO_OCUPADO_EXP_3
                                   ,@DATA_INICIO_EXP_3
                                   ,@DATA_TERMINO_EXP_3
                                   ,@IDIOMA_1
                                   ,@NIVEL_LEITURA_IDIOMA_1
                                   ,@NIVEL_ESCUTAR_IDIOMA_1
                                   ,@NIVEL_FALAR_IDIOMA_1
                                   ,@IDIOMA_2
                                   ,@NIVEL_LEITURA_IDIOMA_2
                                   ,@NIVEL_ESCUTAR_IDIOMA_2
                                   ,@NIVEL_FALAR_IDIOMA_2
                                   ,@IDIOMA_3
                                   ,@NIVEL_LEITURA_IDIOMA_3
                                   ,@NIVEL_ESCUTAR_IDIOMA_3
                                   ,@NIVEL_FALAR_IDIOMA_3
                                   ,@IDIOMA_4
                                   ,@NIVEL_LEITURA_IDIOMA_4
                                   ,@NIVEL_ESCUTAR_IDIOMA_4
                                   ,@NIVEL_FALAR_IDIOMA_4
                                   ,@IDIOMA_5
                                   ,@NIVEL_LEITURA_IDIOMA_5
                                   ,@NIVEL_ESCUTAR_IDIOMA_5
                                   ,@NIVEL_FALAR_IDIOMA_5)";
            #endregion

            HelperDAO.ExecuteSQL(sql, GetCurriculoParameters(curriculo));
        }

        public void Edit(CurriculoViewModel curriculo)
        {
            #region SQL ( Gigante )
            string sql = @"UPDATE tbCurriculo
                         SET 
                         CPF = @CPF,
                         NOME = @NOME,
                         ENDERECO = @ENDERECO,
                         TELEFONE = @TELEFONE,
                         EMAIL = @EMAIL,
                         PRETENSAO_SALARIAL = @PRETENSAO_SALARIAL,
                         CARGO_PRETENDIDO = @CARGO_PRETENDIDO,
                         TIPO_FORMACAO_1 = @TIPO_FORMACAO_1,
                         TITULO_FORMACAO_1 = @TITULO_FORMACAO_1,
                         DESCRICAO_FORMACAO_1 = @DESCRICAO_FORMACAO_1,
                         DATA_INICIO_FORMACAO_1 = @DATA_INICIO_FORMACAO_1,
                         DATA_TERMINO_FORMACAO_1 = @DATA_TERMINO_FORMACAO_1,
                         TIPO_FORMACAO_2 = @TIPO_FORMACAO_2,
                         TITULO_FORMACAO_2 = @TITULO_FORMACAO_2,
                         DESCRICAO_FORMACAO_2 = @DESCRICAO_FORMACAO_2,
                         DATA_INICIO_FORMACAO_2 = @DATA_INICIO_FORMACAO_2,
                         DATA_TERMINO_FORMACAO_2 = @DATA_TERMINO_FORMACAO_2,
                         TIPO_FORMACAO_3 = @TIPO_FORMACAO_3,
                         TITULO_FORMACAO_3 = @TITULO_FORMACAO_3,
                         DESCRICAO_FORMACAO_3 = @DESCRICAO_FORMACAO_3,
                         DATA_INICIO_FORMACAO_3 = @DATA_INICIO_FORMACAO_3,
                         DATA_TERMINO_FORMACAO_3 = @DATA_TERMINO_FORMACAO_3,
                         TIPO_FORMACAO_4 = @TIPO_FORMACAO_4,
                         TITULO_FORMACAO_4 = @TITULO_FORMACAO_4,
                         DESCRICAO_FORMACAO_4 = @DESCRICAO_FORMACAO_4,
                         DATA_INICIO_FORMACAO_4 = @DATA_INICIO_FORMACAO_4,
                         DATA_TERMINO_FORMACAO_4 = @DATA_TERMINO_FORMACAO_4,
                         TIPO_FORMACAO_5 = @TIPO_FORMACAO_5,
                         TITULO_FORMACAO_5 = @TITULO_FORMACAO_5,
                         DESCRICAO_FORMACAO_5 = @DESCRICAO_FORMACAO_5,
                         DATA_INICIO_FORMACAO_5 = @DATA_INICIO_FORMACAO_5,
                         DATA_TERMINO_FORMACAO_5 = @DATA_TERMINO_FORMACAO_5,
                         CARGO_OCUPADO_EXP_1 = @CARGO_OCUPADO_EXP_1,
                         DATA_INICIO_EXP_1 = @DATA_INICIO_EXP_1,
                         DATA_TERMINO_EXP_1 = @DATA_TERMINO_EXP_1,
                         CARGO_OCUPADO_EXP_2 = @CARGO_OCUPADO_EXP_2,
                         DATA_INICIO_EXP_2 = @DATA_INICIO_EXP_2,
                         DATA_TERMINO_EXP_2 = @DATA_TERMINO_EXP_2,
                         CARGO_OCUPADO_EXP_3 = @CARGO_OCUPADO_EXP_3,
                         DATA_INICIO_EXP_3 = @DATA_INICIO_EXP_3,
                         DATA_TERMINO_EXP_3 = @DATA_TERMINO_EXP_3,
                         IDIOMA_1 = @IDIOMA_1,
                         NIVEL_LEITURA_IDIOMA_1 = @NIVEL_LEITURA_IDIOMA_1,
                         NIVEL_ESCUTAR_IDIOMA_1 = @NIVEL_ESCUTAR_IDIOMA_1,
                         NIVEL_FALAR_IDIOMA_1 = @NIVEL_FALAR_IDIOMA_1,
                         IDIOMA_2 = @IDIOMA_2,
                         NIVEL_LEITURA_IDIOMA_2 = @NIVEL_LEITURA_IDIOMA_2,
                         NIVEL_ESCUTAR_IDIOMA_2 = @NIVEL_ESCUTAR_IDIOMA_2,
                         NIVEL_FALAR_IDIOMA_2 = @NIVEL_FALAR_IDIOMA_2,
                         IDIOMA_3 = @IDIOMA_3,
                         NIVEL_LEITURA_IDIOMA_3 = @NIVEL_LEITURA_IDIOMA_3,
                         NIVEL_ESCUTAR_IDIOMA_3 = @NIVEL_ESCUTAR_IDIOMA_3,
                         NIVEL_FALAR_IDIOMA_3 = @NIVEL_FALAR_IDIOMA_3,
                         IDIOMA_4 = @IDIOMA_4,
                         NIVEL_LEITURA_IDIOMA_4 = @NIVEL_LEITURA_IDIOMA_4,
                         NIVEL_ESCUTAR_IDIOMA_4 = @NIVEL_ESCUTAR_IDIOMA_4,
                         NIVEL_FALAR_IDIOMA_4 = @NIVEL_FALAR_IDIOMA_4,
                         IDIOMA_5 = @IDIOMA_5,
                         NIVEL_LEITURA_IDIOMA_5 = @NIVEL_LEITURA_IDIOMA_5,
                         NIVEL_ESCUTAR_IDIOMA_5 = @NIVEL_ESCUTAR_IDIOMA_5,
                         NIVEL_FALAR_IDIOMA_5 = @NIVEL_FALAR_IDIOMA_5
                         WHERE Id = @Id";
            #endregion

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
                return CurriculoService.ConvertRowToCurriculoViewModel(table.Rows[0]);
        }

        public List<CurriculoViewModel> SelectAll()
        {
            string sql = "SELECT * FROM tbCurriculo";
            List<CurriculoViewModel> curriculoViewModels = new List<CurriculoViewModel>();

            DataTable table = HelperDAO.ExecuteSelect(sql);

            if (table.Rows.Count == 0)
                return null;
            else
                foreach (DataRow registro in table.Rows)
                    curriculoViewModels.Add(CurriculoService.ConvertRowToCurriculoViewModel(registro));
                
            return curriculoViewModels;
        }

        private SqlParameter[] GetCurriculoParameters(CurriculoViewModel curriculo)
        {
            return new SqlParameter[]
            {
                new SqlParameter("ID", curriculo.Id),
                new SqlParameter("CPF", curriculo.CPF),
                new SqlParameter("NOME", curriculo.Nome),
                new SqlParameter("ENDERECO", curriculo.Endereco),
                new SqlParameter("TELEFONE", curriculo.Telefone),
                new SqlParameter("EMAIL", curriculo.Email),
                new SqlParameter("PRETENSAO_SALARIAL", curriculo.PretensaoSalarial),
                new SqlParameter("CARGO_PRETENDIDO", curriculo.CargoPretendido),

                new SqlParameter("TIPO_FORMACAO_1", curriculo.TipoFormacao1),
                new SqlParameter("TITULO_FORMACAO_1", curriculo.TituloFormacao1),
                new SqlParameter("DESCRICAO_FORMACAO_1", curriculo.DescricaoFormacao1),
                new SqlParameter("DATA_INICIO_FORMACAO_1", curriculo.DataInicioFormacao1),
                new SqlParameter("DATA_TERMINO_FORMACAO_1", curriculo.DataInicioFormacao1),

                new SqlParameter("TIPO_FORMACAO_2", curriculo.TipoFormacao2),
                new SqlParameter("TITULO_FORMACAO_2", curriculo.TituloFormacao2 ?? (object)DBNull.Value),
                new SqlParameter("DESCRICAO_FORMACAO_2", curriculo.DescricaoFormacao2 ?? (object)DBNull.Value),
                new SqlParameter("DATA_INICIO_FORMACAO_2", curriculo.DataInicioFormacao2 ?? (object)DBNull.Value),
                new SqlParameter("DATA_TERMINO_FORMACAO_2", curriculo.DataInicioFormacao2 ?? (object)DBNull.Value),

                new SqlParameter("TIPO_FORMACAO_3", curriculo.TipoFormacao3),
                new SqlParameter("TITULO_FORMACAO_3", curriculo.TituloFormacao3 ?? (object)DBNull.Value),
                new SqlParameter("DESCRICAO_FORMACAO_3", curriculo.DescricaoFormacao3 ?? (object)DBNull.Value),
                new SqlParameter("DATA_INICIO_FORMACAO_3", curriculo.DataInicioFormacao3 ?? (object)DBNull.Value),
                new SqlParameter("DATA_TERMINO_FORMACAO_3", curriculo.DataInicioFormacao3 ?? (object)DBNull.Value),

                new SqlParameter("TIPO_FORMACAO_4", curriculo.TipoFormacao4),
                new SqlParameter("TITULO_FORMACAO_4", curriculo.TituloFormacao4 ?? (object)DBNull.Value),
                new SqlParameter("DESCRICAO_FORMACAO_4", curriculo.DescricaoFormacao4 ?? (object)DBNull.Value),
                new SqlParameter("DATA_INICIO_FORMACAO_4", curriculo.DataInicioFormacao4 ?? (object)DBNull.Value),
                new SqlParameter("DATA_TERMINO_FORMACAO_4", curriculo.DataInicioFormacao4 ?? (object)DBNull.Value),

                new SqlParameter("TIPO_FORMACAO_5", curriculo.TipoFormacao5),
                new SqlParameter("TITULO_FORMACAO_5", curriculo.TituloFormacao5 ?? (object)DBNull.Value),
                new SqlParameter("DESCRICAO_FORMACAO_5", curriculo.DescricaoFormacao5 ?? (object)DBNull.Value),
                new SqlParameter("DATA_INICIO_FORMACAO_5", curriculo.DataInicioFormacao5 ?? (object)DBNull.Value),
                new SqlParameter("DATA_TERMINO_FORMACAO_5", curriculo.DataInicioFormacao5 ?? (object)DBNull.Value),

                new SqlParameter("CARGO_OCUPADO_EXP_1", curriculo.CargoOcupadoExp1 ?? (object)DBNull.Value),
                new SqlParameter("DATA_INICIO_EXP_1", curriculo.DataInicioExp1 ?? (object)DBNull.Value),
                new SqlParameter("DATA_TERMINO_EXP_1", curriculo.DataTerminoExp1 ?? (object)DBNull.Value),

                new SqlParameter("CARGO_OCUPADO_EXP_2", curriculo.CargoOcupadoExp2 ?? (object)DBNull.Value),
                new SqlParameter("DATA_INICIO_EXP_2", curriculo.DataInicioExp2 ?? (object)DBNull.Value),
                new SqlParameter("DATA_TERMINO_EXP_2", curriculo.DataTerminoExp2 ?? (object)DBNull.Value),

                new SqlParameter("CARGO_OCUPADO_EXP_3", curriculo.CargoOcupadoExp3 ?? (object)DBNull.Value),
                new SqlParameter("DATA_INICIO_EXP_3", curriculo.DataInicioExp3 ?? (object)DBNull.Value),
                new SqlParameter("DATA_TERMINO_EXP_3", curriculo.DataTerminoExp3 ?? (object)DBNull.Value),

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