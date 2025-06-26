using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using CyberSecurityChatbotAppGUI; // Assuming helper classes like PlayAudioSound and ConvertToAciiArt are here

namespace CyberSecurityChatbotGUI // Main application namespace
{
    public partial class Form1 : Form
    {
        private readonly ChatbotLogic _chatbotLogic;

        public Form1()
        {
            InitializeComponent();
            _chatbotLogic = new ChatbotLogic();
            SetupChatbotUI();
        }

        private void SetupChatbotUI()
        {
            // Wire up the Enter key press in the user input textbox
            if (this.userInputTextBox != null)
                this.userInputTextBox.KeyPress += UserInputTextBox_KeyPress;

            // Wire up the 'Send' button click event
            if (this.sendButton != null)
                this.sendButton.Click += SendButton_Click;

            // Wire up the 'Play Greeting' button click event.
            if (this.playGreetingButton != null)
                this.playGreetingButton.Click += PlayGreetingButton_Click;

            // Wire up the feature buttons
            if (this.taskAssistantButton != null)
                this.taskAssistantButton.Click += TaskAssistantButton_Click;
            if (this.quizGameButton != null)
                this.quizGameButton.Click += QuizGameButton_Click;
            if (this.activityLogButton != null)
                this.activityLogButton.Click += ActivityLogButton_Click;
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            // --- Part 1: Play the greeting audio asynchronously ---
            try
            {
                await Task.Run(() =>
                {
                    try
                    {
                        // Uncomment the line below if PlayAudioSound class and PlayGreeting method exist
                        // CyberSecurityChatbotAppGUI.PlayAudioSound.PlayGreeting();
                        System.Diagnostics.Debug.WriteLine("Audio greeting would play here.");
                    }
                    catch (Exception audioEx)
                    {
                        System.Diagnostics.Debug.WriteLine($"Audio error: {audioEx.Message}");
                    }
                });
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in Form1_Load audio task: {ex.Message}");
            }

            // --- Part 2: Display ASCII logo and Header ---
            // Adjust this path if your resources are located elsewhere
            string imagePath = Path.Combine(Application.StartupPath, "Resources", "240_F_1212527373_7UGNf8hJ3dLvyXR6AVXZLSQZhy5jnsfR.jpg");
            string asciiArt = string.Empty;

            try
            {
                // Ensure CyberSecurityChatbotAppGUI.ConvertToAciiArt.ConvertImageToASCII is correctly implemented
                asciiArt = CyberSecurityChatbotAppGUI.ConvertToAciiArt.ConvertImageToASCII(imagePath, 60); // 60 is example width
            }
            catch (FileNotFoundException)
            {
                System.Diagnostics.Debug.WriteLine($"Image file not found: {imagePath}. Make sure it's in a 'Resources' folder and 'Copy to Output Directory' is set.");
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error converting image to ASCII: {ex.Message}");
            }

            // Display ASCII art in its dedicated RichTextBox (asciiArtDisplay)
            if (this.asciiArtDisplay != null)
            {
                if (!string.IsNullOrEmpty(asciiArt))
                {
                    this.asciiArtDisplay.Text = asciiArt;
                }
                else
                {
                    this.asciiArtDisplay.Text = "     -- CyberSecurity Awareness Bot --\n     (ASCII Art Not Loaded or Error)";
                }
                this.asciiArtDisplay.SelectionStart = 0;
                this.asciiArtDisplay.SelectionLength = 0;
            }

            // Set the main title label (MainTitleLabel)
            if (this.MainTitleLabel != null)
            {
                this.MainTitleLabel.Text = "CyberSecurity Awareness Bot";
            }

            // Set the divider label (dividerLabel)
            if (this.dividerLabel != null)
            {
                this.dividerLabel.Text = "__________________________________";
            }

            // --- Part 3: Display Initial Chat Messages ---
            AppendBotMessage(_chatbotLogic.GetInitialGreeting());
        }

        private void AppendBotMessage(string message)
        {
            if (chatDisplayRitchTextBox == null)
            {
                System.Diagnostics.Debug.WriteLine("chatDisplayRitchTextBox is null!");
                return;
            }

            if (chatDisplayRitchTextBox.InvokeRequired)
            {
                chatDisplayRitchTextBox.Invoke(new Action(() =>
                {
                    chatDisplayRitchTextBox.SelectionColor = Color.Blue; // Bot messages in blue
                    chatDisplayRitchTextBox.AppendText($"Bot: {message}\n");
                    chatDisplayRitchTextBox.SelectionColor = chatDisplayRitchTextBox.ForeColor; // Reset color
                    chatDisplayRitchTextBox.ScrollToCaret();
                }));
            }
            else
            {
                chatDisplayRitchTextBox.SelectionColor = Color.Blue; // Bot messages in blue
                chatDisplayRitchTextBox.AppendText($"Bot: {message}\n");
                chatDisplayRitchTextBox.SelectionColor = chatDisplayRitchTextBox.ForeColor; // Reset color
                chatDisplayRitchTextBox.ScrollToCaret();
            }
        }

