
namespace ProgramAutoStarter
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
            this.components = new System.ComponentModel.Container();
            this.programListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addBtn = new System.Windows.Forms.Button();
            this.delBtn = new System.Windows.Forms.Button();
            this.startStopBtn = new System.Windows.Forms.Button();
            this.startStopSelProgramBtn = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // programListBox
            // 
            this.programListBox.FormattingEnabled = true;
            this.programListBox.Location = new System.Drawing.Point(15, 25);
            this.programListBox.Name = "programListBox";
            this.programListBox.Size = new System.Drawing.Size(501, 95);
            this.programListBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Runnable programs";
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(15, 126);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 55);
            this.addBtn.TabIndex = 2;
            this.addBtn.Text = "Add program";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // delBtn
            // 
            this.delBtn.Location = new System.Drawing.Point(96, 126);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(90, 55);
            this.delBtn.TabIndex = 3;
            this.delBtn.Text = "Delete program";
            this.delBtn.UseVisualStyleBackColor = true;
            this.delBtn.Click += new System.EventHandler(this.delBtn_Click);
            // 
            // startStopBtn
            // 
            this.startStopBtn.Location = new System.Drawing.Point(441, 126);
            this.startStopBtn.Name = "startStopBtn";
            this.startStopBtn.Size = new System.Drawing.Size(75, 55);
            this.startStopBtn.TabIndex = 4;
            this.startStopBtn.Text = "Autostart stopped";
            this.startStopBtn.UseVisualStyleBackColor = true;
            this.startStopBtn.Click += new System.EventHandler(this.startStopBtn_Click);
            // 
            // startStopSelProgramBtn
            // 
            this.startStopSelProgramBtn.Location = new System.Drawing.Point(336, 126);
            this.startStopSelProgramBtn.Name = "startStopSelProgramBtn";
            this.startStopSelProgramBtn.Size = new System.Drawing.Size(99, 55);
            this.startStopSelProgramBtn.TabIndex = 5;
            this.startStopSelProgramBtn.Text = "Manual start/stop program";
            this.startStopSelProgramBtn.UseVisualStyleBackColor = true;
            this.startStopSelProgramBtn.Click += new System.EventHandler(this.startStopSelProgram_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Executable|*.exe";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(226, 126);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 55);
            this.button1.TabIndex = 6;
            this.button1.Text = "Help";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 193);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.startStopSelProgramBtn);
            this.Controls.Add(this.startStopBtn);
            this.Controls.Add(this.delBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.programListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Program auto starter";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox programListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button delBtn;
        private System.Windows.Forms.Button startStopBtn;
        private System.Windows.Forms.Button startStopSelProgramBtn;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button button1;
    }
}

