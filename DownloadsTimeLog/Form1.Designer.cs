
namespace DownloadsTimeLog
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.controlButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.mainTimer = new System.Windows.Forms.Timer(this.components);
            this.urlBox = new System.Windows.Forms.TextBox();
            this.timerLabel = new System.Windows.Forms.Label();
            this.timerCounter = new System.Windows.Forms.Label();
            this.errorLabel = new System.Windows.Forms.Label();
            this.badLogTimeBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // controlButton
            // 
            this.controlButton.Location = new System.Drawing.Point(650, 36);
            this.controlButton.Name = "controlButton";
            this.controlButton.Size = new System.Drawing.Size(102, 56);
            this.controlButton.TabIndex = 0;
            this.controlButton.Text = "Start";
            this.controlButton.UseVisualStyleBackColor = true;
            this.controlButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "URL:";
            // 
            // mainTimer
            // 
            this.mainTimer.Interval = 1000;
            this.mainTimer.Tick += new System.EventHandler(this.mainTimer_Tick);
            // 
            // urlBox
            // 
            this.urlBox.Location = new System.Drawing.Point(108, 152);
            this.urlBox.Name = "urlBox";
            this.urlBox.Size = new System.Drawing.Size(522, 23);
            this.urlBox.TabIndex = 2;
            // 
            // timerLabel
            // 
            this.timerLabel.AutoSize = true;
            this.timerLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.timerLabel.Location = new System.Drawing.Point(439, 406);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(150, 28);
            this.timerLabel.TabIndex = 3;
            this.timerLabel.Text = "Next download:";
            // 
            // timerCounter
            // 
            this.timerCounter.AutoSize = true;
            this.timerCounter.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.timerCounter.Location = new System.Drawing.Point(595, 406);
            this.timerCounter.Name = "timerCounter";
            this.timerCounter.Size = new System.Drawing.Size(144, 28);
            this.timerCounter.TabIndex = 4;
            this.timerCounter.Text = "process stoped";
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(80, 240);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 30);
            this.errorLabel.TabIndex = 5;
            // 
            // badLogTimeBox
            // 
            this.badLogTimeBox.Location = new System.Drawing.Point(154, 80);
            this.badLogTimeBox.Name = "badLogTimeBox";
            this.badLogTimeBox.Size = new System.Drawing.Size(116, 23);
            this.badLogTimeBox.TabIndex = 6;
            this.badLogTimeBox.Text = "3000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Bad log time:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(277, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "ms";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 481);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.badLogTimeBox);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.timerCounter);
            this.Controls.Add(this.timerLabel);
            this.Controls.Add(this.urlBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.controlButton);
            this.Name = "Form1";
            this.Text = "Download test speed";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button controlButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer mainTimer;
        private System.Windows.Forms.TextBox urlBox;
        private System.Windows.Forms.Label timerLabel;
        private System.Windows.Forms.Label timerCounter;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.TextBox badLogTimeBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

