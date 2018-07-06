using System.Web.Mvc;
using first_project_calculator.TwoArgument;
using SelectListItem = System.Web.WebPages.Html.SelectListItem;

namespace WebApplication.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Operation = new SelectListItem[]
            {
                new SelectListItem()
                {
                    Value = "Multiply", Text ="Multiply"
                },
                new SelectListItem()
                {
                    Value = "Addition", Text ="Addition"
                },
                new SelectListItem()
                {
                    Value = "Subtraction", Text ="Subtraction"
                },
                new SelectListItem()
                {
                    Value = "Division", Text ="Division"
                }
            };
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpPost]
        public ActionResult Index(double firstArgument, double secondArgument, string operation)
        {
            ICalculatorTwoArguments calculator = CalculateTwoFactory.CreateCalculator(operation);
            double result = calculator.Calculate(firstArgument, secondArgument);
            ViewBag.Result = result;
            ViewBag.Operation = new SelectListItem[]
            {
                new SelectListItem()
                {
                    Value = "Multiply", Text ="Multiply"
                },
                new SelectListItem()
                {
                    Value = "Addition", Text ="Addition"
                },
                new SelectListItem()
                {
                    Value = "Subtraction", Text ="Subtraction"
                },
                new SelectListItem()
                {
                    Value = "Division", Text ="Division"
                }
            };
            return View();
        }
    }
}