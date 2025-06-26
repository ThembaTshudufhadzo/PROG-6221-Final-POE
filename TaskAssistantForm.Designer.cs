// File: TaskAssistantForm.Designer.cs
namespace CyberSecurityChatbotGUI // Ensure this matches your project's root namespace
{
    partial class TaskAssistantForm
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
            this.txtNewTask = new System.Windows.Forms.TextBox();
            this.btnAddTask = new System.Windows.Forms.Button();
            this.lstTasks = new System.Windows.Forms.ListBox();
            this.btnCompleteTask = new System.Windows.Forms.Button();
            this.btnDeleteTask = new System.Windows.Forms.Button();
            this.SuspendLayout();
            //
            // txtNewTask
            //
            this.txtNewTask.Location = new System.Drawing.Point(12, 12);
            this.txtNewTask.Name = "txtNewTask";
            this.txtNewTask.Size = new System.Drawing.Size(200, 20);
            this.txtNewTask.TabIndex = 0;
            //
            // btnAddTask
            //
            this.btnAddTask.Location = new System.Drawing.Point(218, 10);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(100, 23);
            this.btnAddTask.TabIndex = 1;
            this.btnAddTask.Text = "Add Task";
            this.btnAddTask.UseVisualStyleBackColor = true;
            this.btnAddTask.Click += new System.EventHandler(this.btnAddTask_Click);
            //
            // lstTasks
            //
            this.lstTasks.FormattingEnabled = true;
            this.lstTasks.Location = new System.Drawing.Point(12, 45);
            this.lstTasks.Name = "lstTasks";
            this.lstTasks.Size = new System.Drawing.Size(306, 160);
            this.lstTasks.TabIndex = 2;
            //
            // btnCompleteTask
            //
            this.btnCompleteTask.Location = new System.Drawing.Point(12, 211);
            this.btnCompleteTask.Name = "btnCompleteTask";
            this.btnCompleteTask.Size = new System.Drawing.Size(140, 23);
            this.btnCompleteTask.TabIndex = 3;
            this.btnCompleteTask.Text = "Complete Selected";
            this.btnCompleteTask.UseVisualStyleBackColor = true;
            this.btnCompleteTask.Click += new System.EventHandler(this.btnCompleteTask_Click);
            //
            // btnDeleteTask
            //
            this.btnDeleteTask.Location = new System.Drawing.Point(178, 211);
            this.btnDeleteTask.Name = "btnDeleteTask";
            this.btnDeleteTask.Size = new System.Drawing.Size(140, 23);
            this.btnDeleteTask.TabIndex = 4;
            this.btnDeleteTask.Text = "Delete Selected";
            this.btnDeleteTask.UseVisualStyleBackColor = true;
            this.btnDeleteTask.Click += new System.EventHandler(this.btnDeleteTask_Click);
            //
            // TaskAssistantForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 246);
            this.Controls.Add(this.btnDeleteTask);
            this.Controls.Add(this.btnCompleteTask);
            this.Controls.Add(this.lstTasks);
            this.Controls.Add(this.btnAddTask);
            this.Controls.Add(this.txtNewTask);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TaskAssistantForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Task Assistant";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNewTask;
        private System.Windows.Forms.Button btnAddTask;
        private System.Windows.Forms.ListBox lstTasks;
        private System.Windows.Forms.Button btnCompleteTask;
        private System.Windows.Forms.Button btnDeleteTask;
    }
}