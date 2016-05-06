namespace RockPaperScissors
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
            this.RockChoice = new System.Windows.Forms.Button();
            this.PaperChoice = new System.Windows.Forms.Button();
            this.ScissorsChoice = new System.Windows.Forms.Button();
            this.Computer = new System.Windows.Forms.RichTextBox();
            this.CombatLog = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // RockChoice
            // 
            this.RockChoice.Location = new System.Drawing.Point(13, 13);
            this.RockChoice.Name = "RockChoice";
            this.RockChoice.Size = new System.Drawing.Size(75, 23);
            this.RockChoice.TabIndex = 0;
            this.RockChoice.Text = "Rock";
            this.RockChoice.UseVisualStyleBackColor = true;
            this.RockChoice.Click += new System.EventHandler(this.RockChoice_Click);
            // 
            // PaperChoice
            // 
            this.PaperChoice.Location = new System.Drawing.Point(13, 43);
            this.PaperChoice.Name = "PaperChoice";
            this.PaperChoice.Size = new System.Drawing.Size(75, 23);
            this.PaperChoice.TabIndex = 1;
            this.PaperChoice.Text = "Paper";
            this.PaperChoice.UseVisualStyleBackColor = true;
            this.PaperChoice.Click += new System.EventHandler(this.PaperChoice_Click);
            // 
            // ScissorsChoice
            // 
            this.ScissorsChoice.Location = new System.Drawing.Point(13, 73);
            this.ScissorsChoice.Name = "ScissorsChoice";
            this.ScissorsChoice.Size = new System.Drawing.Size(75, 23);
            this.ScissorsChoice.TabIndex = 2;
            this.ScissorsChoice.Text = "Scissors";
            this.ScissorsChoice.UseVisualStyleBackColor = true;
            this.ScissorsChoice.Click += new System.EventHandler(this.ScissorsChoice_Click);
            // 
            // Computer
            // 
            this.Computer.Location = new System.Drawing.Point(123, 15);
            this.Computer.Name = "Computer";
            this.Computer.ReadOnly = true;
            this.Computer.Size = new System.Drawing.Size(100, 51);
            this.Computer.TabIndex = 3;
            this.Computer.Text = "Computer Choice";
            // 
            // CombatLog
            // 
            this.CombatLog.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CombatLog.Location = new System.Drawing.Point(13, 117);
            this.CombatLog.Name = "CombatLog";
            this.CombatLog.ReadOnly = true;
            this.CombatLog.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.CombatLog.Size = new System.Drawing.Size(210, 96);
            this.CombatLog.TabIndex = 4;
            this.CombatLog.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 227);
            this.Controls.Add(this.CombatLog);
            this.Controls.Add(this.Computer);
            this.Controls.Add(this.ScissorsChoice);
            this.Controls.Add(this.PaperChoice);
            this.Controls.Add(this.RockChoice);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button RockChoice;
        private System.Windows.Forms.Button PaperChoice;
        private System.Windows.Forms.Button ScissorsChoice;
        private System.Windows.Forms.RichTextBox Computer;
        private System.Windows.Forms.RichTextBox CombatLog;
    }
}

