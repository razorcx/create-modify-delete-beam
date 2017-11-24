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
			this.txtBoxProfile = new System.Windows.Forms.TextBox();
			this.profile = new System.Windows.Forms.Label();
			this.material = new System.Windows.Forms.Label();
			this.finish = new System.Windows.Forms.Label();
			this.txtBoxFinish = new System.Windows.Forms.TextBox();
			this.theClass = new System.Windows.Forms.Label();
			this.txtBoxClass = new System.Windows.Forms.TextBox();
			this.btnDeleteBeam = new System.Windows.Forms.Button();
			this.txtBoxMaterial = new System.Windows.Forms.TextBox();
			this.btnModifyBeam = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox4
			// 
			this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
			this.pictureBox4.Location = new System.Drawing.Point(12, 12);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(254, 65);
			this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pictureBox4.TabIndex = 0;
			this.pictureBox4.TabStop = false;
			// 
			// CreateBeam2
			// 
			this.CreateBeam2.BackColor = System.Drawing.Color.PowderBlue;
			this.CreateBeam2.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.CreateBeam2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.CreateBeam2.Location = new System.Drawing.Point(12, 216);
			this.CreateBeam2.Name = "CreateBeam2";
			this.CreateBeam2.Size = new System.Drawing.Size(83, 38);
			this.CreateBeam2.TabIndex = 1;
			this.CreateBeam2.Text = "Create";
			this.CreateBeam2.UseVisualStyleBackColor = false;
			this.CreateBeam2.Click += new System.EventHandler(this.CreateBeam2_Click);
			// 
			// txtBoxProfile
			// 
			this.txtBoxProfile.Location = new System.Drawing.Point(85, 96);
			this.txtBoxProfile.Name = "txtBoxProfile";
			this.txtBoxProfile.Size = new System.Drawing.Size(181, 22);
			this.txtBoxProfile.TabIndex = 2;
			// 
			// profile
			// 
			this.profile.AutoSize = true;
			this.profile.Location = new System.Drawing.Point(13, 99);
			this.profile.Name = "profile";
			this.profile.Size = new System.Drawing.Size(48, 17);
			this.profile.TabIndex = 3;
			this.profile.Text = "Profile";
			// 
			// material
			// 
			this.material.AutoSize = true;
			this.material.Location = new System.Drawing.Point(13, 126);
			this.material.Name = "material";
			this.material.Size = new System.Drawing.Size(58, 17);
			this.material.TabIndex = 5;
			this.material.Text = "Material";
			// 
			// finish
			// 
			this.finish.AutoSize = true;
			this.finish.Location = new System.Drawing.Point(13, 154);
			this.finish.Name = "finish";
			this.finish.Size = new System.Drawing.Size(45, 17);
			this.finish.TabIndex = 7;
			this.finish.Text = "Finish";
			// 
			// txtBoxFinish
			// 
			this.txtBoxFinish.Location = new System.Drawing.Point(85, 151);
			this.txtBoxFinish.Name = "txtBoxFinish";
			this.txtBoxFinish.Size = new System.Drawing.Size(181, 22);
			this.txtBoxFinish.TabIndex = 6;
			// 
			// theClass
			// 
			this.theClass.AutoSize = true;
			this.theClass.Location = new System.Drawing.Point(13, 182);
			this.theClass.Name = "theClass";
			this.theClass.Size = new System.Drawing.Size(42, 17);
			this.theClass.TabIndex = 9;
			this.theClass.Text = "Class";
			// 
			// txtBoxClass
			// 
			this.txtBoxClass.Location = new System.Drawing.Point(85, 179);
			this.txtBoxClass.Name = "txtBoxClass";
			this.txtBoxClass.Size = new System.Drawing.Size(38, 22);
			this.txtBoxClass.TabIndex = 8;
			// 
			// btnDeleteBeam
			// 
			this.btnDeleteBeam.BackColor = System.Drawing.Color.Salmon;
			this.btnDeleteBeam.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.btnDeleteBeam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDeleteBeam.Location = new System.Drawing.Point(186, 216);
			this.btnDeleteBeam.Name = "btnDeleteBeam";
			this.btnDeleteBeam.Size = new System.Drawing.Size(80, 38);
			this.btnDeleteBeam.TabIndex = 10;
			this.btnDeleteBeam.Text = "Delete";
			this.btnDeleteBeam.UseVisualStyleBackColor = false;
			this.btnDeleteBeam.Click += new System.EventHandler(this.btnDeleteBeam_Click);
			// 
			// txtBoxMaterial
			// 
			this.txtBoxMaterial.Location = new System.Drawing.Point(85, 123);
			this.txtBoxMaterial.Name = "txtBoxMaterial";
			this.txtBoxMaterial.Size = new System.Drawing.Size(181, 22);
			this.txtBoxMaterial.TabIndex = 12;
			// 
			// btnModifyBeam
			// 
			this.btnModifyBeam.BackColor = System.Drawing.Color.LightGreen;
			this.btnModifyBeam.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.btnModifyBeam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnModifyBeam.Location = new System.Drawing.Point(101, 216);
			this.btnModifyBeam.Name = "btnModifyBeam";
			this.btnModifyBeam.Size = new System.Drawing.Size(79, 38);
			this.btnModifyBeam.TabIndex = 13;
			this.btnModifyBeam.Text = "Modify";
			this.btnModifyBeam.UseVisualStyleBackColor = false;
			this.btnModifyBeam.Click += new System.EventHandler(this.btnModifyBeam_Click);
			// 
			// Form1
			// 
			this.BackColor = System.Drawing.SystemColors.Window;
			this.ClientSize = new System.Drawing.Size(278, 268);
			this.Controls.Add(this.btnModifyBeam);
			this.Controls.Add(this.txtBoxMaterial);
			this.Controls.Add(this.btnDeleteBeam);
			this.Controls.Add(this.theClass);
			this.Controls.Add(this.txtBoxClass);
			this.Controls.Add(this.finish);
			this.Controls.Add(this.txtBoxFinish);
			this.Controls.Add(this.material);
			this.Controls.Add(this.profile);
			this.Controls.Add(this.txtBoxProfile);
			this.Controls.Add(this.CreateBeam2);
			this.Controls.Add(this.pictureBox4);
			this.Name = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

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
		private System.Windows.Forms.TextBox txtBoxProfile;
		private System.Windows.Forms.Label profile;
		private System.Windows.Forms.Label material;
		private System.Windows.Forms.Label finish;
		private System.Windows.Forms.TextBox txtBoxFinish;
		private System.Windows.Forms.Label theClass;
		private System.Windows.Forms.TextBox txtBoxClass;
		private System.Windows.Forms.Button btnDeleteBeam;
		private System.Windows.Forms.TextBox txtBoxMaterial;
		private System.Windows.Forms.Button btnModifyBeam;
	}
}

