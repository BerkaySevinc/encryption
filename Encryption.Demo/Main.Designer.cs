namespace AesEncryptionDemo
{
    partial class Main
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
            tbxEncryptorMessage = new TextBox();
            tbxDecryptorPlainText = new TextBox();
            btnSend = new Button();
            tbxEncryptorCipherText = new TextBox();
            cbxEncryptorUseIV = new CheckBox();
            gbxSender = new GroupBox();
            lblCipherText = new Label();
            lblEncryptorSalt = new Label();
            tbxEncryptorSalt = new TextBox();
            lblEncryptorPass = new Label();
            tbxEncryptorPass = new TextBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            lblPlainText = new Label();
            lblDecryptorSalt = new Label();
            tbxDecryptorSalt = new TextBox();
            lblDecryptorPass = new Label();
            cbxDecryptorUseIV = new CheckBox();
            tbxDecryptorPass = new TextBox();
            label4 = new Label();
            btnDecrypt = new Button();
            tbxDecryptorCipherText = new TextBox();
            gbxSender.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // tbxEncryptorMessage
            // 
            tbxEncryptorMessage.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbxEncryptorMessage.Location = new Point(113, 98);
            tbxEncryptorMessage.Name = "tbxEncryptorMessage";
            tbxEncryptorMessage.Size = new Size(442, 29);
            tbxEncryptorMessage.TabIndex = 0;
            tbxEncryptorMessage.Text = "test";
            // 
            // tbxDecryptorPlainText
            // 
            tbxDecryptorPlainText.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            tbxDecryptorPlainText.Location = new Point(36, 493);
            tbxDecryptorPlainText.Name = "tbxDecryptorPlainText";
            tbxDecryptorPlainText.Size = new Size(534, 29);
            tbxDecryptorPlainText.TabIndex = 2;
            // 
            // btnSend
            // 
            btnSend.Cursor = Cursors.Hand;
            btnSend.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSend.ForeColor = SystemColors.ActiveCaptionText;
            btnSend.Location = new Point(86, 327);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(415, 65);
            btnSend.TabIndex = 3;
            btnSend.Text = "Encrypt and Send to Decryptor";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // tbxEncryptorCipherText
            // 
            tbxEncryptorCipherText.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            tbxEncryptorCipherText.Location = new Point(25, 493);
            tbxEncryptorCipherText.Name = "tbxEncryptorCipherText";
            tbxEncryptorCipherText.Size = new Size(534, 29);
            tbxEncryptorCipherText.TabIndex = 5;
            // 
            // cbxEncryptorUseIV
            // 
            cbxEncryptorUseIV.AutoSize = true;
            cbxEncryptorUseIV.Cursor = Cursors.Hand;
            cbxEncryptorUseIV.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbxEncryptorUseIV.ForeColor = SystemColors.ButtonHighlight;
            cbxEncryptorUseIV.Location = new Point(467, 230);
            cbxEncryptorUseIV.Name = "cbxEncryptorUseIV";
            cbxEncryptorUseIV.Size = new Size(73, 25);
            cbxEncryptorUseIV.TabIndex = 6;
            cbxEncryptorUseIV.Text = "Use IV";
            cbxEncryptorUseIV.UseVisualStyleBackColor = true;
            // 
            // gbxSender
            // 
            gbxSender.Controls.Add(lblCipherText);
            gbxSender.Controls.Add(lblEncryptorSalt);
            gbxSender.Controls.Add(tbxEncryptorCipherText);
            gbxSender.Controls.Add(tbxEncryptorSalt);
            gbxSender.Controls.Add(lblEncryptorPass);
            gbxSender.Controls.Add(cbxEncryptorUseIV);
            gbxSender.Controls.Add(tbxEncryptorPass);
            gbxSender.Controls.Add(label1);
            gbxSender.Controls.Add(btnSend);
            gbxSender.Controls.Add(tbxEncryptorMessage);
            gbxSender.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            gbxSender.ForeColor = SystemColors.ButtonHighlight;
            gbxSender.Location = new Point(16, 17);
            gbxSender.Name = "gbxSender";
            gbxSender.Size = new Size(583, 576);
            gbxSender.TabIndex = 7;
            gbxSender.TabStop = false;
            gbxSender.Text = "Encryptor";
            // 
            // lblCipherText
            // 
            lblCipherText.AutoSize = true;
            lblCipherText.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblCipherText.Location = new Point(37, 469);
            lblCipherText.Name = "lblCipherText";
            lblCipherText.Size = new Size(100, 21);
            lblCipherText.TabIndex = 9;
            lblCipherText.Text = "Cipher Text:";
            // 
            // lblEncryptorSalt
            // 
            lblEncryptorSalt.AutoSize = true;
            lblEncryptorSalt.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblEncryptorSalt.Location = new Point(39, 245);
            lblEncryptorSalt.Name = "lblEncryptorSalt";
            lblEncryptorSalt.Size = new Size(119, 21);
            lblEncryptorSalt.TabIndex = 8;
            lblEncryptorSalt.Text = "Password Salt:";
            // 
            // tbxEncryptorSalt
            // 
            tbxEncryptorSalt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbxEncryptorSalt.Location = new Point(159, 242);
            tbxEncryptorSalt.Name = "tbxEncryptorSalt";
            tbxEncryptorSalt.Size = new Size(289, 29);
            tbxEncryptorSalt.TabIndex = 7;
            tbxEncryptorSalt.Text = "salt";
            // 
            // lblEncryptorPass
            // 
            lblEncryptorPass.AutoSize = true;
            lblEncryptorPass.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblEncryptorPass.Location = new Point(72, 218);
            lblEncryptorPass.Name = "lblEncryptorPass";
            lblEncryptorPass.Size = new Size(86, 21);
            lblEncryptorPass.TabIndex = 6;
            lblEncryptorPass.Text = "Password:";
            // 
            // tbxEncryptorPass
            // 
            tbxEncryptorPass.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbxEncryptorPass.Location = new Point(159, 215);
            tbxEncryptorPass.Name = "tbxEncryptorPass";
            tbxEncryptorPass.Size = new Size(289, 29);
            tbxEncryptorPass.TabIndex = 5;
            tbxEncryptorPass.Text = "pass";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(27, 101);
            label1.Name = "label1";
            label1.Size = new Size(80, 21);
            label1.TabIndex = 4;
            label1.Text = "Message:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblPlainText);
            groupBox1.Controls.Add(lblDecryptorSalt);
            groupBox1.Controls.Add(tbxDecryptorSalt);
            groupBox1.Controls.Add(lblDecryptorPass);
            groupBox1.Controls.Add(cbxDecryptorUseIV);
            groupBox1.Controls.Add(tbxDecryptorPass);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(btnDecrypt);
            groupBox1.Controls.Add(tbxDecryptorCipherText);
            groupBox1.Controls.Add(tbxDecryptorPlainText);
            groupBox1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.ForeColor = SystemColors.ButtonHighlight;
            groupBox1.Location = new Point(618, 17);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(604, 576);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Decryptor";
            // 
            // lblPlainText
            // 
            lblPlainText.AutoSize = true;
            lblPlainText.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblPlainText.Location = new Point(48, 469);
            lblPlainText.Name = "lblPlainText";
            lblPlainText.Size = new Size(89, 21);
            lblPlainText.TabIndex = 17;
            lblPlainText.Text = "Plain Text:";
            // 
            // lblDecryptorSalt
            // 
            lblDecryptorSalt.AutoSize = true;
            lblDecryptorSalt.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblDecryptorSalt.Location = new Point(50, 240);
            lblDecryptorSalt.Name = "lblDecryptorSalt";
            lblDecryptorSalt.Size = new Size(119, 21);
            lblDecryptorSalt.TabIndex = 16;
            lblDecryptorSalt.Text = "Password Salt:";
            // 
            // tbxDecryptorSalt
            // 
            tbxDecryptorSalt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbxDecryptorSalt.Location = new Point(170, 237);
            tbxDecryptorSalt.Name = "tbxDecryptorSalt";
            tbxDecryptorSalt.Size = new Size(289, 29);
            tbxDecryptorSalt.TabIndex = 15;
            tbxDecryptorSalt.Text = "salt";
            // 
            // lblDecryptorPass
            // 
            lblDecryptorPass.AutoSize = true;
            lblDecryptorPass.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblDecryptorPass.Location = new Point(83, 213);
            lblDecryptorPass.Name = "lblDecryptorPass";
            lblDecryptorPass.Size = new Size(86, 21);
            lblDecryptorPass.TabIndex = 13;
            lblDecryptorPass.Text = "Password:";
            // 
            // cbxDecryptorUseIV
            // 
            cbxDecryptorUseIV.AutoSize = true;
            cbxDecryptorUseIV.Cursor = Cursors.Hand;
            cbxDecryptorUseIV.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbxDecryptorUseIV.ForeColor = SystemColors.ButtonHighlight;
            cbxDecryptorUseIV.Location = new Point(478, 225);
            cbxDecryptorUseIV.Name = "cbxDecryptorUseIV";
            cbxDecryptorUseIV.Size = new Size(73, 25);
            cbxDecryptorUseIV.TabIndex = 14;
            cbxDecryptorUseIV.Text = "Use IV";
            cbxDecryptorUseIV.UseVisualStyleBackColor = true;
            // 
            // tbxDecryptorPass
            // 
            tbxDecryptorPass.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbxDecryptorPass.Location = new Point(170, 210);
            tbxDecryptorPass.Name = "tbxDecryptorPass";
            tbxDecryptorPass.Size = new Size(289, 29);
            tbxDecryptorPass.TabIndex = 12;
            tbxDecryptorPass.Text = "pass";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(12, 101);
            label4.Name = "label4";
            label4.Size = new Size(123, 21);
            label4.TabIndex = 11;
            label4.Text = "Received Data:";
            // 
            // btnDecrypt
            // 
            btnDecrypt.Cursor = Cursors.Hand;
            btnDecrypt.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnDecrypt.ForeColor = SystemColors.ActiveCaptionText;
            btnDecrypt.Location = new Point(97, 327);
            btnDecrypt.Name = "btnDecrypt";
            btnDecrypt.Size = new Size(415, 65);
            btnDecrypt.TabIndex = 10;
            btnDecrypt.Text = "Decrypt Data";
            btnDecrypt.UseVisualStyleBackColor = true;
            btnDecrypt.Click += btnDecrypt_Click;
            // 
            // tbxDecryptorCipherText
            // 
            tbxDecryptorCipherText.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            tbxDecryptorCipherText.Location = new Point(138, 98);
            tbxDecryptorCipherText.Name = "tbxDecryptorCipherText";
            tbxDecryptorCipherText.Size = new Size(442, 29);
            tbxDecryptorCipherText.TabIndex = 9;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(19, 20, 21);
            ClientSize = new Size(1239, 604);
            Controls.Add(groupBox1);
            Controls.Add(gbxSender);
            Name = "Main";
            Text = "Messaging Demo";
            gbxSender.ResumeLayout(false);
            gbxSender.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox tbxEncryptorMessage;
        private TextBox tbxDecryptorPlainText;
        private Button btnSend;
        private TextBox tbxEncryptorCipherText;
        private CheckBox cbxEncryptorUseIV;
        private GroupBox gbxSender;
        private GroupBox groupBox1;
        private Label label1;
        private Label lblEncryptorPass;
        private TextBox tbxEncryptorPass;
        private Label lblEncryptorSalt;
        private TextBox tbxEncryptorSalt;
        private Label lblDecryptorSalt;
        private TextBox tbxDecryptorSalt;
        private Label lblDecryptorPass;
        private CheckBox cbxDecryptorUseIV;
        private TextBox tbxDecryptorPass;
        private Label label4;
        private Button btnDecrypt;
        private TextBox tbxDecryptorCipherText;
        private Label lblCipherText;
        private Label lblPlainText;
    }
}