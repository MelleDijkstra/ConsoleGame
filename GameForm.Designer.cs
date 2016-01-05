namespace ConsoleGame
{
    partial class GameForm
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

        #region Windows GameForm Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.consoleTextBox = new System.Windows.Forms.TextBox();
            this.storylineTextBox = new System.Windows.Forms.RichTextBox();
            this.playerTextBox = new System.Windows.Forms.RichTextBox();
            this.locationTextBox = new System.Windows.Forms.RichTextBox();
            this.storyLabel = new System.Windows.Forms.Label();
            this.playerLabel = new System.Windows.Forms.Label();
            this.consoleLabel = new System.Windows.Forms.Label();
            this.locationLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // consoleTextBox
            // 
            this.consoleTextBox.BackColor = System.Drawing.Color.Black;
            this.consoleTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.consoleTextBox.CausesValidation = false;
            this.consoleTextBox.Font = new System.Drawing.Font("Myriad Pro", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consoleTextBox.ForeColor = System.Drawing.Color.White;
            this.consoleTextBox.Location = new System.Drawing.Point(12, 468);
            this.consoleTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.consoleTextBox.MaxLength = 255;
            this.consoleTextBox.Name = "consoleTextBox";
            this.consoleTextBox.Size = new System.Drawing.Size(755, 18);
            this.consoleTextBox.TabIndex = 0;
            this.consoleTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.consoleKeyDown);
            // 
            // storylineTextBox
            // 
            this.storylineTextBox.BackColor = System.Drawing.Color.Black;
            this.storylineTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.storylineTextBox.Cursor = System.Windows.Forms.Cursors.No;
            this.storylineTextBox.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storylineTextBox.ForeColor = System.Drawing.Color.White;
            this.storylineTextBox.Location = new System.Drawing.Point(12, 41);
            this.storylineTextBox.Name = "storylineTextBox";
            this.storylineTextBox.ReadOnly = true;
            this.storylineTextBox.Size = new System.Drawing.Size(268, 396);
            this.storylineTextBox.TabIndex = 1;
            this.storylineTextBox.Text = "";
            // 
            // playerTextBox
            // 
            this.playerTextBox.BackColor = System.Drawing.Color.Black;
            this.playerTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.playerTextBox.Cursor = System.Windows.Forms.Cursors.No;
            this.playerTextBox.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerTextBox.ForeColor = System.Drawing.Color.White;
            this.playerTextBox.Location = new System.Drawing.Point(286, 41);
            this.playerTextBox.Name = "playerTextBox";
            this.playerTextBox.ReadOnly = true;
            this.playerTextBox.Size = new System.Drawing.Size(481, 200);
            this.playerTextBox.TabIndex = 2;
            this.playerTextBox.Text = "";
            // 
            // locationTextBox
            // 
            this.locationTextBox.BackColor = System.Drawing.Color.Black;
            this.locationTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.locationTextBox.Cursor = System.Windows.Forms.Cursors.No;
            this.locationTextBox.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationTextBox.ForeColor = System.Drawing.Color.White;
            this.locationTextBox.Location = new System.Drawing.Point(286, 272);
            this.locationTextBox.Name = "locationTextBox";
            this.locationTextBox.ReadOnly = true;
            this.locationTextBox.Size = new System.Drawing.Size(481, 165);
            this.locationTextBox.TabIndex = 3;
            this.locationTextBox.Text = "";
            // 
            // storyLabel
            // 
            this.storyLabel.AutoSize = true;
            this.storyLabel.Font = new System.Drawing.Font("Myriad Pro", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storyLabel.Location = new System.Drawing.Point(13, 13);
            this.storyLabel.Name = "storyLabel";
            this.storyLabel.Size = new System.Drawing.Size(59, 25);
            this.storyLabel.TabIndex = 4;
            this.storyLabel.Text = "Story";
            // 
            // playerLabel
            // 
            this.playerLabel.AutoSize = true;
            this.playerLabel.Font = new System.Drawing.Font("Myriad Pro", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerLabel.Location = new System.Drawing.Point(281, 13);
            this.playerLabel.Name = "playerLabel";
            this.playerLabel.Size = new System.Drawing.Size(66, 25);
            this.playerLabel.TabIndex = 5;
            this.playerLabel.Text = "Player";
            // 
            // consoleLabel
            // 
            this.consoleLabel.AutoSize = true;
            this.consoleLabel.Font = new System.Drawing.Font("Myriad Pro", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consoleLabel.Location = new System.Drawing.Point(7, 440);
            this.consoleLabel.Name = "consoleLabel";
            this.consoleLabel.Size = new System.Drawing.Size(60, 25);
            this.consoleLabel.TabIndex = 6;
            this.consoleLabel.Text = "Input";
            // 
            // locationLabel
            // 
            this.locationLabel.AutoSize = true;
            this.locationLabel.Font = new System.Drawing.Font("Myriad Pro", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationLabel.Location = new System.Drawing.Point(286, 244);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(89, 25);
            this.locationLabel.TabIndex = 7;
            this.locationLabel.Text = "Location";
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 495);
            this.Controls.Add(this.locationLabel);
            this.Controls.Add(this.consoleLabel);
            this.Controls.Add(this.playerLabel);
            this.Controls.Add(this.storyLabel);
            this.Controls.Add(this.locationTextBox);
            this.Controls.Add(this.playerTextBox);
            this.Controls.Add(this.storylineTextBox);
            this.Controls.Add(this.consoleTextBox);
            this.Name = "GameForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label storyLabel;
        private System.Windows.Forms.Label playerLabel;
        private System.Windows.Forms.Label consoleLabel;
        private System.Windows.Forms.Label locationLabel;
        public System.Windows.Forms.TextBox consoleTextBox;
        public System.Windows.Forms.RichTextBox storylineTextBox;
        public System.Windows.Forms.RichTextBox playerTextBox;
        public System.Windows.Forms.RichTextBox locationTextBox;
    }
}

