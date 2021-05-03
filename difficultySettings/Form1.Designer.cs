
namespace difficultySettings
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
            this.enterNameText = new System.Windows.Forms.Label();
            this.selectDifficultyText = new System.Windows.Forms.Label();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.easyButton = new System.Windows.Forms.Button();
            this.mediumButton = new System.Windows.Forms.Button();
            this.hardButton = new System.Windows.Forms.Button();
            this.beginButton = new System.Windows.Forms.Button();
            this.nameOutput = new System.Windows.Forms.Label();
            this.messageOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // enterNameText
            // 
            this.enterNameText.AutoSize = true;
            this.enterNameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterNameText.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.enterNameText.Location = new System.Drawing.Point(24, 57);
            this.enterNameText.Name = "enterNameText";
            this.enterNameText.Size = new System.Drawing.Size(214, 25);
            this.enterNameText.TabIndex = 0;
            this.enterNameText.Text = "Enter Your Name Hero:";
            // 
            // selectDifficultyText
            // 
            this.selectDifficultyText.AutoSize = true;
            this.selectDifficultyText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectDifficultyText.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.selectDifficultyText.Location = new System.Drawing.Point(134, 122);
            this.selectDifficultyText.Name = "selectDifficultyText";
            this.selectDifficultyText.Size = new System.Drawing.Size(248, 25);
            this.selectDifficultyText.TabIndex = 1;
            this.selectDifficultyText.Text = "Select Your Difficulty Level:";
            // 
            // nameInput
            // 
            this.nameInput.Location = new System.Drawing.Point(244, 58);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(251, 26);
            this.nameInput.TabIndex = 2;
            this.nameInput.Click += new System.EventHandler(this.nameInput_Load);
            // 
            // easyButton
            // 
            this.easyButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.easyButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.easyButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.easyButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.easyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.easyButton.Location = new System.Drawing.Point(51, 187);
            this.easyButton.Name = "easyButton";
            this.easyButton.Size = new System.Drawing.Size(126, 62);
            this.easyButton.TabIndex = 3;
            this.easyButton.Text = "Easy";
            this.easyButton.UseVisualStyleBackColor = false;
            this.easyButton.Click += new System.EventHandler(this.easyButton_Click);
            // 
            // mediumButton
            // 
            this.mediumButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mediumButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.mediumButton.Location = new System.Drawing.Point(203, 187);
            this.mediumButton.Name = "mediumButton";
            this.mediumButton.Size = new System.Drawing.Size(126, 62);
            this.mediumButton.TabIndex = 4;
            this.mediumButton.Text = "Medium";
            this.mediumButton.UseVisualStyleBackColor = false;
            this.mediumButton.Click += new System.EventHandler(this.mediumButton_Click);
            // 
            // hardButton
            // 
            this.hardButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.hardButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.hardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hardButton.Location = new System.Drawing.Point(349, 187);
            this.hardButton.Name = "hardButton";
            this.hardButton.Size = new System.Drawing.Size(126, 62);
            this.hardButton.TabIndex = 5;
            this.hardButton.Text = "Hard";
            this.hardButton.UseVisualStyleBackColor = false;
            this.hardButton.Click += new System.EventHandler(this.hardButton_Click);
            // 
            // beginButton
            // 
            this.beginButton.Location = new System.Drawing.Point(89, 265);
            this.beginButton.Name = "beginButton";
            this.beginButton.Size = new System.Drawing.Size(365, 65);
            this.beginButton.TabIndex = 6;
            this.beginButton.Text = "Begin";
            this.beginButton.UseVisualStyleBackColor = true;
            this.beginButton.Click += new System.EventHandler(this.beginButton_Click);
            // 
            // nameOutput
            // 
            this.nameOutput.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.nameOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameOutput.Location = new System.Drawing.Point(29, 357);
            this.nameOutput.Name = "nameOutput";
            this.nameOutput.Size = new System.Drawing.Size(247, 33);
            this.nameOutput.TabIndex = 7;
            this.nameOutput.Click += new System.EventHandler(this.nameOutput_Click);
            // 
            // messageOutput
            // 
            this.messageOutput.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.messageOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.messageOutput.Location = new System.Drawing.Point(29, 403);
            this.messageOutput.Name = "messageOutput";
            this.messageOutput.Size = new System.Drawing.Size(466, 33);
            this.messageOutput.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(528, 488);
            this.Controls.Add(this.messageOutput);
            this.Controls.Add(this.nameOutput);
            this.Controls.Add(this.beginButton);
            this.Controls.Add(this.hardButton);
            this.Controls.Add(this.mediumButton);
            this.Controls.Add(this.easyButton);
            this.Controls.Add(this.nameInput);
            this.Controls.Add(this.selectDifficultyText);
            this.Controls.Add(this.enterNameText);
            this.Name = "Form1";
            this.Text = "Hero Quest";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label enterNameText;
        private System.Windows.Forms.Label selectDifficultyText;
        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.Button easyButton;
        private System.Windows.Forms.Button mediumButton;
        private System.Windows.Forms.Button hardButton;
        private System.Windows.Forms.Button beginButton;
        private System.Windows.Forms.Label nameOutput;
        private System.Windows.Forms.Label messageOutput;
    }
}

