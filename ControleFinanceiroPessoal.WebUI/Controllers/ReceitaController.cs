using ControleFinanceiroPessoal.Domain.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ControleFinanceiroPessoal.WebUI.Controllers
{
    public class ReceitaController : BaseController
    {
        private IRepositoryReceita repository;
        public ReceitaController(IRepositoryReceita repository) {
            this.repository = repository;
        }

        //
        // GET: /Receita/
        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /Receita/List
        public ActionResult List() {
            return View(this.repository.Receitas);
        }

        //
        // GET: /Receita/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Receita/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Receita/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Receita/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Receita/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Receita/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Receita/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
