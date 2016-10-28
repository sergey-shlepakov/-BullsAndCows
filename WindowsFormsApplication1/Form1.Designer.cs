namespace WindowsFormsApplication1
{
	partial class Form1
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
			this.label1 = new System.Windows.Forms.Label();
			this.btn_start = new System.Windows.Forms.Button();
			this.button_rules = new System.Windows.Forms.Button();
			this.btn_close = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 22.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(2, 40);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(765, 46);
			this.label1.TabIndex = 0;
			this.label1.Text = "быки и коровы";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btn_start
			// 
			this.btn_start.Font = new System.Drawing.Font("Segoe Print", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_start.Location = new System.Drawing.Point(298, 207);
			this.btn_start.Name = "btn_start";
			this.btn_start.Size = new System.Drawing.Size(161, 54);
			this.btn_start.TabIndex = 1;
			this.btn_start.Text = "начать";
			this.btn_start.UseVisualStyleBackColor = true;
			this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
			// 
			// button_rules
			// 
			this.button_rules.Font = new System.Drawing.Font("Segoe Print", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_rules.Location = new System.Drawing.Point(298, 363);
			this.button_rules.Name = "button_rules";
			this.button_rules.Size = new System.Drawing.Size(161, 54);
			this.button_rules.TabIndex = 2;
			this.button_rules.Text = "правила";
			this.button_rules.UseVisualStyleBackColor = true;
			this.button_rules.Click += new System.EventHandler(this.button_rules_Click);
			// 
			// btn_close
			// 
			this.btn_close.Font = new System.Drawing.Font("Segoe Print", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_close.Location = new System.Drawing.Point(298, 501);
			this.btn_close.Name = "btn_close";
			this.btn_close.Size = new System.Drawing.Size(161, 54);
			this.btn_close.TabIndex = 3;
			this.btn_close.Text = "выйти";
			this.btn_close.UseVisualStyleBackColor = true;
			this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(767, 822);
			this.Controls.Add(this.btn_close);
			this.Controls.Add(this.button_rules);
			this.Controls.Add(this.btn_start);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "быки и коровы";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btn_start;
		private System.Windows.Forms.Button button_rules;
		private System.Windows.Forms.Button btn_close;
	}
}

