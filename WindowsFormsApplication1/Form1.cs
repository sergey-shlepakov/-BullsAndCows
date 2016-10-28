using System.Windows.Forms;

namespace WindowsFormsApplication1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btn_close_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void button_rules_Click(object sender, System.EventArgs e)
		{
			new RulesForm().ShowDialog();
		}

		private void btn_start_Click(object sender, System.EventArgs e)
		{
			new GameForm().ShowDialog();
		}
	}
}
