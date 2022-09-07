
namespace RSA
{
	partial class Form1
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.textBox_p = new System.Windows.Forms.TextBox();
			this.textBox_q = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.Encrypt_button = new System.Windows.Forms.Button();
			this.Dencrypt_button = new System.Windows.Forms.Button();
			this.textBox_d = new System.Windows.Forms.TextBox();
			this.textBox_n2 = new System.Windows.Forms.TextBox();
			this.textBox_n1 = new System.Windows.Forms.TextBox();
			this.textBox_e = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.Gen_primes_button = new System.Windows.Forms.Button();
			this.label10 = new System.Windows.Forms.Label();
			this.info_button = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// textBox_p
			// 
			this.textBox_p.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox_p.Location = new System.Drawing.Point(165, 186);
			this.textBox_p.Name = "textBox_p";
			this.textBox_p.Size = new System.Drawing.Size(64, 28);
			this.textBox_p.TabIndex = 1;
			this.textBox_p.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// textBox_q
			// 
			this.textBox_q.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox_q.Location = new System.Drawing.Point(404, 186);
			this.textBox_q.Name = "textBox_q";
			this.textBox_q.Size = new System.Drawing.Size(64, 28);
			this.textBox_q.TabIndex = 2;
			this.textBox_q.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(112, 187);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(46, 24);
			this.label1.TabIndex = 3;
			this.label1.Text = "p = ";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(352, 187);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(46, 24);
			this.label2.TabIndex = 4;
			this.label2.Text = "q = ";
			// 
			// Encrypt_button
			// 
			this.Encrypt_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Encrypt_button.Location = new System.Drawing.Point(108, 318);
			this.Encrypt_button.Name = "Encrypt_button";
			this.Encrypt_button.Size = new System.Drawing.Size(112, 54);
			this.Encrypt_button.TabIndex = 5;
			this.Encrypt_button.Text = "Encrypt message";
			this.Encrypt_button.UseVisualStyleBackColor = true;
			this.Encrypt_button.Click += new System.EventHandler(this.Encrypt_button_Click);
			// 
			// Dencrypt_button
			// 
			this.Dencrypt_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Dencrypt_button.Location = new System.Drawing.Point(372, 318);
			this.Dencrypt_button.Name = "Dencrypt_button";
			this.Dencrypt_button.Size = new System.Drawing.Size(112, 54);
			this.Dencrypt_button.TabIndex = 6;
			this.Dencrypt_button.Text = "Decrypt message";
			this.Dencrypt_button.UseVisualStyleBackColor = true;
			this.Dencrypt_button.Click += new System.EventHandler(this.Dencrypt_button_Click);
			// 
			// textBox_d
			// 
			this.textBox_d.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox_d.Location = new System.Drawing.Point(339, 277);
			this.textBox_d.Name = "textBox_d";
			this.textBox_d.Size = new System.Drawing.Size(86, 28);
			this.textBox_d.TabIndex = 7;
			this.textBox_d.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// textBox_n2
			// 
			this.textBox_n2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox_n2.Location = new System.Drawing.Point(431, 277);
			this.textBox_n2.Name = "textBox_n2";
			this.textBox_n2.Size = new System.Drawing.Size(86, 28);
			this.textBox_n2.TabIndex = 8;
			this.textBox_n2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// textBox_n1
			// 
			this.textBox_n1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox_n1.Location = new System.Drawing.Point(164, 275);
			this.textBox_n1.Name = "textBox_n1";
			this.textBox_n1.Size = new System.Drawing.Size(86, 28);
			this.textBox_n1.TabIndex = 9;
			this.textBox_n1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// textBox_e
			// 
			this.textBox_e.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox_e.Location = new System.Drawing.Point(72, 275);
			this.textBox_e.Name = "textBox_e";
			this.textBox_e.Size = new System.Drawing.Size(86, 28);
			this.textBox_e.TabIndex = 10;
			this.textBox_e.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(43, 273);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(23, 29);
			this.label3.TabIndex = 11;
			this.label3.Text = "{";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.Location = new System.Drawing.Point(310, 275);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(23, 29);
			this.label4.TabIndex = 12;
			this.label4.Text = "{";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label5.Location = new System.Drawing.Point(256, 275);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(23, 29);
			this.label5.TabIndex = 13;
			this.label5.Text = "}";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label6.Location = new System.Drawing.Point(523, 275);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(23, 29);
			this.label6.TabIndex = 14;
			this.label6.Text = "}";
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label7.Location = new System.Drawing.Point(72, 246);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(178, 26);
			this.label7.TabIndex = 15;
			this.label7.Text = "public key";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label8.Location = new System.Drawing.Point(339, 246);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(178, 26);
			this.label8.TabIndex = 16;
			this.label8.Text = "private key";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label9
			// 
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label9.Location = new System.Drawing.Point(235, 9);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(112, 56);
			this.label9.TabIndex = 17;
			this.label9.Text = "RSA";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button2.Location = new System.Drawing.Point(235, 68);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(112, 54);
			this.button2.TabIndex = 19;
			this.button2.Text = "Enter message";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// Gen_primes_button
			// 
			this.Gen_primes_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Gen_primes_button.Location = new System.Drawing.Point(235, 185);
			this.Gen_primes_button.Name = "Gen_primes_button";
			this.Gen_primes_button.Size = new System.Drawing.Size(112, 29);
			this.Gen_primes_button.TabIndex = 21;
			this.Gen_primes_button.Text = "Gen p, q";
			this.Gen_primes_button.UseVisualStyleBackColor = true;
			this.Gen_primes_button.Click += new System.EventHandler(this.Gen_primes_button_Click);
			// 
			// label10
			// 
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label10.Location = new System.Drawing.Point(130, 144);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(329, 26);
			this.label10.TabIndex = 20;
			this.label10.Text = "Enter prime numbers";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// info_button
			// 
			this.info_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.info_button.Location = new System.Drawing.Point(12, 12);
			this.info_button.Name = "info_button";
			this.info_button.Size = new System.Drawing.Size(30, 32);
			this.info_button.TabIndex = 22;
			this.info_button.Text = "?";
			this.info_button.UseVisualStyleBackColor = true;
			this.info_button.Click += new System.EventHandler(this.info_button_Click);
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button1.Location = new System.Drawing.Point(484, 405);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(90, 30);
			this.button1.TabIndex = 23;
			this.button1.Text = "clear all";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(586, 447);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.info_button);
			this.Controls.Add(this.Gen_primes_button);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.textBox_e);
			this.Controls.Add(this.textBox_n1);
			this.Controls.Add(this.textBox_n2);
			this.Controls.Add(this.textBox_d);
			this.Controls.Add(this.Dencrypt_button);
			this.Controls.Add(this.Encrypt_button);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBox_q);
			this.Controls.Add(this.textBox_p);
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(604, 494);
			this.MinimumSize = new System.Drawing.Size(604, 494);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "RSA cipher";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.TextBox textBox_p;
		private System.Windows.Forms.TextBox textBox_q;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button Encrypt_button;
		private System.Windows.Forms.Button Dencrypt_button;
		private System.Windows.Forms.TextBox textBox_d;
		private System.Windows.Forms.TextBox textBox_n2;
		private System.Windows.Forms.TextBox textBox_n1;
		private System.Windows.Forms.TextBox textBox_e;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button Gen_primes_button;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Button info_button;
		private System.Windows.Forms.Button button1;
	}
}

