namespace CreateBeam
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.CreateBeam2 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox4
			// 
			this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
			this.pictureBox4.Location = new System.Drawing.Point(12, 12);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(287, 62);
			this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pictureBox4.TabIndex = 0;
			this.pictureBox4.TabStop = false;
			// 
			// CreateBeam2
			// 
			this.CreateBeam2.BackColor = System.Drawing.Color.PowderBlue;
			this.CreateBeam2.Location = new System.Drawing.Point(105, 101);
			this.CreateBeam2.Name = "CreateBeam2";
			this.CreateBeam2.Size = new System.Drawing.Size(112, 49);
			this.CreateBeam2.TabIndex = 1;
			this.CreateBeam2.Text = "Create Beam";
			this.CreateBeam2.UseVisualStyleBackColor = false;
			this.CreateBeam2.Click += new System.EventHandler(this.CreateBeam2_Click);
			// 
			// Form1
			// 
			this.BackColor = System.Drawing.SystemColors.Window;
			this.ClientSize = new System.Drawing.Size(311, 191);
			this.Controls.Add(this.CreateBeam2);
			this.Controls.Add(this.pictureBox4);
			this.Name = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btn_CreateBeam;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button btnCreateBeam;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.PictureBox pictureBox4;
		private System.Windows.Forms.Button CreateBeam2;
	}
}

