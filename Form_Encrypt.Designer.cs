namespace Project1
{
    partial class Form_Encrypt
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
            this.btnInputFile = new System.Windows.Forms.Button();
            this.buttonEncrypt = new System.Windows.Forms.Button();
            this.labelSelectedFile = new System.Windows.Forms.Label();
            this.labelEcyptedFile = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SuspendLayout();
            // 
            // btnInputFile
            // 
            this.btnInputFile.BackColor = System.Drawing.SystemColors.Menu;
            this.btnInputFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInputFile.Location = new System.Drawing.Point(149, 70);
            this.btnInputFile.Name = "btnInputFile";
            this.btnInputFile.Size = new System.Drawing.Size(106, 37);
            this.btnInputFile.TabIndex = 1;
            this.btnInputFile.Text = "Select File";
            this.btnInputFile.UseVisualStyleBackColor = false;
            this.btnInputFile.Click += new System.EventHandler(this.onInputFileButtonClick);
            // 
            // buttonEncrypt
            // 
            this.buttonEncrypt.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonEncrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEncrypt.Location = new System.Drawing.Point(519, 70);
            this.buttonEncrypt.Name = "buttonEncrypt";
            this.buttonEncrypt.Size = new System.Drawing.Size(106, 37);
            this.buttonEncrypt.TabIndex = 2;
            this.buttonEncrypt.Text = "Encrypt File";
            this.buttonEncrypt.UseVisualStyleBackColor = false;
            this.buttonEncrypt.Click += new System.EventHandler(this.onButtonEncryptClick);
            // 
            // labelSelectedFile
            // 
            this.labelSelectedFile.AutoSize = true;
            this.labelSelectedFile.BackColor = System.Drawing.SystemColors.Info;
            this.labelSelectedFile.Location = new System.Drawing.Point(210, 186);
            this.labelSelectedFile.MinimumSize = new System.Drawing.Size(300, 20);
            this.labelSelectedFile.Name = "labelSelectedFile";
            this.labelSelectedFile.Size = new System.Drawing.Size(300, 20);
            this.labelSelectedFile.TabIndex = 4;
            this.labelSelectedFile.Text = "Selected File: ";
            // 
            // labelEcyptedFile
            // 
            this.labelEcyptedFile.AutoSize = true;
            this.labelEcyptedFile.BackColor = System.Drawing.SystemColors.Info;
            this.labelEcyptedFile.Location = new System.Drawing.Point(210, 248);
            this.labelEcyptedFile.MinimumSize = new System.Drawing.Size(300, 20);
            this.labelEcyptedFile.Name = "labelEcyptedFile";
            this.labelEcyptedFile.Size = new System.Drawing.Size(300, 20);
            this.labelEcyptedFile.TabIndex = 5;
            this.labelEcyptedFile.Text = "Encrypted File: ";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Form_Encrypt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelEcyptedFile);
            this.Controls.Add(this.labelSelectedFile);
            this.Controls.Add(this.buttonEncrypt);
            this.Controls.Add(this.btnInputFile);
            this.MinimumSize = new System.Drawing.Size(100, 100);
            this.Name = "Form_Encrypt";
            this.Text = "Encrypt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnInputFile;
        private System.Windows.Forms.Button buttonEncrypt;
        private System.Windows.Forms.Label labelSelectedFile;
        private System.Windows.Forms.Label labelEcyptedFile;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}