using Calculator_App.Data;
using Calculator_App.Models;
using Calculator_App.Models.db;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace Calculator_App.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private DataContext Context;
        private CalcHistoryRepository Repository;
        private OperationsContext Operations;

        public HomeController(ILogger<HomeController> logger, DataContext context)
        {
            _logger = logger;
            this.Context = context;
            this.Repository = new CalcHistoryRepository(context);
            this.Operations = new OperationsContext();
        }

        public IActionResult Index()
        {
            IEnumerable<Calculation> history = this.Repository.FindLatest();

            return View(history);
        }

        [HttpGet]
        public IActionResult GetPartial()
        {       
            IEnumerable<Calculation> history = this.Repository.FindLatest();
            
            return PartialView("_HistoryViewPartial", history);
        }
        [HttpPost]
        public IActionResult Calculate(Calculator c)
        {

            double result = Operations.Calculate(c);

            Calculation calc = new Calculation()
            {
                ValueA = c.ValueA,
                ValueB = c.ValueB,
                Operation = c.Operation,
                Result = result,
                Date = DateTime.Now
            };
            this.Repository.CreateRecord(calc);

            return Json(result);

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}