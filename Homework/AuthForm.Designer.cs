namespace Homework
{
    partial class AuthForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthForm));
            AuthButton = new Button();
            AuthLog = new TextBox();
            AuthPass = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // AuthButton
            // 
            AuthButton.BackColor = Color.LightPink;
            AuthButton.Cursor = Cursors.Hand;
            AuthButton.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            AuthButton.ForeColor = Color.White;
            AuthButton.Location = new Point(132, 209);
            AuthButton.Name = "AuthButton";
            AuthButton.Size = new Size(205, 43);
            AuthButton.TabIndex = 4;
            AuthButton.Text = "Войти!";
            AuthButton.UseVisualStyleBackColor = false;
            AuthButton.Click += button1_Click;
            // 
            // AuthLog
            // 
            AuthLog.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            AuthLog.Location = new Point(57, 150);
            AuthLog.Multiline = true;
            AuthLog.Name = "AuthLog";
            AuthLog.Size = new Size(295, 37);
            AuthLog.TabIndex = 6;
            // 
            // AuthPass
            // 
            AuthPass.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            AuthPass.Location = new Point(57, 61);
            AuthPass.Multiline = true;
            AuthPass.Name = "AuthPass";
            AuthPass.Size = new Size(295, 37);
            AuthPass.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Niagara Engraved", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(57, 36);
            label1.Name = "label1";
            label1.Size = new Size(197, 22);
            label1.TabIndex = 7;
            label1.Text = "Введите имя смешарика";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Niagara Engraved", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(57, 125);
            label2.Name = "label2";
            label2.Size = new Size(135, 22);
            label2.TabIndex = 8;
            label2.Text = "Введите пароль";
            // 
            // AuthForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(467, 254);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(AuthLog);
            Controls.Add(AuthPass);
            Controls.Add(AuthButton);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AuthForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AuthForm";
            FormClosing += AuthForm_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button AuthButton;
        private TextBox AuthLog;
        private TextBox AuthPass;
        private Label label1;
        private Label label2;
    }
}