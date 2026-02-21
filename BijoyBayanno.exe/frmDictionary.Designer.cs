namespace BijoyBayanno
{
	// Token: 0x02000013 RID: 19
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class frmDictionary : global::System.Windows.Forms.Form
	{
		// Token: 0x06000036 RID: 54 RVA: 0x000CA510 File Offset: 0x000C8910
		[global::System.Diagnostics.DebuggerNonUserCode]
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000037 RID: 55 RVA: 0x000CA548 File Offset: 0x000C8948
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.lblEnglish = new global::System.Windows.Forms.Label();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.SuspendLayout();
			this.lblEnglish.AutoSize = true;
			this.lblEnglish.BackColor = global::System.Drawing.Color.Transparent;
			this.lblEnglish.Font = new global::System.Drawing.Font("Trebuchet MS", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			global::System.Windows.Forms.Control lblEnglish = this.lblEnglish;
			global::System.Drawing.Point location = new global::System.Drawing.Point(12, 9);
			lblEnglish.Location = location;
			this.lblEnglish.Name = "lblEnglish";
			global::System.Windows.Forms.Control lblEnglish2 = this.lblEnglish;
			global::System.Drawing.Size size = new global::System.Drawing.Size(49, 18);
			lblEnglish2.Size = size;
			this.lblEnglish.TabIndex = 0;
			this.lblEnglish.Text = "English";
			this.Label1.AutoSize = true;
			this.Label1.BackColor = global::System.Drawing.Color.Transparent;
			this.Label1.Font = new global::System.Drawing.Font("SutonnyMJ", 14.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label1.ForeColor = global::System.Drawing.SystemColors.HighlightText;
			global::System.Windows.Forms.Control label = this.Label1;
			location = new global::System.Drawing.Point(11, 37);
			label.Location = location;
			this.Label1.Name = "Label1";
			global::System.Windows.Forms.Control label2 = this.Label1;
			size = new global::System.Drawing.Size(42, 23);
			label2.Size = size;
			this.Label1.TabIndex = 1;
			this.Label1.Text = "evsjv";
			global::System.Drawing.SizeF autoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			this.AutoScaleDimensions = autoScaleDimensions;
			this.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::BijoyBayanno.My.Resources.Resources.Bar;
			size = new global::System.Drawing.Size(159, 64);
			this.ClientSize = size;
			this.Controls.Add(this.Label1);
			this.Controls.Add(this.lblEnglish);
			this.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			this.Name = "frmDictionary";
			this.Text = "frmDictionary";
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		// Token: 0x04000046 RID: 70
		private global::System.ComponentModel.IContainer components;
	}
}
