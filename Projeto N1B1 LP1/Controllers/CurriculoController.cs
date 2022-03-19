using Microsoft.AspNetCore.Mvc;
using Projeto_N1B1_LP1.DAO;
using System;

namespace Projeto_N1B1_LP1.Controllers
{
    public class CurriculoController : Controller
    {
        public IActionResult Index()
        {
            try
            {
                var curriculoDAO = new CurriculoDAO();
                var model = curriculoDAO.SelectAll();

                return View("Index", model);
            }
            catch (Exception erro)
            {
                return View("Error", erro);
            }
        }
    }
}
