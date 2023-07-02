namespace Project1
{
    partial class Form_Decrypt
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
            this.btnInputFile = new System.Windows.Forms.Button();
            this.buttonDecrypt = new System.Windows.Forms.Button();
            this.labelSelectedFile = new System.Windows.Forms.Label();
            this.labelDecyptedFile = new System.Windows.Forms.Label();
            this.buttonSelectPrivKey = new System.Windows.Forms.Button();
            this.labelSelectPrivKey = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnInputFile
            // 
            this.btnInputFile.BackColor = System.Drawing.SystemColors.Menu;
            this.btnInputFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInputFile.Location = new System.Drawing.Point(128, 70);
            this.btnInputFile.Name = "btnInputFile";
            this.btnInputFile.Size = new System.Drawing.Size(106, 37);
            this.btnInputFile.TabIndex = 1;
            this.btnInputFile.Text = "Select File";
            this.btnInputFile.UseVisualStyleBackColor = false;
            this.btnInputFile.Click += new System.EventHandler(this.onInputFileButtonClick);
            // 
            // buttonDecrypt
            // 
            this.buttonDecrypt.BackColor = System.Drawing.Color.LightCoral;
            this.buttonDecrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDecrypt.Location = new System.Drawing.Point(519, 70);
            this.buttonDecrypt.Name = "buttonDecrypt";
            this.buttonDecrypt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonDecrypt.Size = new System.Drawing.Size(106, 37);
            this.buttonDecrypt.TabIndex = 2;
            this.buttonDecrypt.Text = "Decrypt File";
            this.buttonDecrypt.UseVisualStyleBackColor = false;
            this.buttonDecrypt.Click += new System.EventHandler(this.onButtonDecryptClick);
            // 
            // labelSelectedFile
            // 
            this.labelSelectedFile.AutoSize = true;
            this.labelSelectedFile.BackColor = System.Drawing.SystemColors.Info;
            this.labelSelectedFile.Location = new System.Drawing.Point(125, 184);
            this.labelSelectedFile.MinimumSize = new System.Drawing.Size(500, 20);
            this.labelSelectedFile.Name = "labelSelectedFile";
            this.labelSelectedFile.Size = new System.Drawing.Size(500, 20);
            this.labelSelectedFile.TabIndex = 4;
            this.labelSelectedFile.Text = "Selected File: ";
            // 
            // labelDecyptedFile
            // 
            this.labelDecyptedFile.AutoSize = true;
            this.labelDecyptedFile.BackColor = System.Drawing.SystemColors.Info;
            this.labelDecyptedFile.Location = new System.Drawing.Point(125, 318);
            this.labelDecyptedFile.MinimumSize = new System.Drawing.Size(500, 20);
            this.labelDecyptedFile.Name = "labelDecyptedFile";
            this.labelDecyptedFile.Size = new System.Drawing.Size(500, 20);
            this.labelDecyptedFile.TabIndex = 5;
            this.labelDecyptedFile.Text = "Decrypted File: ";
            // 
            // buttonSelectPrivKey
            // 
            this.buttonSelectPrivKey.BackColor = System.Drawing.SystemColors.Menu;
            this.buttonSelectPrivKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSelectPrivKey.Location = new System.Drawing.Point(306, 70);
            this.buttonSelectPrivKey.Name = "buttonSelectPrivKey";
            this.buttonSelectPrivKey.Size = new System.Drawing.Size(145, 37);
            this.buttonSelectPrivKey.TabIndex = 6;
            this.buttonSelectPrivKey.Text = "Select Private Key";
            this.buttonSelectPrivKey.UseVisualStyleBackColor = false;
            this.buttonSelectPrivKey.Click += new System.EventHandler(this.onButtonSelectPrivKeyClick);
            // 
            // labelSelectPrivKey
            // 
            this.labelSelectPrivKey.AutoSize = true;
            this.labelSelectPrivKey.BackColor = System.Drawing.SystemColors.Info;
            this.labelSelectPrivKey.Location = new System.Drawing.Point(125, 250);
            this.labelSelectPrivKey.MinimumSize = new System.Drawing.Size(500, 20);
            this.labelSelectPrivKey.Name = "labelSelectPrivKey";
            this.labelSelectPrivKey.Size = new System.Drawing.Size(500, 20);
            this.labelSelectPrivKey.TabIndex = 7;
            this.labelSelectPrivKey.Text = "Selected Private key File: ";
            // 
            // Form_Decrypt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelSelectPrivKey);
            this.Controls.Add(this.buttonSelectPrivKey);
            this.Controls.Add(this.labelDecyptedFile);
            this.Controls.Add(this.labelSelectedFile);
            this.Controls.Add(this.buttonDecrypt);
            this.Controls.Add(this.btnInputFile);
            this.MinimumSize = new System.Drawing.Size(100, 100);
            this.Name = "Form_Decrypt";
            this.Text = "Decrypt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnInputFile;
        private System.Windows.Forms.Button buttonDecrypt;
        private System.Windows.Forms.Label labelSelectedFile;
        private System.Windows.Forms.Label labelDecyptedFile;
        private System.Windows.Forms.Button buttonSelectPrivKey;
        private System.Windows.Forms.Label labelSelectPrivKey;
    }
}