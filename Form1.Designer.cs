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
            ((System.ComponentModel.ISupportInitialize)(this.numberInput)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.BackColor = System.Drawing.SystemColors.Desktop;
            this.nameLabel.Font = new System.Drawing.Font("HACKED", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.ForeColor = System.Drawing.Color.YellowGreen;
            this.nameLabel.Location = new System.Drawing.Point(11, 9);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(134, 35);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "obiettivo";
            this.nameLabel.MouseEnter += new System.EventHandler(this.nameLabel_MouseEnter);
            this.nameLabel.MouseLeave += new System.EventHandler(this.nameLabel_MouseLeave);
            // 
            // nameInput
            // 
            this.nameInput.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.nameInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameInput.Font = new System.Drawing.Font("DEC Terminal Modern", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameInput.ForeColor = System.Drawing.Color.OliveDrab;
            this.nameInput.Location = new System.Drawing.Point(17, 65);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(384, 42);
            this.nameInput.TabIndex = 1;
            this.nameInput.Text = "Scrivi il nome del contatto";
            this.nameInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nameInput_KeyDown);
            this.nameInput.Leave += new System.EventHandler(this.nameInput_Leave);
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.BackColor = System.Drawing.SystemColors.Desktop;
            this.messageLabel.Font = new System.Drawing.Font("HACKED", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageLabel.ForeColor = System.Drawing.Color.YellowGreen;
            this.messageLabel.Location = new System.Drawing.Point(11, 150);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(158, 35);
            this.messageLabel.TabIndex = 2;
            this.messageLabel.Text = "Messaggio";
            this.messageLabel.MouseEnter += new System.EventHandler(this.messageLabel_MouseEnter);
            this.messageLabel.MouseLeave += new System.EventHandler(this.messageLabel_MouseLeave);
            // 
            // messageInput
            // 
            this.messageInput.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.messageInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.messageInput.Font = new System.Drawing.Font("DEC Terminal Modern", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageInput.ForeColor = System.Drawing.Color.OliveDrab;
            this.messageInput.Location = new System.Drawing.Point(17, 202);
            this.messageInput.Name = "messageInput";
            this.messageInput.Size = new System.Drawing.Size(361, 42);
            this.messageInput.TabIndex = 3;
            this.messageInput.Text = "Scrivi il messaggio";
            this.messageInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.messageInput_KeyDown);
            this.messageInput.Leave += new System.EventHandler(this.messageInput_Leave);
            // 
            // numberLabel
            // 
            this.numberLabel.AutoSize = true;
            this.numberLabel.BackColor = System.Drawing.SystemColors.Desktop;
            this.numberLabel.Font = new System.Drawing.Font("HACKED", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberLabel.ForeColor = System.Drawing.Color.YellowGreen;
            this.numberLabel.Location = new System.Drawing.Point(11, 292);
            this.numberLabel.Name = "numberLabel";
            this.numberLabel.Size = new System.Drawing.Size(247, 35);
            this.numberLabel.TabIndex = 4;
            this.numberLabel.Text = "numero messaggi";
            this.numberLabel.MouseEnter += new System.EventHandler(this.numberLabel_MouseEnter);
            this.numberLabel.MouseLeave += new System.EventHandler(this.numberLabel_MouseLeave);
            // 
            // numberInput
            // 
            this.numberInput.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.numberInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numberInput.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.numberInput.Font = new System.Drawing.Font("Virtual DJ", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberInput.ForeColor = System.Drawing.Color.YellowGreen;
            this.numberInput.Location = new System.Drawing.Point(17, 345);
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
            this.numberInput.Size = new System.Drawing.Size(156, 36);
            this.numberInput.TabIndex = 5;
            this.numberInput.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // confirmButton
            // 
            this.confirmButton.Location = new System.Drawing.Point(584, 46);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(347, 367);
            this.confirmButton.TabIndex = 6;
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // progressBar
            // 
            this.progressBar.BackColor = System.Drawing.SystemColors.Desktop;
            this.progressBar.Location = new System.Drawing.Point(17, 422);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(359, 23);
            this.progressBar.TabIndex = 7;
            // 
            // Whatspam
            // 
            this.AcceptButton = this.confirmButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(985, 473);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.numberInput);
            this.Controls.Add(this.numberLabel);
            this.Controls.Add(this.messageInput);
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.nameInput);
            this.Controls.Add(this.nameLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1003, 520);
            this.MinimumSize = new System.Drawing.Size(1003, 520);
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
    }
}