        private void AppendUserMessage(string message)
        {
            if (chatDisplayRitchTextBox == null)
            {
                System.Diagnostics.Debug.WriteLine("chatDisplayRitchTextBox is null!");
                return;
            }

            if (chatDisplayRitchTextBox.InvokeRequired)
            {
                chatDisplayRitchTextBox.Invoke(new Action(() =>
                {
                    chatDisplayRitchTextBox.SelectionColor = Color.Green; // User messages in green
                    chatDisplayRitchTextBox.AppendText($"You: {message}\n");
                    chatDisplayRitchTextBox.SelectionColor = chatDisplayRitchTextBox.ForeColor; // Reset color
                    chatDisplayRitchTextBox.ScrollToCaret();
                }));
            }
            else
            {
                chatDisplayRitchTextBox.SelectionColor = Color.Green; // User messages in green
                chatDisplayRitchTextBox.AppendText($"You: {message}\n");
                chatDisplayRitchTextBox.SelectionColor = chatDisplayRitchTextBox.ForeColor; // Reset color
                chatDisplayRitchTextBox.ScrollToCaret();
            }
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            ProcessUserInput();
        }

        private void UserInputTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                ProcessUserInput();
                e.Handled = true; // Suppress the "ding" sound
            }
        }

        private void ProcessUserInput()
        {
            if (userInputTextBox == null)
            {
                System.Diagnostics.Debug.WriteLine("userInputTextBox is null!");
                return;
            }

            string input = userInputTextBox.Text.Trim();
            if (string.IsNullOrWhiteSpace(input))
            {
                return; // Do nothing if input is empty
            }

            AppendUserMessage(input);
            userInputTextBox.Clear();

            try
            {
                string botResponse = _chatbotLogic.ProcessUserInput(input);
                AppendBotMessage(botResponse);
            }
            catch (Exception ex)
            {
                AppendBotMessage($"Sorry, I encountered an error: {ex.Message}");
                System.Diagnostics.Debug.WriteLine($"Error processing input: {ex}");
            }
        }

        private async void PlayGreetingButton_Click(object sender, EventArgs e)
        {
            try
            {
                await Task.Run(() =>
                {
                    try
                    {
                        // Uncomment if your PlayAudioSound class is ready
                        CyberSecurityChatbotAppGUI.PlayAudioSound.PlayGreeting();
                        System.Diagnostics.Debug.WriteLine("Greeting audio played on button click.");
                    }
                    catch (Exception audioEx)
                    {
                        System.Diagnostics.Debug.WriteLine($"Audio error: {audioEx.Message}");
                    }
                });
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in PlayGreetingButton_Click: {ex.Message}");
            }
        }

        // --- FEATURE BUTTON IMPLEMENTATIONS ---
        private void TaskAssistantButton_Click(object sender, EventArgs e)
        {
            AppendBotMessage("Opening Task Assistant interface...");
            TaskAssistant taskAssistantInstance = _chatbotLogic.GetTaskAssistantInstance();

            using (TaskAssistantForm taskForm = new TaskAssistantForm(taskAssistantInstance))
            {
                taskForm.ShowDialog(); // ShowDialog makes it a modal dialog (blocks main form until closed)
            }
        }

        private void QuizGameButton_Click(object sender, EventArgs e)
        {
            AppendBotMessage("Initiating Quiz Game...");
            // When the Quiz Game button is clicked, we essentially tell the chatbot to "start quiz"
            // This will transition the chatbot's state and provide the first question.
            string quizResponse = _chatbotLogic.ProcessUserInput("start quiz");
            AppendBotMessage(quizResponse);
        }

        private void ActivityLogButton_Click(object sender, EventArgs e)
        {
            AppendBotMessage("Requesting Activity Log...");
            // When the Activity Log button is clicked, we tell the chatbot to "show activity log"
            string logResponse = _chatbotLogic.ProcessUserInput("show activity log");
            AppendBotMessage(logResponse);
        }
    }
}