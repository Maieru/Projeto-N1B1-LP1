using Microsoft.AspNetCore.Mvc;
using Projeto_N1B1_LP1.DAO;
using Projeto_N1B1_LP1.Models;
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

        public IActionResult Delete(int id)
        {
            try
            {
                var curriculoDAO = new CurriculoDAO();
                curriculoDAO.Delete(id);

                return RedirectToAction("Index");
            }
            catch (Exception erro)
            {
                return View("Error", erro);
            }
        }

        public IActionResult Create()
        {
            return View("Create");
        }

        public IActionResult Post(CurriculoViewModel curriculoViewModel, bool edicao)
        {
            try
            {
                var curriculoDAO = new CurriculoDAO();

                if (edicao)
                    curriculoDAO.Edit(curriculoViewModel);
                else
                    curriculoDAO.Insert(curriculoViewModel);

                return RedirectToAction("Index");
            }
            catch (Exception erro)
            {
                return View("Error", erro);
            }

        }

        public IActionResult Visualizar(int id)
        {
            var curriculoDAO = new CurriculoDAO();
            var model = curriculoDAO.Select(id);
            return View("Exibicao", model);
        }
    }
}
