using DIController.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DIController.Controllers
{
    public class TodoController : Controller
    {
        private readonly ITodoItemRepository _todoItemRepository;

        public TodoController(ITodoItemRepository todoItemRepository)
        {
            _todoItemRepository = todoItemRepository;
        }
        public IActionResult Index()
        {
            return View(_todoItemRepository.List());
        }
    }
}
