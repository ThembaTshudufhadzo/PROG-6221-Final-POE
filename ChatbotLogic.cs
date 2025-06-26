using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

namespace CyberSecurityChatbotGUI // IMPORTANT: Ensure this namespace matches your project's root namespace
{
    public enum ChatbotState
    {
        InitialGreeting,        // Chatbot just started, displays first message
        WaitingForName,         // Explicitly waiting for the user to type their name
        NormalChat,             // General conversation mode
        QuizMode,               // Currently running a quiz
        WaitingForTaskDetails,  // User said "add task", waiting for the description
        WaitingForTaskNumber_Complete, // User said "complete task", waiting for the number
        WaitingForTaskNumber_Delete    // User said "delete task", waiting for the number
    }

    public class ChatbotLogic
    {
        private readonly ChatbotResponses _responses;
        private string _userName;
        private ChatbotState _currentState;

        private readonly QuizGame _quizGame;
        private readonly TaskAssistant _taskAssistant;
        private readonly ActivityLog _activityLog;

        public ChatbotLogic()
        {
            _responses = new ChatbotResponses();
            _userName = "there";
            _currentState = ChatbotState.InitialGreeting;

            _quizGame = new QuizGame();
            _taskAssistant = new TaskAssistant();
            _activityLog = new ActivityLog();
        }

        public string GetInitialGreeting()
        {
            _currentState = ChatbotState.WaitingForName;
            _activityLog.LogActivity("Bot: Hello! I am your Cybersecurity Awareness Chatbot. Before we start, what's your name?");
            return "Hello! I am your Cybersecurity Awareness Chatbot. Before we start, what's your name?";
        }

