namespace BijoyBayanno
{
	// Token: 0x02000019 RID: 25
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class frmSplash : global::System.Windows.Forms.Form
	{
		// Token: 0x06000235 RID: 565 RVA: 0x000DB350 File Offset: 0x000D9750
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

		// Token: 0x06000236 RID: 566 RVA: 0x000DB388 File Offset: 0x000D9788
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::BijoyBayanno.frmSplash));
			this.FadeTimer = new global::System.Windows.Forms.Timer(this.components);
			this.SuspendLayout();
			this.FadeTimer.Enabled = true;
			this.FadeTimer.Interval = 10;
			global::System.Drawing.SizeF autoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			this.AutoScaleDimensions = autoScaleDimensions;
			this.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.WhiteSmoke;
			this.BackgroundImage = (global::System.Drawing.Image)componentResourceManager.GetObject("$this.BackgroundImage");
			this.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.None;
			global::System.Drawing.Size clientSize = new global::System.Drawing.Size(237, 240);
			this.ClientSize = clientSize;
			this.DoubleBuffered = true;
			this.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmSplash";
			this.Opacity = 0.0;
			this.ShowInTaskbar = false;
			this.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Splash";
			this.TopMost = true;
			this.ResumeLayout(false);
		}

		// Token: 0x04000128 RID: 296
		private global::System.ComponentModel.IContainer components;
	}
}
