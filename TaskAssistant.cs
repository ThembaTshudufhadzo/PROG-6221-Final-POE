// File: TaskAssistant.cs
using System.Collections.Generic;
using System.Text;

namespace CyberSecurityChatbotGUI // Ensure this matches your project's root namespace
{
    public class TaskAssistant
    {
        private List<string> _tasks = new List<string>();

        // Method to add a new task
        public void AddTask(string taskDescription)
        {
            _tasks.Add(taskDescription);
        }

        // Method to get all tasks as a formatted string
        public string GetTasks()
        {
            if (_tasks.Count == 0)
            {
                return "You have no tasks currently. Use 'add task [description]' to add one.";
            }

            StringBuilder sb = new StringBuilder("Your current tasks:\n");
            for (int i = 0; i < _tasks.Count; i++)
            {
                sb.AppendLine($"{i + 1}. {_tasks[i]}");
            }
            return sb.ToString();
        }

        // Method to mark a task as complete and remove it
        public string CompleteTask(int taskNumber)
        {
            if (taskNumber > 0 && taskNumber <= _tasks.Count)
            {
                string completedTask = _tasks[taskNumber - 1]; // Get task description
                _tasks.RemoveAt(taskNumber - 1); // Remove from list
                return $"Task '{completedTask}' marked as complete!";
            }
            return "Invalid task number. Please provide a valid number from your task list.";
        }

        // Method to delete a task
        public string DeleteTask(int taskNumber)
        {
            if (taskNumber > 0 && taskNumber <= _tasks.Count)
            {
                string deletedTask = _tasks[taskNumber - 1]; // Get task description
                _tasks.RemoveAt(taskNumber - 1); // Remove from list
                return $"Task '{deletedTask}' has been deleted.";
            }
            return "Invalid task number. Please provide a valid number from your task list.";
        }
    }
}