using DIController.Interfaces;
using DIController.Models;

namespace DIController.Infrastructure
{
    public class TodoItemRepository : ITodoItemRepository
    {
        private static List<TodoItem> _item = new();

        static TodoItemRepository()
        {
            for(int i = 0; i < 10; i++)
            {
                _item.Add(new TodoItem()
                {
                    IsDone = i % 3 == 0,
                    Name = "Task " + (i + 1),
                    Priority = i % 5 + 1
                });
            }
        }

        public IEnumerable<TodoItem> List()
        {
            return _item.AsEnumerable();      
        }
    }
}
