using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using BijoyBayanno.My;
using BijoyBayanno.My.Resources;
using Microsoft.VisualBasic.CompilerServices;

namespace BijoyBayanno
{
	// Token: 0x02000016 RID: 22
	[DesignerGenerated]
	public partial class frmMain : Form
	{
		// Token: 0x06000192 RID: 402 RVA: 0x000D60B0 File Offset: 0x000D44B0
		[DebuggerNonUserCode]
		public frmMain()
		{
			base.Load += this.frmMain_Load;
			base.MouseDown += this.frmMain_MouseDown;
			base.FormClosing += this.frmMain_FormClosing;
			base.MouseHover += this.frmMain_MouseHover;
			List<WeakReference> _ENCList = frmMain.__ENCList;
			lock (_ENCList)
			{
				frmMain.__ENCList.Add(new WeakReference(this));
			}
			this.InitializeComponent();
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x06000195 RID: 405 RVA: 0x000D6A84 File Offset: 0x000D4E84
		// (set) Token: 0x06000196 RID: 406 RVA: 0x000D6A9C File Offset: 0x000D4E9C
		internal virtual NotifyIcon NotifyIcon
		{
			[DebuggerNonUserCode]
			get
			{
				return this._NotifyIcon;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				MouseEventHandler value2 = new MouseEventHandler(this.NotifyIcon_MouseClick);
				MouseEventHandler value3 = new MouseEventHandler(this.NotifyIcon_MouseDoubleClick);
				bool flag = this._NotifyIcon != null;
				if (flag)
				{
					this._NotifyIcon.MouseClick -= value2;
					this._NotifyIcon.MouseDoubleClick -= value3;
				}
				this._NotifyIcon = value;
				flag = (this._NotifyIcon != null);
				if (flag)
				{
					this._NotifyIcon.MouseClick += value2;
					this._NotifyIcon.MouseDoubleClick += value3;
				}
			}
		}

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x06000197 RID: 407 RVA: 0x000D6B24 File Offset: 0x000D4F24
		// (set) Token: 0x06000198 RID: 408 RVA: 0x000D6B3C File Offset: 0x000D4F3C
		internal virtual ContextMenuStrip NotifyMenu
		{
			[DebuggerNonUserCode]
			get
			{
				return this._NotifyMenu;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				ToolStripItemClickedEventHandler value2 = new ToolStripItemClickedEventHandler(this.NotifyMenu_ItemClicked);
				bool flag = this._NotifyMenu != null;
				if (flag)
				{
					this._NotifyMenu.ItemClicked -= value2;
				}
				this._NotifyMenu = value;
				flag = (this._NotifyMenu != null);
				if (flag)
				{
					this._NotifyMenu.ItemClicked += value2;
				}
			}
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x06000199 RID: 409 RVA: 0x000D6B9C File Offset: 0x000D4F9C
		// (set) Token: 0x0600019A RID: 410 RVA: 0x000D6BB4 File Offset: 0x000D4FB4
		internal virtual ToolStripMenuItem ExitToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ExitToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ExitToolStripMenuItem_Click);
				bool flag = this._ExitToolStripMenuItem != null;
				if (flag)
				{
					this._ExitToolStripMenuItem.Click -= value2;
				}
				this._ExitToolStripMenuItem = value;
				flag = (this._ExitToolStripMenuItem != null);
				if (flag)
				{
					this._ExitToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x0600019B RID: 411 RVA: 0x000D6C14 File Offset: 0x000D5014
		// (set) Token: 0x0600019C RID: 412 RVA: 0x000D6C2C File Offset: 0x000D502C
		internal virtual ToolStripSeparator ToolStripSeparator1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ToolStripSeparator1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ToolStripSeparator1 = value;
			}
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x0600019D RID: 413 RVA: 0x000D6C38 File Offset: 0x000D5038
		// (set) Token: 0x0600019E RID: 414 RVA: 0x000D6C50 File Offset: 0x000D5050
		internal virtual ToolStripMenuItem ShowToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ShowToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ShowToolStripMenuItem_Click);
				bool flag = this._ShowToolStripMenuItem != null;
				if (flag)
				{
					this._ShowToolStripMenuItem.Click -= value2;
				}
				this._ShowToolStripMenuItem = value;
				flag = (this._ShowToolStripMenuItem != null);
				if (flag)
				{
					this._ShowToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x0600019F RID: 415 RVA: 0x000D6CB0 File Offset: 0x000D50B0
		// (set) Token: 0x060001A0 RID: 416 RVA: 0x000D6CC8 File Offset: 0x000D50C8
		internal virtual Timer FadeTimer
		{
			[DebuggerNonUserCode]
			get
			{
				return this._FadeTimer;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.FadeTimer_Tick);
				bool flag = this._FadeTimer != null;
				if (flag)
				{
					this._FadeTimer.Tick -= value2;
				}
				this._FadeTimer = value;
				flag = (this._FadeTimer != null);
				if (flag)
				{
					this._FadeTimer.Tick += value2;
				}
			}
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x060001A1 RID: 417 RVA: 0x000D6D28 File Offset: 0x000D5128
		// (set) Token: 0x060001A2 RID: 418 RVA: 0x000D6D40 File Offset: 0x000D5140
		internal virtual PictureBox btnClose
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btnClose;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btnClose_Click);
				EventHandler value3 = new EventHandler(this.btnClose_MouseLeave);
				EventHandler value4 = new EventHandler(this.btnClose_MouseHover);
				bool flag = this._btnClose != null;
				if (flag)
				{
					this._btnClose.Click -= value2;
					this._btnClose.MouseLeave -= value3;
					this._btnClose.MouseHover -= value4;
				}
				this._btnClose = value;
				flag = (this._btnClose != null);
				if (flag)
				{
					this._btnClose.Click += value2;
					this._btnClose.MouseLeave += value3;
					this._btnClose.MouseHover += value4;
				}
			}
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x060001A3 RID: 419 RVA: 0x000D6DF0 File Offset: 0x000D51F0
		// (set) Token: 0x060001A4 RID: 420 RVA: 0x000D6E08 File Offset: 0x000D5208
		internal virtual PictureBox btnMinimize
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btnMinimize;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btnMinimize_MouseHover);
				EventHandler value3 = new EventHandler(this.btnMinimize_Click);
				EventHandler value4 = new EventHandler(this.btnMinimize_MouseLeave);
				bool flag = this._btnMinimize != null;
				if (flag)
				{
					this._btnMinimize.MouseHover -= value2;
					this._btnMinimize.Click -= value3;
					this._btnMinimize.MouseLeave -= value4;
				}
				this._btnMinimize = value;
				flag = (this._btnMinimize != null);
				if (flag)
				{
					this._btnMinimize.MouseHover += value2;
					this._btnMinimize.Click += value3;
					this._btnMinimize.MouseLeave += value4;
				}
			}
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x060001A5 RID: 421 RVA: 0x000D6EB8 File Offset: 0x000D52B8
		// (set) Token: 0x060001A6 RID: 422 RVA: 0x000D6ED0 File Offset: 0x000D52D0
		internal virtual PictureBox picIco
		{
			[DebuggerNonUserCode]
			get
			{
				return this._picIco;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.picIco_Click);
				bool flag = this._picIco != null;
				if (flag)
				{
					this._picIco.Click -= value2;
				}
				this._picIco = value;
				flag = (this._picIco != null);
				if (flag)
				{
					this._picIco.Click += value2;
				}
			}
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x060001A7 RID: 423 RVA: 0x000D6F30 File Offset: 0x000D5330
		// (set) Token: 0x060001A8 RID: 424 RVA: 0x000D6F48 File Offset: 0x000D5348
		internal virtual ComboBox comLayouts
		{
			[DebuggerNonUserCode]
			get
			{
				return this._comLayouts;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.comLayouts_SelectedIndexChanged);
				bool flag = this._comLayouts != null;
				if (flag)
				{
					this._comLayouts.SelectedIndexChanged -= value2;
				}
				this._comLayouts = value;
				flag = (this._comLayouts != null);
				if (flag)
				{
					this._comLayouts.SelectedIndexChanged += value2;
				}
			}
		}

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x060001A9 RID: 425 RVA: 0x000D6FA8 File Offset: 0x000D53A8
		// (set) Token: 0x060001AA RID: 426 RVA: 0x000D6FC0 File Offset: 0x000D53C0
		internal virtual PictureBox btnOptions
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btnOptions;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btnOptions_Click);
				EventHandler value3 = new EventHandler(this.btnOptions_MouseLeave);
				EventHandler value4 = new EventHandler(this.btnOptions_MouseHover);
				bool flag = this._btnOptions != null;
				if (flag)
				{
					this._btnOptions.Click -= value2;
					this._btnOptions.MouseLeave -= value3;
					this._btnOptions.MouseHover -= value4;
				}
				this._btnOptions = value;
				flag = (this._btnOptions != null);
				if (flag)
				{
					this._btnOptions.Click += value2;
					this._btnOptions.MouseLeave += value3;
					this._btnOptions.MouseHover += value4;
				}
			}
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x060001AB RID: 427 RVA: 0x000D7070 File Offset: 0x000D5470
		// (set) Token: 0x060001AC RID: 428 RVA: 0x000D7088 File Offset: 0x000D5488
		internal virtual PictureBox btnLEditor
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btnLEditor;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btnLEditor_MouseLeave);
				EventHandler value3 = new EventHandler(this.btnLEditor_MouseHover);
				EventHandler value4 = new EventHandler(this.btnLEditor_Click);
				bool flag = this._btnLEditor != null;
				if (flag)
				{
					this._btnLEditor.MouseLeave -= value2;
					this._btnLEditor.MouseHover -= value3;
					this._btnLEditor.Click -= value4;
				}
				this._btnLEditor = value;
				flag = (this._btnLEditor != null);
				if (flag)
				{
					this._btnLEditor.MouseLeave += value2;
					this._btnLEditor.MouseHover += value3;
					this._btnLEditor.Click += value4;
				}
			}
		}

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x060001AD RID: 429 RVA: 0x000D7138 File Offset: 0x000D5538
		// (set) Token: 0x060001AE RID: 430 RVA: 0x000D7150 File Offset: 0x000D5550
		internal virtual ToolTip ToolTip
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ToolTip;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ToolTip = value;
			}
		}

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x060001AF RID: 431 RVA: 0x000D715C File Offset: 0x000D555C
		// (set) Token: 0x060001B0 RID: 432 RVA: 0x000D7174 File Offset: 0x000D5574
		internal virtual PictureBox btnDrag
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btnDrag;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				MouseEventHandler value2 = new MouseEventHandler(this.btnDrag_MouseDown);
				bool flag = this._btnDrag != null;
				if (flag)
				{
					this._btnDrag.MouseDown -= value2;
				}
				this._btnDrag = value;
				flag = (this._btnDrag != null);
				if (flag)
				{
					this._btnDrag.MouseDown += value2;
				}
			}
		}

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x060001B1 RID: 433 RVA: 0x000D71D4 File Offset: 0x000D55D4
		// (set) Token: 0x060001B2 RID: 434 RVA: 0x000D71EC File Offset: 0x000D55EC
		internal virtual Timer CheckHandle
		{
			[DebuggerNonUserCode]
			get
			{
				return this._CheckHandle;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.CheckHandle_Tick);
				bool flag = this._CheckHandle != null;
				if (flag)
				{
					this._CheckHandle.Tick -= value2;
				}
				this._CheckHandle = value;
				flag = (this._CheckHandle != null);
				if (flag)
				{
					this._CheckHandle.Tick += value2;
				}
			}
		}

		// Token: 0x060001B3 RID: 435 RVA: 0x000D724C File Offset: 0x000D564C
		private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.NotifyIcon.Dispose();
			modKeyboard.UnhookKeyboard();
			this.Close();
			this.Dispose();
			ProjectData.EndApp();
		}

		// Token: 0x060001B4 RID: 436 RVA: 0x000D7278 File Offset: 0x000D5678
		private void NotifyIcon_MouseClick(object sender, MouseEventArgs e)
		{
			try
			{
				bool flag = e.Button == MouseButtons.Left;
				if (flag)
				{
					bool flag2 = this.comLayouts.SelectedIndex == 0;
					if (flag2)
					{
						this.comLayouts.SelectedIndex = modKeyboard.defLayout;
						mHandleInfo.AddInfo((long)modKeyboard.GetForegroundWindow(), modKeyboard.Layout[modKeyboard.defLayout]);
					}
					else
					{
						this.comLayouts.SelectedIndex = 0;
					}
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x060001B5 RID: 437 RVA: 0x000D7308 File Offset: 0x000D5708
		private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
		{
			try
			{
				MyProject.Computer.Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\BijoyEkushe\\Options", "ApplicationMode", modKeyboard.AM);
				MyProject.Computer.Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\BijoyEkushe\\Options", "TrayMode", myFunctions.TrayMode);
				MyProject.Computer.Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\BijoyEkushe\\Options", "DefaultLayout", modKeyboard.defLayout);
				MyProject.Computer.Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\BijoyEkushe\\Options", "Position", this.Left);
				MyProject.Computer.Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\BijoyEkushe\\Options", "LAM", this.CheckHandle.Enabled);
				MyProject.Computer.Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\BijoyEkushe\\Options", "Password", myFunctions.Password);
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x000D7414 File Offset: 0x000D5814
		private void frmMain_Load(object sender, EventArgs e)
		{
			this.ToolTip.SetToolTip(this.btnLEditor, "Keyboard Layout Editor...");
			this.ToolTip.SetToolTip(this.btnOptions, "Options...");
			this.ToolTip.SetToolTip(this.btnMinimize, "Goto SysTray");
			this.ToolTip.SetToolTip(this.btnClose, "Exit Bijoy Ekushe");
			try
			{
				MyProject.Computer.Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\BijoyEkushe\\Options", "ApplicationMode", modKeyboard.AM);
				MyProject.Computer.Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\BijoyEkushe\\Options", "Password", myFunctions.Password);
				MyProject.Computer.Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\BijoyEkushe\\Options", "TrayMode", myFunctions.TrayMode);
				MyProject.Computer.Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\BijoyEkushe\\Options", "DefaultLayout", modKeyboard.defLayout);
				MyProject.Computer.Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\BijoyEkushe\\Options", "Position", this.Left);
				MyProject.Computer.Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\BijoyEkushe\\Options", "LAM", this.CheckHandle.Enabled);
			}
			catch (Exception ex)
			{
			}
			MyProject.Forms.frmSplash.Hide();
			this.comLayouts.Items.Add("English");
			this.comLayouts.SelectedIndex = 0;
			ToolStripSeparator value = new ToolStripSeparator();
			ToolStripMenuItem toolStripMenuItem = new ToolStripMenuItem();
			toolStripMenuItem.Text = "English";
			toolStripMenuItem.Image = Resources.Main16;
			toolStripMenuItem.Tag = 1;
			toolStripMenuItem.CheckState = CheckState.Checked;
			this.NotifyMenu.Items.Insert(0, value);
			this.NotifyMenu.Items.Insert(0, toolStripMenuItem);
			modFindLayouts.Find();
			this.Top = 0;
			this.Height = 26;
			modKeyboard.HookKeyboard();
			this.Focus();
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x000D7634 File Offset: 0x000D5A34
		private void ShowToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Visible = true;
			this.FadeStatus = false;
			this.FadeTimer.Enabled = true;
			myFunctions.TrayMode = false;
			this.Focus();
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x000D7664 File Offset: 0x000D5A64
		private void FadeTimer_Tick(object sender, EventArgs e)
		{
			int num;
			int num4;
			object obj;
			try
			{
				IL_01:
				ProjectData.ClearProjectError();
				num = -2;
				IL_09:
				int num2 = 2;
				bool fadeStatus = this.FadeStatus;
				if (!fadeStatus)
				{
					goto IL_78;
				}
				IL_15:
				num2 = 3;
				bool flag = this.Opacity > 0.0;
				if (!flag)
				{
					goto IL_49;
				}
				IL_2E:
				num2 = 4;
				this.Opacity -= 0.01;
				IL_47:
				goto IL_75;
				IL_49:
				num2 = 6;
				IL_4C:
				num2 = 7;
				this.FadeTimer.Enabled = false;
				IL_5B:
				num2 = 8;
				this.Visible = false;
				IL_65:
				num2 = 9;
				this.NotifyIcon.Visible = true;
				IL_75:
				IL_76:
				goto IL_D7;
				IL_78:
				num2 = 12;
				IL_7C:
				num2 = 13;
				flag = (this.Opacity < 1.0);
				if (!flag)
				{
					goto IL_B2;
				}
				IL_96:
				num2 = 14;
				this.Opacity += 0.01;
				IL_B0:
				goto IL_D6;
				IL_B2:
				num2 = 16;
				IL_B6:
				num2 = 17;
				this.FadeTimer.Enabled = false;
				IL_C6:
				num2 = 18;
				this.NotifyIcon.Visible = false;
				IL_D6:
				IL_D7:
				IL_D8:
				goto IL_189;
				IL_E0:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_142:
				goto IL_17E;
				IL_144:
				num4 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], (num > -2) ? num : 1);
				IL_15C:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_144;
			}
			IL_17E:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_189:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x000D7820 File Offset: 0x000D5C20
		private void btnClose_Click(object sender, EventArgs e)
		{
			this.FadeStatus = true;
			this.FadeTimer.Enabled = true;
			while (this.FadeTimer.Enabled)
			{
				Application.DoEvents();
			}
			this.ExitToolStripMenuItem.PerformClick();
		}

		// Token: 0x060001BA RID: 442 RVA: 0x000D7868 File Offset: 0x000D5C68
		private void btnMinimize_Click(object sender, EventArgs e)
		{
			this.FadeStatus = true;
			this.FadeTimer.Enabled = true;
			myFunctions.TrayMode = true;
		}

		// Token: 0x060001BB RID: 443 RVA: 0x000D7888 File Offset: 0x000D5C88
		private void btnMinimize_MouseHover(object sender, EventArgs e)
		{
			this.btnMinimize.Width = 22;
			this.btnMinimize.Height = 22;
		}

		// Token: 0x060001BC RID: 444 RVA: 0x000D78A8 File Offset: 0x000D5CA8
		private void btnMinimize_MouseLeave(object sender, EventArgs e)
		{
			this.btnMinimize.Width = 18;
			this.btnMinimize.Height = 18;
		}

		// Token: 0x060001BD RID: 445 RVA: 0x000D78C8 File Offset: 0x000D5CC8
		private void btnOptions_MouseHover(object sender, EventArgs e)
		{
			this.btnOptions.Width = 20;
			this.btnOptions.Height = 20;
		}

		// Token: 0x060001BE RID: 446 RVA: 0x000D78E8 File Offset: 0x000D5CE8
		private void btnOptions_MouseLeave(object sender, EventArgs e)
		{
			this.btnOptions.Width = 18;
			this.btnOptions.Height = 18;
		}

		// Token: 0x060001BF RID: 447 RVA: 0x000D7908 File Offset: 0x000D5D08
		private void btnClose_MouseHover(object sender, EventArgs e)
		{
			this.btnClose.Width = 22;
			this.btnClose.Height = 22;
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x000D7928 File Offset: 0x000D5D28
		private void btnClose_MouseLeave(object sender, EventArgs e)
		{
			this.btnClose.Width = 18;
			this.btnClose.Height = 18;
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x000D7948 File Offset: 0x000D5D48
		private void comLayouts_SelectedIndexChanged(object sender, EventArgs e)
		{
			modKeyboard.curLayout = checked(this.comLayouts.SelectedIndex - 1);
			bool flag = modKeyboard.curLayout != -1;
			if (flag)
			{
				string str = myFunctions.VerifyPath(MyProject.Application.Info.DirectoryPath);
				str += "Icons\\";
				try
				{
					Icon icon = new Icon(str + modKeyboard.Layout[modKeyboard.curLayout].IconName + ".ico", 16, 16);
					this.NotifyIcon.Icon = icon;
					icon = new Icon(str + modKeyboard.Layout[modKeyboard.curLayout].IconName + ".ico", 24, 24);
					this.picIco.Image = icon.ToBitmap();
				}
				catch (Exception ex)
				{
					this.NotifyIcon.Icon = Resources.BanN;
					this.picIco.Image = Resources.Main;
					mHandleInfo.AddInfo((long)modKeyboard.GetForegroundWindow(), modKeyboard.Layout[modKeyboard.defLayout]);
				}
			}
			else
			{
				this.NotifyIcon.Icon = Resources.BanN;
				this.picIco.Image = Resources.Main;
			}
			flag = (this.comLayouts.SelectedIndex != 0);
			if (flag)
			{
				modKeyboard.defLayout = this.comLayouts.SelectedIndex;
			}
			try
			{
				foreach (object obj in this.NotifyMenu.Items)
				{
					ToolStripItem toolStripItem = (ToolStripItem)obj;
					flag = (Operators.ConditionalCompareObjectNotEqual(toolStripItem.Tag, null, false) && toolStripItem is ToolStripMenuItem);
					if (flag)
					{
						bool flag2 = Operators.ConditionalCompareObjectEqual(toolStripItem.Tag, checked(this.comLayouts.SelectedIndex + 1), false);
						if (flag2)
						{
							((ToolStripMenuItem)toolStripItem).Checked = true;
						}
						else
						{
							((ToolStripMenuItem)toolStripItem).Checked = false;
						}
					}
				}
			}
			finally
			{
				IEnumerator enumerator;
				bool flag2 = enumerator is IDisposable;
				if (flag2)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x000D7B78 File Offset: 0x000D5F78
		private void NotifyMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{
			bool flag = Operators.ConditionalCompareObjectNotEqual(e.ClickedItem.Tag, null, false);
			if (flag)
			{
				this.comLayouts.SelectedIndex = Conversions.ToInteger(Operators.SubtractObject(e.ClickedItem.Tag, 1));
			}
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x000D7BC8 File Offset: 0x000D5FC8
		private void frmMain_MouseDown(object sender, MouseEventArgs e)
		{
			this.Select();
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x000D7BD4 File Offset: 0x000D5FD4
		private void OptionToolStripMenuItem_Click(object sender, EventArgs e)
		{
			int num;
			int num4;
			object obj;
			try
			{
				IL_01:
				ProjectData.ClearProjectError();
				num = -2;
				IL_09:
				int num2 = 2;
				MyProject.Forms.frmOptions.ShowDialog();
				IL_1B:
				goto IL_81;
				IL_20:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_3A:
				goto IL_76;
				IL_3C:
				num4 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], (num > -2) ? num : 1);
				IL_54:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_3C;
			}
			IL_76:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_81:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x000D7C7C File Offset: 0x000D607C
		private void btnOptions_Click(object sender, EventArgs e)
		{
			int num;
			int num3;
			object obj;
			try
			{
				IL_01:
				ProjectData.ClearProjectError();
				num = -2;
				IL_09:
				goto IL_6B;
				IL_0E:
				int num2 = num3 + 1;
				num3 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num2);
				IL_24:
				goto IL_60;
				IL_26:
				int num4;
				num3 = num4;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], (num > -2) ? num : 1);
				IL_3E:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num3 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_26;
			}
			IL_60:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_6B:
			if (num3 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x000D7D10 File Offset: 0x000D6110
		private void picIco_Click(object sender, EventArgs e)
		{
			int num;
			int num4;
			object obj;
			try
			{
				IL_01:
				ProjectData.ClearProjectError();
				num = -2;
				IL_09:
				int num2 = 2;
				this.NotifyIcon_MouseClick(RuntimeHelpers.GetObjectValue(sender), (MouseEventArgs)e);
				IL_1E:
				goto IL_84;
				IL_23:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_3D:
				goto IL_79;
				IL_3F:
				num4 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], (num > -2) ? num : 1);
				IL_57:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_3F;
			}
			IL_79:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_84:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x060001C7 RID: 455 RVA: 0x000D7DBC File Offset: 0x000D61BC
		private void LayoutEditorToolStripMenuItem_Click(object sender, EventArgs e)
		{
			int num;
			int num4;
			object obj;
			try
			{
				IL_01:
				ProjectData.ClearProjectError();
				num = -2;
				IL_09:
				int num2 = 2;
				MyProject.Forms.frmLayoutCreator.Show();
				IL_1B:
				goto IL_81;
				IL_20:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_3A:
				goto IL_76;
				IL_3C:
				num4 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], (num > -2) ? num : 1);
				IL_54:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_3C;
			}
			IL_76:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_81:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x060001C8 RID: 456 RVA: 0x000D7E64 File Offset: 0x000D6264
		private void btnLEditor_Click(object sender, EventArgs e)
		{
			int num;
			int num4;
			object obj;
			try
			{
				IL_01:
				ProjectData.ClearProjectError();
				num = -2;
				IL_09:
				int num2 = 2;
				MyProject.Forms.frmLayoutCreator.Show();
				IL_1B:
				goto IL_81;
				IL_20:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_3A:
				goto IL_76;
				IL_3C:
				num4 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], (num > -2) ? num : 1);
				IL_54:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_3C;
			}
			IL_76:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_81:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x060001C9 RID: 457 RVA: 0x000D7F0C File Offset: 0x000D630C
		private void btnLEditor_MouseHover(object sender, EventArgs e)
		{
			this.btnLEditor.Width = 20;
			this.btnLEditor.Height = 20;
		}

		// Token: 0x060001CA RID: 458 RVA: 0x000D7F2C File Offset: 0x000D632C
		private void btnLEditor_MouseLeave(object sender, EventArgs e)
		{
			this.btnLEditor.Width = 18;
			this.btnLEditor.Height = 18;
		}

		// Token: 0x060001CB RID: 459 RVA: 0x000D7F4C File Offset: 0x000D634C
		private void frmMain_MouseHover(object sender, EventArgs e)
		{
			this.Select();
			this.Focus();
		}

		// Token: 0x060001CC RID: 460 RVA: 0x000D7F60 File Offset: 0x000D6360
		private void btnDrag_MouseDown(object sender, MouseEventArgs e)
		{
			myFunctions.Drag(this);
		}

		// Token: 0x060001CD RID: 461 RVA: 0x000D7F6C File Offset: 0x000D636C
		private void CheckHandle_Tick(object sender, EventArgs e)
		{
			int foregroundWindow = modKeyboard.GetForegroundWindow();
			bool flag = this.lastHandle != foregroundWindow;
			if (flag)
			{
				try
				{
					this.comLayouts.SelectedIndex = checked(mHandleInfo.FindInfo(unchecked((long)modKeyboard.GetForegroundWindow())).ID + 1);
				}
				catch (Exception ex)
				{
					this.comLayouts.SelectedIndex = 0;
				}
				this.lastHandle = foregroundWindow;
			}
		}

		// Token: 0x060001CE RID: 462 RVA: 0x000D7FE8 File Offset: 0x000D63E8
		private void NotifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
		{
		}

		// Token: 0x040000E5 RID: 229
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x040000E7 RID: 231
		[AccessedThroughProperty("NotifyIcon")]
		private NotifyIcon _NotifyIcon;

		// Token: 0x040000E8 RID: 232
		[AccessedThroughProperty("NotifyMenu")]
		private ContextMenuStrip _NotifyMenu;

		// Token: 0x040000E9 RID: 233
		[AccessedThroughProperty("ExitToolStripMenuItem")]
		private ToolStripMenuItem _ExitToolStripMenuItem;

		// Token: 0x040000EA RID: 234
		[AccessedThroughProperty("ToolStripSeparator1")]
		private ToolStripSeparator _ToolStripSeparator1;

		// Token: 0x040000EB RID: 235
		[AccessedThroughProperty("ShowToolStripMenuItem")]
		private ToolStripMenuItem _ShowToolStripMenuItem;

		// Token: 0x040000EC RID: 236
		[AccessedThroughProperty("FadeTimer")]
		private Timer _FadeTimer;

		// Token: 0x040000ED RID: 237
		[AccessedThroughProperty("btnClose")]
		private PictureBox _btnClose;

		// Token: 0x040000EE RID: 238
		[AccessedThroughProperty("btnMinimize")]
		private PictureBox _btnMinimize;

		// Token: 0x040000EF RID: 239
		[AccessedThroughProperty("picIco")]
		private PictureBox _picIco;

		// Token: 0x040000F0 RID: 240
		[AccessedThroughProperty("comLayouts")]
		private ComboBox _comLayouts;

		// Token: 0x040000F1 RID: 241
		[AccessedThroughProperty("btnOptions")]
		private PictureBox _btnOptions;

		// Token: 0x040000F2 RID: 242
		[AccessedThroughProperty("btnLEditor")]
		private PictureBox _btnLEditor;

		// Token: 0x040000F3 RID: 243
		[AccessedThroughProperty("ToolTip")]
		private ToolTip _ToolTip;

		// Token: 0x040000F4 RID: 244
		[AccessedThroughProperty("btnDrag")]
		private PictureBox _btnDrag;

		// Token: 0x040000F5 RID: 245
		[AccessedThroughProperty("CheckHandle")]
		private Timer _CheckHandle;

		// Token: 0x040000F6 RID: 246
		private bool FadeStatus;

		// Token: 0x040000F7 RID: 247
		private int lastHandle;
	}
}
