using hyundaiClient.Models;
using Microsoft.AspNetCore.Mvc;

namespace hyundaiClient.Controllers
{
    public class CarsController : Controller
    {
        private readonly APIGateway apiGateway;

        public CarsController(APIGateway ApiGateway)
        {
            this.apiGateway = ApiGateway;
        }
        

        public IActionResult Index()
        {
            List<Cars> cars;
            cars = apiGateway.ListCars();
            return View(cars);
        }

        [HttpGet]
        public IActionResult Create()
        {
            Cars cars = new Cars();
            return View(cars);
        }
        [HttpPost]
        public IActionResult Create(Cars cars)
        {
            apiGateway.CreateCars(cars);
            return RedirectToAction("Index");
        }

        public IActionResult Details(int Id)
        {
            Cars cars = new Cars();
            cars = apiGateway.GetCars(Id);
            return View(cars);
        }

        [HttpGet]
        public IActionResult Edit(int Id)
        {
            Cars cars;
            cars = apiGateway.GetCars(Id);
            return View(cars);
        }
        [HttpPost]
        public IActionResult Edit(Cars cars)
        {
            apiGateway.UpdateCars(cars);
            return RedirectToAction("index");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            Cars cars;
            cars = apiGateway.GetCars(id);
            return View(cars);
        }
        [HttpPost]
        public IActionResult Delete(Cars cars)
        {
            apiGateway.DeleteCars(cars.id);
            return RedirectToAction("index");
        }
    }
}
