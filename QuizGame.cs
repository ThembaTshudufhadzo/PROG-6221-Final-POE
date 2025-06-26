using System;
using System.Collections.Generic;
using System.Linq; // For .OrderBy and .Take
using System.Text;

namespace CyberSecurityChatbotGUI // Or your main project namespace
{
    public class QuizGame
    {
        private List<QuizQuestion> _allQuestions; // All available questions
        private List<QuizQuestion> _currentQuizQuestions; // Subset for the current quiz
        private int _currentQuestionIndex;
        private int _score;
        private Random _random;
        private bool _quizInProgress;
        public int TotalQuestions { get; private set; } // Property to expose total questions

        public int Score => _score; // Property to expose current score
        public bool IsQuizFinished => !_quizInProgress && _currentQuestionIndex >= TotalQuestions;

        public QuizGame()
        {
            InitializeAllQuestions();
            _random = new Random();
            ResetQuiz();
        }

        private void InitializeAllQuestions()
        {
            _allQuestions = new List<QuizQuestion>
            {
                new QuizQuestion("What is 'phishing' in cybersecurity?",
                                 new List<string> { "A. A type of malware", "B. A method of tricking people into revealing information", "C. A secure Browse protocol" },
                                 "B"),
                new QuizQuestion("Which of these is a characteristic of a strong password?",
                                 new List<string> { "A. Easy to remember", "B. Uses your birthdate", "C. Long and complex, mixing characters" },
                                 "C"),
                new QuizQuestion("What is the primary purpose of antivirus software?",
                                 new List<string> { "A. To speed up your computer", "B. To protect against malicious software", "C. To manage your files" },
                                 "B"),
                new QuizQuestion("What does 'MFA' stand for in cybersecurity?",
                                 new List<string> { "A. Malware Functionality Analysis", "B. Multi-Factor Authentication", "C. Main Firewall Access" },
                                 "B"),
                new QuizQuestion("Which of these is a common sign of a phishing email?",
                                 new List<string> { "A. Perfect grammar and spelling", "B. An urgent request for personal information", "C. A sender you recognize and trust" },
                                 "B"),
                new QuizQuestion("What is the best way to secure your home Wi-Fi network?",
                                 new List<string> { "A. Use the default password", "B. Hide the network name (SSID)", "C. Use a strong, unique password and WPA3 encryption" },
                                 "C"),
                new QuizQuestion("What is ransomware?",
                                 new List<string> { "A. Software that helps you organize files", "B. Malware that encrypts your files and demands payment", "C. A tool for secure online shopping" },
                                 "B")
            };
        }

        public void ResetQuiz()
        {
            _currentQuestionIndex = 0;
            _score = 0;
            _quizInProgress = false;
            // Select a random subset of questions for the current quiz
            TotalQuestions = Math.Min(5, _allQuestions.Count); // Take up to 5 questions
            _currentQuizQuestions = _allQuestions.OrderBy(q => _random.Next()).Take(TotalQuestions).ToList();
        }

        public string StartQuiz()
        {
            ResetQuiz(); // Ensure quiz is reset before starting
            _quizInProgress = true;
            return GetNextQuestion(); // Returns the first question
        }

        public string GetNextQuestion()
        {
            if (_currentQuestionIndex < TotalQuestions)
            {
                var question = _currentQuizQuestions[_currentQuestionIndex];
                StringBuilder sb = new StringBuilder();
                sb.AppendLine($"Question {_currentQuestionIndex + 1}/{TotalQuestions}: {question.QuestionText}");
                foreach (var option in question.Options)
                {
                    sb.AppendLine(option);
                }
                return sb.ToString();
            }
            else
            {
                _quizInProgress = false;
                return "Quiz finished!"; // Should not be reached if IsQuizFinished check is prior
            }
        }

        public string ProcessAnswer(string userAnswer)
        {
            if (!_quizInProgress || _currentQuestionIndex >= TotalQuestions)
            {
                return "No quiz in progress or quiz already finished. Type 'start quiz' to begin a new one.";
            }

            var currentQuestion = _currentQuizQuestions[_currentQuestionIndex];
            string feedback;

            // Normalize user answer (e.g., "a", "A", "b.")
            string normalizedAnswer = userAnswer.Trim().ToUpper();
            if (normalizedAnswer.EndsWith("."))
            {
                normalizedAnswer = normalizedAnswer.TrimEnd('.');
            }

            if (normalizedAnswer == currentQuestion.CorrectAnswer.ToUpper())
            {
                _score++;
                feedback = "Correct!";
            }
            else
            {
                feedback = $"Incorrect. The correct answer was {currentQuestion.CorrectAnswer}.";
            }

            _currentQuestionIndex++;

            if (_currentQuestionIndex < TotalQuestions)
            {
                return $"{feedback}\n{GetNextQuestion()}"; // Return feedback and the next question
            }
            else
            {
                _quizInProgress = false; // Mark quiz as finished
                return $"{feedback}"; // Final feedback will be given by ChatbotLogic
            }
        }

        public string GetFinalFeedback()
        {
            if (_score == TotalQuestions)
            {
                return "\nExcellent! You have solid cybersecurity knowledge! 👏";
            }
            else if (_score >= TotalQuestions / 2)
            {
                return "\nGood job! You have a decent understanding of cybersecurity, keep learning! 👍";
            }
            else
            {
                return "\nKeep studying! There's always more to learn about cybersecurity. 📚";
            }
        }
    }

    public class QuizQuestion
    {
        public string QuestionText { get; }
        public List<string> Options { get; }
        public string CorrectAnswer { get; }

        public QuizQuestion(string questionText, List<string> options, string correctAnswer)
        {
            QuestionText = questionText;
            Options = options;
            CorrectAnswer = correctAnswer;
        }
    }
}