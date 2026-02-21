using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using BijoyBayanno.My;
using BijoyBayanno.My.Resources;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace BijoyBayanno
{
	// Token: 0x02000017 RID: 23
	[DesignerGenerated]
	public partial class frmOptions : Form
	{
		// Token: 0x060001D0 RID: 464 RVA: 0x000D7FFC File Offset: 0x000D63FC
		[DebuggerNonUserCode]
		public frmOptions()
		{
			base.Load += this.frmSettings_Load;
			List<WeakReference> _ENCList = frmOptions.__ENCList;
			lock (_ENCList)
			{
				frmOptions.__ENCList.Add(new WeakReference(this));
			}
			this.InitializeComponent();
		}

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x060001D3 RID: 467 RVA: 0x000D9354 File Offset: 0x000D7754
		// (set) Token: 0x060001D4 RID: 468 RVA: 0x000D936C File Offset: 0x000D776C
		internal virtual TableLayoutPanel TableLayoutPanel1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._TableLayoutPanel1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._TableLayoutPanel1 = value;
			}
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x060001D5 RID: 469 RVA: 0x000D9378 File Offset: 0x000D7778
		// (set) Token: 0x060001D6 RID: 470 RVA: 0x000D9390 File Offset: 0x000D7790
		internal virtual Button OK_Button
		{
			[DebuggerNonUserCode]
			get
			{
				return this._OK_Button;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.OK_Button_Click);
				bool flag = this._OK_Button != null;
				if (flag)
				{
					this._OK_Button.Click -= value2;
				}
				this._OK_Button = value;
				flag = (this._OK_Button != null);
				if (flag)
				{
					this._OK_Button.Click += value2;
				}
			}
		}

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x060001D7 RID: 471 RVA: 0x000D93F0 File Offset: 0x000D77F0
		// (set) Token: 0x060001D8 RID: 472 RVA: 0x000D9408 File Offset: 0x000D7808
		internal virtual Button Cancel_Button
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Cancel_Button;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Cancel_Button_Click);
				bool flag = this._Cancel_Button != null;
				if (flag)
				{
					this._Cancel_Button.Click -= value2;
				}
				this._Cancel_Button = value;
				flag = (this._Cancel_Button != null);
				if (flag)
				{
					this._Cancel_Button.Click += value2;
				}
			}
		}

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x060001D9 RID: 473 RVA: 0x000D9468 File Offset: 0x000D7868
		// (set) Token: 0x060001DA RID: 474 RVA: 0x000D9480 File Offset: 0x000D7880
		internal virtual TabControl TabControl1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._TabControl1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._TabControl1 = value;
			}
		}

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x060001DB RID: 475 RVA: 0x000D948C File Offset: 0x000D788C
		// (set) Token: 0x060001DC RID: 476 RVA: 0x000D94A4 File Offset: 0x000D78A4
		internal virtual TabPage TabPage1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._TabPage1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._TabPage1 = value;
			}
		}

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x060001DD RID: 477 RVA: 0x000D94B0 File Offset: 0x000D78B0
		// (set) Token: 0x060001DE RID: 478 RVA: 0x000D94C8 File Offset: 0x000D78C8
		internal virtual TabPage TabPage2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._TabPage2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._TabPage2 = value;
			}
		}

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x060001DF RID: 479 RVA: 0x000D94D4 File Offset: 0x000D78D4
		// (set) Token: 0x060001E0 RID: 480 RVA: 0x000D94EC File Offset: 0x000D78EC
		internal virtual Button btnLayout
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btnLayout;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btnLayout_Click);
				bool flag = this._btnLayout != null;
				if (flag)
				{
					this._btnLayout.Click -= value2;
				}
				this._btnLayout = value;
				flag = (this._btnLayout != null);
				if (flag)
				{
					this._btnLayout.Click += value2;
				}
			}
		}

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x060001E1 RID: 481 RVA: 0x000D954C File Offset: 0x000D794C
		// (set) Token: 0x060001E2 RID: 482 RVA: 0x000D9564 File Offset: 0x000D7964
		internal virtual CheckBox chkStart
		{
			[DebuggerNonUserCode]
			get
			{
				return this._chkStart;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._chkStart = value;
			}
		}

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x060001E3 RID: 483 RVA: 0x000D9570 File Offset: 0x000D7970
		// (set) Token: 0x060001E4 RID: 484 RVA: 0x000D9588 File Offset: 0x000D7988
		internal virtual GroupBox GroupBox1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._GroupBox1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._GroupBox1 = value;
			}
		}

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x060001E5 RID: 485 RVA: 0x000D9594 File Offset: 0x000D7994
		// (set) Token: 0x060001E6 RID: 486 RVA: 0x000D95AC File Offset: 0x000D79AC
		internal virtual RadioButton rWindow
		{
			[DebuggerNonUserCode]
			get
			{
				return this._rWindow;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._rWindow = value;
			}
		}

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x060001E7 RID: 487 RVA: 0x000D95B8 File Offset: 0x000D79B8
		// (set) Token: 0x060001E8 RID: 488 RVA: 0x000D95D0 File Offset: 0x000D79D0
		internal virtual RadioButton rGlobal
		{
			[DebuggerNonUserCode]
			get
			{
				return this._rGlobal;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._rGlobal = value;
			}
		}

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x060001E9 RID: 489 RVA: 0x000D95DC File Offset: 0x000D79DC
		// (set) Token: 0x060001EA RID: 490 RVA: 0x000D95F4 File Offset: 0x000D79F4
		internal virtual GroupBox GroupBox2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._GroupBox2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._GroupBox2 = value;
			}
		}

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x060001EB RID: 491 RVA: 0x000D9600 File Offset: 0x000D7A00
		// (set) Token: 0x060001EC RID: 492 RVA: 0x000D9618 File Offset: 0x000D7A18
		internal virtual RadioButton rAM3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._rAM3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._rAM3 = value;
			}
		}

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x060001ED RID: 493 RVA: 0x000D9624 File Offset: 0x000D7A24
		// (set) Token: 0x060001EE RID: 494 RVA: 0x000D963C File Offset: 0x000D7A3C
		internal virtual RadioButton rAM2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._rAM2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._rAM2 = value;
			}
		}

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x060001EF RID: 495 RVA: 0x000D9648 File Offset: 0x000D7A48
		// (set) Token: 0x060001F0 RID: 496 RVA: 0x000D9660 File Offset: 0x000D7A60
		internal virtual RadioButton rAM1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._rAM1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._rAM1 = value;
			}
		}

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x060001F1 RID: 497 RVA: 0x000D966C File Offset: 0x000D7A6C
		// (set) Token: 0x060001F2 RID: 498 RVA: 0x000D9684 File Offset: 0x000D7A84
		internal virtual PictureBox PictureBox1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._PictureBox1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._PictureBox1 = value;
			}
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x060001F3 RID: 499 RVA: 0x000D9690 File Offset: 0x000D7A90
		// (set) Token: 0x060001F4 RID: 500 RVA: 0x000D96A8 File Offset: 0x000D7AA8
		internal virtual PictureBox PictureBox2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._PictureBox2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._PictureBox2 = value;
			}
		}

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x060001F5 RID: 501 RVA: 0x000D96B4 File Offset: 0x000D7AB4
		// (set) Token: 0x060001F6 RID: 502 RVA: 0x000D96CC File Offset: 0x000D7ACC
		internal virtual GroupBox GroupBox3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._GroupBox3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._GroupBox3 = value;
			}
		}

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x060001F7 RID: 503 RVA: 0x000D96D8 File Offset: 0x000D7AD8
		// (set) Token: 0x060001F8 RID: 504 RVA: 0x000D96F0 File Offset: 0x000D7AF0
		internal virtual ComboBox comKey
		{
			[DebuggerNonUserCode]
			get
			{
				return this._comKey;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._comKey = value;
			}
		}

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x060001F9 RID: 505 RVA: 0x000D96FC File Offset: 0x000D7AFC
		// (set) Token: 0x060001FA RID: 506 RVA: 0x000D9714 File Offset: 0x000D7B14
		internal virtual CheckBox chkShift
		{
			[DebuggerNonUserCode]
			get
			{
				return this._chkShift;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._chkShift = value;
			}
		}

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x060001FB RID: 507 RVA: 0x000D9720 File Offset: 0x000D7B20
		// (set) Token: 0x060001FC RID: 508 RVA: 0x000D9738 File Offset: 0x000D7B38
		internal virtual CheckBox chkCtrl
		{
			[DebuggerNonUserCode]
			get
			{
				return this._chkCtrl;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.chkCtrl_CheckedChanged);
				bool flag = this._chkCtrl != null;
				if (flag)
				{
					this._chkCtrl.CheckedChanged -= value2;
				}
				this._chkCtrl = value;
				flag = (this._chkCtrl != null);
				if (flag)
				{
					this._chkCtrl.CheckedChanged += value2;
				}
			}
		}

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x060001FD RID: 509 RVA: 0x000D9798 File Offset: 0x000D7B98
		// (set) Token: 0x060001FE RID: 510 RVA: 0x000D97B0 File Offset: 0x000D7BB0
		internal virtual CheckBox chkAlt
		{
			[DebuggerNonUserCode]
			get
			{
				return this._chkAlt;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.chkAlt_CheckedChanged);
				bool flag = this._chkAlt != null;
				if (flag)
				{
					this._chkAlt.CheckedChanged -= value2;
				}
				this._chkAlt = value;
				flag = (this._chkAlt != null);
				if (flag)
				{
					this._chkAlt.CheckedChanged += value2;
				}
			}
		}

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x060001FF RID: 511 RVA: 0x000D9810 File Offset: 0x000D7C10
		// (set) Token: 0x06000200 RID: 512 RVA: 0x000D9828 File Offset: 0x000D7C28
		internal virtual Label Label5
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label5;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label5 = value;
			}
		}

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x06000201 RID: 513 RVA: 0x000D9834 File Offset: 0x000D7C34
		// (set) Token: 0x06000202 RID: 514 RVA: 0x000D984C File Offset: 0x000D7C4C
		internal virtual Label Label2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label2 = value;
			}
		}

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x06000203 RID: 515 RVA: 0x000D9858 File Offset: 0x000D7C58
		// (set) Token: 0x06000204 RID: 516 RVA: 0x000D9870 File Offset: 0x000D7C70
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
				MouseEventHandler value3 = new MouseEventHandler(this.comLayouts_MouseClick);
				bool flag = this._comLayouts != null;
				if (flag)
				{
					this._comLayouts.SelectedIndexChanged -= value2;
					this._comLayouts.MouseClick -= value3;
				}
				this._comLayouts = value;
				flag = (this._comLayouts != null);
				if (flag)
				{
					this._comLayouts.SelectedIndexChanged += value2;
					this._comLayouts.MouseClick += value3;
				}
			}
		}

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x06000205 RID: 517 RVA: 0x000D98F8 File Offset: 0x000D7CF8
		// (set) Token: 0x06000206 RID: 518 RVA: 0x000D9910 File Offset: 0x000D7D10
		internal virtual Label Label1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label1 = value;
			}
		}

		// Token: 0x06000207 RID: 519 RVA: 0x000D991C File Offset: 0x000D7D1C
		private void OK_Button_Click(object sender, EventArgs e)
		{
			bool flag = this.rWindow.Checked;
			if (flag)
			{
				MyProject.Forms.frmMain.CheckHandle.Enabled = true;
			}
			else
			{
				MyProject.Forms.frmMain.CheckHandle.Enabled = false;
			}
			flag = this.rAM1.Checked;
			if (flag)
			{
				modKeyboard.AM = 1;
			}
			else
			{
				flag = this.rAM2.Checked;
				if (flag)
				{
					modKeyboard.AM = 2;
				}
				else
				{
					modKeyboard.AM = 3;
				}
			}
			try
			{
				flag = this.chkStart.Checked;
				if (flag)
				{
					MyProject.Computer.Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", "BijoyEkushe", myFunctions.VerifyPath(MyProject.Application.Info.DirectoryPath) + MyProject.Application.Info.AssemblyName + ".exe");
				}
				else
				{
					MyProject.Computer.Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", "BijoyEkushe", "");
				}
			}
			catch (Exception ex)
			{
				Interaction.MsgBox("Not enough privilege", MsgBoxStyle.Critical, null);
			}
			flag = this.chkAlt.Enabled;
			checked
			{
				if (flag)
				{
					this.WorkLay.Shortcut.Alt = this.chkAlt.Checked;
					this.WorkLay.Shortcut.Ctrl = this.chkCtrl.Checked;
					this.WorkLay.Shortcut.Shift = this.chkShift.Checked;
					flag = (this.chkAlt.Checked | this.chkCtrl.Checked);
					if (flag)
					{
						this.WorkLay.Shortcut.KeyCode = Strings.AscW(this.comKey.Text);
					}
					else
					{
						this.WorkLay.Shortcut.KeyCode = myFunctions.DefineKey(this.comKey.Text);
					}
					int num = Information.LBound(modKeyboard.Layout, 1);
					int num2 = Information.UBound(modKeyboard.Layout, 1);
					int num3 = num;
					for (;;)
					{
						int num4 = num3;
						int num5 = num2;
						if (num4 > num5)
						{
							goto Block_8;
						}
						flag = (modKeyboard.Layout[num3].Shortcut.Equals(this.WorkLay.Shortcut) & !modKeyboard.Layout[num3].Equals(this.WorkLay));
						if (flag)
						{
							break;
						}
						num3++;
					}
					Interaction.MsgBox(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Interaction.IIf(this.WorkLay.Shortcut.Alt, "Alt + ", ""), Interaction.IIf(this.WorkLay.Shortcut.Ctrl, "Ctrl + ", "")), Interaction.IIf(this.WorkLay.Shortcut.Shift, "Shift + ", "")), this.comKey.Text), " is already assigned to "), modKeyboard.Layout[num3].Name), " Layout"), "\r\n"), "Please, Change this Shortcut Key."), MsgBoxStyle.Critical, null);
					return;
					Block_8:
					try
					{
						MyProject.Computer.Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\BijoyEkushe\\Options\\" + this.WorkLay.Name, "Alt", this.WorkLay.Shortcut.Alt);
						MyProject.Computer.Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\BijoyEkushe\\Options\\" + this.WorkLay.Name, "Ctrl", this.WorkLay.Shortcut.Ctrl);
						MyProject.Computer.Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\BijoyEkushe\\Options\\" + this.WorkLay.Name, "Shift", this.WorkLay.Shortcut.Shift);
						MyProject.Computer.Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\BijoyEkushe\\Options\\" + this.WorkLay.Name, "KeyCode", this.WorkLay.Shortcut.KeyCode);
					}
					catch (Exception ex2)
					{
						Interaction.MsgBox("Not enough privilege", MsgBoxStyle.Critical, null);
					}
				}
				this.DialogResult = DialogResult.OK;
				this.Close();
			}
		}

		// Token: 0x06000208 RID: 520 RVA: 0x000D9D84 File Offset: 0x000D8184
		private void Cancel_Button_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}

		// Token: 0x06000209 RID: 521 RVA: 0x000D9D98 File Offset: 0x000D8198
		private void frmSettings_Load(object sender, EventArgs e)
		{
			this.rWindow.Checked = MyProject.Forms.frmMain.CheckHandle.Enabled;
			this.rAM2.Checked = (modKeyboard.AM == 2);
			this.rAM3.Checked = (modKeyboard.AM == 3);
			this.chkStart.Checked = Operators.ConditionalCompareObjectNotEqual(MyProject.Computer.Registry.GetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", "BijoyEkushe", ""), "", false);
			myFunctions.SetControlStyle(this.comKey, myFunctions.Style.ES_UPPERCASE);
			this.comLayouts.Items.Clear();
			int num = 1;
			checked
			{
				int num2 = MyProject.Forms.frmMain.comLayouts.Items.Count - 1;
				int num3 = num;
				for (;;)
				{
					int num4 = num3;
					int num5 = num2;
					if (num4 > num5)
					{
						break;
					}
					this.comLayouts.Items.Add(RuntimeHelpers.GetObjectValue(MyProject.Forms.frmMain.comLayouts.Items[num3]));
					num3++;
				}
				bool flag = this.comKey.Items.Count == 0;
				if (flag)
				{
					this.comKey.Items.Clear();
					num3 = 1;
					int num5;
					int num6;
					do
					{
						this.comKey.Items.Add("F" + Conversions.ToString(num3));
						num3++;
						num6 = num3;
						num5 = 12;
					}
					while (num6 <= num5);
					this.comKey.Text = "";
				}
			}
		}

		// Token: 0x0600020A RID: 522 RVA: 0x000D9F08 File Offset: 0x000D8308
		private void btnLayout_Click(object sender, EventArgs e)
		{
			this.Hide();
			MyProject.Forms.frmLayoutCreator.Show();
		}

		// Token: 0x0600020B RID: 523 RVA: 0x000D9F24 File Offset: 0x000D8324
		private void chkAlt_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = this.chkAlt.Checked | this.chkCtrl.Checked | this.chkShift.Checked;
			if (flag)
			{
				this.comKey.Items.Clear();
				short num = 48;
				short num2;
				short num3;
				do
				{
					this.comKey.Items.Add(Strings.Chr((int)num));
					num += 1;
					num2 = num;
					num3 = 57;
				}
				while (num2 <= num3);
				num = 65;
				short num4;
				do
				{
					this.comKey.Items.Add(Strings.Chr((int)num));
					num += 1;
					num4 = num;
					num3 = 90;
				}
				while (num4 <= num3);
				this.comKey.Text = "";
			}
			else
			{
				flag = !(this.chkCtrl.Checked & this.chkShift.Checked);
				if (flag)
				{
					this.comKey.Items.Clear();
					short num = 1;
					short num3;
					short num5;
					do
					{
						this.comKey.Items.Add("F" + Conversions.ToString((int)num));
						num += 1;
						num5 = num;
						num3 = 12;
					}
					while (num5 <= num3);
					this.comKey.Text = "";
				}
			}
		}

		// Token: 0x0600020C RID: 524 RVA: 0x000DA048 File Offset: 0x000D8448
		private void chkCtrl_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = this.chkAlt.Checked | this.chkCtrl.Checked | this.chkShift.Checked;
			if (flag)
			{
				this.comKey.Items.Clear();
				short num = 48;
				short num2;
				short num3;
				do
				{
					this.comKey.Items.Add(Strings.Chr((int)num));
					num += 1;
					num2 = num;
					num3 = 57;
				}
				while (num2 <= num3);
				num = 65;
				short num4;
				do
				{
					this.comKey.Items.Add(Strings.Chr((int)num));
					num += 1;
					num4 = num;
					num3 = 90;
				}
				while (num4 <= num3);
				this.comKey.Text = "";
			}
			else
			{
				flag = !(this.chkAlt.Checked & this.chkShift.Checked);
				if (flag)
				{
					this.comKey.Items.Clear();
					short num = 1;
					short num3;
					short num5;
					do
					{
						this.comKey.Items.Add("F" + Conversions.ToString((int)num));
						num += 1;
						num5 = num;
						num3 = 12;
					}
					while (num5 <= num3);
					this.comKey.Text = "";
				}
			}
		}

		// Token: 0x0600020D RID: 525 RVA: 0x000DA16C File Offset: 0x000D856C
		private void comLayouts_MouseClick(object sender, MouseEventArgs e)
		{
		}

		// Token: 0x0600020E RID: 526 RVA: 0x000DA170 File Offset: 0x000D8570
		private void comLayouts_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.comKey.Enabled = (this.comLayouts.Text.Length > 1);
			this.chkAlt.Enabled = (this.comLayouts.Text.Length > 1);
			this.chkCtrl.Enabled = (this.comLayouts.Text.Length > 1);
			this.chkShift.Enabled = (this.comLayouts.Text.Length > 1);
			this.WorkLay = modKeyboard.Layout[this.comLayouts.SelectedIndex];
			this.chkAlt.Checked = this.WorkLay.Shortcut.Alt;
			this.chkCtrl.Checked = this.WorkLay.Shortcut.Ctrl;
			this.chkShift.Checked = this.WorkLay.Shortcut.Shift;
			bool flag = this.chkAlt.Checked | this.chkCtrl.Checked;
			if (flag)
			{
				this.comKey.Text = Conversions.ToString(Strings.Chr(this.WorkLay.Shortcut.KeyCode));
			}
			else
			{
				this.comKey.Text = "F" + Conversions.ToString(checked(this.WorkLay.Shortcut.KeyCode - 111));
			}
		}

		// Token: 0x040000F8 RID: 248
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x040000FA RID: 250
		[AccessedThroughProperty("TableLayoutPanel1")]
		private TableLayoutPanel _TableLayoutPanel1;

		// Token: 0x040000FB RID: 251
		[AccessedThroughProperty("OK_Button")]
		private Button _OK_Button;

		// Token: 0x040000FC RID: 252
		[AccessedThroughProperty("Cancel_Button")]
		private Button _Cancel_Button;

		// Token: 0x040000FD RID: 253
		[AccessedThroughProperty("TabControl1")]
		private TabControl _TabControl1;

		// Token: 0x040000FE RID: 254
		[AccessedThroughProperty("TabPage1")]
		private TabPage _TabPage1;

		// Token: 0x040000FF RID: 255
		[AccessedThroughProperty("TabPage2")]
		private TabPage _TabPage2;

		// Token: 0x04000100 RID: 256
		[AccessedThroughProperty("btnLayout")]
		private Button _btnLayout;

		// Token: 0x04000101 RID: 257
		[AccessedThroughProperty("chkStart")]
		private CheckBox _chkStart;

		// Token: 0x04000102 RID: 258
		[AccessedThroughProperty("GroupBox1")]
		private GroupBox _GroupBox1;

		// Token: 0x04000103 RID: 259
		[AccessedThroughProperty("rWindow")]
		private RadioButton _rWindow;

		// Token: 0x04000104 RID: 260
		[AccessedThroughProperty("rGlobal")]
		private RadioButton _rGlobal;

		// Token: 0x04000105 RID: 261
		[AccessedThroughProperty("GroupBox2")]
		private GroupBox _GroupBox2;

		// Token: 0x04000106 RID: 262
		[AccessedThroughProperty("rAM3")]
		private RadioButton _rAM3;

		// Token: 0x04000107 RID: 263
		[AccessedThroughProperty("rAM2")]
		private RadioButton _rAM2;

		// Token: 0x04000108 RID: 264
		[AccessedThroughProperty("rAM1")]
		private RadioButton _rAM1;

		// Token: 0x04000109 RID: 265
		[AccessedThroughProperty("PictureBox1")]
		private PictureBox _PictureBox1;

		// Token: 0x0400010A RID: 266
		[AccessedThroughProperty("PictureBox2")]
		private PictureBox _PictureBox2;

		// Token: 0x0400010B RID: 267
		[AccessedThroughProperty("GroupBox3")]
		private GroupBox _GroupBox3;

		// Token: 0x0400010C RID: 268
		[AccessedThroughProperty("comKey")]
		private ComboBox _comKey;

		// Token: 0x0400010D RID: 269
		[AccessedThroughProperty("chkShift")]
		private CheckBox _chkShift;

		// Token: 0x0400010E RID: 270
		[AccessedThroughProperty("chkCtrl")]
		private CheckBox _chkCtrl;

		// Token: 0x0400010F RID: 271
		[AccessedThroughProperty("chkAlt")]
		private CheckBox _chkAlt;

		// Token: 0x04000110 RID: 272
		[AccessedThroughProperty("Label5")]
		private Label _Label5;

		// Token: 0x04000111 RID: 273
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		// Token: 0x04000112 RID: 274
		[AccessedThroughProperty("comLayouts")]
		private ComboBox _comLayouts;

		// Token: 0x04000113 RID: 275
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x04000114 RID: 276
		private clsLayouts WorkLay;
	}
}
