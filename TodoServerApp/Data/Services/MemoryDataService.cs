using TodoServerApp.Data.Interfaces;
namespace TodoServerApp.Data.Services
{
    public class MemoryDataService : IDateService
    {
        private static IEnumerable<TaskItem> tasks = [
        new () {Id = 1, Title = "Task1", Description = "TaskDescription", CreatedDate = DateTime.Now},
        new () {Id = 2, Title = "Task2", Description = "TaskDescription", CreatedDate = DateTime.Now},
        new () {Id = 3, Title = "Task3", Description = "TaskDescription", CreatedDate = DateTime.Now},
        ];

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TaskItem>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<TaskItem> GetAllSync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<TaskItem> GetTaskAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<TaskItem>> GetTaskItemsAsync()
        {
            await Task.Delay(1000);
            return await Task.FromResult(tasks);
        }

        public Task SaveAsync(TaskItem item)
        {
            throw new NotImplementedException();
        }
    }
}
