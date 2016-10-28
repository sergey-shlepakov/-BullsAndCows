using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
	public partial class GameForm : Form
	{
		string key;
		TextBox last_tb;
		Label last_lb;

		public GameForm()
		{
			InitializeComponent();

			Random r = new Random();
			key = "";
			while (key.Length < 5)
			{
				string rn = r.Next(0, 10).ToString();
				bool found = false;
				for (int j = 0; j < key.Length; j++)
				{
					if (key[j] == rn[0])
						found = true;
				}
				if (!found)
					key = key + rn;
			}

			this.Text = key;

			last_tb = vv;
			last_lb = l_response;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (last_tb.Text.Length != 5)
			{
				MessageBox.Show("Вы ввели недопустимое колличество символов!");
				return;
			}
			for (int s = 0; s < 5; s++)
			{
				if (last_tb.Text[s] >= '9' || last_tb.Text[0] <= '0')
				{
					MessageBox.Show("Вы ввели недопустимый формат символов!");
					return;
				}
			}
			int q_bulls = 0;
			for (int f = 0; f < 5; f++)
			{
				if (key[f] == last_tb.Text[f])
					q_bulls = q_bulls + 1;

			}
			last_lb.Text = q_bulls + "б.";

			int q_cows = 0;
			for (int f = 0; f < 5; f++)
			{
				bool found = false;
				for (int j = 0; j < key.Length; j++)
				{
					if (key[j] == last_tb.Text[f] && j != f)
						found = true;
				}
				if (found)
					q_cows = q_cows + 1;
			}
			last_lb.Text = q_bulls + "б." + q_cows + "к.";
			if (q_bulls == 5)
			{
				MessageBox.Show("Поздравляю, Вы победили!");
				this.Close();
				return;
			}

			Panel new_pan = new Panel();
			flowLayoutPanel1.Controls.Add(new_pan);
			new_pan.Size = panel1.Size;
		

			TextBox new_tb = new TextBox();
			new_pan.Controls.Add(new_tb);
			new_tb.Location = new Point(last_tb.Location.X, last_tb.Location.Y);
			new_tb.Font = last_tb.Font;
			new_tb.Size = last_tb.Size;
			new_tb.Focus();
			last_tb.ReadOnly = true;


			Label new_lb = new Label();
			new_pan.Controls.Add(new_lb);
			new_lb.Location = new Point(last_lb.Location.X, last_lb.Location.Y);
			new_lb.Font = last_lb.Font;
			new_lb.AutoSize = true;

			last_tb = new_tb;
			last_lb = new_lb;

		}

		private void button11_Click(object sender, EventArgs e)
		{
			Button btn = (Button)sender;
			if (btn.BackColor == SystemColors.Control)
				btn.BackColor = Color.GreenYellow;
			else if (btn.BackColor == Color.GreenYellow)
				btn.BackColor = Color.IndianRed;
			else if (btn.BackColor == Color.IndianRed)
				btn.BackColor = SystemColors.Control;

		}
	}
}
