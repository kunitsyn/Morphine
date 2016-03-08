using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Morphine
{
	public partial class MainWindow : Form
	{
		public MainWindow()
		{
			InitializeComponent();

			statusLabel.Text = "Ready";
		}

		private void RecordBeat_Click(object sender, EventArgs e)
		{
			MessageBox.Show("recording!");
		}
	}
}
