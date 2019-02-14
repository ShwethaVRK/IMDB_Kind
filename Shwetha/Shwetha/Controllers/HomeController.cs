using System.Web.Mvc;
using Shwetha.EF.ShwethaService;

namespace Shwetha.Controllers
{
    public class HomeController : Controller
    {
        #region Private member variables

        private readonly ShwethaService _ShwethaService;

        #endregion

        #region Public Constructor

        /// <summary>
        /// Public constructor to initialize ShwethaService instance
        /// </summary>
        public HomeController()
        {
            _ShwethaService = new ShwethaService();
        }

        #endregion

        public ActionResult Index()
        {
            var listOfMovies = _ShwethaService.GetListOfMovies();
            return View(listOfMovies);
        }

        public JsonResult ShowGridData()
        {
            var listOfMovies = _ShwethaService.GetListOfMovies();
            return Json(listOfMovies, JsonRequestBehavior.AllowGet);
        }

        public JsonResult ShowMovieData(int pkMovieId)
        {
            if (pkMovieId < 0)
            {
                return null;
            }
            var data = _ShwethaService.GetMovieDetailsById(pkMovieId);
            return Json(data, JsonRequestBehavior.AllowGet);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Shwetha IMDB consists the information of new released movies and actors";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact Us:";

            return View();
        }
    }
}