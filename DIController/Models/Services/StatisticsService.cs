using DIController.Interfaces;

namespace DIController.Models.Services
{
    public class StatisticsService
    {
        private readonly ITodoItemRepository _todoItemRepository;

        public StatisticsService(ITodoItemRepository todoItemRepository)
        {
            _todoItemRepository = todoItemRepository;
        }

        public int GetCount()
        {
            return _todoItemRepository.List().Count();
        }

        public int GetCompletedCount() 
        {
            return _todoItemRepository.List().Count(x=>x.IsDone);
        }

        public double GetAveragePriority() 
        {
            if (_todoItemRepository.List().Count() == 0) 
            { 
                return 0.0;
            }
            return _todoItemRepository.List().Average(x=>x.Priority);
        }
    }
}
