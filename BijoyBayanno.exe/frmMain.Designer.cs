namespace BijoyBayanno
{
	// Token: 0x02000016 RID: 22
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class frmMain : global::System.Windows.Forms.Form
	{
		// Token: 0x06000193 RID: 403 RVA: 0x000D6158 File Offset: 0x000D4558
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

		// Token: 0x06000194 RID: 404 RVA: 0x000D6190 File Offset: 0x000D4590
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::BijoyBayanno.frmMain));
			this.NotifyIcon = new global::System.Windows.Forms.NotifyIcon(this.components);
			this.NotifyMenu = new global::System.Windows.Forms.ContextMenuStrip(this.components);
			this.ShowToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.ToolStripSeparator1 = new global::System.Windows.Forms.ToolStripSeparator();
			this.ExitToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.FadeTimer = new global::System.Windows.Forms.Timer(this.components);
			this.btnClose = new global::System.Windows.Forms.PictureBox();
			this.btnMinimize = new global::System.Windows.Forms.PictureBox();
			this.picIco = new global::System.Windows.Forms.PictureBox();
			this.comLayouts = new global::System.Windows.Forms.ComboBox();
			this.btnOptions = new global::System.Windows.Forms.PictureBox();
			this.btnLEditor = new global::System.Windows.Forms.PictureBox();
			this.ToolTip = new global::System.Windows.Forms.ToolTip(this.components);
			this.btnDrag = new global::System.Windows.Forms.PictureBox();
			this.CheckHandle = new global::System.Windows.Forms.Timer(this.components);
			this.NotifyMenu.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.btnClose).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.btnMinimize).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.picIco).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.btnOptions).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.btnLEditor).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.btnDrag).BeginInit();
			this.SuspendLayout();
			this.NotifyIcon.BalloonTipIcon = global::System.Windows.Forms.ToolTipIcon.Info;
			this.NotifyIcon.BalloonTipText = "Bijoy Ekushe :D";
			this.NotifyIcon.BalloonTipTitle = "Bijoy Ekushe";
			this.NotifyIcon.ContextMenuStrip = this.NotifyMenu;
			this.NotifyIcon.Text = "Bijoy Bayanno";
			this.NotifyMenu.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.ShowToolStripMenuItem,
				this.ToolStripSeparator1,
				this.ExitToolStripMenuItem
			});
			this.NotifyMenu.Name = "NotifyMenu";
			this.NotifyMenu.ShowCheckMargin = true;
			global::System.Windows.Forms.Control notifyMenu = this.NotifyMenu;
			global::System.Drawing.Size size = new global::System.Drawing.Size(181, 54);
			notifyMenu.Size = size;
			this.ShowToolStripMenuItem.Image = global::BijoyBayanno.My.Resources.Resources.show;
			this.ShowToolStripMenuItem.Name = "ShowToolStripMenuItem";
			global::System.Windows.Forms.ToolStripItem showToolStripMenuItem = this.ShowToolStripMenuItem;
			size = new global::System.Drawing.Size(180, 22);
			showToolStripMenuItem.Size = size;
			this.ShowToolStripMenuItem.Text = "Show as Topbar";
			this.ToolStripSeparator1.Name = "ToolStripSeparator1";
			global::System.Windows.Forms.ToolStripItem toolStripSeparator = this.ToolStripSeparator1;
			size = new global::System.Drawing.Size(177, 6);
			toolStripSeparator.Size = size;
			this.ExitToolStripMenuItem.Image = global::BijoyBayanno.My.Resources.Resources.Close2;
			this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
			global::System.Windows.Forms.ToolStripItem exitToolStripMenuItem = this.ExitToolStripMenuItem;
			size = new global::System.Drawing.Size(180, 22);
			exitToolStripMenuItem.Size = size;
			this.ExitToolStripMenuItem.Text = "Close";
			this.FadeTimer.Interval = 10;
			this.btnClose.Anchor = global::System.Windows.Forms.AnchorStyles.None;
			this.btnClose.BackColor = global::System.Drawing.Color.Transparent;
			this.btnClose.Image = global::BijoyBayanno.My.Resources.Resources.Close2;
			global::System.Windows.Forms.Control btnClose = this.btnClose;
			global::System.Drawing.Point location = new global::System.Drawing.Point(237, 2);
			btnClose.Location = location;
			this.btnClose.Name = "btnClose";
			global::System.Windows.Forms.Control btnClose2 = this.btnClose;
			size = new global::System.Drawing.Size(18, 18);
			btnClose2.Size = size;
			this.btnClose.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.btnClose.TabIndex = 4;
			this.btnClose.TabStop = false;
			this.btnMinimize.Anchor = global::System.Windows.Forms.AnchorStyles.None;
			this.btnMinimize.BackColor = global::System.Drawing.Color.Transparent;
			this.btnMinimize.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("btnMinimize.Image");
			global::System.Windows.Forms.Control btnMinimize = this.btnMinimize;
			location = new global::System.Drawing.Point(214, 3);
			btnMinimize.Location = location;
			this.btnMinimize.Name = "btnMinimize";
			global::System.Windows.Forms.Control btnMinimize2 = this.btnMinimize;
			size = new global::System.Drawing.Size(18, 18);
			btnMinimize2.Size = size;
			this.btnMinimize.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.btnMinimize.TabIndex = 5;
			this.btnMinimize.TabStop = false;
			this.picIco.Image = global::BijoyBayanno.My.Resources.Resources.Main;
			global::System.Windows.Forms.Control picIco = this.picIco;
			location = new global::System.Drawing.Point(86, 1);
			picIco.Location = location;
			this.picIco.Name = "picIco";
			global::System.Windows.Forms.Control picIco2 = this.picIco;
			size = new global::System.Drawing.Size(24, 24);
			picIco2.Size = size;
			this.picIco.TabIndex = 6;
			this.picIco.TabStop = false;
			this.comLayouts.AutoCompleteMode = global::System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.comLayouts.AutoCompleteSource = global::System.Windows.Forms.AutoCompleteSource.ListItems;
			this.comLayouts.CausesValidation = false;
			this.comLayouts.Font = new global::System.Drawing.Font("Times New Roman", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.comLayouts.FormattingEnabled = true;
			this.comLayouts.ItemHeight = 15;
			global::System.Windows.Forms.Control comLayouts = this.comLayouts;
			location = new global::System.Drawing.Point(112, 1);
			comLayouts.Location = location;
			this.comLayouts.Name = "comLayouts";
			global::System.Windows.Forms.Control comLayouts2 = this.comLayouts;
			size = new global::System.Drawing.Size(97, 23);
			comLayouts2.Size = size;
			this.comLayouts.TabIndex = 0;
			this.comLayouts.TabStop = false;
			this.btnOptions.Anchor = global::System.Windows.Forms.AnchorStyles.None;
			this.btnOptions.BackColor = global::System.Drawing.Color.Transparent;
			this.btnOptions.Image = global::BijoyBayanno.My.Resources.Resources.tools;
			this.btnOptions.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			global::System.Windows.Forms.Control btnOptions = this.btnOptions;
			location = new global::System.Drawing.Point(175, 64);
			btnOptions.Location = location;
			this.btnOptions.Name = "btnOptions";
			global::System.Windows.Forms.Control btnOptions2 = this.btnOptions;
			size = new global::System.Drawing.Size(18, 18);
			btnOptions2.Size = size;
			this.btnOptions.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.btnOptions.TabIndex = 7;
			this.btnOptions.TabStop = false;
			this.btnLEditor.Anchor = global::System.Windows.Forms.AnchorStyles.None;
			this.btnLEditor.BackColor = global::System.Drawing.Color.Transparent;
			this.btnLEditor.Image = global::BijoyBayanno.My.Resources.Resources.kb;
			this.btnLEditor.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			global::System.Windows.Forms.Control btnLEditor = this.btnLEditor;
			location = new global::System.Drawing.Point(132, 64);
			btnLEditor.Location = location;
			this.btnLEditor.Name = "btnLEditor";
			global::System.Windows.Forms.Control btnLEditor2 = this.btnLEditor;
			size = new global::System.Drawing.Size(18, 18);
			btnLEditor2.Size = size;
			this.btnLEditor.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.btnLEditor.TabIndex = 8;
			this.btnLEditor.TabStop = false;
			this.ToolTip.AutoPopDelay = 5000;
			this.ToolTip.InitialDelay = 100;
			this.ToolTip.ReshowDelay = 100;
			this.btnDrag.BackColor = global::System.Drawing.Color.Transparent;
			this.btnDrag.Cursor = global::System.Windows.Forms.Cursors.SizeAll;
			this.btnDrag.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("btnDrag.Image");
			global::System.Windows.Forms.Control btnDrag = this.btnDrag;
			location = new global::System.Drawing.Point(3, 2);
			btnDrag.Location = location;
			this.btnDrag.Name = "btnDrag";
			global::System.Windows.Forms.Control btnDrag2 = this.btnDrag;
			size = new global::System.Drawing.Size(87, 22);
			btnDrag2.Size = size;
			this.btnDrag.TabIndex = 9;
			this.btnDrag.TabStop = false;
			global::System.Drawing.SizeF autoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			this.AutoScaleDimensions = autoScaleDimensions;
			this.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.DarkSlateGray;
			this.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Stretch;
			size = new global::System.Drawing.Size(258, 25);
			this.ClientSize = size;
			this.ControlBox = false;
			this.Controls.Add(this.btnLEditor);
			this.Controls.Add(this.btnOptions);
			this.Controls.Add(this.btnMinimize);
			this.Controls.Add(this.picIco);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.comLayouts);
			this.Controls.Add(this.btnDrag);
			this.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			this.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			this.Name = "frmMain";
			this.ShowInTaskbar = false;
			this.Text = "Bijoy Bayanno";
			this.TopMost = true;
			this.NotifyMenu.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.btnClose).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.btnMinimize).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.picIco).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.btnOptions).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.btnLEditor).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.btnDrag).EndInit();
			this.ResumeLayout(false);
		}

		// Token: 0x040000E6 RID: 230
		private global::System.ComponentModel.IContainer components;
	}
}
