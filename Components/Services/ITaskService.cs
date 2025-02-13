using static SchoolWebApp.Components.Pages.HomePage;

namespace SchoolWebApp.Components.Services
{
    public interface ITaskService
    {
        public void Add(taskItem task);
        public void Delete(taskItem task);
        public void Edit(taskItem task);
        public List<taskItem> GetTaskList();
    }
}
