namespace Whatspam
{
    partial class Whatspam
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Whatspam));
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.messageLabel = new System.Windows.Forms.Label();
            this.messageInput = new System.Windows.Forms.TextBox();
            this.numberLabel = new System.Windows.Forms.Label();
            this.numberInput = new System.Windows.Forms.NumericUpDown();
            this.confirmButton = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.italianButton = new System.Windows.Forms.Button();
            this.englishButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numberInput)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.BackColor = System.Drawing.SystemColors.Desktop;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.ForeColor = System.Drawing.Color.YellowGreen;
            this.nameLabel.Location = new System.Drawing.Point(22, 17);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(223, 75);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Target";
            this.nameLabel.MouseEnter += new System.EventHandler(this.nameLabel_MouseEnter);
            this.nameLabel.MouseLeave += new System.EventHandler(this.nameLabel_MouseLeave);
            // 
            // nameInput
            // 
            this.nameInput.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.nameInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameInput.ForeColor = System.Drawing.Color.OliveDrab;
            this.nameInput.Location = new System.Drawing.Point(34, 126);
            this.nameInput.Margin = new System.Windows.Forms.Padding(6);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(766, 75);
            this.nameInput.TabIndex = 1;
            this.nameInput.Text = "Write the target name";
            this.nameInput.Click += new System.EventHandler(this.nameInput_Click);
            this.nameInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nameInput_KeyDown);
            this.nameInput.Leave += new System.EventHandler(this.nameInput_Leave);
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.BackColor = System.Drawing.SystemColors.Desktop;
            this.messageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageLabel.ForeColor = System.Drawing.Color.YellowGreen;
            this.messageLabel.Location = new System.Drawing.Point(22, 291);
            this.messageLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(301, 75);
            this.messageLabel.TabIndex = 2;
            this.messageLabel.Text = "Message";
            this.messageLabel.MouseEnter += new System.EventHandler(this.messageLabel_MouseEnter);
            this.messageLabel.MouseLeave += new System.EventHandler(this.messageLabel_MouseLeave);
            // 
            // messageInput
            // 
            this.messageInput.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.messageInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.messageInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageInput.ForeColor = System.Drawing.Color.OliveDrab;
            this.messageInput.Location = new System.Drawing.Point(34, 391);
            this.messageInput.Margin = new System.Windows.Forms.Padding(6);
            this.messageInput.Name = "messageInput";
            this.messageInput.Size = new System.Drawing.Size(720, 75);
            this.messageInput.TabIndex = 3;
            this.messageInput.Text = "Write the message";
            this.messageInput.Click += new System.EventHandler(this.messageInput_Click);
            this.messageInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.messageInput_KeyDown);
            this.messageInput.Leave += new System.EventHandler(this.messageInput_Leave);
            // 
            // numberLabel
            // 
            this.numberLabel.AutoSize = true;
            this.numberLabel.BackColor = System.Drawing.SystemColors.Desktop;
            this.numberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberLabel.ForeColor = System.Drawing.Color.YellowGreen;
            this.numberLabel.Location = new System.Drawing.Point(22, 566);
            this.numberLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.numberLabel.Name = "numberLabel";
            this.numberLabel.Size = new System.Drawing.Size(481, 75);
            this.numberLabel.TabIndex = 4;
            this.numberLabel.Text = "Spams number";
            this.numberLabel.MouseEnter += new System.EventHandler(this.numberLabel_MouseEnter);
            this.numberLabel.MouseLeave += new System.EventHandler(this.numberLabel_MouseLeave);
            // 
            // numberInput
            // 
            this.numberInput.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.numberInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numberInput.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.numberInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberInput.ForeColor = System.Drawing.Color.YellowGreen;
            this.numberInput.Location = new System.Drawing.Point(35, 669);
            this.numberInput.Margin = new System.Windows.Forms.Padding(6);
            this.numberInput.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numberInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numberInput.Name = "numberInput";
            this.numberInput.Size = new System.Drawing.Size(312, 60);
            this.numberInput.TabIndex = 5;
            this.numberInput.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // confirmButton
            // 
            this.confirmButton.Location = new System.Drawing.Point(1301, 168);
            this.confirmButton.Margin = new System.Windows.Forms.Padding(6);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(626, 654);
            this.confirmButton.TabIndex = 6;
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // progressBar
            // 
            this.progressBar.BackColor = System.Drawing.SystemColors.Desktop;
            this.progressBar.Location = new System.Drawing.Point(34, 818);
            this.progressBar.Margin = new System.Windows.Forms.Padding(6);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(718, 45);
            this.progressBar.TabIndex = 7;
            // 
            // italianButton
            // 
            this.italianButton.BackColor = System.Drawing.Color.Gainsboro;
            this.italianButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.italianButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.italianButton.Location = new System.Drawing.Point(1818, 28);
            this.italianButton.Name = "italianButton";
            this.italianButton.Size = new System.Drawing.Size(76, 76);
            this.italianButton.TabIndex = 8;
            this.italianButton.Text = "IT";
            this.italianButton.UseVisualStyleBackColor = false;
            this.italianButton.Click += new System.EventHandler(this.languageItalian);
            // 
            // englishButton
            // 
            this.englishButton.BackColor = System.Drawing.Color.Gray;
            this.englishButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.englishButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.englishButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.englishButton.Location = new System.Drawing.Point(1736, 28);
            this.englishButton.Name = "englishButton";
            this.englishButton.Size = new System.Drawing.Size(76, 76);
            this.englishButton.TabIndex = 9;
            this.englishButton.Text = "EN";
            this.englishButton.UseVisualStyleBackColor = false;
            this.englishButton.Click += new System.EventHandler(this.languageEnglish);
            // 
            // Whatspam
            // 
            this.AcceptButton = this.confirmButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(1942, 837);
            this.Controls.Add(this.englishButton);
            this.Controls.Add(this.italianButton);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.numberInput);
            this.Controls.Add(this.numberLabel);
            this.Controls.Add(this.messageInput);
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.nameInput);
            this.Controls.Add(this.nameLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximumSize = new System.Drawing.Size(1974, 925);
            this.MinimumSize = new System.Drawing.Size(1974, 925);
            this.Name = "Whatspam";
            this.Text = "Whatspam";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Whatspam_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.numberInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.TextBox messageInput;
        private System.Windows.Forms.Label numberLabel;
        private System.Windows.Forms.NumericUpDown numberInput;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button italianButton;
        private System.Windows.Forms.Button englishButton;
    }
}

