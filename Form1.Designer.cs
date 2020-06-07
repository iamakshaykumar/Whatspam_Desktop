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
            this.nameInput = new System.Windows.Forms.TextBox();
            this.messageInput = new System.Windows.Forms.TextBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.confirmButton = new System.Windows.Forms.Button();
            this.spamInput = new System.Windows.Forms.TextBox();
            this.numericUp = new System.Windows.Forms.Button();
            this.numericDown = new System.Windows.Forms.Button();
            this.number10 = new System.Windows.Forms.Button();
            this.number100 = new System.Windows.Forms.Button();
            this.number1k = new System.Windows.Forms.Button();
            this.number10k = new System.Windows.Forms.Button();
            this.number100k = new System.Windows.Forms.Button();
            this.number500k = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameInput
            // 
            this.nameInput.BackColor = System.Drawing.Color.WhiteSmoke;
            this.nameInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameInput.ForeColor = System.Drawing.Color.OliveDrab;
            this.nameInput.Location = new System.Drawing.Point(131, 157);
            this.nameInput.Margin = new System.Windows.Forms.Padding(6);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(586, 53);
            this.nameInput.TabIndex = 1;
            this.nameInput.Text = "Write the target name";
            this.nameInput.Click += new System.EventHandler(this.nameInput_Click);
            this.nameInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nameInput_KeyDown);
            this.nameInput.Leave += new System.EventHandler(this.nameInput_Leave);
            // 
            // messageInput
            // 
            this.messageInput.BackColor = System.Drawing.Color.WhiteSmoke;
            this.messageInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.messageInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageInput.ForeColor = System.Drawing.Color.OliveDrab;
            this.messageInput.Location = new System.Drawing.Point(131, 342);
            this.messageInput.Margin = new System.Windows.Forms.Padding(6);
            this.messageInput.Name = "messageInput";
            this.messageInput.Size = new System.Drawing.Size(586, 53);
            this.messageInput.TabIndex = 3;
            this.messageInput.Text = "Write the message";
            this.messageInput.Click += new System.EventHandler(this.messageInput_Click);
            this.messageInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.messageInput_KeyDown);
            this.messageInput.Leave += new System.EventHandler(this.messageInput_Leave);
            // 
            // progressBar
            // 
            this.progressBar.BackColor = System.Drawing.Color.Black;
            this.progressBar.ForeColor = System.Drawing.Color.Red;
            this.progressBar.Location = new System.Drawing.Point(1195, 759);
            this.progressBar.Margin = new System.Windows.Forms.Padding(6);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(630, 54);
            this.progressBar.TabIndex = 7;
            // 
            // confirmButton
            // 
            this.confirmButton.BackColor = System.Drawing.Color.Transparent;
            this.confirmButton.BackgroundImage = global::Whatspam.Properties.Resources.Bottone_spento_normale;
            this.confirmButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.confirmButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.confirmButton.Enabled = false;
            this.confirmButton.FlatAppearance.BorderSize = 0;
            this.confirmButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.confirmButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.confirmButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirmButton.Location = new System.Drawing.Point(1195, 12);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(630, 630);
            this.confirmButton.TabIndex = 8;
            this.confirmButton.UseVisualStyleBackColor = false;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            this.confirmButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.confirmButton_MouseDown);
            this.confirmButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.confirmButton_MouseUp);
            // 
            // spamInput
            // 
            this.spamInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spamInput.Location = new System.Drawing.Point(131, 504);
            this.spamInput.Name = "spamInput";
            this.spamInput.Size = new System.Drawing.Size(241, 53);
            this.spamInput.TabIndex = 9;
            this.spamInput.Text = "1";
            this.spamInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // numericUp
            // 
            this.numericUp.BackColor = System.Drawing.Color.Transparent;
            this.numericUp.BackgroundImage = global::Whatspam.Properties.Resources.freccia_su;
            this.numericUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.numericUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.numericUp.FlatAppearance.BorderSize = 0;
            this.numericUp.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.numericUp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.numericUp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.numericUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.numericUp.Location = new System.Drawing.Point(407, 490);
            this.numericUp.Name = "numericUp";
            this.numericUp.Size = new System.Drawing.Size(70, 36);
            this.numericUp.TabIndex = 10;
            this.numericUp.UseVisualStyleBackColor = false;
            this.numericUp.Click += new System.EventHandler(this.numericUp_Click);
            // 
            // numericDown
            // 
            this.numericDown.BackColor = System.Drawing.Color.Transparent;
            this.numericDown.BackgroundImage = global::Whatspam.Properties.Resources.freccia_giu;
            this.numericDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.numericDown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.numericDown.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.numericDown.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.numericDown.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.numericDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.numericDown.Location = new System.Drawing.Point(407, 532);
            this.numericDown.Name = "numericDown";
            this.numericDown.Size = new System.Drawing.Size(70, 36);
            this.numericDown.TabIndex = 11;
            this.numericDown.UseVisualStyleBackColor = false;
            this.numericDown.Click += new System.EventHandler(this.numericDown_Click);
            // 
            // number10
            // 
            this.number10.BackColor = System.Drawing.Color.Transparent;
            this.number10.BackgroundImage = global::Whatspam.Properties.Resources._10_off;
            this.number10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.number10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.number10.FlatAppearance.BorderSize = 0;
            this.number10.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.number10.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.number10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.number10.Location = new System.Drawing.Point(60, 574);
            this.number10.Name = "number10";
            this.number10.Size = new System.Drawing.Size(248, 239);
            this.number10.TabIndex = 12;
            this.number10.Tag = "10";
            this.number10.UseVisualStyleBackColor = false;
            this.number10.MouseDown += new System.Windows.Forms.MouseEventHandler(this.number10_MouseDown);
            this.number10.MouseUp += new System.Windows.Forms.MouseEventHandler(this.number10_MouseUp);
            // 
            // number100
            // 
            this.number100.BackColor = System.Drawing.Color.Transparent;
            this.number100.BackgroundImage = global::Whatspam.Properties.Resources._100_off;
            this.number100.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.number100.Cursor = System.Windows.Forms.Cursors.Hand;
            this.number100.FlatAppearance.BorderSize = 0;
            this.number100.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.number100.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.number100.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.number100.Location = new System.Drawing.Point(280, 574);
            this.number100.Name = "number100";
            this.number100.Size = new System.Drawing.Size(248, 239);
            this.number100.TabIndex = 13;
            this.number100.Tag = "100";
            this.number100.UseVisualStyleBackColor = false;
            this.number100.MouseDown += new System.Windows.Forms.MouseEventHandler(this.number100_MouseDown);
            this.number100.MouseUp += new System.Windows.Forms.MouseEventHandler(this.number100_MouseUp);
            // 
            // number1k
            // 
            this.number1k.BackColor = System.Drawing.Color.Transparent;
            this.number1k.BackgroundImage = global::Whatspam.Properties.Resources._1k_off;
            this.number1k.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.number1k.Cursor = System.Windows.Forms.Cursors.Hand;
            this.number1k.FlatAppearance.BorderSize = 0;
            this.number1k.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.number1k.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.number1k.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.number1k.Location = new System.Drawing.Point(516, 574);
            this.number1k.Name = "number1k";
            this.number1k.Size = new System.Drawing.Size(248, 239);
            this.number1k.TabIndex = 14;
            this.number1k.Tag = "1k";
            this.number1k.UseVisualStyleBackColor = false;
            this.number1k.MouseDown += new System.Windows.Forms.MouseEventHandler(this.number1k_MouseDown);
            this.number1k.MouseUp += new System.Windows.Forms.MouseEventHandler(this.number1k_MouseUp);
            // 
            // number10k
            // 
            this.number10k.BackColor = System.Drawing.Color.Transparent;
            this.number10k.BackgroundImage = global::Whatspam.Properties.Resources._10k_off;
            this.number10k.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.number10k.Cursor = System.Windows.Forms.Cursors.Hand;
            this.number10k.FlatAppearance.BorderSize = 0;
            this.number10k.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.number10k.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.number10k.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.number10k.Location = new System.Drawing.Point(60, 776);
            this.number10k.Name = "number10k";
            this.number10k.Size = new System.Drawing.Size(248, 249);
            this.number10k.TabIndex = 15;
            this.number10k.Tag = "10k";
            this.number10k.UseVisualStyleBackColor = false;
            this.number10k.MouseDown += new System.Windows.Forms.MouseEventHandler(this.number10k_MouseDown);
            this.number10k.MouseUp += new System.Windows.Forms.MouseEventHandler(this.number10k_MouseUp);
            // 
            // number100k
            // 
            this.number100k.BackColor = System.Drawing.Color.Transparent;
            this.number100k.BackgroundImage = global::Whatspam.Properties.Resources._100k_off;
            this.number100k.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.number100k.Cursor = System.Windows.Forms.Cursors.Hand;
            this.number100k.FlatAppearance.BorderSize = 0;
            this.number100k.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.number100k.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.number100k.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.number100k.Location = new System.Drawing.Point(280, 776);
            this.number100k.Name = "number100k";
            this.number100k.Size = new System.Drawing.Size(248, 249);
            this.number100k.TabIndex = 16;
            this.number100k.Tag = "100k";
            this.number100k.UseVisualStyleBackColor = false;
            this.number100k.MouseDown += new System.Windows.Forms.MouseEventHandler(this.number100k_MouseDown);
            this.number100k.MouseUp += new System.Windows.Forms.MouseEventHandler(this.number100k_MouseUp);
            // 
            // number500k
            // 
            this.number500k.BackColor = System.Drawing.Color.Transparent;
            this.number500k.BackgroundImage = global::Whatspam.Properties.Resources._500k_off;
            this.number500k.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.number500k.Cursor = System.Windows.Forms.Cursors.Hand;
            this.number500k.FlatAppearance.BorderSize = 0;
            this.number500k.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.number500k.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.number500k.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.number500k.Location = new System.Drawing.Point(516, 776);
            this.number500k.Name = "number500k";
            this.number500k.Size = new System.Drawing.Size(248, 249);
            this.number500k.TabIndex = 17;
            this.number500k.Tag = "500k";
            this.number500k.UseVisualStyleBackColor = false;
            this.number500k.MouseDown += new System.Windows.Forms.MouseEventHandler(this.number500k_MouseDown);
            this.number500k.MouseUp += new System.Windows.Forms.MouseEventHandler(this.number500k_MouseUp);
            // 
            // Whatspam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(240F, 240F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::Whatspam.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1888, 992);
            this.Controls.Add(this.number500k);
            this.Controls.Add(this.number100k);
            this.Controls.Add(this.number10k);
            this.Controls.Add(this.number1k);
            this.Controls.Add(this.number100);
            this.Controls.Add(this.number10);
            this.Controls.Add(this.numericDown);
            this.Controls.Add(this.numericUp);
            this.Controls.Add(this.spamInput);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.messageInput);
            this.Controls.Add(this.nameInput);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimumSize = new System.Drawing.Size(1920, 1080);
            this.Name = "Whatspam";
            this.Text = "Whatspam";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Whatspam_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.TextBox messageInput;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.TextBox spamInput;
        private System.Windows.Forms.Button numericUp;
        private System.Windows.Forms.Button numericDown;
        private System.Windows.Forms.Button number10;
        private System.Windows.Forms.Button number100;
        private System.Windows.Forms.Button number1k;
        private System.Windows.Forms.Button number10k;
        private System.Windows.Forms.Button number100k;
        private System.Windows.Forms.Button number500k;
    }
}

