using System.Diagnostics;
using static SchoolWebApp.Components.Pages.HomePage;

namespace SchoolWebApp.Components.Services
{
    public class TaskService : ITaskService
    {
        private List<taskItem> taskList;
        public TaskService()
        {
            taskList = new List<taskItem>();
            taskList.Add(new taskItem("Task 1", "This is the first task"));
            taskList.Add(new taskItem("Task 2", "This is the second task"));
            taskList.Add(new taskItem("Task 3", "Lorem ipsum aaaaaaaaa aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa "));
            taskList.Add(new taskItem("Task 3", "Lorem ipsum aaaaaaaaa"));
        }
        public void Add(taskItem task)
        {
            taskList.Add(task);
        }
        public void Delete(taskItem task)
        {
            Console.WriteLine("Task Deleted in service");
            taskList.Remove(task);
        }
        public void Edit(taskItem task)
        {
            taskList[taskList.IndexOf(task)] = task;
        }

        public List<taskItem> GetTaskList()
        {
            return taskList;
        }
    }
}