        public string ProcessUserInput(string input)
        {
            _activityLog.LogActivity($"User: {input}");

            string response = string.Empty;
            string normalizedInput = input.ToLower().Trim();

            switch (_currentState)
            {
                case ChatbotState.WaitingForName:
                    if (!IsGeneralGreetingOrCommand(normalizedInput))
                    {
                        _userName = input;
                        _currentState = ChatbotState.NormalChat;
                        response = string.Format(_responses.GetResponse("name_set", _userName), _userName);
                    }
                    else
                    {
                        response = "I'm ready! Please tell me your name, then we can start discussing cybersecurity.";
                    }
                    break;

                case ChatbotState.QuizMode:
                    response = _quizGame.ProcessAnswer(input);
                    if (_quizGame.IsQuizFinished)
                    {
                        _activityLog.LogActivity($"Quiz completed. Score: {_quizGame.Score}/{_quizGame.TotalQuestions}");
                        _currentState = ChatbotState.NormalChat;
                    }
                    break;

                case ChatbotState.WaitingForTaskDetails:
                    if (!string.IsNullOrWhiteSpace(input))
                    {
                        _taskAssistant.AddTask(input);
                        _activityLog.LogActivity($"Task added: '{input}'");
                        _currentState = ChatbotState.NormalChat;
                        response = $"Okay {_userName}, I've added '{input}' to your tasks.";
                    }
                    else
                    {
                        response = $"It looks like you didn't provide a task description, {_userName}. Please try 'add task [your task here]' again.";
                        _currentState = ChatbotState.NormalChat;
                    }
                    break;

                case ChatbotState.WaitingForTaskNumber_Complete:
                case ChatbotState.WaitingForTaskNumber_Delete:
                    if (int.TryParse(input, out int taskNumber))
                    {
                        if (_currentState == ChatbotState.WaitingForTaskNumber_Complete)
                        {
                            response = _taskAssistant.CompleteTask(taskNumber);
                            if (!response.Contains("Invalid"))
                                _activityLog.LogActivity($"Task {taskNumber} completed by {_userName}.");
                        }
                        else
                        {
                            response = _taskAssistant.DeleteTask(taskNumber);
                            if (!response.Contains("Invalid"))
                                _activityLog.LogActivity($"Task {taskNumber} deleted by {_userName}.");
                        }
                        _currentState = ChatbotState.NormalChat;
                        response = $"{_userName}, " + response;
                    }
                    else
                    {
                        response = $"Sorry {_userName}, I need a valid task number (e.g., '1', '2'). Please try again.";
                        _currentState = ChatbotState.NormalChat;
                    }
                    break;

                case ChatbotState.NormalChat:
                default:
                    // --- Task-related commands ---
                    if (normalizedInput.Contains("add task"))
                    {
                        _currentState = ChatbotState.WaitingForTaskDetails;
                        response = string.Format(_responses.GetResponse("add task", _userName), _userName);
                    }
                    else if (normalizedInput.Contains("show tasks") || normalizedInput.Contains("view tasks"))
                    {
                        response = $"{_userName}, {_taskAssistant.GetTasks()}"; // This is where the task list is retrieved and personalized
                        _activityLog.LogActivity($"Tasks viewed by {_userName}.");
                    }
                    else if (normalizedInput.Contains("complete task"))
                    {
                        response = string.Format(_responses.GetResponse("complete task", _userName), _userName) + "\n" + _taskAssistant.GetTasks();
                        _currentState = ChatbotState.WaitingForTaskNumber_Complete;
                    }
                    else if (normalizedInput.Contains("delete task"))
                    {
                        response = string.Format(_responses.GetResponse("delete task", _userName), _userName) + "\n" + _taskAssistant.GetTasks();
                        _currentState = ChatbotState.WaitingForTaskNumber_Delete;
                    }
                    // --- Quiz command ---
                    else if (normalizedInput.Contains("start quiz"))
                    {
                        _quizGame.StartQuiz();
                        _currentState = ChatbotState.QuizMode;
                        response = string.Format(_responses.GetResponse("start quiz", _userName), _userName) + "\n" + _quizGame.GetNextQuestion();
                    }
                    // --- Activity Log command ---
                    else if (normalizedInput.Contains("show activity log") || normalizedInput.Contains("view activity log"))
                    {
                        response = _activityLog.GetActivityLog();
                    }
                    // --- General Greetings and Questions about the Chatbot ---
                    else if (normalizedInput.Contains("how are you"))
                    {
                        response = string.Format(_responses.GetResponse("how are you", _userName), _userName);
                    }
                    else if (normalizedInput.Contains("hi") || normalizedInput.Contains("hello") || normalizedInput.Contains("hey"))
                    {
                        response = string.Format(_responses.GetResponse("hello", _userName), _userName);
                    }
                    else if (normalizedInput.Contains("what can i ask you about"))
                    {
                        response = string.Format(_responses.GetResponse("what can i ask you about", _userName), _userName);
                    }
                    else if (normalizedInput.Contains("thanks") || normalizedInput.Contains("thank you"))
                    {
                        response = string.Format(_responses.GetResponse("positive_feedback", _userName), _userName);
                    }
                    // --- Keyword-based Topic Queries ---
                    else if (normalizedInput.Contains("password theft") || normalizedInput.Contains("password theaft"))
                    {
                        response = string.Format(_responses.GetResponse("what is password theft", _userName), _userName);
                    }
                    else if (normalizedInput.Contains("password safety"))
                    {
                        response = string.Format(_responses.GetResponse("password safety overview", _userName), _userName);
                    }
                    else if (normalizedInput.Contains("phishing"))
                    {
                        response = string.Format(_responses.GetResponse("phishing overview", _userName), _userName);
                    }
                    else if (normalizedInput.Contains("malware"))
                    {
                        response = string.Format(_responses.GetResponse("malware overview", _userName), _userName);
                    }
                    else if (normalizedInput.Contains("social engineering"))
                    {
                        response = string.Format(_responses.GetResponse("social engineering overview", _userName), _userName);
                    }
                    else if (normalizedInput.Contains("data privacy"))
                    {
                        response = string.Format(_responses.GetResponse("data privacy overview", _userName), _userName);
                    }
                    else if (normalizedInput.Contains("network security"))
                    {
                        response = string.Format(_responses.GetResponse("network security overview", _userName), _userName);
                    }
                    else if (normalizedInput.Contains("incident response"))
                    {
                        response = string.Format(_responses.GetResponse("incident response overview", _userName), _userName);
                    }
                    else if (normalizedInput.Contains("safe browse"))
                    {
                        response = string.Format(_responses.GetResponse("safe browse overview", _userName), _userName);
                    }
                    // Fallback to general GetResponse if no specific topic/command matched
                    else
                    {
                        response = _responses.GetResponse(input, _userName);
                    }
                    break;
            }

            _activityLog.LogActivity($"Bot: {response}");
            return response;
        }

        private bool IsGeneralGreetingOrCommand(string normalizedInput)
        {
            string[] commandsAndGreetings = {
                "hi", "hello", "hey", "how are you", "start quiz", "add task",
                "show tasks", "view tasks", "complete task", "delete task",
                "show activity log", "view activity log", "what can i ask you about",
                "password safety", "phishing", "malware", "social engineering",
                "data privacy", "network security", "incident response", "safe browse",
                "thanks", "thank you"
            };

            return commandsAndGreetings.Any(keyword => normalizedInput.Contains(keyword));
        }

        public QuizGame GetQuizGameInstance() => _quizGame;
        public TaskAssistant GetTaskAssistantInstance() => _taskAssistant;
        public ActivityLog GetActivityLogInstance() => _activityLog;
    }
}