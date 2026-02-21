using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using BijoyBayanno.My;
using Microsoft.VisualBasic.CompilerServices;

namespace BijoyBayanno
{
	// Token: 0x02000023 RID: 35
	[DesignerGenerated]
	public class myButton : UserControl
	{
		// Token: 0x06000272 RID: 626 RVA: 0x000DB824 File Offset: 0x000D9C24
		[DebuggerNonUserCode]
		public myButton()
		{
			List<WeakReference> _ENCList = myButton.__ENCList;
			lock (_ENCList)
			{
				myButton.__ENCList.Add(new WeakReference(this));
			}
			this.InitializeComponent();
		}

		// Token: 0x06000273 RID: 627 RVA: 0x000DB87C File Offset: 0x000D9C7C
		[DebuggerNonUserCode]
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000274 RID: 628 RVA: 0x000DB8B4 File Offset: 0x000D9CB4
		[DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.mButton = new Button();
			this.SuspendLayout();
			this.mButton.Dock = DockStyle.Fill;
			this.mButton.FlatStyle = FlatStyle.Flat;
			Control mButton = this.mButton;
			Point location = new Point(0, 0);
			mButton.Location = location;
			this.mButton.Name = "mButton";
			Control mButton2 = this.mButton;
			Size size = new Size(35, 35);
			mButton2.Size = size;
			this.mButton.TabIndex = 2;
			this.mButton.UseVisualStyleBackColor = true;
			SizeF autoScaleDimensions = new SizeF(6f, 13f);
			this.AutoScaleDimensions = autoScaleDimensions;
			this.AutoScaleMode = AutoScaleMode.Font;
			this.Controls.Add(this.mButton);
			this.Name = "myButton";
			size = new Size(35, 35);
			this.Size = size;
			this.ResumeLayout(false);
		}

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x06000275 RID: 629 RVA: 0x000DB9A8 File Offset: 0x000D9DA8
		// (set) Token: 0x06000276 RID: 630 RVA: 0x000DB9C0 File Offset: 0x000D9DC0
		internal virtual Button mButton
		{
			[DebuggerNonUserCode]
			get
			{
				return this._mButton;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				KeyPressEventHandler value2 = new KeyPressEventHandler(this.mButton_KeyPress);
				EventHandler value3 = new EventHandler(this.mButton_Click);
				bool flag = this._mButton != null;
				if (flag)
				{
					this._mButton.KeyPress -= value2;
					this._mButton.Click -= value3;
				}
				this._mButton = value;
				flag = (this._mButton != null);
				if (flag)
				{
					this._mButton.KeyPress += value2;
					this._mButton.Click += value3;
				}
			}
		}

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x06000277 RID: 631 RVA: 0x000DBA48 File Offset: 0x000D9E48
		// (set) Token: 0x06000278 RID: 632 RVA: 0x000DBA60 File Offset: 0x000D9E60
		public string NormalKey
		{
			get
			{
				return this.nKey;
			}
			set
			{
				this.nKey = value;
				bool flag = !this.ShiftState;
				if (flag)
				{
					this.mButton.Text = value;
				}
			}
		}

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x06000279 RID: 633 RVA: 0x000DBA90 File Offset: 0x000D9E90
		// (set) Token: 0x0600027A RID: 634 RVA: 0x000DBAA8 File Offset: 0x000D9EA8
		public string NormalKeyOption
		{
			get
			{
				return this.nKeyOption;
			}
			set
			{
				this.nKeyOption = value;
			}
		}

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x0600027B RID: 635 RVA: 0x000DBAB4 File Offset: 0x000D9EB4
		// (set) Token: 0x0600027C RID: 636 RVA: 0x000DBACC File Offset: 0x000D9ECC
		public string ShiftKey
		{
			get
			{
				return this.sKey;
			}
			set
			{
				this.sKey = value;
				bool shiftState = this.ShiftState;
				if (shiftState)
				{
					this.mButton.Text = value;
				}
			}
		}

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x0600027D RID: 637 RVA: 0x000DBAFC File Offset: 0x000D9EFC
		// (set) Token: 0x0600027E RID: 638 RVA: 0x000DBB14 File Offset: 0x000D9F14
		public string ShiftKeyOption
		{
			get
			{
				return this.sKeyOption;
			}
			set
			{
				this.sKeyOption = value;
			}
		}

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x0600027F RID: 639 RVA: 0x000DBB20 File Offset: 0x000D9F20
		// (set) Token: 0x06000280 RID: 640 RVA: 0x000DBB38 File Offset: 0x000D9F38
		public bool ShiftState
		{
			get
			{
				return this.kState;
			}
			set
			{
				this.kState = value;
				bool flag = this.kState;
				if (flag)
				{
					this.mButton.Text = this.sKey;
				}
				else
				{
					this.mButton.Text = this.nKey;
				}
			}
		}

		// Token: 0x06000281 RID: 641 RVA: 0x000DBB80 File Offset: 0x000D9F80
		private void mButton_Click(object sender, EventArgs e)
		{
			bool flag = this.kState;
			if (flag)
			{
				frmDlg frmDlg = new frmDlg();
				frmDlg.Text = "Enter Value";
				frmDlg.TextBox1.Text = this.ShiftKey;
				frmDlg.TextBox2.Text = this.ShiftKeyOption;
				frmDlg.TextBox1.Font = MyProject.Forms.frmLayoutCreator.dlgFont.Font;
				frmDlg.ShowDialog();
				flag = (Operators.CompareString(frmDlg.oStr, "", false) != 0);
				if (flag)
				{
					this.ShiftKey = frmDlg.oStr;
					this.mButton.Font = MyProject.Forms.frmLayoutCreator.dlgFont.Font;
				}
				flag = (Operators.CompareString(frmDlg.Options, "", false) != 0);
				if (flag)
				{
					this.ShiftKeyOption = frmDlg.Options;
				}
			}
			else
			{
				frmDlg frmDlg2 = new frmDlg();
				frmDlg2.Text = "Enter Value";
				frmDlg2.TextBox1.Text = this.NormalKey;
				frmDlg2.TextBox2.Text = this.NormalKeyOption;
				frmDlg2.TextBox1.Font = MyProject.Forms.frmLayoutCreator.dlgFont.Font;
				frmDlg2.ShowDialog();
				flag = (Operators.CompareString(frmDlg2.oStr, "", false) != 0);
				if (flag)
				{
					this.NormalKey = frmDlg2.oStr;
					this.mButton.Font = MyProject.Forms.frmLayoutCreator.dlgFont.Font;
				}
				flag = (Operators.CompareString(frmDlg2.Options, "", false) != 0);
				if (flag)
				{
					this.NormalKeyOption = frmDlg2.Options;
				}
			}
		}

		// Token: 0x06000282 RID: 642 RVA: 0x000DBD44 File Offset: 0x000DA144
		private void mButton_KeyPress(object sender, KeyPressEventArgs e)
		{
		}

		// Token: 0x04000155 RID: 341
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x04000156 RID: 342
		private IContainer components;

		// Token: 0x04000157 RID: 343
		[AccessedThroughProperty("mButton")]
		private Button _mButton;

		// Token: 0x04000158 RID: 344
		private string nKey;

		// Token: 0x04000159 RID: 345
		private string nKeyOption;

		// Token: 0x0400015A RID: 346
		private string sKey;

		// Token: 0x0400015B RID: 347
		private string sKeyOption;

		// Token: 0x0400015C RID: 348
		private bool kState;
	}
}
