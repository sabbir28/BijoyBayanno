using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace BijoyBayanno
{
	// Token: 0x02000014 RID: 20
	[DesignerGenerated]
	public partial class frmDlg : Form
	{
		// Token: 0x0600003D RID: 61 RVA: 0x000CA7B4 File Offset: 0x000C8BB4
		[DebuggerNonUserCode]
		public frmDlg()
		{
			base.Load += this.frmDlg_Load;
			List<WeakReference> _ENCList = frmDlg.__ENCList;
			lock (_ENCList)
			{
				frmDlg.__ENCList.Add(new WeakReference(this));
			}
			this.InitializeComponent();
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000040 RID: 64 RVA: 0x000CAF4C File Offset: 0x000C934C
		// (set) Token: 0x06000041 RID: 65 RVA: 0x000CAF64 File Offset: 0x000C9364
		internal virtual TextBox TextBox1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._TextBox1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.TextBox1_TextChanged);
				bool flag = this._TextBox1 != null;
				if (flag)
				{
					this._TextBox1.TextChanged -= value2;
				}
				this._TextBox1 = value;
				flag = (this._TextBox1 != null);
				if (flag)
				{
					this._TextBox1.TextChanged += value2;
				}
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000042 RID: 66 RVA: 0x000CAFC4 File Offset: 0x000C93C4
		// (set) Token: 0x06000043 RID: 67 RVA: 0x000CAFDC File Offset: 0x000C93DC
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

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000044 RID: 68 RVA: 0x000CB03C File Offset: 0x000C943C
		// (set) Token: 0x06000045 RID: 69 RVA: 0x000CB054 File Offset: 0x000C9454
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

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000046 RID: 70 RVA: 0x000CB0B4 File Offset: 0x000C94B4
		// (set) Token: 0x06000047 RID: 71 RVA: 0x000CB0CC File Offset: 0x000C94CC
		internal virtual TextBox TextBox2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._TextBox2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._TextBox2 = value;
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000048 RID: 72 RVA: 0x000CB0D8 File Offset: 0x000C94D8
		// (set) Token: 0x06000049 RID: 73 RVA: 0x000CB0F0 File Offset: 0x000C94F0
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

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x0600004A RID: 74 RVA: 0x000CB0FC File Offset: 0x000C94FC
		// (set) Token: 0x0600004B RID: 75 RVA: 0x000CB114 File Offset: 0x000C9514
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

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x0600004C RID: 76 RVA: 0x000CB120 File Offset: 0x000C9520
		// (set) Token: 0x0600004D RID: 77 RVA: 0x000CB138 File Offset: 0x000C9538
		internal virtual Label Label3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label3 = value;
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x0600004E RID: 78 RVA: 0x000CB144 File Offset: 0x000C9544
		// (set) Token: 0x0600004F RID: 79 RVA: 0x000CB15C File Offset: 0x000C955C
		internal virtual Button btnExpand
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btnExpand;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btnExpand_Click);
				bool flag = this._btnExpand != null;
				if (flag)
				{
					this._btnExpand.Click -= value2;
				}
				this._btnExpand = value;
				flag = (this._btnExpand != null);
				if (flag)
				{
					this._btnExpand.Click += value2;
				}
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000050 RID: 80 RVA: 0x000CB1BC File Offset: 0x000C95BC
		// (set) Token: 0x06000051 RID: 81 RVA: 0x000CB1D4 File Offset: 0x000C95D4
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

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000052 RID: 82 RVA: 0x000CB1E0 File Offset: 0x000C95E0
		// (set) Token: 0x06000053 RID: 83 RVA: 0x000CB1F8 File Offset: 0x000C95F8
		internal virtual Label Label4
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label4;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label4 = value;
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000054 RID: 84 RVA: 0x000CB204 File Offset: 0x000C9604
		// (set) Token: 0x06000055 RID: 85 RVA: 0x000CB21C File Offset: 0x000C961C
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

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000056 RID: 86 RVA: 0x000CB228 File Offset: 0x000C9628
		// (set) Token: 0x06000057 RID: 87 RVA: 0x000CB240 File Offset: 0x000C9640
		internal virtual TextBox TextBox3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._TextBox3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.TextBox3_TextChanged);
				bool flag = this._TextBox3 != null;
				if (flag)
				{
					this._TextBox3.TextChanged -= value2;
				}
				this._TextBox3 = value;
				flag = (this._TextBox3 != null);
				if (flag)
				{
					this._TextBox3.TextChanged += value2;
				}
			}
		}

		// Token: 0x06000058 RID: 88 RVA: 0x000CB2A0 File Offset: 0x000C96A0
		private void OK_Button_Click(object sender, EventArgs e)
		{
			this.oStr = this.TextBox1.Text;
			this.Options = this.TextBox2.Text;
			this.DialogResult = DialogResult.OK;
			this.Close();
		}

		// Token: 0x06000059 RID: 89 RVA: 0x000CB2D8 File Offset: 0x000C96D8
		private void Cancel_Button_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}

		// Token: 0x0600005A RID: 90 RVA: 0x000CB2EC File Offset: 0x000C96EC
		private void btnExpand_Click(object sender, EventArgs e)
		{
			bool flag = Operators.CompareString(this.btnExpand.Text, ">", false) == 0;
			if (flag)
			{
				this.btnExpand.Text = "<";
				this.Width = 350;
				this.ToolTip.SetToolTip(this.btnExpand, "Click here for hide Advance Option");
			}
			else
			{
				this.btnExpand.Text = ">";
				this.Width = 190;
				this.ToolTip.SetToolTip(this.btnExpand, "Click here for Advance Option");
			}
		}

		// Token: 0x0600005B RID: 91 RVA: 0x000CB384 File Offset: 0x000C9784
		private void frmDlg_Load(object sender, EventArgs e)
		{
			bool flag = this.TextBox2.TextLength > 0;
			if (flag)
			{
				this.btnExpand.Text = "<";
				this.Width = 350;
				this.ToolTip.SetToolTip(this.btnExpand, "Click here for hide Advance Option");
			}
			else
			{
				this.btnExpand.Text = ">";
				this.Width = 190;
				this.ToolTip.SetToolTip(this.btnExpand, "Click here for Advance Option");
			}
		}

		// Token: 0x0600005C RID: 92 RVA: 0x000CB414 File Offset: 0x000C9814
		private void TextBox1_TextChanged(object sender, EventArgs e)
		{
			bool flag = !this.flagHex;
			checked
			{
				if (flag)
				{
					this.flagChar = true;
					string text = "";
					try
					{
						string text2 = this.TextBox1.Text;
						int num = 0;
						int num2 = text2.Length - 1;
						int num3 = num;
						for (;;)
						{
							int num4 = num3;
							int num5 = num2;
							if (num4 > num5)
							{
								break;
							}
							text = text + Conversion.Hex(Strings.AscW(text2.Substring(num3, 1))) + ",";
							num3++;
						}
					}
					catch (Exception ex)
					{
					}
					finally
					{
						flag = (text.Length - 1 >= 0);
						if (flag)
						{
							this.TextBox3.Text = Strings.Left(text, text.Length - 1);
						}
						else
						{
							this.TextBox3.Text = "";
						}
					}
					this.flagChar = false;
				}
			}
		}

		// Token: 0x0600005D RID: 93 RVA: 0x000CB504 File Offset: 0x000C9904
		private void TextBox3_TextChanged(object sender, EventArgs e)
		{
			bool flag = !this.flagChar;
			checked
			{
				if (flag)
				{
					this.flagHex = true;
					string text = "";
					try
					{
						string[] array = Strings.Split(this.TextBox3.Text, ",", -1, CompareMethod.Binary);
						int num = Information.LBound(array, 1);
						int num2 = Information.UBound(array, 1);
						int num3 = num;
						for (;;)
						{
							int num4 = num3;
							int num5 = num2;
							if (num4 > num5)
							{
								break;
							}
							text += Conversions.ToString(Strings.ChrW((int)Convert.ToInt16(array[num3], 16)));
							num3++;
						}
					}
					catch (Exception ex)
					{
					}
					finally
					{
						this.TextBox1.Text = text;
					}
					this.flagHex = false;
				}
			}
		}

		// Token: 0x04000049 RID: 73
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x0400004B RID: 75
		[AccessedThroughProperty("TextBox1")]
		private TextBox _TextBox1;

		// Token: 0x0400004C RID: 76
		[AccessedThroughProperty("OK_Button")]
		private Button _OK_Button;

		// Token: 0x0400004D RID: 77
		[AccessedThroughProperty("Cancel_Button")]
		private Button _Cancel_Button;

		// Token: 0x0400004E RID: 78
		[AccessedThroughProperty("TextBox2")]
		private TextBox _TextBox2;

		// Token: 0x0400004F RID: 79
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x04000050 RID: 80
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		// Token: 0x04000051 RID: 81
		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		// Token: 0x04000052 RID: 82
		[AccessedThroughProperty("btnExpand")]
		private Button _btnExpand;

		// Token: 0x04000053 RID: 83
		[AccessedThroughProperty("ToolTip")]
		private ToolTip _ToolTip;

		// Token: 0x04000054 RID: 84
		[AccessedThroughProperty("Label4")]
		private Label _Label4;

		// Token: 0x04000055 RID: 85
		[AccessedThroughProperty("Label5")]
		private Label _Label5;

		// Token: 0x04000056 RID: 86
		[AccessedThroughProperty("TextBox3")]
		private TextBox _TextBox3;

		// Token: 0x04000057 RID: 87
		public string oStr;

		// Token: 0x04000058 RID: 88
		public string Options;

		// Token: 0x04000059 RID: 89
		private bool flagChar;

		// Token: 0x0400005A RID: 90
		private bool flagHex;
	}
}
