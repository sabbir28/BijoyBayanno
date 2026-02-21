namespace BijoyBayanno
{
	// Token: 0x02000018 RID: 24
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class frmRegistration : global::System.Windows.Forms.Form
	{
		// Token: 0x06000211 RID: 529 RVA: 0x000DA374 File Offset: 0x000D8774
		[global::System.Diagnostics.DebuggerNonUserCode]
		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				bool flag = this.components != null;
				if (flag)
				{
					this.components.Dispose();
				}
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000220 RID: 544 RVA: 0x000DA5A8 File Offset: 0x000D89A8
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::BijoyBayanno.frmRegistration));
			this.LogoPictureBox = new global::System.Windows.Forms.PictureBox();
			this.UsernameLabel = new global::System.Windows.Forms.Label();
			this.PasswordLabel = new global::System.Windows.Forms.Label();
			this.IDTextBox = new global::System.Windows.Forms.TextBox();
			this.PasswordTextBox = new global::System.Windows.Forms.TextBox();
			this.OK = new global::System.Windows.Forms.Button();
			this.Cancel = new global::System.Windows.Forms.Button();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.PictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.PasswordTextBox4 = new global::System.Windows.Forms.TextBox();
			this.PasswordTextBox3 = new global::System.Windows.Forms.TextBox();
			this.PasswordTextBox2 = new global::System.Windows.Forms.TextBox();
			this.PasswordTextBox1 = new global::System.Windows.Forms.TextBox();
			((global::System.ComponentModel.ISupportInitialize)this.LogoPictureBox).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.PictureBox1).BeginInit();
			this.SuspendLayout();
			this.LogoPictureBox.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("LogoPictureBox.Image");
			global::System.Windows.Forms.Control logoPictureBox = this.LogoPictureBox;
			global::System.Drawing.Point location = new global::System.Drawing.Point(0, 0);
			logoPictureBox.Location = location;
			this.LogoPictureBox.Name = "LogoPictureBox";
			global::System.Windows.Forms.Control logoPictureBox2 = this.LogoPictureBox;
			global::System.Drawing.Size size = new global::System.Drawing.Size(286, 72);
			logoPictureBox2.Size = size;
			this.LogoPictureBox.TabIndex = 0;
			this.LogoPictureBox.TabStop = false;
			global::System.Windows.Forms.Control usernameLabel = this.UsernameLabel;
			location = new global::System.Drawing.Point(30, 43);
			usernameLabel.Location = location;
			this.UsernameLabel.Name = "UsernameLabel";
			global::System.Windows.Forms.Control usernameLabel2 = this.UsernameLabel;
			size = new global::System.Drawing.Size(220, 23);
			usernameLabel2.Size = size;
			this.UsernameLabel.TabIndex = 0;
			this.UsernameLabel.Text = "&Mechine ID";
			this.UsernameLabel.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.PasswordLabel.Font = new global::System.Drawing.Font("Times New Roman", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			global::System.Windows.Forms.Control passwordLabel = this.PasswordLabel;
			location = new global::System.Drawing.Point(29, 123);
			passwordLabel.Location = location;
			this.PasswordLabel.Name = "PasswordLabel";
			global::System.Windows.Forms.Control passwordLabel2 = this.PasswordLabel;
			size = new global::System.Drawing.Size(220, 23);
			passwordLabel2.Size = size;
			this.PasswordLabel.TabIndex = 2;
			this.PasswordLabel.Text = "&Activation Code";
			this.PasswordLabel.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			global::System.Windows.Forms.Control idtextBox = this.IDTextBox;
			location = new global::System.Drawing.Point(32, 63);
			idtextBox.Location = location;
			this.IDTextBox.Name = "IDTextBox";
			this.IDTextBox.ReadOnly = true;
			global::System.Windows.Forms.Control idtextBox2 = this.IDTextBox;
			size = new global::System.Drawing.Size(220, 20);
			idtextBox2.Size = size;
			this.IDTextBox.TabIndex = 1;
			this.IDTextBox.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.PasswordTextBox.Font = new global::System.Drawing.Font("Times New Roman", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			global::System.Windows.Forms.Control passwordTextBox = this.PasswordTextBox;
			location = new global::System.Drawing.Point(31, 144);
			passwordTextBox.Location = location;
			this.PasswordTextBox.MaxLength = 4;
			this.PasswordTextBox.Name = "PasswordTextBox";
			global::System.Windows.Forms.Control passwordTextBox2 = this.PasswordTextBox;
			size = new global::System.Drawing.Size(61, 20);
			passwordTextBox2.Size = size;
			this.PasswordTextBox.TabIndex = 0;
			this.PasswordTextBox.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			global::System.Windows.Forms.Control ok = this.OK;
			location = new global::System.Drawing.Point(242, 204);
			ok.Location = location;
			this.OK.Name = "OK";
			global::System.Windows.Forms.Control ok2 = this.OK;
			size = new global::System.Drawing.Size(94, 23);
			ok2.Size = size;
			this.OK.TabIndex = 4;
			this.OK.Text = "&Activate";
			this.Cancel.DialogResult = global::System.Windows.Forms.DialogResult.Cancel;
			global::System.Windows.Forms.Control cancel = this.Cancel;
			location = new global::System.Drawing.Point(33, 204);
			cancel.Location = location;
			this.Cancel.Name = "Cancel";
			global::System.Windows.Forms.Control cancel2 = this.Cancel;
			size = new global::System.Drawing.Size(94, 23);
			cancel2.Size = size;
			this.Cancel.TabIndex = 5;
			this.Cancel.Text = "&Cancel";
			this.Label1.AutoSize = true;
			global::System.Windows.Forms.Control label = this.Label1;
			location = new global::System.Drawing.Point(92, 47);
			label.Location = location;
			this.Label1.Name = "Label1";
			global::System.Windows.Forms.Control label2 = this.Label1;
			size = new global::System.Drawing.Size(39, 13);
			label2.Size = size;
			this.Label1.TabIndex = 6;
			this.Label1.Text = "Label1";
			this.PictureBox1.BackColor = global::System.Drawing.SystemColors.InactiveCaptionText;
			this.PictureBox1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("PictureBox1.Image");
			this.PictureBox1.InitialImage = (global::System.Drawing.Image)componentResourceManager.GetObject("PictureBox1.InitialImage");
			global::System.Windows.Forms.Control pictureBox = this.PictureBox1;
			location = new global::System.Drawing.Point(0, 0);
			pictureBox.Location = location;
			this.PictureBox1.Name = "PictureBox1";
			global::System.Windows.Forms.Control pictureBox2 = this.PictureBox1;
			size = new global::System.Drawing.Size(363, 88);
			pictureBox2.Size = size;
			this.PictureBox1.TabIndex = 7;
			this.PictureBox1.TabStop = false;
			this.PasswordTextBox4.Font = new global::System.Drawing.Font("Times New Roman", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			global::System.Windows.Forms.Control passwordTextBox3 = this.PasswordTextBox4;
			location = new global::System.Drawing.Point(275, 144);
			passwordTextBox3.Location = location;
			this.PasswordTextBox4.MaxLength = 4;
			this.PasswordTextBox4.Name = "PasswordTextBox4";
			global::System.Windows.Forms.Control passwordTextBox4 = this.PasswordTextBox4;
			size = new global::System.Drawing.Size(61, 20);
			passwordTextBox4.Size = size;
			this.PasswordTextBox4.TabIndex = 13;
			this.PasswordTextBox4.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.PasswordTextBox3.Font = new global::System.Drawing.Font("Times New Roman", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			global::System.Windows.Forms.Control passwordTextBox5 = this.PasswordTextBox3;
			location = new global::System.Drawing.Point(214, 144);
			passwordTextBox5.Location = location;
			this.PasswordTextBox3.MaxLength = 4;
			this.PasswordTextBox3.Name = "PasswordTextBox3";
			global::System.Windows.Forms.Control passwordTextBox6 = this.PasswordTextBox3;
			size = new global::System.Drawing.Size(61, 20);
			passwordTextBox6.Size = size;
			this.PasswordTextBox3.TabIndex = 12;
			this.PasswordTextBox3.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.PasswordTextBox2.Font = new global::System.Drawing.Font("Times New Roman", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			global::System.Windows.Forms.Control passwordTextBox7 = this.PasswordTextBox2;
			location = new global::System.Drawing.Point(153, 144);
			passwordTextBox7.Location = location;
			this.PasswordTextBox2.MaxLength = 4;
			this.PasswordTextBox2.Name = "PasswordTextBox2";
			global::System.Windows.Forms.Control passwordTextBox8 = this.PasswordTextBox2;
			size = new global::System.Drawing.Size(61, 20);
			passwordTextBox8.Size = size;
			this.PasswordTextBox2.TabIndex = 11;
			this.PasswordTextBox2.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.PasswordTextBox1.Font = new global::System.Drawing.Font("Times New Roman", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			global::System.Windows.Forms.Control passwordTextBox9 = this.PasswordTextBox1;
			location = new global::System.Drawing.Point(92, 144);
			passwordTextBox9.Location = location;
			this.PasswordTextBox1.MaxLength = 4;
			this.PasswordTextBox1.Name = "PasswordTextBox1";
			global::System.Windows.Forms.Control passwordTextBox10 = this.PasswordTextBox1;
			size = new global::System.Drawing.Size(61, 20);
			passwordTextBox10.Size = size;
			this.PasswordTextBox1.TabIndex = 10;
			this.PasswordTextBox1.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.AcceptButton = this.OK;
			global::System.Drawing.SizeF autoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			this.AutoScaleDimensions = autoScaleDimensions;
			this.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.SystemColors.AppWorkspace;
			this.CancelButton = this.Cancel;
			size = new global::System.Drawing.Size(364, 248);
			this.ClientSize = size;
			this.Controls.Add(this.PasswordTextBox4);
			this.Controls.Add(this.PasswordTextBox3);
			this.Controls.Add(this.PasswordTextBox2);
			this.Controls.Add(this.PasswordTextBox1);
			this.Controls.Add(this.PictureBox1);
			this.Controls.Add(this.Label1);
			this.Controls.Add(this.Cancel);
			this.Controls.Add(this.OK);
			this.Controls.Add(this.PasswordTextBox);
			this.Controls.Add(this.IDTextBox);
			this.Controls.Add(this.PasswordLabel);
			this.Controls.Add(this.UsernameLabel);
			this.Controls.Add(this.LogoPictureBox);
			this.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmRegistration";
			this.ShowInTaskbar = false;
			this.SizeGripStyle = global::System.Windows.Forms.SizeGripStyle.Hide;
			this.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Registration Form";
			this.TopMost = true;
			((global::System.ComponentModel.ISupportInitialize)this.LogoPictureBox).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.PictureBox1).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		// Token: 0x0400011D RID: 285
		private global::System.ComponentModel.IContainer components;
	}
}
