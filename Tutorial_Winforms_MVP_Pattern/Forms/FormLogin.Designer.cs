
namespace Tutorial_Winforms_MVP_Pattern.Forms
{
    partial class FormLogin
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
            this.uxUserNameLabel = new System.Windows.Forms.Label();
            this.uxUserNameTextBox = new System.Windows.Forms.TextBox();
            this.uxPasswordTextBox = new System.Windows.Forms.TextBox();
            this.uxPasswordLabel = new System.Windows.Forms.Label();
            this.uxLoginButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uxUserNameLabel
            // 
            this.uxUserNameLabel.AutoSize = true;
            this.uxUserNameLabel.Location = new System.Drawing.Point(40, 29);
            this.uxUserNameLabel.Name = "uxUserNameLabel";
            this.uxUserNameLabel.Size = new System.Drawing.Size(62, 15);
            this.uxUserNameLabel.TabIndex = 0;
            this.uxUserNameLabel.Text = "UserName";
            // 
            // uxUserNameTextBox
            // 
            this.uxUserNameTextBox.Location = new System.Drawing.Point(129, 26);
            this.uxUserNameTextBox.Name = "uxUserNameTextBox";
            this.uxUserNameTextBox.Size = new System.Drawing.Size(237, 23);
            this.uxUserNameTextBox.TabIndex = 1;
            // 
            // uxPasswordTextBox
            // 
            this.uxPasswordTextBox.Location = new System.Drawing.Point(129, 70);
            this.uxPasswordTextBox.Name = "uxPasswordTextBox";
            this.uxPasswordTextBox.Size = new System.Drawing.Size(237, 23);
            this.uxPasswordTextBox.TabIndex = 3;
            // 
            // uxPasswordLabel
            // 
            this.uxPasswordLabel.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.uxPasswordLabel.AutoSize = true;
            this.uxPasswordLabel.Location = new System.Drawing.Point(40, 73);
            this.uxPasswordLabel.Name = "uxPasswordLabel";
            this.uxPasswordLabel.Size = new System.Drawing.Size(57, 15);
            this.uxPasswordLabel.TabIndex = 2;
            this.uxPasswordLabel.Text = "Password";
            // 
            // uxLoginButton
            // 
            this.uxLoginButton.Location = new System.Drawing.Point(184, 110);
            this.uxLoginButton.Name = "uxLoginButton";
            this.uxLoginButton.Size = new System.Drawing.Size(122, 32);
            this.uxLoginButton.TabIndex = 4;
            this.uxLoginButton.Text = "Login";
            this.uxLoginButton.UseVisualStyleBackColor = true;
            this.uxLoginButton.Click += new System.EventHandler(this.uxLoginButton_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 158);
            this.Controls.Add(this.uxLoginButton);
            this.Controls.Add(this.uxPasswordTextBox);
            this.Controls.Add(this.uxPasswordLabel);
            this.Controls.Add(this.uxUserNameTextBox);
            this.Controls.Add(this.uxUserNameLabel);
            this.Name = "FormLogin";
            this.Text = "FormLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label uxUserNameLabel;
        private System.Windows.Forms.Label uxPasswordLabel;
        private System.Windows.Forms.TextBox uxUserNameTextBox;
        private System.Windows.Forms.TextBox uxPasswordTextBox;
        private System.Windows.Forms.Button uxLoginButton;
    }
}