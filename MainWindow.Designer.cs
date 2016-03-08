namespace Morphine
{
	partial class MainWindow
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
			this.RecordBeat = new System.Windows.Forms.Button();
			this.statusStrip = new System.Windows.Forms.StatusStrip();
			this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.statusStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// RecordBeat
			// 
			this.RecordBeat.Location = new System.Drawing.Point(12, 12);
			this.RecordBeat.Name = "RecordBeat";
			this.RecordBeat.Size = new System.Drawing.Size(70, 33);
			this.RecordBeat.TabIndex = 0;
			this.RecordBeat.Text = "start rec";
			this.RecordBeat.UseVisualStyleBackColor = true;
			this.RecordBeat.Click += new System.EventHandler(this.RecordBeat_Click);
			// 
			// statusStrip
			// 
			this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
			this.statusStrip.Location = new System.Drawing.Point(0, 320);
			this.statusStrip.Name = "statusStrip";
			this.statusStrip.Size = new System.Drawing.Size(681, 22);
			this.statusStrip.TabIndex = 1;
			this.statusStrip.Text = "statusStrip1";
			// 
			// statusLabel
			// 
			this.statusLabel.Name = "statusLabel";
			this.statusLabel.Size = new System.Drawing.Size(140, 17);
			this.statusLabel.Text = "PROGRAM STATUS HERE";
			// 
			// MainWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(681, 342);
			this.Controls.Add(this.statusStrip);
			this.Controls.Add(this.RecordBeat);
			this.Name = "MainWindow";
			this.Text = "Morphine";
			this.statusStrip.ResumeLayout(false);
			this.statusStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button RecordBeat;
		private System.Windows.Forms.StatusStrip statusStrip;
		private System.Windows.Forms.ToolStripStatusLabel statusLabel;
	}
}

