using DIController.Models;

namespace DIController.Interfaces
{
    public interface ITodoItemRepository
    {
        IEnumerable<TodoItem> List();
    }
}
