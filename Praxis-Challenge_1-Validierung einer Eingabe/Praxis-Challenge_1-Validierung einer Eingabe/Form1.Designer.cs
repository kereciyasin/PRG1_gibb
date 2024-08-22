namespace Praxis_Challenge_1_Validierung_einer_Eingabe
{
	partial class Form1
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
			label1 = new Label();
			label2 = new Label();
			txtEmail = new TextBox();
			txtPass = new TextBox();
			button1 = new Button();
			button2 = new Button();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(76, 127);
			label1.Name = "label1";
			label1.Size = new Size(105, 38);
			label1.TabIndex = 0;
			label1.Text = "Email :";
			label1.Click += label1_Click;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(26, 186);
			label2.Name = "label2";
			label2.Size = new Size(155, 38);
			label2.TabIndex = 1;
			label2.Text = "Password :";
			// 
			// txtEmail
			// 
			txtEmail.Location = new Point(187, 120);
			txtEmail.Name = "txtEmail";
			txtEmail.Size = new Size(260, 45);
			txtEmail.TabIndex = 2;
			// 
			// txtPass
			// 
			txtPass.Location = new Point(187, 179);
			txtPass.Name = "txtPass";
			txtPass.PasswordChar = '*';
			txtPass.Size = new Size(260, 45);
			txtPass.TabIndex = 3;
			// 
			// button1
			// 
			button1.Location = new Point(187, 242);
			button1.Name = "button1";
			button1.Size = new Size(130, 45);
			button1.TabIndex = 4;
			button1.Text = "Login";
			button1.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			button2.Location = new Point(317, 242);
			button2.Name = "button2";
			button2.Size = new Size(130, 45);
			button2.TabIndex = 5;
			button2.Text = "Reset";
			button2.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(17F, 38F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.RosyBrown;
			ClientSize = new Size(632, 460);
			Controls.Add(button2);
			Controls.Add(button1);
			Controls.Add(txtPass);
			Controls.Add(txtEmail);
			Controls.Add(label2);
			Controls.Add(label1);
			Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
			Margin = new Padding(5);
			Name = "Form1";
			Text = "Form1";
			Load += Form1_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Label label2;
		private TextBox txtEmail;
		private TextBox txtPass;
		private Button button1;
		private Button button2;
	}
}
