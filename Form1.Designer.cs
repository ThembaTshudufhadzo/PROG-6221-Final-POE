namespace CyberSecurityChatbotGUI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainLayout = new System.Windows.Forms.TableLayoutPanel();
            this.headerpanel = new System.Windows.Forms.Panel();
            this.chatDisplayRitchTextBox = new System.Windows.Forms.RichTextBox();
            this.dividerLabel = new System.Windows.Forms.Label();
            this.MainTitleLabel = new System.Windows.Forms.Label();
            this.asciiArtDisplay = new System.Windows.Forms.RichTextBox();
            this.inputAndButtonLayout = new System.Windows.Forms.TableLayoutPanel();
            this.userInputTextBox = new System.Windows.Forms.TextBox();
            this.sendButton = new System.Windows.Forms.Button();
            this.featureButtonLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.playGreetingButton = new System.Windows.Forms.Button();
            this.taskAssistantButton = new System.Windows.Forms.Button();
            this.quizGameButton = new System.Windows.Forms.Button();
            this.activityLogButton = new System.Windows.Forms.Button();
            this.mainLayout.SuspendLayout();
            this.headerpanel.SuspendLayout();
            this.inputAndButtonLayout.SuspendLayout();
            this.featureButtonLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainLayout
            // 
            this.mainLayout.BackColor = System.Drawing.Color.Transparent;
            this.mainLayout.ColumnCount = 2;
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.58824F));
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.41176F));
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.mainLayout.Controls.Add(this.headerpanel, 0, 1);
            this.mainLayout.Controls.Add(this.inputAndButtonLayout, 0, 2);
            this.mainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainLayout.Location = new System.Drawing.Point(0, 0);
            this.mainLayout.Name = "mainLayout";
            this.mainLayout.RowCount = 3;
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 81.1784F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.8216F));
            this.mainLayout.Size = new System.Drawing.Size(834, 611);
            this.mainLayout.TabIndex = 5;
            // 
            // headerpanel
            // 
            this.mainLayout.SetColumnSpan(this.headerpanel, 2);
            this.headerpanel.Controls.Add(this.chatDisplayRitchTextBox);
            this.headerpanel.Controls.Add(this.dividerLabel);
            this.headerpanel.Controls.Add(this.MainTitleLabel);
            this.headerpanel.Controls.Add(this.asciiArtDisplay);
            this.headerpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.headerpanel.Location = new System.Drawing.Point(3, 3);
            this.headerpanel.Name = "headerpanel";
            this.headerpanel.Size = new System.Drawing.Size(828, 490);
            this.headerpanel.TabIndex = 0;
            // 
            // chatDisplayRitchTextBox
            // 
            this.chatDisplayRitchTextBox.BackColor = System.Drawing.Color.White;
            this.chatDisplayRitchTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chatDisplayRitchTextBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chatDisplayRitchTextBox.Location = new System.Drawing.Point(0, 329);
            this.chatDisplayRitchTextBox.Name = "chatDisplayRitchTextBox";
            this.chatDisplayRitchTextBox.ReadOnly = true;
            this.chatDisplayRitchTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.chatDisplayRitchTextBox.Size = new System.Drawing.Size(828, 161);
            this.chatDisplayRitchTextBox.TabIndex = 3;
            this.chatDisplayRitchTextBox.Text = "";
            // 
            // dividerLabel
            // 
            this.dividerLabel.AutoSize = true;
            this.dividerLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.dividerLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dividerLabel.ForeColor = System.Drawing.Color.Gray;
            this.dividerLabel.Location = new System.Drawing.Point(0, 314);
            this.dividerLabel.Name = "dividerLabel";
            this.dividerLabel.Size = new System.Drawing.Size(402, 15);
            this.dividerLabel.TabIndex = 2;
            this.dividerLabel.Text = "_______________________________________________________________________________";
            this.dividerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainTitleLabel
            // 
            this.MainTitleLabel.AutoSize = true;
            this.MainTitleLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MainTitleLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainTitleLabel.ForeColor = System.Drawing.Color.Blue;
            this.MainTitleLabel.Location = new System.Drawing.Point(0, 279);
            this.MainTitleLabel.Name = "MainTitleLabel";
            this.MainTitleLabel.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.MainTitleLabel.Size = new System.Drawing.Size(312, 35);
            this.MainTitleLabel.TabIndex = 1;
            this.MainTitleLabel.Text = "**CyberSecuriity Awareness Bot**";
            this.MainTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // asciiArtDisplay
            // 
            this.asciiArtDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.asciiArtDisplay.Dock = System.Windows.Forms.DockStyle.Top;
            this.asciiArtDisplay.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.asciiArtDisplay.Location = new System.Drawing.Point(0, 0);
            this.asciiArtDisplay.Name = "asciiArtDisplay";
            this.asciiArtDisplay.ReadOnly = true;
            this.asciiArtDisplay.Size = new System.Drawing.Size(828, 279);
            this.asciiArtDisplay.TabIndex = 0;
            this.asciiArtDisplay.Text = "";
            // 
            // inputAndButtonLayout
            // 
            this.inputAndButtonLayout.ColumnCount = 2;
            this.mainLayout.SetColumnSpan(this.inputAndButtonLayout, 2);
            this.inputAndButtonLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.inputAndButtonLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.inputAndButtonLayout.Controls.Add(this.userInputTextBox, 0, 0);
            this.inputAndButtonLayout.Controls.Add(this.sendButton, 1, 0);
            this.inputAndButtonLayout.Controls.Add(this.featureButtonLayout, 0, 1);
            this.inputAndButtonLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputAndButtonLayout.Location = new System.Drawing.Point(3, 499);
            this.inputAndButtonLayout.Name = "inputAndButtonLayout";
            this.inputAndButtonLayout.RowCount = 2;
            this.inputAndButtonLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.35808F));
            this.inputAndButtonLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 57.64192F));
            this.inputAndButtonLayout.Size = new System.Drawing.Size(828, 109);
            this.inputAndButtonLayout.TabIndex = 1;
            // 
            // userInputTextBox
            // 
            this.userInputTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userInputTextBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userInputTextBox.Location = new System.Drawing.Point(5, 5);
            this.userInputTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.userInputTextBox.Name = "userInputTextBox";
            this.userInputTextBox.Size = new System.Drawing.Size(569, 25);
            this.userInputTextBox.TabIndex = 0;
            this.userInputTextBox.Text = "\"Type your Message here...\"";
            // 
            // sendButton
            // 
            this.sendButton.BackColor = System.Drawing.Color.LightGreen;
            this.sendButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sendButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sendButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendButton.ForeColor = System.Drawing.Color.White;
            this.sendButton.Location = new System.Drawing.Point(584, 5);
            this.sendButton.Margin = new System.Windows.Forms.Padding(5);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(239, 36);
            this.sendButton.TabIndex = 1;
            this.sendButton.Text = "Send";
            this.sendButton.UseVisualStyleBackColor = false;
            // 
            // featureButtonLayout
            // 
            this.featureButtonLayout.AutoScroll = true;
            this.inputAndButtonLayout.SetColumnSpan(this.featureButtonLayout, 2);
            this.featureButtonLayout.Controls.Add(this.playGreetingButton);
            this.featureButtonLayout.Controls.Add(this.taskAssistantButton);
            this.featureButtonLayout.Controls.Add(this.quizGameButton);
            this.featureButtonLayout.Controls.Add(this.activityLogButton);
            this.featureButtonLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.featureButtonLayout.Location = new System.Drawing.Point(3, 49);
            this.featureButtonLayout.Name = "featureButtonLayout";
            this.featureButtonLayout.Padding = new System.Windows.Forms.Padding(5);
            this.featureButtonLayout.Size = new System.Drawing.Size(822, 57);
            this.featureButtonLayout.TabIndex = 2;
            // 
            // playGreetingButton
            // 
            this.playGreetingButton.BackColor = System.Drawing.Color.LightBlue;
            this.playGreetingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playGreetingButton.ForeColor = System.Drawing.Color.White;
            this.playGreetingButton.Location = new System.Drawing.Point(10, 10);
            this.playGreetingButton.Margin = new System.Windows.Forms.Padding(5);
            this.playGreetingButton.Name = "playGreetingButton";
            this.playGreetingButton.Size = new System.Drawing.Size(120, 35);
            this.playGreetingButton.TabIndex = 0;
            this.playGreetingButton.Text = "Play Greeting";
            this.playGreetingButton.UseVisualStyleBackColor = false;
            // 
            // taskAssistantButton
            // 
            this.taskAssistantButton.BackColor = System.Drawing.Color.LightCoral;
            this.taskAssistantButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.taskAssistantButton.ForeColor = System.Drawing.Color.Black;
            this.taskAssistantButton.Location = new System.Drawing.Point(140, 10);
            this.taskAssistantButton.Margin = new System.Windows.Forms.Padding(5);
            this.taskAssistantButton.Name = "taskAssistantButton";
            this.taskAssistantButton.Size = new System.Drawing.Size(120, 35);
            this.taskAssistantButton.TabIndex = 1;
            this.taskAssistantButton.Text = "Tasks";
            this.taskAssistantButton.UseVisualStyleBackColor = false;
            // 
            // quizGameButton
            // 
            this.quizGameButton.BackColor = System.Drawing.Color.LightSalmon;
            this.quizGameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.quizGameButton.ForeColor = System.Drawing.Color.White;
            this.quizGameButton.Location = new System.Drawing.Point(270, 10);
            this.quizGameButton.Margin = new System.Windows.Forms.Padding(5);
            this.quizGameButton.Name = "quizGameButton";
            this.quizGameButton.Size = new System.Drawing.Size(120, 35);
            this.quizGameButton.TabIndex = 2;
            this.quizGameButton.Text = "Quiz";
            this.quizGameButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.quizGameButton.UseVisualStyleBackColor = false;
            // 
            // activityLogButton
            // 
            this.activityLogButton.BackColor = System.Drawing.Color.LightGray;
            this.activityLogButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.activityLogButton.ForeColor = System.Drawing.Color.Black;
            this.activityLogButton.Location = new System.Drawing.Point(400, 10);
            this.activityLogButton.Margin = new System.Windows.Forms.Padding(5);
            this.activityLogButton.Name = "activityLogButton";
            this.activityLogButton.Size = new System.Drawing.Size(120, 35);
            this.activityLogButton.TabIndex = 3;
            this.activityLogButton.Text = "Activity Log";
            this.activityLogButton.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 611);
            this.Controls.Add(this.mainLayout);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CyberSecurityChatBot";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.mainLayout.ResumeLayout(false);
            this.headerpanel.ResumeLayout(false);
            this.headerpanel.PerformLayout();
            this.inputAndButtonLayout.ResumeLayout(false);
            this.inputAndButtonLayout.PerformLayout();
            this.featureButtonLayout.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel mainLayout;
        private System.Windows.Forms.Panel headerpanel;
        private System.Windows.Forms.RichTextBox asciiArtDisplay;
        private System.Windows.Forms.Label MainTitleLabel;
        private System.Windows.Forms.Label dividerLabel;
        private System.Windows.Forms.RichTextBox chatDisplayRitchTextBox;
        private System.Windows.Forms.TableLayoutPanel inputAndButtonLayout;
        private System.Windows.Forms.TextBox userInputTextBox;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.FlowLayoutPanel featureButtonLayout;
        private System.Windows.Forms.Button playGreetingButton;
        private System.Windows.Forms.Button taskAssistantButton;
        private System.Windows.Forms.Button activityLogButton;
        private System.Windows.Forms.Button quizGameButton;
    }
}

