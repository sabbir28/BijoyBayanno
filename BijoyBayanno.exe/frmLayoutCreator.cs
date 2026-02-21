using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Xml;
using BijoyBayanno.My;
using BijoyBayanno.My.Resources;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.Compatibility.VB6;
using Microsoft.VisualBasic.CompilerServices;

namespace BijoyBayanno
{
	// Token: 0x02000015 RID: 21
	[DesignerGenerated]
	public partial class frmLayoutCreator : Form
	{
		// Token: 0x0600005F RID: 95 RVA: 0x000CB5DC File Offset: 0x000C99DC
		public frmLayoutCreator()
		{
			base.Activated += this.frmLayoutCreator_Activated;
			base.KeyDown += this.frmLayoutCreator_KeyDown;
			base.Load += this.frmLayoutCreator_Load;
			List<WeakReference> _ENCList = frmLayoutCreator.__ENCList;
			lock (_ENCList)
			{
				frmLayoutCreator.__ENCList.Add(new WeakReference(this));
			}
			this.blankLayout = new Dictionary<int, string[]>();
			this.InitializeComponent();
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000062 RID: 98 RVA: 0x000D1630 File Offset: 0x000CFA30
		// (set) Token: 0x06000063 RID: 99 RVA: 0x000D1648 File Offset: 0x000CFA48
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

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000064 RID: 100 RVA: 0x000D1654 File Offset: 0x000CFA54
		// (set) Token: 0x06000065 RID: 101 RVA: 0x000D166C File Offset: 0x000CFA6C
		internal virtual TextBox txtName
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txtName;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.txtName_TextChanged);
				bool flag = this._txtName != null;
				if (flag)
				{
					this._txtName.TextChanged -= value2;
				}
				this._txtName = value;
				flag = (this._txtName != null);
				if (flag)
				{
					this._txtName.TextChanged += value2;
				}
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000066 RID: 102 RVA: 0x000D16CC File Offset: 0x000CFACC
		// (set) Token: 0x06000067 RID: 103 RVA: 0x000D16E4 File Offset: 0x000CFAE4
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

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000068 RID: 104 RVA: 0x000D16F0 File Offset: 0x000CFAF0
		// (set) Token: 0x06000069 RID: 105 RVA: 0x000D1708 File Offset: 0x000CFB08
		internal virtual TextBox txtIco
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txtIco;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.txtIco_TextChanged);
				bool flag = this._txtIco != null;
				if (flag)
				{
					this._txtIco.TextChanged -= value2;
				}
				this._txtIco = value;
				flag = (this._txtIco != null);
				if (flag)
				{
					this._txtIco.TextChanged += value2;
				}
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x0600006A RID: 106 RVA: 0x000D1768 File Offset: 0x000CFB68
		// (set) Token: 0x0600006B RID: 107 RVA: 0x000D1780 File Offset: 0x000CFB80
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

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x0600006C RID: 108 RVA: 0x000D178C File Offset: 0x000CFB8C
		// (set) Token: 0x0600006D RID: 109 RVA: 0x000D17A4 File Offset: 0x000CFBA4
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

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x0600006E RID: 110 RVA: 0x000D17B0 File Offset: 0x000CFBB0
		// (set) Token: 0x0600006F RID: 111 RVA: 0x000D17C8 File Offset: 0x000CFBC8
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

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x06000070 RID: 112 RVA: 0x000D17D4 File Offset: 0x000CFBD4
		// (set) Token: 0x06000071 RID: 113 RVA: 0x000D17EC File Offset: 0x000CFBEC
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

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06000072 RID: 114 RVA: 0x000D17F8 File Offset: 0x000CFBF8
		// (set) Token: 0x06000073 RID: 115 RVA: 0x000D1810 File Offset: 0x000CFC10
		internal virtual Label Label6
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label6;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label6 = value;
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x06000074 RID: 116 RVA: 0x000D181C File Offset: 0x000CFC1C
		// (set) Token: 0x06000075 RID: 117 RVA: 0x000D1834 File Offset: 0x000CFC34
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
				EventHandler value2 = new EventHandler(this.comLayouts_TextChanged);
				MouseEventHandler value3 = new MouseEventHandler(this.comLayouts_MouseClick);
				bool flag = this._comLayouts != null;
				if (flag)
				{
					this._comLayouts.TextChanged -= value2;
					this._comLayouts.MouseClick -= value3;
				}
				this._comLayouts = value;
				flag = (this._comLayouts != null);
				if (flag)
				{
					this._comLayouts.TextChanged += value2;
					this._comLayouts.MouseClick += value3;
				}
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x06000076 RID: 118 RVA: 0x000D18BC File Offset: 0x000CFCBC
		// (set) Token: 0x06000077 RID: 119 RVA: 0x000D18D4 File Offset: 0x000CFCD4
		internal virtual Label Label7
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label7;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label7 = value;
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x06000078 RID: 120 RVA: 0x000D18E0 File Offset: 0x000CFCE0
		// (set) Token: 0x06000079 RID: 121 RVA: 0x000D18F8 File Offset: 0x000CFCF8
		internal virtual Button btnEdit
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btnEdit;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btnEdit_Click);
				bool flag = this._btnEdit != null;
				if (flag)
				{
					this._btnEdit.Click -= value2;
				}
				this._btnEdit = value;
				flag = (this._btnEdit != null);
				if (flag)
				{
					this._btnEdit.Click += value2;
				}
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x0600007A RID: 122 RVA: 0x000D1958 File Offset: 0x000CFD58
		// (set) Token: 0x0600007B RID: 123 RVA: 0x000D1970 File Offset: 0x000CFD70
		internal virtual Button btnNew
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btnNew;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btnNew_Click);
				bool flag = this._btnNew != null;
				if (flag)
				{
					this._btnNew.Click -= value2;
				}
				this._btnNew = value;
				flag = (this._btnNew != null);
				if (flag)
				{
					this._btnNew.Click += value2;
				}
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x0600007C RID: 124 RVA: 0x000D19D0 File Offset: 0x000CFDD0
		// (set) Token: 0x0600007D RID: 125 RVA: 0x000D19E8 File Offset: 0x000CFDE8
		internal virtual FontDialog dlgFont
		{
			[DebuggerNonUserCode]
			get
			{
				return this._dlgFont;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.dlgFont_Apply);
				bool flag = this._dlgFont != null;
				if (flag)
				{
					this._dlgFont.Apply -= value2;
				}
				this._dlgFont = value;
				flag = (this._dlgFont != null);
				if (flag)
				{
					this._dlgFont.Apply += value2;
				}
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x0600007E RID: 126 RVA: 0x000D1A48 File Offset: 0x000CFE48
		// (set) Token: 0x0600007F RID: 127 RVA: 0x000D1A60 File Offset: 0x000CFE60
		internal virtual Button btnFont
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btnFont;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btnFont_Click);
				bool flag = this._btnFont != null;
				if (flag)
				{
					this._btnFont.Click -= value2;
				}
				this._btnFont = value;
				flag = (this._btnFont != null);
				if (flag)
				{
					this._btnFont.Click += value2;
				}
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x06000080 RID: 128 RVA: 0x000D1AC0 File Offset: 0x000CFEC0
		// (set) Token: 0x06000081 RID: 129 RVA: 0x000D1AD8 File Offset: 0x000CFED8
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

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x06000082 RID: 130 RVA: 0x000D1AE4 File Offset: 0x000CFEE4
		// (set) Token: 0x06000083 RID: 131 RVA: 0x000D1AFC File Offset: 0x000CFEFC
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

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x06000084 RID: 132 RVA: 0x000D1B08 File Offset: 0x000CFF08
		// (set) Token: 0x06000085 RID: 133 RVA: 0x000D1B20 File Offset: 0x000CFF20
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

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x06000086 RID: 134 RVA: 0x000D1B80 File Offset: 0x000CFF80
		// (set) Token: 0x06000087 RID: 135 RVA: 0x000D1B98 File Offset: 0x000CFF98
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

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x06000088 RID: 136 RVA: 0x000D1BF8 File Offset: 0x000CFFF8
		// (set) Token: 0x06000089 RID: 137 RVA: 0x000D1C10 File Offset: 0x000D0010
		internal virtual Button btnSave
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btnSave;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btnSave_Click);
				bool flag = this._btnSave != null;
				if (flag)
				{
					this._btnSave.Click -= value2;
				}
				this._btnSave = value;
				flag = (this._btnSave != null);
				if (flag)
				{
					this._btnSave.Click += value2;
				}
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x0600008A RID: 138 RVA: 0x000D1C70 File Offset: 0x000D0070
		// (set) Token: 0x0600008B RID: 139 RVA: 0x000D1C88 File Offset: 0x000D0088
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

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x0600008C RID: 140 RVA: 0x000D1C94 File Offset: 0x000D0094
		// (set) Token: 0x0600008D RID: 141 RVA: 0x000D1CAC File Offset: 0x000D00AC
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

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x0600008E RID: 142 RVA: 0x000D1CB8 File Offset: 0x000D00B8
		// (set) Token: 0x0600008F RID: 143 RVA: 0x000D1CD0 File Offset: 0x000D00D0
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

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x06000090 RID: 144 RVA: 0x000D1CDC File Offset: 0x000D00DC
		// (set) Token: 0x06000091 RID: 145 RVA: 0x000D1CF4 File Offset: 0x000D00F4
		internal virtual CheckBox chkRShift
		{
			[DebuggerNonUserCode]
			get
			{
				return this._chkRShift;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.chkRShift_Click);
				bool flag = this._chkRShift != null;
				if (flag)
				{
					this._chkRShift.Click -= value2;
				}
				this._chkRShift = value;
				flag = (this._chkRShift != null);
				if (flag)
				{
					this._chkRShift.Click += value2;
				}
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x06000092 RID: 146 RVA: 0x000D1D54 File Offset: 0x000D0154
		// (set) Token: 0x06000093 RID: 147 RVA: 0x000D1D6C File Offset: 0x000D016C
		internal virtual CheckBox chkLShift
		{
			[DebuggerNonUserCode]
			get
			{
				return this._chkLShift;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.chkLShift_CheckedChanged);
				bool flag = this._chkLShift != null;
				if (flag)
				{
					this._chkLShift.CheckedChanged -= value2;
				}
				this._chkLShift = value;
				flag = (this._chkLShift != null);
				if (flag)
				{
					this._chkLShift.CheckedChanged += value2;
				}
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x06000094 RID: 148 RVA: 0x000D1DCC File Offset: 0x000D01CC
		// (set) Token: 0x06000095 RID: 149 RVA: 0x000D1DE4 File Offset: 0x000D01E4
		internal virtual Button Button30
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Button30;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Button30 = value;
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x06000096 RID: 150 RVA: 0x000D1DF0 File Offset: 0x000D01F0
		// (set) Token: 0x06000097 RID: 151 RVA: 0x000D1E08 File Offset: 0x000D0208
		internal virtual Button Button29
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Button29;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Button29 = value;
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x06000098 RID: 152 RVA: 0x000D1E14 File Offset: 0x000D0214
		// (set) Token: 0x06000099 RID: 153 RVA: 0x000D1E2C File Offset: 0x000D022C
		internal virtual Button Button28
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Button28;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Button28 = value;
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x0600009A RID: 154 RVA: 0x000D1E38 File Offset: 0x000D0238
		// (set) Token: 0x0600009B RID: 155 RVA: 0x000D1E50 File Offset: 0x000D0250
		internal virtual Button Button27
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Button27;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Button27 = value;
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x0600009C RID: 156 RVA: 0x000D1E5C File Offset: 0x000D025C
		// (set) Token: 0x0600009D RID: 157 RVA: 0x000D1E74 File Offset: 0x000D0274
		internal virtual Button Button26
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Button26;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Button26 = value;
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x0600009E RID: 158 RVA: 0x000D1E80 File Offset: 0x000D0280
		// (set) Token: 0x0600009F RID: 159 RVA: 0x000D1E98 File Offset: 0x000D0298
		internal virtual Button Button23
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Button23;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Button23 = value;
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060000A0 RID: 160 RVA: 0x000D1EA4 File Offset: 0x000D02A4
		// (set) Token: 0x060000A1 RID: 161 RVA: 0x000D1EBC File Offset: 0x000D02BC
		internal virtual Button Button24
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Button24;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Button24 = value;
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060000A2 RID: 162 RVA: 0x000D1EC8 File Offset: 0x000D02C8
		// (set) Token: 0x060000A3 RID: 163 RVA: 0x000D1EE0 File Offset: 0x000D02E0
		internal virtual Button Button25
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Button25;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Button25 = value;
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x060000A4 RID: 164 RVA: 0x000D1EEC File Offset: 0x000D02EC
		// (set) Token: 0x060000A5 RID: 165 RVA: 0x000D1F04 File Offset: 0x000D0304
		internal virtual Button Button20
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Button20;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Button20 = value;
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x060000A6 RID: 166 RVA: 0x000D1F10 File Offset: 0x000D0310
		// (set) Token: 0x060000A7 RID: 167 RVA: 0x000D1F28 File Offset: 0x000D0328
		internal virtual Button Button21
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Button21;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Button21 = value;
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x060000A8 RID: 168 RVA: 0x000D1F34 File Offset: 0x000D0334
		// (set) Token: 0x060000A9 RID: 169 RVA: 0x000D1F4C File Offset: 0x000D034C
		internal virtual Button Button22
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Button22;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Button22 = value;
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x060000AA RID: 170 RVA: 0x000D1F58 File Offset: 0x000D0358
		// (set) Token: 0x060000AB RID: 171 RVA: 0x000D1F70 File Offset: 0x000D0370
		internal virtual Button Button17
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Button17;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Button17 = value;
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x060000AC RID: 172 RVA: 0x000D1F7C File Offset: 0x000D037C
		// (set) Token: 0x060000AD RID: 173 RVA: 0x000D1F94 File Offset: 0x000D0394
		internal virtual Button Button18
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Button18;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Button18 = value;
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x060000AE RID: 174 RVA: 0x000D1FA0 File Offset: 0x000D03A0
		// (set) Token: 0x060000AF RID: 175 RVA: 0x000D1FB8 File Offset: 0x000D03B8
		internal virtual Button Button19
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Button19;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Button19 = value;
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x060000B0 RID: 176 RVA: 0x000D1FC4 File Offset: 0x000D03C4
		// (set) Token: 0x060000B1 RID: 177 RVA: 0x000D1FDC File Offset: 0x000D03DC
		internal virtual Button Button16
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Button16;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Button16 = value;
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x060000B2 RID: 178 RVA: 0x000D1FE8 File Offset: 0x000D03E8
		// (set) Token: 0x060000B3 RID: 179 RVA: 0x000D2000 File Offset: 0x000D0400
		internal virtual Button Button15
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Button15;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Button15 = value;
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x060000B4 RID: 180 RVA: 0x000D200C File Offset: 0x000D040C
		// (set) Token: 0x060000B5 RID: 181 RVA: 0x000D2024 File Offset: 0x000D0424
		internal virtual Button Button14
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Button14;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Button14 = value;
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x060000B6 RID: 182 RVA: 0x000D2030 File Offset: 0x000D0430
		// (set) Token: 0x060000B7 RID: 183 RVA: 0x000D2048 File Offset: 0x000D0448
		internal virtual Button Button11
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Button11;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Button11 = value;
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x060000B8 RID: 184 RVA: 0x000D2054 File Offset: 0x000D0454
		// (set) Token: 0x060000B9 RID: 185 RVA: 0x000D206C File Offset: 0x000D046C
		internal virtual Button Button13
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Button13;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Button13 = value;
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x060000BA RID: 186 RVA: 0x000D2078 File Offset: 0x000D0478
		// (set) Token: 0x060000BB RID: 187 RVA: 0x000D2090 File Offset: 0x000D0490
		internal virtual Button Button12
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Button12;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Button12 = value;
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x060000BC RID: 188 RVA: 0x000D209C File Offset: 0x000D049C
		// (set) Token: 0x060000BD RID: 189 RVA: 0x000D20B4 File Offset: 0x000D04B4
		internal virtual Button Button10
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Button10;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Button10 = value;
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x060000BE RID: 190 RVA: 0x000D20C0 File Offset: 0x000D04C0
		// (set) Token: 0x060000BF RID: 191 RVA: 0x000D20D8 File Offset: 0x000D04D8
		internal virtual Button Button9
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Button9;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Button9 = value;
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x060000C0 RID: 192 RVA: 0x000D20E4 File Offset: 0x000D04E4
		// (set) Token: 0x060000C1 RID: 193 RVA: 0x000D20FC File Offset: 0x000D04FC
		internal virtual Button Button8
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Button8;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Button8 = value;
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x060000C2 RID: 194 RVA: 0x000D2108 File Offset: 0x000D0508
		// (set) Token: 0x060000C3 RID: 195 RVA: 0x000D2120 File Offset: 0x000D0520
		internal virtual Button Button7
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Button7;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Button7 = value;
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x060000C4 RID: 196 RVA: 0x000D212C File Offset: 0x000D052C
		// (set) Token: 0x060000C5 RID: 197 RVA: 0x000D2144 File Offset: 0x000D0544
		internal virtual myButton MyButton48
		{
			[DebuggerNonUserCode]
			get
			{
				return this._MyButton48;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._MyButton48 = value;
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x060000C6 RID: 198 RVA: 0x000D2150 File Offset: 0x000D0550
		// (set) Token: 0x060000C7 RID: 199 RVA: 0x000D2168 File Offset: 0x000D0568
		internal virtual Button btnRShift
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btnRShift;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btnRShift_Click);
				bool flag = this._btnRShift != null;
				if (flag)
				{
					this._btnRShift.Click -= value2;
				}
				this._btnRShift = value;
				flag = (this._btnRShift != null);
				if (flag)
				{
					this._btnRShift.Click += value2;
				}
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x060000C8 RID: 200 RVA: 0x000D21C8 File Offset: 0x000D05C8
		// (set) Token: 0x060000C9 RID: 201 RVA: 0x000D21E0 File Offset: 0x000D05E0
		internal virtual myButton MyButton47
		{
			[DebuggerNonUserCode]
			get
			{
				return this._MyButton47;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._MyButton47 = value;
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x060000CA RID: 202 RVA: 0x000D21EC File Offset: 0x000D05EC
		// (set) Token: 0x060000CB RID: 203 RVA: 0x000D2204 File Offset: 0x000D0604
		internal virtual Button Button5
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Button5;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Button5 = value;
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x060000CC RID: 204 RVA: 0x000D2210 File Offset: 0x000D0610
		// (set) Token: 0x060000CD RID: 205 RVA: 0x000D2228 File Offset: 0x000D0628
		internal virtual myButton MyButton46
		{
			[DebuggerNonUserCode]
			get
			{
				return this._MyButton46;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._MyButton46 = value;
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x060000CE RID: 206 RVA: 0x000D2234 File Offset: 0x000D0634
		// (set) Token: 0x060000CF RID: 207 RVA: 0x000D224C File Offset: 0x000D064C
		internal virtual myButton MyButton45
		{
			[DebuggerNonUserCode]
			get
			{
				return this._MyButton45;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._MyButton45 = value;
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x060000D0 RID: 208 RVA: 0x000D2258 File Offset: 0x000D0658
		// (set) Token: 0x060000D1 RID: 209 RVA: 0x000D2270 File Offset: 0x000D0670
		internal virtual myButton MyButton44
		{
			[DebuggerNonUserCode]
			get
			{
				return this._MyButton44;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._MyButton44 = value;
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x060000D2 RID: 210 RVA: 0x000D227C File Offset: 0x000D067C
		// (set) Token: 0x060000D3 RID: 211 RVA: 0x000D2294 File Offset: 0x000D0694
		internal virtual myButton MyButton43
		{
			[DebuggerNonUserCode]
			get
			{
				return this._MyButton43;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._MyButton43 = value;
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x060000D4 RID: 212 RVA: 0x000D22A0 File Offset: 0x000D06A0
		// (set) Token: 0x060000D5 RID: 213 RVA: 0x000D22B8 File Offset: 0x000D06B8
		internal virtual myButton MyButton42
		{
			[DebuggerNonUserCode]
			get
			{
				return this._MyButton42;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._MyButton42 = value;
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x060000D6 RID: 214 RVA: 0x000D22C4 File Offset: 0x000D06C4
		// (set) Token: 0x060000D7 RID: 215 RVA: 0x000D22DC File Offset: 0x000D06DC
		internal virtual Button Button4
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Button4;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Button4 = value;
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x060000D8 RID: 216 RVA: 0x000D22E8 File Offset: 0x000D06E8
		// (set) Token: 0x060000D9 RID: 217 RVA: 0x000D2300 File Offset: 0x000D0700
		internal virtual myButton MyButton41
		{
			[DebuggerNonUserCode]
			get
			{
				return this._MyButton41;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._MyButton41 = value;
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x060000DA RID: 218 RVA: 0x000D230C File Offset: 0x000D070C
		// (set) Token: 0x060000DB RID: 219 RVA: 0x000D2324 File Offset: 0x000D0724
		internal virtual myButton MyButton40
		{
			[DebuggerNonUserCode]
			get
			{
				return this._MyButton40;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._MyButton40 = value;
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x060000DC RID: 220 RVA: 0x000D2330 File Offset: 0x000D0730
		// (set) Token: 0x060000DD RID: 221 RVA: 0x000D2348 File Offset: 0x000D0748
		internal virtual Button btnLShift
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btnLShift;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btnLShift_Click);
				bool flag = this._btnLShift != null;
				if (flag)
				{
					this._btnLShift.Click -= value2;
				}
				this._btnLShift = value;
				flag = (this._btnLShift != null);
				if (flag)
				{
					this._btnLShift.Click += value2;
				}
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x060000DE RID: 222 RVA: 0x000D23A8 File Offset: 0x000D07A8
		// (set) Token: 0x060000DF RID: 223 RVA: 0x000D23C0 File Offset: 0x000D07C0
		internal virtual Button Button2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Button2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Button2 = value;
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x060000E0 RID: 224 RVA: 0x000D23CC File Offset: 0x000D07CC
		// (set) Token: 0x060000E1 RID: 225 RVA: 0x000D23E4 File Offset: 0x000D07E4
		internal virtual myButton MyButton39
		{
			[DebuggerNonUserCode]
			get
			{
				return this._MyButton39;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._MyButton39 = value;
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x060000E2 RID: 226 RVA: 0x000D23F0 File Offset: 0x000D07F0
		// (set) Token: 0x060000E3 RID: 227 RVA: 0x000D2408 File Offset: 0x000D0808
		internal virtual Button Button1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Button1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Button1 = value;
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x060000E4 RID: 228 RVA: 0x000D2414 File Offset: 0x000D0814
		// (set) Token: 0x060000E5 RID: 229 RVA: 0x000D242C File Offset: 0x000D082C
		internal virtual myButton MyButton29
		{
			[DebuggerNonUserCode]
			get
			{
				return this._MyButton29;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._MyButton29 = value;
			}
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x060000E6 RID: 230 RVA: 0x000D2438 File Offset: 0x000D0838
		// (set) Token: 0x060000E7 RID: 231 RVA: 0x000D2450 File Offset: 0x000D0850
		internal virtual myButton MyButton30
		{
			[DebuggerNonUserCode]
			get
			{
				return this._MyButton30;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._MyButton30 = value;
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x060000E8 RID: 232 RVA: 0x000D245C File Offset: 0x000D085C
		// (set) Token: 0x060000E9 RID: 233 RVA: 0x000D2474 File Offset: 0x000D0874
		internal virtual myButton MyButton31
		{
			[DebuggerNonUserCode]
			get
			{
				return this._MyButton31;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._MyButton31 = value;
			}
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x060000EA RID: 234 RVA: 0x000D2480 File Offset: 0x000D0880
		// (set) Token: 0x060000EB RID: 235 RVA: 0x000D2498 File Offset: 0x000D0898
		internal virtual myButton MyButton32
		{
			[DebuggerNonUserCode]
			get
			{
				return this._MyButton32;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._MyButton32 = value;
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x060000EC RID: 236 RVA: 0x000D24A4 File Offset: 0x000D08A4
		// (set) Token: 0x060000ED RID: 237 RVA: 0x000D24BC File Offset: 0x000D08BC
		internal virtual myButton MyButton33
		{
			[DebuggerNonUserCode]
			get
			{
				return this._MyButton33;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._MyButton33 = value;
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x060000EE RID: 238 RVA: 0x000D24C8 File Offset: 0x000D08C8
		// (set) Token: 0x060000EF RID: 239 RVA: 0x000D24E0 File Offset: 0x000D08E0
		internal virtual myButton MyButton34
		{
			[DebuggerNonUserCode]
			get
			{
				return this._MyButton34;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._MyButton34 = value;
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x060000F0 RID: 240 RVA: 0x000D24EC File Offset: 0x000D08EC
		// (set) Token: 0x060000F1 RID: 241 RVA: 0x000D2504 File Offset: 0x000D0904
		internal virtual myButton MyButton35
		{
			[DebuggerNonUserCode]
			get
			{
				return this._MyButton35;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._MyButton35 = value;
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x060000F2 RID: 242 RVA: 0x000D2510 File Offset: 0x000D0910
		// (set) Token: 0x060000F3 RID: 243 RVA: 0x000D2528 File Offset: 0x000D0928
		internal virtual myButton MyButton36
		{
			[DebuggerNonUserCode]
			get
			{
				return this._MyButton36;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._MyButton36 = value;
			}
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x060000F4 RID: 244 RVA: 0x000D2534 File Offset: 0x000D0934
		// (set) Token: 0x060000F5 RID: 245 RVA: 0x000D254C File Offset: 0x000D094C
		internal virtual myButton MyButton37
		{
			[DebuggerNonUserCode]
			get
			{
				return this._MyButton37;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._MyButton37 = value;
			}
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x060000F6 RID: 246 RVA: 0x000D2558 File Offset: 0x000D0958
		// (set) Token: 0x060000F7 RID: 247 RVA: 0x000D2570 File Offset: 0x000D0970
		internal virtual myButton MyButton38
		{
			[DebuggerNonUserCode]
			get
			{
				return this._MyButton38;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._MyButton38 = value;
			}
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x060000F8 RID: 248 RVA: 0x000D257C File Offset: 0x000D097C
		// (set) Token: 0x060000F9 RID: 249 RVA: 0x000D2594 File Offset: 0x000D0994
		internal virtual myButton MyButton28
		{
			[DebuggerNonUserCode]
			get
			{
				return this._MyButton28;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._MyButton28 = value;
			}
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x060000FA RID: 250 RVA: 0x000D25A0 File Offset: 0x000D09A0
		// (set) Token: 0x060000FB RID: 251 RVA: 0x000D25B8 File Offset: 0x000D09B8
		internal virtual myButton MyButton19
		{
			[DebuggerNonUserCode]
			get
			{
				return this._MyButton19;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._MyButton19 = value;
			}
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x060000FC RID: 252 RVA: 0x000D25C4 File Offset: 0x000D09C4
		// (set) Token: 0x060000FD RID: 253 RVA: 0x000D25DC File Offset: 0x000D09DC
		internal virtual myButton MyButton20
		{
			[DebuggerNonUserCode]
			get
			{
				return this._MyButton20;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._MyButton20 = value;
			}
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x060000FE RID: 254 RVA: 0x000D25E8 File Offset: 0x000D09E8
		// (set) Token: 0x060000FF RID: 255 RVA: 0x000D2600 File Offset: 0x000D0A00
		internal virtual myButton MyButton21
		{
			[DebuggerNonUserCode]
			get
			{
				return this._MyButton21;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._MyButton21 = value;
			}
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x06000100 RID: 256 RVA: 0x000D260C File Offset: 0x000D0A0C
		// (set) Token: 0x06000101 RID: 257 RVA: 0x000D2624 File Offset: 0x000D0A24
		internal virtual myButton MyButton22
		{
			[DebuggerNonUserCode]
			get
			{
				return this._MyButton22;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._MyButton22 = value;
			}
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x06000102 RID: 258 RVA: 0x000D2630 File Offset: 0x000D0A30
		// (set) Token: 0x06000103 RID: 259 RVA: 0x000D2648 File Offset: 0x000D0A48
		internal virtual myButton MyButton23
		{
			[DebuggerNonUserCode]
			get
			{
				return this._MyButton23;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._MyButton23 = value;
			}
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x06000104 RID: 260 RVA: 0x000D2654 File Offset: 0x000D0A54
		// (set) Token: 0x06000105 RID: 261 RVA: 0x000D266C File Offset: 0x000D0A6C
		internal virtual myButton MyButton24
		{
			[DebuggerNonUserCode]
			get
			{
				return this._MyButton24;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._MyButton24 = value;
			}
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x06000106 RID: 262 RVA: 0x000D2678 File Offset: 0x000D0A78
		// (set) Token: 0x06000107 RID: 263 RVA: 0x000D2690 File Offset: 0x000D0A90
		internal virtual myButton MyButton25
		{
			[DebuggerNonUserCode]
			get
			{
				return this._MyButton25;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._MyButton25 = value;
			}
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x06000108 RID: 264 RVA: 0x000D269C File Offset: 0x000D0A9C
		// (set) Token: 0x06000109 RID: 265 RVA: 0x000D26B4 File Offset: 0x000D0AB4
		internal virtual myButton MyButton26
		{
			[DebuggerNonUserCode]
			get
			{
				return this._MyButton26;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._MyButton26 = value;
			}
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x0600010A RID: 266 RVA: 0x000D26C0 File Offset: 0x000D0AC0
		// (set) Token: 0x0600010B RID: 267 RVA: 0x000D26D8 File Offset: 0x000D0AD8
		internal virtual myButton MyButton27
		{
			[DebuggerNonUserCode]
			get
			{
				return this._MyButton27;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._MyButton27 = value;
			}
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x0600010C RID: 268 RVA: 0x000D26E4 File Offset: 0x000D0AE4
		// (set) Token: 0x0600010D RID: 269 RVA: 0x000D26FC File Offset: 0x000D0AFC
		internal virtual myButton MyButton10
		{
			[DebuggerNonUserCode]
			get
			{
				return this._MyButton10;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._MyButton10 = value;
			}
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x0600010E RID: 270 RVA: 0x000D2708 File Offset: 0x000D0B08
		// (set) Token: 0x0600010F RID: 271 RVA: 0x000D2720 File Offset: 0x000D0B20
		internal virtual myButton MyButton11
		{
			[DebuggerNonUserCode]
			get
			{
				return this._MyButton11;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._MyButton11 = value;
			}
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x06000110 RID: 272 RVA: 0x000D272C File Offset: 0x000D0B2C
		// (set) Token: 0x06000111 RID: 273 RVA: 0x000D2744 File Offset: 0x000D0B44
		internal virtual myButton MyButton12
		{
			[DebuggerNonUserCode]
			get
			{
				return this._MyButton12;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._MyButton12 = value;
			}
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x06000112 RID: 274 RVA: 0x000D2750 File Offset: 0x000D0B50
		// (set) Token: 0x06000113 RID: 275 RVA: 0x000D2768 File Offset: 0x000D0B68
		internal virtual myButton MyButton13
		{
			[DebuggerNonUserCode]
			get
			{
				return this._MyButton13;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._MyButton13 = value;
			}
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x06000114 RID: 276 RVA: 0x000D2774 File Offset: 0x000D0B74
		// (set) Token: 0x06000115 RID: 277 RVA: 0x000D278C File Offset: 0x000D0B8C
		internal virtual myButton MyButton14
		{
			[DebuggerNonUserCode]
			get
			{
				return this._MyButton14;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._MyButton14 = value;
			}
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x06000116 RID: 278 RVA: 0x000D2798 File Offset: 0x000D0B98
		// (set) Token: 0x06000117 RID: 279 RVA: 0x000D27B0 File Offset: 0x000D0BB0
		internal virtual myButton MyButton15
		{
			[DebuggerNonUserCode]
			get
			{
				return this._MyButton15;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._MyButton15 = value;
			}
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x06000118 RID: 280 RVA: 0x000D27BC File Offset: 0x000D0BBC
		// (set) Token: 0x06000119 RID: 281 RVA: 0x000D27D4 File Offset: 0x000D0BD4
		internal virtual myButton MyButton16
		{
			[DebuggerNonUserCode]
			get
			{
				return this._MyButton16;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._MyButton16 = value;
			}
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x0600011A RID: 282 RVA: 0x000D27E0 File Offset: 0x000D0BE0
		// (set) Token: 0x0600011B RID: 283 RVA: 0x000D27F8 File Offset: 0x000D0BF8
		internal virtual myButton MyButton17
		{
			[DebuggerNonUserCode]
			get
			{
				return this._MyButton17;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._MyButton17 = value;
			}
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x0600011C RID: 284 RVA: 0x000D2804 File Offset: 0x000D0C04
		// (set) Token: 0x0600011D RID: 285 RVA: 0x000D281C File Offset: 0x000D0C1C
		internal virtual myButton MyButton18
		{
			[DebuggerNonUserCode]
			get
			{
				return this._MyButton18;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._MyButton18 = value;
			}
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x0600011E RID: 286 RVA: 0x000D2828 File Offset: 0x000D0C28
		// (set) Token: 0x0600011F RID: 287 RVA: 0x000D2840 File Offset: 0x000D0C40
		internal virtual myButton MyButton9
		{
			[DebuggerNonUserCode]
			get
			{
				return this._MyButton9;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._MyButton9 = value;
			}
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x06000120 RID: 288 RVA: 0x000D284C File Offset: 0x000D0C4C
		// (set) Token: 0x06000121 RID: 289 RVA: 0x000D2864 File Offset: 0x000D0C64
		internal virtual myButton MyButton8
		{
			[DebuggerNonUserCode]
			get
			{
				return this._MyButton8;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._MyButton8 = value;
			}
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x06000122 RID: 290 RVA: 0x000D2870 File Offset: 0x000D0C70
		// (set) Token: 0x06000123 RID: 291 RVA: 0x000D2888 File Offset: 0x000D0C88
		internal virtual myButton MyButton7
		{
			[DebuggerNonUserCode]
			get
			{
				return this._MyButton7;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._MyButton7 = value;
			}
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x06000124 RID: 292 RVA: 0x000D2894 File Offset: 0x000D0C94
		// (set) Token: 0x06000125 RID: 293 RVA: 0x000D28AC File Offset: 0x000D0CAC
		internal virtual myButton MyButton6
		{
			[DebuggerNonUserCode]
			get
			{
				return this._MyButton6;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._MyButton6 = value;
			}
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x06000126 RID: 294 RVA: 0x000D28B8 File Offset: 0x000D0CB8
		// (set) Token: 0x06000127 RID: 295 RVA: 0x000D28D0 File Offset: 0x000D0CD0
		internal virtual myButton MyButton5
		{
			[DebuggerNonUserCode]
			get
			{
				return this._MyButton5;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._MyButton5 = value;
			}
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x06000128 RID: 296 RVA: 0x000D28DC File Offset: 0x000D0CDC
		// (set) Token: 0x06000129 RID: 297 RVA: 0x000D28F4 File Offset: 0x000D0CF4
		internal virtual myButton MyButton4
		{
			[DebuggerNonUserCode]
			get
			{
				return this._MyButton4;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._MyButton4 = value;
			}
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x0600012A RID: 298 RVA: 0x000D2900 File Offset: 0x000D0D00
		// (set) Token: 0x0600012B RID: 299 RVA: 0x000D2918 File Offset: 0x000D0D18
		internal virtual myButton MyButton3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._MyButton3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._MyButton3 = value;
			}
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x0600012C RID: 300 RVA: 0x000D2924 File Offset: 0x000D0D24
		// (set) Token: 0x0600012D RID: 301 RVA: 0x000D293C File Offset: 0x000D0D3C
		internal virtual myButton MyButton2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._MyButton2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._MyButton2 = value;
			}
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x0600012E RID: 302 RVA: 0x000D2948 File Offset: 0x000D0D48
		// (set) Token: 0x0600012F RID: 303 RVA: 0x000D2960 File Offset: 0x000D0D60
		internal virtual myButton MyButton1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._MyButton1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._MyButton1 = value;
			}
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x06000130 RID: 304 RVA: 0x000D296C File Offset: 0x000D0D6C
		// (set) Token: 0x06000131 RID: 305 RVA: 0x000D2984 File Offset: 0x000D0D84
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

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x06000132 RID: 306 RVA: 0x000D2990 File Offset: 0x000D0D90
		// (set) Token: 0x06000133 RID: 307 RVA: 0x000D29A8 File Offset: 0x000D0DA8
		internal virtual CheckBox chkKey
		{
			[DebuggerNonUserCode]
			get
			{
				return this._chkKey;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.chkKey_CheckedChanged);
				bool flag = this._chkKey != null;
				if (flag)
				{
					this._chkKey.CheckedChanged -= value2;
				}
				this._chkKey = value;
				flag = (this._chkKey != null);
				if (flag)
				{
					this._chkKey.CheckedChanged += value2;
				}
			}
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x06000134 RID: 308 RVA: 0x000D2A08 File Offset: 0x000D0E08
		// (set) Token: 0x06000135 RID: 309 RVA: 0x000D2A20 File Offset: 0x000D0E20
		internal virtual DataGridViewTextBoxColumn Column1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Column1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Column1 = value;
			}
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x06000136 RID: 310 RVA: 0x000D2A2C File Offset: 0x000D0E2C
		// (set) Token: 0x06000137 RID: 311 RVA: 0x000D2A44 File Offset: 0x000D0E44
		internal virtual DataGridViewTextBoxColumn Column2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Column2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Column2 = value;
			}
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x06000138 RID: 312 RVA: 0x000D2A50 File Offset: 0x000D0E50
		// (set) Token: 0x06000139 RID: 313 RVA: 0x000D2A68 File Offset: 0x000D0E68
		internal virtual Label Label9
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label9;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label9 = value;
			}
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x0600013A RID: 314 RVA: 0x000D2A74 File Offset: 0x000D0E74
		// (set) Token: 0x0600013B RID: 315 RVA: 0x000D2A8C File Offset: 0x000D0E8C
		internal virtual TextBox txtCom
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txtCom;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.txtCom_TextChanged);
				bool flag = this._txtCom != null;
				if (flag)
				{
					this._txtCom.TextChanged -= value2;
				}
				this._txtCom = value;
				flag = (this._txtCom != null);
				if (flag)
				{
					this._txtCom.TextChanged += value2;
				}
			}
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x0600013C RID: 316 RVA: 0x000D2AEC File Offset: 0x000D0EEC
		// (set) Token: 0x0600013D RID: 317 RVA: 0x000D2B04 File Offset: 0x000D0F04
		internal virtual Label Label8
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label8;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label8 = value;
			}
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x0600013E RID: 318 RVA: 0x000D2B10 File Offset: 0x000D0F10
		// (set) Token: 0x0600013F RID: 319 RVA: 0x000D2B28 File Offset: 0x000D0F28
		internal virtual TextBox txtSeq
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txtSeq;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.txtSeq_TextChanged);
				KeyEventHandler value3 = new KeyEventHandler(this.txtSeq_KeyUp);
				bool flag = this._txtSeq != null;
				if (flag)
				{
					this._txtSeq.TextChanged -= value2;
					this._txtSeq.KeyUp -= value3;
				}
				this._txtSeq = value;
				flag = (this._txtSeq != null);
				if (flag)
				{
					this._txtSeq.TextChanged += value2;
					this._txtSeq.KeyUp += value3;
				}
			}
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x06000140 RID: 320 RVA: 0x000D2BB0 File Offset: 0x000D0FB0
		// (set) Token: 0x06000141 RID: 321 RVA: 0x000D2BC8 File Offset: 0x000D0FC8
		internal virtual Button btnDown
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btnDown;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btnDown_Click);
				bool flag = this._btnDown != null;
				if (flag)
				{
					this._btnDown.Click -= value2;
				}
				this._btnDown = value;
				flag = (this._btnDown != null);
				if (flag)
				{
					this._btnDown.Click += value2;
				}
			}
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x06000142 RID: 322 RVA: 0x000D2C28 File Offset: 0x000D1028
		// (set) Token: 0x06000143 RID: 323 RVA: 0x000D2C40 File Offset: 0x000D1040
		internal virtual Button btnUp
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btnUp;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btnUp_Click);
				bool flag = this._btnUp != null;
				if (flag)
				{
					this._btnUp.Click -= value2;
				}
				this._btnUp = value;
				flag = (this._btnUp != null);
				if (flag)
				{
					this._btnUp.Click += value2;
				}
			}
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x06000144 RID: 324 RVA: 0x000D2CA0 File Offset: 0x000D10A0
		// (set) Token: 0x06000145 RID: 325 RVA: 0x000D2CB8 File Offset: 0x000D10B8
		internal virtual Button btnUpdate
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btnUpdate;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btnUpdate_Click);
				bool flag = this._btnUpdate != null;
				if (flag)
				{
					this._btnUpdate.Click -= value2;
				}
				this._btnUpdate = value;
				flag = (this._btnUpdate != null);
				if (flag)
				{
					this._btnUpdate.Click += value2;
				}
			}
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x06000146 RID: 326 RVA: 0x000D2D18 File Offset: 0x000D1118
		// (set) Token: 0x06000147 RID: 327 RVA: 0x000D2D30 File Offset: 0x000D1130
		internal virtual Button btnAdd
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btnAdd;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btnAdd_Click);
				bool flag = this._btnAdd != null;
				if (flag)
				{
					this._btnAdd.Click -= value2;
				}
				this._btnAdd = value;
				flag = (this._btnAdd != null);
				if (flag)
				{
					this._btnAdd.Click += value2;
				}
			}
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x06000148 RID: 328 RVA: 0x000D2D90 File Offset: 0x000D1190
		// (set) Token: 0x06000149 RID: 329 RVA: 0x000D2DA8 File Offset: 0x000D11A8
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

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x0600014A RID: 330 RVA: 0x000D2DB4 File Offset: 0x000D11B4
		// (set) Token: 0x0600014B RID: 331 RVA: 0x000D2DCC File Offset: 0x000D11CC
		internal virtual PictureBox picIco24
		{
			[DebuggerNonUserCode]
			get
			{
				return this._picIco24;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._picIco24 = value;
			}
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x0600014C RID: 332 RVA: 0x000D2DD8 File Offset: 0x000D11D8
		// (set) Token: 0x0600014D RID: 333 RVA: 0x000D2DF0 File Offset: 0x000D11F0
		internal virtual PictureBox picIco16
		{
			[DebuggerNonUserCode]
			get
			{
				return this._picIco16;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._picIco16 = value;
			}
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x0600014E RID: 334 RVA: 0x000D2DFC File Offset: 0x000D11FC
		// (set) Token: 0x0600014F RID: 335 RVA: 0x000D2E14 File Offset: 0x000D1214
		internal virtual Label lblNotFound
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lblNotFound;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lblNotFound = value;
			}
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x06000150 RID: 336 RVA: 0x000D2E20 File Offset: 0x000D1220
		// (set) Token: 0x06000151 RID: 337 RVA: 0x000D2E38 File Offset: 0x000D1238
		internal virtual Button btnDel
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btnDel;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btnDel_Click);
				bool flag = this._btnDel != null;
				if (flag)
				{
					this._btnDel.Click -= value2;
				}
				this._btnDel = value;
				flag = (this._btnDel != null);
				if (flag)
				{
					this._btnDel.Click += value2;
				}
			}
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x06000152 RID: 338 RVA: 0x000D2E98 File Offset: 0x000D1298
		// (set) Token: 0x06000153 RID: 339 RVA: 0x000D2EB0 File Offset: 0x000D12B0
		internal virtual DataGridView dgJuks
		{
			[DebuggerNonUserCode]
			get
			{
				return this._dgJuks;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.dgJuks_SelectionChanged);
				bool flag = this._dgJuks != null;
				if (flag)
				{
					this._dgJuks.SelectionChanged -= value2;
				}
				this._dgJuks = value;
				flag = (this._dgJuks != null);
				if (flag)
				{
					this._dgJuks.SelectionChanged += value2;
				}
			}
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x06000154 RID: 340 RVA: 0x000D2F10 File Offset: 0x000D1310
		// (set) Token: 0x06000155 RID: 341 RVA: 0x000D2F28 File Offset: 0x000D1328
		internal virtual Label Label11
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label11;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label11 = value;
			}
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x06000156 RID: 342 RVA: 0x000D2F34 File Offset: 0x000D1334
		// (set) Token: 0x06000157 RID: 343 RVA: 0x000D2F4C File Offset: 0x000D134C
		internal virtual Label Label10
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label10;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label10 = value;
			}
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x06000158 RID: 344 RVA: 0x000D2F58 File Offset: 0x000D1358
		// (set) Token: 0x06000159 RID: 345 RVA: 0x000D2F70 File Offset: 0x000D1370
		internal virtual TextBox txtComHex
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txtComHex;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.txtComHex_TextChanged);
				bool flag = this._txtComHex != null;
				if (flag)
				{
					this._txtComHex.TextChanged -= value2;
				}
				this._txtComHex = value;
				flag = (this._txtComHex != null);
				if (flag)
				{
					this._txtComHex.TextChanged += value2;
				}
			}
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x0600015A RID: 346 RVA: 0x000D2FD0 File Offset: 0x000D13D0
		// (set) Token: 0x0600015B RID: 347 RVA: 0x000D2FE8 File Offset: 0x000D13E8
		internal virtual TextBox txtSeqHex
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txtSeqHex;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.txtSeqHex_TextChanged);
				KeyEventHandler value3 = new KeyEventHandler(this.txtSeqHex_KeyUp);
				bool flag = this._txtSeqHex != null;
				if (flag)
				{
					this._txtSeqHex.TextChanged -= value2;
					this._txtSeqHex.KeyUp -= value3;
				}
				this._txtSeqHex = value;
				flag = (this._txtSeqHex != null);
				if (flag)
				{
					this._txtSeqHex.TextChanged += value2;
					this._txtSeqHex.KeyUp += value3;
				}
			}
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x0600015C RID: 348 RVA: 0x000D3070 File Offset: 0x000D1470
		// (set) Token: 0x0600015D RID: 349 RVA: 0x000D3088 File Offset: 0x000D1488
		internal virtual Label Label12
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label12;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label12 = value;
			}
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x0600015E RID: 350 RVA: 0x000D3094 File Offset: 0x000D1494
		// (set) Token: 0x0600015F RID: 351 RVA: 0x000D30AC File Offset: 0x000D14AC
		internal virtual Button btnCancel
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btnCancel;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btnCancel_Click);
				bool flag = this._btnCancel != null;
				if (flag)
				{
					this._btnCancel.Click -= value2;
				}
				this._btnCancel = value;
				flag = (this._btnCancel != null);
				if (flag)
				{
					this._btnCancel.Click += value2;
				}
			}
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x06000160 RID: 352 RVA: 0x000D310C File Offset: 0x000D150C
		// (set) Token: 0x06000161 RID: 353 RVA: 0x000D3124 File Offset: 0x000D1524
		internal virtual CheckBox chkListG
		{
			[DebuggerNonUserCode]
			get
			{
				return this._chkListG;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._chkListG = value;
			}
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x06000162 RID: 354 RVA: 0x000D3130 File Offset: 0x000D1530
		// (set) Token: 0x06000163 RID: 355 RVA: 0x000D3148 File Offset: 0x000D1548
		internal virtual ToolTip ToolTips
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ToolTips;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ToolTips = value;
			}
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x06000164 RID: 356 RVA: 0x000D3154 File Offset: 0x000D1554
		// (set) Token: 0x06000165 RID: 357 RVA: 0x000D316C File Offset: 0x000D156C
		internal virtual Button btnInsert
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btnInsert;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btnInsert_Click);
				bool flag = this._btnInsert != null;
				if (flag)
				{
					this._btnInsert.Click -= value2;
				}
				this._btnInsert = value;
				flag = (this._btnInsert != null);
				if (flag)
				{
					this._btnInsert.Click += value2;
				}
			}
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x06000166 RID: 358 RVA: 0x000D31CC File Offset: 0x000D15CC
		// (set) Token: 0x06000167 RID: 359 RVA: 0x000D31E4 File Offset: 0x000D15E4
		internal virtual Label Label13
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label13;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label13 = value;
			}
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x06000168 RID: 360 RVA: 0x000D31F0 File Offset: 0x000D15F0
		// (set) Token: 0x06000169 RID: 361 RVA: 0x000D3208 File Offset: 0x000D1608
		internal virtual TextBox txtCounter
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txtCounter;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.txtCounter_TextChanged);
				MouseEventHandler value3 = new MouseEventHandler(this.txtCounter_MouseClick);
				bool flag = this._txtCounter != null;
				if (flag)
				{
					this._txtCounter.TextChanged -= value2;
					this._txtCounter.MouseClick -= value3;
				}
				this._txtCounter = value;
				flag = (this._txtCounter != null);
				if (flag)
				{
					this._txtCounter.TextChanged += value2;
					this._txtCounter.MouseClick += value3;
				}
			}
		}

		// Token: 0x0600016A RID: 362 RVA: 0x000D3290 File Offset: 0x000D1690
		private void frmLayoutCreator_Activated(object sender, EventArgs e)
		{
		}

		// Token: 0x0600016B RID: 363 RVA: 0x000D3294 File Offset: 0x000D1694
		private void frmLayoutCreator_KeyDown(object sender, KeyEventArgs e)
		{
			try
			{
				foreach (object obj in this.GroupBox1.Controls)
				{
					Control control = (Control)obj;
					bool flag = control is myButton;
					if (flag)
					{
						myButton myButton = (myButton)control;
						flag = Operators.ConditionalCompareObjectEqual(myButton.Tag, e.KeyCode, false);
						if (flag)
						{
							myButton.mButton.PerformClick();
						}
					}
				}
			}
			finally
			{
				IEnumerator enumerator;
				bool flag = enumerator is IDisposable;
				if (flag)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
		}

		// Token: 0x0600016C RID: 364 RVA: 0x000D333C File Offset: 0x000D173C
		private void frmLayoutCreator_Load(object sender, EventArgs e)
		{
			myFunctions.SetControlStyle(this.txtCounter, myFunctions.Style.ES_NUMBER);
			myFunctions.SetControlStyle(this.comKey, myFunctions.Style.ES_UPPERCASE);
			bool flag = this.blankLayout.Count == 0;
			checked
			{
				if (flag)
				{
					this.comLayouts.Items.Clear();
					int num = 1;
					int num2 = MyProject.Forms.frmMain.comLayouts.Items.Count - 1;
					int num3 = num;
					int num5;
					for (;;)
					{
						int num4 = num3;
						num5 = num2;
						if (num4 > num5)
						{
							break;
						}
						this.comLayouts.Items.Add(RuntimeHelpers.GetObjectValue(MyProject.Forms.frmMain.comLayouts.Items[num3]));
						num3++;
					}
					this.comKey.Items.Clear();
					num3 = 1;
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
					try
					{
						foreach (object obj in this.GroupBox1.Controls)
						{
							Control control = (Control)obj;
							flag = (control is myButton);
							if (flag)
							{
								myButton myButton = (myButton)control;
								flag = Operators.ConditionalCompareObjectNotEqual(myButton.Tag, "", false);
								if (flag)
								{
									string[] array = new string[5];
									array[0] = myButton.NormalKey;
									array[2] = myButton.NormalKeyOption;
									array[1] = myButton.ShiftKey;
									array[3] = myButton.ShiftKeyOption;
									this.blankLayout.Add(Conversions.ToInteger(myButton.Tag), array);
								}
							}
						}
					}
					finally
					{
						IEnumerator enumerator;
						flag = (enumerator is IDisposable);
						if (flag)
						{
							(enumerator as IDisposable).Dispose();
						}
					}
				}
				this.ToolTips.SetToolTip(this.chkListG, "Generate existing combination from list in Sequence textbox");
			}
		}

		// Token: 0x0600016D RID: 365 RVA: 0x000D353C File Offset: 0x000D193C
		private void comLayouts_MouseClick(object sender, MouseEventArgs e)
		{
			this.btnEdit.Enabled = (Operators.CompareString(this.comLayouts.Text, "", false) != 0);
		}

		// Token: 0x0600016E RID: 366 RVA: 0x000D3568 File Offset: 0x000D1968
		private void comLayouts_TextChanged(object sender, EventArgs e)
		{
			this.btnEdit.Enabled = (Operators.CompareString(this.comLayouts.Text, "", false) != 0);
		}

		// Token: 0x0600016F RID: 367 RVA: 0x000D3594 File Offset: 0x000D1994
		private void btnEdit_Click(object sender, EventArgs e)
		{
			this.btnCancel.Enabled = true;
			this.WorkLay = modKeyboard.Layout[this.comLayouts.SelectedIndex];
			this.chkAlt.Enabled = true;
			this.chkCtrl.Enabled = true;
			this.chkShift.Enabled = true;
			this.txtIco.Enabled = true;
			this.comKey.Enabled = true;
			this.ResetLayout();
			this.txtName.Text = this.WorkLay.Name;
			this.txtIco.Text = this.WorkLay.IconName;
			this.chkAlt.Checked = this.WorkLay.Shortcut.Alt;
			this.chkCtrl.Checked = this.WorkLay.Shortcut.Ctrl;
			this.chkShift.Checked = this.WorkLay.Shortcut.Shift;
			this.Text = "Keyboard Layout Editor 1.0.1 || Currently editing - " + this.WorkLay.Name + " layout";
			bool flag = this.chkAlt.Checked | this.chkCtrl.Checked;
			checked
			{
				if (flag)
				{
					this.comKey.Text = Conversions.ToString(Strings.Chr(this.WorkLay.Shortcut.KeyCode));
				}
				else
				{
					this.comKey.Text = "F" + Conversions.ToString(this.WorkLay.Shortcut.KeyCode - 111);
				}
				try
				{
					foreach (object obj in this.GroupBox1.Controls)
					{
						Control control = (Control)obj;
						flag = (control is myButton);
						if (flag)
						{
							myButton myButton = (myButton)control;
							flag = Operators.ConditionalCompareObjectNotEqual(myButton.Tag, "", false);
							if (flag)
							{
								try
								{
									ArrayList arrayList = this.WorkLay.Key[Conversions.ToInteger(Convert.ChangeType(RuntimeHelpers.GetObjectValue(myButton.Tag), TypeCode.Int16))];
									myButton.NormalKey = Conversions.ToString(arrayList[0]);
									myButton.NormalKeyOption = Conversions.ToString(arrayList[2]);
									myButton.ShiftKey = Conversions.ToString(arrayList[1]);
									myButton.ShiftKeyOption = Conversions.ToString(arrayList[3]);
									myButton.mButton.Font = this.dlgFont.Font;
									flag = (myButton.ShiftState & Operators.CompareString(myButton.ShiftKeyOption, "", false) != 0);
									if (flag)
									{
										myButton.ForeColor = Color.Red;
									}
									else
									{
										flag = (!myButton.ShiftState & Operators.CompareString(myButton.NormalKeyOption, "", false) != 0);
										if (flag)
										{
											myButton.ForeColor = Color.Red;
										}
										else
										{
											myButton.ForeColor = Color.Black;
										}
									}
								}
								catch (Exception ex)
								{
									myButton.ForeColor = Color.Black;
								}
							}
						}
					}
				}
				finally
				{
					IEnumerator enumerator;
					flag = (enumerator is IDisposable);
					if (flag)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
				this.dgJuks.Rows.Clear();
				flag = (this.WorkLay.Juk.Count > 0);
				if (flag)
				{
					this.dgJuks.Rows.Add(this.WorkLay.Juk.Count);
					this.dgJuks.Font = this.dlgFont.Font;
					this.txtCom.Font = this.dlgFont.Font;
					this.txtSeq.Font = this.dlgFont.Font;
					int num = 0;
					try
					{
						foreach (string value in this.WorkLay.Juk.Keys)
						{
							this.dgJuks[0, num].Value = value;
							num++;
						}
					}
					finally
					{
						Dictionary<string, string>.KeyCollection.Enumerator enumerator2;
						((IDisposable)enumerator2).Dispose();
					}
					num = 0;
					try
					{
						foreach (string value in this.WorkLay.Juk.Values)
						{
							this.dgJuks[1, num].Value = value;
							num++;
						}
					}
					finally
					{
						Dictionary<string, string>.ValueCollection.Enumerator enumerator3;
						((IDisposable)enumerator3).Dispose();
					}
				}
			}
		}

		// Token: 0x06000170 RID: 368 RVA: 0x000D3A8C File Offset: 0x000D1E8C
		private void btnFont_Click(object sender, EventArgs e)
		{
			bool flag = this.dlgFont.ShowDialog() == DialogResult.OK;
			if (flag)
			{
				try
				{
					foreach (object obj in this.GroupBox1.Controls)
					{
						Control control = (Control)obj;
						bool flag2 = control is myButton;
						if (flag2)
						{
							myButton myButton = (myButton)control;
							flag2 = Operators.ConditionalCompareObjectNotEqual(myButton.Tag, "", false);
							if (flag2)
							{
								try
								{
									flag = myButton.ShiftState;
									if (flag)
									{
										bool flag3 = Operators.CompareString(myButton.ShiftKey, this.blankLayout[Conversions.ToInteger(myButton.Tag)][1], false) != 0;
										if (flag3)
										{
											myButton.mButton.Font = this.dlgFont.Font;
										}
									}
									else
									{
										bool flag3 = Operators.CompareString(myButton.NormalKey, this.blankLayout[Conversions.ToInteger(myButton.Tag)][0], false) != 0;
										if (flag3)
										{
											myButton.mButton.Font = this.dlgFont.Font;
										}
									}
								}
								catch (Exception ex)
								{
								}
							}
						}
					}
				}
				finally
				{
					IEnumerator enumerator;
					bool flag3 = enumerator is IDisposable;
					if (flag3)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
				this.dgJuks.Font = this.dlgFont.Font;
				this.txtSeq.Font = this.dlgFont.Font;
				this.txtCom.Font = this.dlgFont.Font;
			}
		}

		// Token: 0x06000171 RID: 369 RVA: 0x000D3C68 File Offset: 0x000D2068
		private void dlgFont_Apply(object sender, EventArgs e)
		{
			this.btnEdit.PerformClick();
		}

		// Token: 0x06000172 RID: 370 RVA: 0x000D3C78 File Offset: 0x000D2078
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

		// Token: 0x06000173 RID: 371 RVA: 0x000D3D9C File Offset: 0x000D219C
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

		// Token: 0x06000174 RID: 372 RVA: 0x000D3EC0 File Offset: 0x000D22C0
		private void btnNew_Click(object sender, EventArgs e)
		{
			this.btnCancel.Enabled = true;
			this.WorkLay = null;
			this.Text = "Keyboard Layout Editor 1.0.1 || Currently creating a new layout";
			this.comLayouts.Text = "";
			this.txtName.Text = "";
			this.txtIco.Text = "";
			this.chkAlt.Checked = false;
			this.chkCtrl.Checked = false;
			this.chkShift.Checked = false;
			this.dgJuks.Rows.Clear();
			this.dgJuks.Font = this.Font;
			this.txtSeq.Text = "";
			this.txtCom.Text = "";
			this.ResetLayout();
			this.comLayouts.Enabled = false;
			this.txtName.Enabled = true;
		}

		// Token: 0x06000175 RID: 373 RVA: 0x000D3FB0 File Offset: 0x000D23B0
		private void btnSave_Click(object sender, EventArgs e)
		{
			bool flag = this.SaveAndLoad();
			if (flag)
			{
				this.Text = "Keyboard Layout Editor 1.0.1 || Currently editing - " + this.WorkLay.Name + " layout";
			}
		}

		// Token: 0x06000176 RID: 374 RVA: 0x000D3FEC File Offset: 0x000D23EC
		private void btnLShift_Click(object sender, EventArgs e)
		{
			this.chkLShift.Checked = Conversions.ToBoolean(Interaction.IIf(this.chkLShift.Checked, false, true));
		}

		// Token: 0x06000177 RID: 375 RVA: 0x000D4020 File Offset: 0x000D2420
		private void btnRShift_Click(object sender, EventArgs e)
		{
			this.btnLShift.PerformClick();
		}

		// Token: 0x06000178 RID: 376 RVA: 0x000D4030 File Offset: 0x000D2430
		private void chkLShift_CheckedChanged(object sender, EventArgs e)
		{
			this.chkRShift.Checked = this.chkLShift.Checked;
			try
			{
				foreach (object obj in this.GroupBox1.Controls)
				{
					Control control = (Control)obj;
					bool flag = control is myButton;
					if (flag)
					{
						myButton myButton = (myButton)control;
						myButton.ShiftState = this.chkLShift.Checked;
						try
						{
							flag = (myButton.ShiftState & Operators.CompareString(myButton.ShiftKeyOption, "", false) != 0);
							if (flag)
							{
								myButton.ForeColor = Color.Red;
							}
							else
							{
								flag = (!myButton.ShiftState & Operators.CompareString(myButton.NormalKeyOption, "", false) != 0);
								if (flag)
								{
									myButton.ForeColor = Color.Red;
								}
								else
								{
									myButton.ForeColor = Color.Black;
								}
							}
						}
						catch (Exception ex)
						{
							myButton.ForeColor = Color.Black;
						}
						try
						{
							flag = myButton.ShiftState;
							if (flag)
							{
								bool flag2 = Operators.CompareString(myButton.ShiftKey, this.blankLayout[Conversions.ToInteger(myButton.Tag)][1], false) != 0;
								if (flag2)
								{
									myButton.mButton.Font = this.dlgFont.Font;
								}
								else
								{
									myButton.mButton.Font = this.Font;
								}
							}
							else
							{
								bool flag2 = Operators.CompareString(myButton.NormalKey, this.blankLayout[Conversions.ToInteger(myButton.Tag)][0], false) != 0;
								if (flag2)
								{
									myButton.mButton.Font = this.dlgFont.Font;
								}
								else
								{
									myButton.mButton.Font = this.Font;
								}
							}
						}
						catch (Exception ex2)
						{
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

		// Token: 0x06000179 RID: 377 RVA: 0x000D429C File Offset: 0x000D269C
		private void chkKey_CheckedChanged(object sender, EventArgs e)
		{
			this.KeyPreview = this.chkKey.Checked;
			try
			{
				foreach (object obj in this.GroupBox2.Controls)
				{
					Control control = (Control)obj;
					bool flag = control is TextBox;
					if (flag)
					{
						TextBox textBox = (TextBox)control;
						flag = this.chkKey.Checked;
						if (flag)
						{
							textBox.Enabled = false;
						}
						else
						{
							textBox.Enabled = true;
						}
					}
				}
			}
			finally
			{
				IEnumerator enumerator;
				bool flag = enumerator is IDisposable;
				if (flag)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
		}

		// Token: 0x0600017A RID: 378 RVA: 0x000D4354 File Offset: 0x000D2754
		private void chkRShift_Click(object sender, EventArgs e)
		{
			this.chkLShift.Checked = Conversions.ToBoolean(Interaction.IIf(this.chkLShift.Checked, false, true));
		}

		// Token: 0x0600017B RID: 379 RVA: 0x000D4388 File Offset: 0x000D2788
		private void dgJuks_SelectionChanged(object sender, EventArgs e)
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
				this.txtSeq.Text = Conversions.ToString(this.dgJuks[0, this.dgJuks.SelectedRows[0].Index].Value);
				IL_43:
				num2 = 3;
				this.txtCom.Text = Conversions.ToString(this.dgJuks[1, this.dgJuks.SelectedRows[0].Index].Value);
				IL_7D:
				goto IL_E7;
				IL_82:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_A0:
				goto IL_DC;
				IL_A2:
				num4 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], (num > -2) ? num : 1);
				IL_BA:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_A2;
			}
			IL_DC:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_E7:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x0600017C RID: 380 RVA: 0x000D4498 File Offset: 0x000D2898
		private void txtIco_TextChanged(object sender, EventArgs e)
		{
			string str = myFunctions.VerifyPath(MyProject.Application.Info.DirectoryPath);
			str += "Icons\\";
			try
			{
				this.lblNotFound.Visible = false;
				Icon icon = new Icon(str + Strings.Replace(this.txtIco.Text, ".ico", "", 1, -1, CompareMethod.Binary) + ".ico", 16, 16);
				this.picIco16.Image = icon.ToBitmap();
				icon = new Icon(str + Strings.Replace(this.txtIco.Text, ".ico", "", 1, -1, CompareMethod.Binary) + ".ico", 24, 24);
				this.picIco24.Image = icon.ToBitmap();
			}
			catch (Exception ex)
			{
				this.picIco16.Image = null;
				this.picIco24.Image = null;
				this.lblNotFound.Visible = true;
			}
		}

		// Token: 0x0600017D RID: 381 RVA: 0x000D45A8 File Offset: 0x000D29A8
		private void txtSeq_KeyUp(object sender, KeyEventArgs e)
		{
			bool @checked = this.chkListG.Checked;
			checked
			{
				if (@checked)
				{
					int num = 0;
					int num2 = this.dgJuks.Rows.Count - 1;
					int num3 = num;
					for (;;)
					{
						int num4 = num3;
						int num5 = num2;
						if (num4 > num5)
						{
							break;
						}
						bool flag = this.txtSeq.Text.Contains(Conversions.ToString(this.dgJuks[0, num3].Value));
						if (flag)
						{
							this.dgJuks.Rows[num3].Selected = true;
							int selectionStart = this.txtSeq.SelectionStart;
							TextBox txtSeq = this.txtSeq;
							object text = this.txtSeq.Text;
							Type type = null;
							string memberName = "Replace";
							object[] array = new object[2];
							object[] array2 = array;
							int num6 = 0;
							DataGridViewCell dataGridViewCell = this.dgJuks[0, num3];
							array2[num6] = RuntimeHelpers.GetObjectValue(dataGridViewCell.Value);
							object[] array3 = array;
							int num7 = 1;
							DataGridViewCell dataGridViewCell2 = this.dgJuks[1, num3];
							array3[num7] = RuntimeHelpers.GetObjectValue(dataGridViewCell2.Value);
							object[] array4 = array;
							object[] arguments = array4;
							string[] argumentNames = null;
							Type[] typeArguments = null;
							bool[] array5 = new bool[]
							{
								true,
								true
							};
							object value = NewLateBinding.LateGet(text, type, memberName, arguments, argumentNames, typeArguments, array5);
							if (array5[0])
							{
								dataGridViewCell.Value = RuntimeHelpers.GetObjectValue(array4[0]);
							}
							if (array5[1])
							{
								dataGridViewCell2.Value = RuntimeHelpers.GetObjectValue(array4[1]);
							}
							txtSeq.Text = Conversions.ToString(value);
							this.txtSeq.SelectionStart = selectionStart;
							this.dgJuks.FirstDisplayedScrollingRowIndex = this.dgJuks.SelectedRows[0].Index;
						}
						num3++;
					}
				}
			}
		}

		// Token: 0x0600017E RID: 382 RVA: 0x000D4730 File Offset: 0x000D2B30
		private bool ResetLayout()
		{
			try
			{
				foreach (object obj in this.GroupBox1.Controls)
				{
					Control control = (Control)obj;
					bool flag = control is myButton;
					if (flag)
					{
						myButton myButton = (myButton)control;
						flag = Operators.ConditionalCompareObjectNotEqual(myButton.Tag, "", false);
						if (flag)
						{
							string[] array = this.blankLayout[Conversions.ToInteger(myButton.Tag)];
							myButton.NormalKey = array[0];
							myButton.NormalKeyOption = array[2];
							myButton.ShiftKey = array[1];
							myButton.ShiftKeyOption = array[3];
							myButton.mButton.Font = this.Font;
							myButton.ForeColor = Color.Black;
						}
					}
				}
			}
			finally
			{
				IEnumerator enumerator;
				bool flag = enumerator is IDisposable;
				if (flag)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
			bool result;
			return result;
		}

		// Token: 0x0600017F RID: 383 RVA: 0x000D4838 File Offset: 0x000D2C38
		private void btnUp_Click(object sender, EventArgs e)
		{
			checked
			{
				try
				{
					string value = Conversions.ToString(this.dgJuks[0, this.dgJuks.SelectedRows[0].Index - Conversions.ToInteger(this.txtCounter.Text)].Value);
					string value2 = Conversions.ToString(this.dgJuks[1, this.dgJuks.SelectedRows[0].Index - Conversions.ToInteger(this.txtCounter.Text)].Value);
					this.dgJuks[0, this.dgJuks.SelectedRows[0].Index - Conversions.ToInteger(this.txtCounter.Text)].Value = RuntimeHelpers.GetObjectValue(this.dgJuks[0, this.dgJuks.SelectedRows[0].Index].Value);
					this.dgJuks[1, this.dgJuks.SelectedRows[0].Index - Conversions.ToInteger(this.txtCounter.Text)].Value = RuntimeHelpers.GetObjectValue(this.dgJuks[1, this.dgJuks.SelectedRows[0].Index].Value);
					this.dgJuks[0, this.dgJuks.SelectedRows[0].Index].Value = value;
					this.dgJuks[1, this.dgJuks.SelectedRows[0].Index].Value = value2;
					this.dgJuks.Rows[this.dgJuks.SelectedRows[0].Index - Conversions.ToInteger(this.txtCounter.Text)].Selected = true;
					this.dgJuks.FirstDisplayedScrollingRowIndex = this.dgJuks.SelectedRows[0].Index;
				}
				catch (Exception ex)
				{
					Interaction.MsgBox("Unable to move up", MsgBoxStyle.Critical, null);
				}
			}
		}

		// Token: 0x06000180 RID: 384 RVA: 0x000D4A7C File Offset: 0x000D2E7C
		private void btnDown_Click(object sender, EventArgs e)
		{
			checked
			{
				try
				{
					string value = Conversions.ToString(this.dgJuks[0, this.dgJuks.SelectedRows[0].Index + Conversions.ToInteger(this.txtCounter.Text)].Value);
					string value2 = Conversions.ToString(this.dgJuks[1, this.dgJuks.SelectedRows[0].Index + Conversions.ToInteger(this.txtCounter.Text)].Value);
					this.dgJuks[0, this.dgJuks.SelectedRows[0].Index + Conversions.ToInteger(this.txtCounter.Text)].Value = RuntimeHelpers.GetObjectValue(this.dgJuks[0, this.dgJuks.SelectedRows[0].Index].Value);
					this.dgJuks[1, this.dgJuks.SelectedRows[0].Index + Conversions.ToInteger(this.txtCounter.Text)].Value = RuntimeHelpers.GetObjectValue(this.dgJuks[1, this.dgJuks.SelectedRows[0].Index].Value);
					this.dgJuks[0, this.dgJuks.SelectedRows[0].Index].Value = value;
					this.dgJuks[1, this.dgJuks.SelectedRows[0].Index].Value = value2;
					this.dgJuks.Rows[this.dgJuks.SelectedRows[0].Index + Conversions.ToInteger(this.txtCounter.Text)].Selected = true;
					this.dgJuks.FirstDisplayedScrollingRowIndex = this.dgJuks.SelectedRows[0].Index;
				}
				catch (Exception ex)
				{
					Interaction.MsgBox("Unable to move down", MsgBoxStyle.Critical, null);
				}
			}
		}

		// Token: 0x06000181 RID: 385 RVA: 0x000D4CC0 File Offset: 0x000D30C0
		private void btnUpdate_Click(object sender, EventArgs e)
		{
			bool flag = Operators.CompareString(this.txtSeq.Text, "", false) != 0 & Operators.CompareString(this.txtCom.Text, "", false) != 0;
			if (flag)
			{
				this.dgJuks[0, this.dgJuks.SelectedRows[0].Index].Value = this.txtSeq.Text;
				this.dgJuks[1, this.dgJuks.SelectedRows[0].Index].Value = this.txtCom.Text;
			}
			else
			{
				Interaction.MsgBox("Can't update blank Sequence/Combination", MsgBoxStyle.Critical, null);
			}
		}

		// Token: 0x06000182 RID: 386 RVA: 0x000D4D84 File Offset: 0x000D3184
		private void btnAdd_Click(object sender, EventArgs e)
		{
			bool flag = Operators.CompareString(this.txtSeq.Text, "", false) != 0 & Operators.CompareString(this.txtCom.Text, "", false) != 0;
			checked
			{
				if (flag)
				{
					int num = 0;
					int num2 = this.dgJuks.Rows.Count - 1;
					int num3 = num;
					for (;;)
					{
						int num4 = num3;
						int num5 = num2;
						if (num4 > num5)
						{
							goto Block_3;
						}
						bool flag2 = Operators.ConditionalCompareObjectEqual(this.txtSeq.Text, this.dgJuks[0, num3].Value, false);
						if (flag2)
						{
							break;
						}
						num3++;
					}
					this.dgJuks.Rows[num3].Selected = true;
					Interaction.MsgBox("Sequence Already Exsist!", MsgBoxStyle.Critical, null);
					return;
					Block_3:
					string[] array = new string[3];
					array[0] = this.txtSeq.Text;
					array[1] = this.txtCom.Text;
					this.dgJuks.Rows.Add(array);
					this.txtSeq.Text = "";
					this.txtCom.Text = "";
					this.txtSeq.Focus();
				}
				else
				{
					Interaction.MsgBox("Can't add blank Sequence/Combination", MsgBoxStyle.Critical, null);
				}
			}
		}

		// Token: 0x06000183 RID: 387 RVA: 0x000D4EC4 File Offset: 0x000D32C4
		private void btnDel_Click(object sender, EventArgs e)
		{
			this.dgJuks.Rows.RemoveAt(this.dgJuks.SelectedRows[0].Index);
		}

		// Token: 0x06000184 RID: 388 RVA: 0x000D4EF0 File Offset: 0x000D32F0
		private void txtSeqHex_KeyUp(object sender, KeyEventArgs e)
		{
			bool @checked = this.chkListG.Checked;
			checked
			{
				if (@checked)
				{
					int num = 0;
					int num2 = this.dgJuks.Rows.Count - 1;
					int num3 = num;
					for (;;)
					{
						int num4 = num3;
						int num5 = num2;
						if (num4 > num5)
						{
							break;
						}
						bool flag = this.txtSeq.Text.Contains(Conversions.ToString(this.dgJuks[0, num3].Value));
						if (flag)
						{
							this.dgJuks.Rows[num3].Selected = true;
							int selectionStart = this.txtSeq.SelectionStart;
							TextBox txtSeq = this.txtSeq;
							object text = this.txtSeq.Text;
							Type type = null;
							string memberName = "Replace";
							object[] array = new object[2];
							object[] array2 = array;
							int num6 = 0;
							DataGridViewCell dataGridViewCell = this.dgJuks[0, num3];
							array2[num6] = RuntimeHelpers.GetObjectValue(dataGridViewCell.Value);
							object[] array3 = array;
							int num7 = 1;
							DataGridViewCell dataGridViewCell2 = this.dgJuks[1, num3];
							array3[num7] = RuntimeHelpers.GetObjectValue(dataGridViewCell2.Value);
							object[] array4 = array;
							object[] arguments = array4;
							string[] argumentNames = null;
							Type[] typeArguments = null;
							bool[] array5 = new bool[]
							{
								true,
								true
							};
							object value = NewLateBinding.LateGet(text, type, memberName, arguments, argumentNames, typeArguments, array5);
							if (array5[0])
							{
								dataGridViewCell.Value = RuntimeHelpers.GetObjectValue(array4[0]);
							}
							if (array5[1])
							{
								dataGridViewCell2.Value = RuntimeHelpers.GetObjectValue(array4[1]);
							}
							txtSeq.Text = Conversions.ToString(value);
							this.txtSeq.SelectionStart = selectionStart;
							this.dgJuks.FirstDisplayedScrollingRowIndex = this.dgJuks.SelectedRows[0].Index;
						}
						num3++;
					}
				}
			}
		}

		// Token: 0x06000185 RID: 389 RVA: 0x000D5078 File Offset: 0x000D3478
		private void txtSeqHex_TextChanged(object sender, EventArgs e)
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
						string[] array = Strings.Split(this.txtSeqHex.Text, ",", -1, CompareMethod.Binary);
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
						this.txtSeq.Text = text;
					}
					this.flagHex = false;
				}
			}
		}

		// Token: 0x06000186 RID: 390 RVA: 0x000D5140 File Offset: 0x000D3540
		private void txtComHex_TextChanged(object sender, EventArgs e)
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
						string[] array = Strings.Split(this.txtComHex.Text, ",", -1, CompareMethod.Binary);
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
						this.txtCom.Text = text;
					}
					this.flagHex = false;
				}
			}
		}

		// Token: 0x06000187 RID: 391 RVA: 0x000D5208 File Offset: 0x000D3608
		private void txtSeq_TextChanged(object sender, EventArgs e)
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
						string text2 = this.txtSeq.Text;
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
						flag = (text.Length > 0);
						if (flag)
						{
							this.txtSeqHex.Text = Strings.Left(text, text.Length - 1);
						}
						flag = (Operators.CompareString(this.txtSeq.Text, "", false) == 0);
						if (flag)
						{
							this.txtSeqHex.Text = "";
						}
					}
					this.flagChar = false;
				}
			}
		}

		// Token: 0x06000188 RID: 392 RVA: 0x000D5310 File Offset: 0x000D3710
		private void txtCom_TextChanged(object sender, EventArgs e)
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
						string text2 = this.txtCom.Text;
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
						flag = (text.Length > 0);
						if (flag)
						{
							this.txtComHex.Text = Strings.Left(text, text.Length - 1);
						}
						flag = (Operators.CompareString(this.txtCom.Text, "", false) == 0);
						if (flag)
						{
							this.txtComHex.Text = "";
						}
					}
					this.flagChar = false;
				}
			}
		}

		// Token: 0x06000189 RID: 393 RVA: 0x000D5418 File Offset: 0x000D3818
		private void txtName_TextChanged(object sender, EventArgs e)
		{
			bool flag = this.txtName.Text.Length > 0;
			if (flag)
			{
				this.btnSave.Enabled = true;
			}
			else
			{
				this.btnSave.Enabled = false;
			}
		}

		// Token: 0x0600018A RID: 394 RVA: 0x000D545C File Offset: 0x000D385C
		private void btnCancel_Click(object sender, EventArgs e)
		{
			MsgBoxResult msgBoxResult = Interaction.MsgBox("Do you want to save the changes?", MsgBoxStyle.OkCancel | MsgBoxStyle.AbortRetryIgnore | MsgBoxStyle.Critical | MsgBoxStyle.Question, null);
			bool flag = msgBoxResult == MsgBoxResult.Yes;
			if (flag)
			{
				bool flag2 = this.SaveAndLoad();
				if (flag2)
				{
					this.btnNew.PerformClick();
					this.Text = "Keyboard Layout Editor 1.0.1";
					this.comLayouts.Enabled = true;
					this.btnCancel.Enabled = false;
					Interaction.MsgBox("Layout saved & published successfully", MsgBoxStyle.Information, "Layout Editor 1.0.1");
				}
			}
			else
			{
				bool flag2 = msgBoxResult == MsgBoxResult.No;
				if (flag2)
				{
					this.btnNew.PerformClick();
					this.Text = "Keyboard Layout Editor 1.0.1";
					this.comLayouts.Enabled = true;
					this.btnCancel.Enabled = false;
				}
			}
		}

		// Token: 0x0600018B RID: 395 RVA: 0x000D5510 File Offset: 0x000D3910
		private bool SaveLayout(string Path)
		{
			clsLayouts.LayoutShortcut layoutShortcut;
			layoutShortcut.Alt = this.chkAlt.Checked;
			layoutShortcut.Ctrl = this.chkCtrl.Checked;
			layoutShortcut.Shift = this.chkShift.Checked;
			bool flag = this.chkAlt.Checked | this.chkCtrl.Checked;
			if (flag)
			{
				layoutShortcut.KeyCode = Strings.AscW(this.comKey.Text);
			}
			else
			{
				layoutShortcut.KeyCode = myFunctions.DefineKey(this.comKey.Text);
			}
			int num = Information.LBound(modKeyboard.Layout, 1);
			int num2 = Information.UBound(modKeyboard.Layout, 1);
			int num3 = num;
			checked
			{
				for (;;)
				{
					int num4 = num3;
					int num5 = num2;
					if (num4 > num5)
					{
						goto Block_3;
					}
					flag = (modKeyboard.Layout[num3].Shortcut.Equals(layoutShortcut) & !modKeyboard.Layout[num3].Equals(this.WorkLay));
					if (flag)
					{
						break;
					}
					num3++;
				}
				Interaction.MsgBox(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Interaction.IIf(layoutShortcut.Alt, "Alt + ", ""), Interaction.IIf(layoutShortcut.Ctrl, "Ctrl + ", "")), Interaction.IIf(layoutShortcut.Shift, "Shift + ", "")), this.comKey.Text), " is already assigned to "), modKeyboard.Layout[num3].Name), " Layout"), "\r\n"), "Please, Change this Shortcut Key."), MsgBoxStyle.Critical, null);
				return false;
				Block_3:
				XmlWriter xmlWriter = XmlWriter.Create(Path, new XmlWriterSettings
				{
					CheckCharacters = true,
					CloseOutput = true,
					Indent = true
				});
				XmlWriter xmlWriter2 = xmlWriter;
				try
				{
					try
					{
						xmlWriter.WriteStartDocument(true);
						xmlWriter.WriteComment("Start of Layout");
						xmlWriter.WriteStartElement("KeyLayout");
						xmlWriter.WriteElementString("Name", this.txtName.Text);
						xmlWriter.WriteStartElement("Shortcut");
						xmlWriter.WriteElementString("Alt", Conversions.ToString(layoutShortcut.Alt));
						xmlWriter.WriteElementString("Ctrl", Conversions.ToString(layoutShortcut.Ctrl));
						xmlWriter.WriteElementString("Shift", Conversions.ToString(layoutShortcut.Shift));
						xmlWriter.WriteElementString("KeyCode", Conversions.ToString(layoutShortcut.KeyCode));
						xmlWriter.WriteEndElement();
						xmlWriter.WriteElementString("IconName", this.txtIco.Text);
						xmlWriter.WriteStartElement("Keys");
						try
						{
							foreach (object obj in this.GroupBox1.Controls)
							{
								Control control = (Control)obj;
								flag = (control is myButton);
								if (flag)
								{
									myButton myButton = (myButton)control;
									flag = Operators.ConditionalCompareObjectNotEqual(myButton.Tag, "", false);
									if (flag)
									{
										string[] array = this.blankLayout[Conversions.ToInteger(myButton.Tag)];
										flag = (Operators.CompareString(myButton.NormalKey, array[0], false) != 0 | Operators.CompareString(myButton.ShiftKey, array[1], false) != 0 | Operators.CompareString(myButton.ShiftKeyOption, "", false) != 0 | Operators.CompareString(myButton.NormalKeyOption, "", false) != 0);
										if (flag)
										{
											xmlWriter.WriteStartElement("Key");
											xmlWriter.WriteAttributeString("KeyCode", Conversions.ToString(myButton.Tag));
											flag = (Operators.CompareString(myButton.NormalKeyOption, "", false) != 0);
											if (flag)
											{
												xmlWriter.WriteAttributeString("Normal_Option", myButton.NormalKeyOption);
											}
											flag = (Operators.CompareString(myButton.ShiftKeyOption, "", false) != 0);
											if (flag)
											{
												xmlWriter.WriteAttributeString("Shift_Option", myButton.ShiftKeyOption);
											}
											xmlWriter.WriteStartElement("Normal");
											xmlWriter.WriteValue(myButton.NormalKey);
											xmlWriter.WriteEndElement();
											xmlWriter.WriteStartElement("Shift");
											xmlWriter.WriteValue(myButton.ShiftKey);
											xmlWriter.WriteEndElement();
											xmlWriter.WriteEndElement();
										}
									}
								}
							}
						}
						finally
						{
							IEnumerator enumerator;
							flag = (enumerator is IDisposable);
							if (flag)
							{
								(enumerator as IDisposable).Dispose();
							}
						}
						xmlWriter.WriteComment("Creator Designed by Rifat");
						flag = (this.dgJuks.Rows.Count > 0);
						if (flag)
						{
							xmlWriter.WriteEndElement();
							xmlWriter.WriteStartElement("Juks");
							int num6 = 0;
							int num7 = this.dgJuks.Rows.Count - 1;
							num3 = num6;
							for (;;)
							{
								int num8 = num3;
								int num5 = num7;
								if (num8 > num5)
								{
									break;
								}
								xmlWriter.WriteStartElement("Juk");
								xmlWriter.WriteElementString("Seq", Conversions.ToString(this.dgJuks[0, num3].Value));
								xmlWriter.WriteElementString("Out", Conversions.ToString(this.dgJuks[1, num3].Value));
								xmlWriter.WriteEndElement();
								num3++;
							}
							xmlWriter.WriteEndElement();
						}
						xmlWriter.WriteEndElement();
						xmlWriter.WriteComment("End of Layout");
						xmlWriter.WriteEndDocument();
					}
					catch (Exception ex)
					{
					}
					finally
					{
						xmlWriter.Close();
					}
				}
				finally
				{
					flag = (xmlWriter2 != null);
					if (flag)
					{
						((IDisposable)xmlWriter2).Dispose();
					}
				}
				return true;
			}
		}

		// Token: 0x0600018C RID: 396 RVA: 0x000D5B38 File Offset: 0x000D3F38
		private bool SaveAndLoad()
		{
			bool flag = Operators.CompareString(this.txtName.Text, "", false) == 0;
			checked
			{
				bool result;
				if (flag)
				{
					Interaction.MsgBox("You must type a Layout Name", MsgBoxStyle.Information, null);
					result = false;
				}
				else
				{
					string text = myFunctions.VerifyPath(MyProject.Application.Info.DirectoryPath);
					flag = (this.WorkLay == null);
					if (flag)
					{
						text = string.Concat(new string[]
						{
							text,
							"Layouts\\",
							Support.Format(this.comLayouts.Items.Count + 1, "00", FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1),
							" ",
							this.txtName.Text,
							".xml"
						});
					}
					else
					{
						text = this.WorkLay.Path;
					}
					flag = this.SaveLayout(text);
					if (flag)
					{
						bool flag2 = this.WorkLay == null;
						if (flag2)
						{
							int num = modKeyboard.LayoutNumber - 1;
							modKeyboard.Layout = (clsLayouts[])Utils.CopyArray((Array)modKeyboard.Layout, new clsLayouts[num + 1]);
							modKeyboard.Layout[num] = new clsLayouts();
							this.WorkLay = modKeyboard.Layout[num];
							modKeyboard.Layout[num].Init(text);
							modKeyboard.Layout[num].Path = text;
							this.comLayouts.Enabled = true;
							MyProject.Forms.frmMain.comLayouts.Items.Add(modKeyboard.Layout[num].Name);
							this.comLayouts.Items.Add(modKeyboard.Layout[num].Name);
							this.comLayouts.Text = modKeyboard.Layout[num].Name;
							ToolStripMenuItem toolStripMenuItem = new ToolStripMenuItem();
							toolStripMenuItem.Text = modKeyboard.Layout[num].Name;
							modKeyboard.Layout[num].ID = num;
							toolStripMenuItem.Tag = num + 2;
							MyProject.Forms.frmMain.NotifyMenu.Items.Insert(0, toolStripMenuItem);
							modKeyboard.LayoutNumber = num + 2;
						}
						else
						{
							this.WorkLay.Update();
						}
						string name = this.WorkLay.Name;
						MyProject.Forms.frmMain.comLayouts.Items[this.WorkLay.ID + 1] = name;
						this.comLayouts.Items[this.WorkLay.ID] = name;
						try
						{
							foreach (object obj in MyProject.Forms.frmMain.NotifyMenu.Items)
							{
								ToolStripItem toolStripItem = (ToolStripItem)obj;
								flag2 = (Operators.ConditionalCompareObjectNotEqual(toolStripItem.Tag, null, false) && toolStripItem is ToolStripMenuItem);
								if (flag2)
								{
									flag = Operators.ConditionalCompareObjectEqual(toolStripItem.Tag, this.WorkLay.ID + 2, false);
									if (flag)
									{
										((ToolStripMenuItem)toolStripItem).Text = name;
									}
								}
							}
						}
						finally
						{
							IEnumerator enumerator;
							flag2 = (enumerator is IDisposable);
							if (flag2)
							{
								(enumerator as IDisposable).Dispose();
							}
						}
						result = true;
					}
					else
					{
						result = false;
					}
				}
				return result;
			}
		}

		// Token: 0x0600018D RID: 397 RVA: 0x000D5EA0 File Offset: 0x000D42A0
		private void btnCSave_Click(object sender, EventArgs e)
		{
			this.SaveAndLoad();
		}

		// Token: 0x0600018E RID: 398 RVA: 0x000D5EAC File Offset: 0x000D42AC
		private void btnInsert_Click(object sender, EventArgs e)
		{
			bool flag = Operators.CompareString(this.txtSeq.Text, "", false) != 0 & Operators.CompareString(this.txtCom.Text, "", false) != 0;
			checked
			{
				if (flag)
				{
					int num = 0;
					int num2 = this.dgJuks.Rows.Count - 1;
					int num3 = num;
					for (;;)
					{
						int num4 = num3;
						int num5 = num2;
						if (num4 > num5)
						{
							goto Block_3;
						}
						bool flag2 = Operators.ConditionalCompareObjectEqual(this.txtSeq.Text, this.dgJuks[0, num3].Value, false);
						if (flag2)
						{
							break;
						}
						num3++;
					}
					this.dgJuks.Rows[num3].Selected = true;
					Interaction.MsgBox("Sequence Already Exsist!", MsgBoxStyle.Critical, null);
					return;
					Block_3:
					string[] array = new string[3];
					array[0] = this.txtSeq.Text;
					array[1] = this.txtCom.Text;
					this.dgJuks.Rows.Insert(this.dgJuks.SelectedRows[0].Index + 1, array);
					this.txtSeq.Text = "";
					this.txtCom.Text = "";
					this.txtSeq.Focus();
				}
				else
				{
					Interaction.MsgBox("Can't add blank Sequence/Combination", MsgBoxStyle.Critical, null);
				}
			}
		}

		// Token: 0x0600018F RID: 399 RVA: 0x000D6004 File Offset: 0x000D4404
		private void txtCounter_MouseClick(object sender, MouseEventArgs e)
		{
			this.txtCounter.SelectAll();
		}

		// Token: 0x06000190 RID: 400 RVA: 0x000D6014 File Offset: 0x000D4414
		private void txtCounter_TextChanged(object sender, EventArgs e)
		{
			bool flag = Operators.CompareString(this.txtCounter.Text, "", false) == 0;
			if (flag)
			{
				this.txtCounter.Text = Conversions.ToString(1);
			}
			this.btnUp.Text = "Move &Up (" + this.txtCounter.Text + ")";
			this.btnDown.Text = "Move &Down (" + this.txtCounter.Text + ")";
		}

		// Token: 0x0400005B RID: 91
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x0400005D RID: 93
		[AccessedThroughProperty("GroupBox2")]
		private GroupBox _GroupBox2;

		// Token: 0x0400005E RID: 94
		[AccessedThroughProperty("txtName")]
		private TextBox _txtName;

		// Token: 0x0400005F RID: 95
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x04000060 RID: 96
		[AccessedThroughProperty("txtIco")]
		private TextBox _txtIco;

		// Token: 0x04000061 RID: 97
		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		// Token: 0x04000062 RID: 98
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		// Token: 0x04000063 RID: 99
		[AccessedThroughProperty("Label4")]
		private Label _Label4;

		// Token: 0x04000064 RID: 100
		[AccessedThroughProperty("Label5")]
		private Label _Label5;

		// Token: 0x04000065 RID: 101
		[AccessedThroughProperty("Label6")]
		private Label _Label6;

		// Token: 0x04000066 RID: 102
		[AccessedThroughProperty("comLayouts")]
		private ComboBox _comLayouts;

		// Token: 0x04000067 RID: 103
		[AccessedThroughProperty("Label7")]
		private Label _Label7;

		// Token: 0x04000068 RID: 104
		[AccessedThroughProperty("btnEdit")]
		private Button _btnEdit;

		// Token: 0x04000069 RID: 105
		[AccessedThroughProperty("btnNew")]
		private Button _btnNew;

		// Token: 0x0400006A RID: 106
		[AccessedThroughProperty("dlgFont")]
		private FontDialog _dlgFont;

		// Token: 0x0400006B RID: 107
		[AccessedThroughProperty("btnFont")]
		private Button _btnFont;

		// Token: 0x0400006C RID: 108
		[AccessedThroughProperty("comKey")]
		private ComboBox _comKey;

		// Token: 0x0400006D RID: 109
		[AccessedThroughProperty("chkShift")]
		private CheckBox _chkShift;

		// Token: 0x0400006E RID: 110
		[AccessedThroughProperty("chkCtrl")]
		private CheckBox _chkCtrl;

		// Token: 0x0400006F RID: 111
		[AccessedThroughProperty("chkAlt")]
		private CheckBox _chkAlt;

		// Token: 0x04000070 RID: 112
		[AccessedThroughProperty("btnSave")]
		private Button _btnSave;

		// Token: 0x04000071 RID: 113
		[AccessedThroughProperty("TabControl1")]
		private TabControl _TabControl1;

		// Token: 0x04000072 RID: 114
		[AccessedThroughProperty("TabPage1")]
		private TabPage _TabPage1;

		// Token: 0x04000073 RID: 115
		[AccessedThroughProperty("GroupBox1")]
		private GroupBox _GroupBox1;

		// Token: 0x04000074 RID: 116
		[AccessedThroughProperty("chkRShift")]
		private CheckBox _chkRShift;

		// Token: 0x04000075 RID: 117
		[AccessedThroughProperty("chkLShift")]
		private CheckBox _chkLShift;

		// Token: 0x04000076 RID: 118
		[AccessedThroughProperty("Button30")]
		private Button _Button30;

		// Token: 0x04000077 RID: 119
		[AccessedThroughProperty("Button29")]
		private Button _Button29;

		// Token: 0x04000078 RID: 120
		[AccessedThroughProperty("Button28")]
		private Button _Button28;

		// Token: 0x04000079 RID: 121
		[AccessedThroughProperty("Button27")]
		private Button _Button27;

		// Token: 0x0400007A RID: 122
		[AccessedThroughProperty("Button26")]
		private Button _Button26;

		// Token: 0x0400007B RID: 123
		[AccessedThroughProperty("Button23")]
		private Button _Button23;

		// Token: 0x0400007C RID: 124
		[AccessedThroughProperty("Button24")]
		private Button _Button24;

		// Token: 0x0400007D RID: 125
		[AccessedThroughProperty("Button25")]
		private Button _Button25;

		// Token: 0x0400007E RID: 126
		[AccessedThroughProperty("Button20")]
		private Button _Button20;

		// Token: 0x0400007F RID: 127
		[AccessedThroughProperty("Button21")]
		private Button _Button21;

		// Token: 0x04000080 RID: 128
		[AccessedThroughProperty("Button22")]
		private Button _Button22;

		// Token: 0x04000081 RID: 129
		[AccessedThroughProperty("Button17")]
		private Button _Button17;

		// Token: 0x04000082 RID: 130
		[AccessedThroughProperty("Button18")]
		private Button _Button18;

		// Token: 0x04000083 RID: 131
		[AccessedThroughProperty("Button19")]
		private Button _Button19;

		// Token: 0x04000084 RID: 132
		[AccessedThroughProperty("Button16")]
		private Button _Button16;

		// Token: 0x04000085 RID: 133
		[AccessedThroughProperty("Button15")]
		private Button _Button15;

		// Token: 0x04000086 RID: 134
		[AccessedThroughProperty("Button14")]
		private Button _Button14;

		// Token: 0x04000087 RID: 135
		[AccessedThroughProperty("Button11")]
		private Button _Button11;

		// Token: 0x04000088 RID: 136
		[AccessedThroughProperty("Button13")]
		private Button _Button13;

		// Token: 0x04000089 RID: 137
		[AccessedThroughProperty("Button12")]
		private Button _Button12;

		// Token: 0x0400008A RID: 138
		[AccessedThroughProperty("Button10")]
		private Button _Button10;

		// Token: 0x0400008B RID: 139
		[AccessedThroughProperty("Button9")]
		private Button _Button9;

		// Token: 0x0400008C RID: 140
		[AccessedThroughProperty("Button8")]
		private Button _Button8;

		// Token: 0x0400008D RID: 141
		[AccessedThroughProperty("Button7")]
		private Button _Button7;

		// Token: 0x0400008E RID: 142
		[AccessedThroughProperty("MyButton48")]
		private myButton _MyButton48;

		// Token: 0x0400008F RID: 143
		[AccessedThroughProperty("btnRShift")]
		private Button _btnRShift;

		// Token: 0x04000090 RID: 144
		[AccessedThroughProperty("MyButton47")]
		private myButton _MyButton47;

		// Token: 0x04000091 RID: 145
		[AccessedThroughProperty("Button5")]
		private Button _Button5;

		// Token: 0x04000092 RID: 146
		[AccessedThroughProperty("MyButton46")]
		private myButton _MyButton46;

		// Token: 0x04000093 RID: 147
		[AccessedThroughProperty("MyButton45")]
		private myButton _MyButton45;

		// Token: 0x04000094 RID: 148
		[AccessedThroughProperty("MyButton44")]
		private myButton _MyButton44;

		// Token: 0x04000095 RID: 149
		[AccessedThroughProperty("MyButton43")]
		private myButton _MyButton43;

		// Token: 0x04000096 RID: 150
		[AccessedThroughProperty("MyButton42")]
		private myButton _MyButton42;

		// Token: 0x04000097 RID: 151
		[AccessedThroughProperty("Button4")]
		private Button _Button4;

		// Token: 0x04000098 RID: 152
		[AccessedThroughProperty("MyButton41")]
		private myButton _MyButton41;

		// Token: 0x04000099 RID: 153
		[AccessedThroughProperty("MyButton40")]
		private myButton _MyButton40;

		// Token: 0x0400009A RID: 154
		[AccessedThroughProperty("btnLShift")]
		private Button _btnLShift;

		// Token: 0x0400009B RID: 155
		[AccessedThroughProperty("Button2")]
		private Button _Button2;

		// Token: 0x0400009C RID: 156
		[AccessedThroughProperty("MyButton39")]
		private myButton _MyButton39;

		// Token: 0x0400009D RID: 157
		[AccessedThroughProperty("Button1")]
		private Button _Button1;

		// Token: 0x0400009E RID: 158
		[AccessedThroughProperty("MyButton29")]
		private myButton _MyButton29;

		// Token: 0x0400009F RID: 159
		[AccessedThroughProperty("MyButton30")]
		private myButton _MyButton30;

		// Token: 0x040000A0 RID: 160
		[AccessedThroughProperty("MyButton31")]
		private myButton _MyButton31;

		// Token: 0x040000A1 RID: 161
		[AccessedThroughProperty("MyButton32")]
		private myButton _MyButton32;

		// Token: 0x040000A2 RID: 162
		[AccessedThroughProperty("MyButton33")]
		private myButton _MyButton33;

		// Token: 0x040000A3 RID: 163
		[AccessedThroughProperty("MyButton34")]
		private myButton _MyButton34;

		// Token: 0x040000A4 RID: 164
		[AccessedThroughProperty("MyButton35")]
		private myButton _MyButton35;

		// Token: 0x040000A5 RID: 165
		[AccessedThroughProperty("MyButton36")]
		private myButton _MyButton36;

		// Token: 0x040000A6 RID: 166
		[AccessedThroughProperty("MyButton37")]
		private myButton _MyButton37;

		// Token: 0x040000A7 RID: 167
		[AccessedThroughProperty("MyButton38")]
		private myButton _MyButton38;

		// Token: 0x040000A8 RID: 168
		[AccessedThroughProperty("MyButton28")]
		private myButton _MyButton28;

		// Token: 0x040000A9 RID: 169
		[AccessedThroughProperty("MyButton19")]
		private myButton _MyButton19;

		// Token: 0x040000AA RID: 170
		[AccessedThroughProperty("MyButton20")]
		private myButton _MyButton20;

		// Token: 0x040000AB RID: 171
		[AccessedThroughProperty("MyButton21")]
		private myButton _MyButton21;

		// Token: 0x040000AC RID: 172
		[AccessedThroughProperty("MyButton22")]
		private myButton _MyButton22;

		// Token: 0x040000AD RID: 173
		[AccessedThroughProperty("MyButton23")]
		private myButton _MyButton23;

		// Token: 0x040000AE RID: 174
		[AccessedThroughProperty("MyButton24")]
		private myButton _MyButton24;

		// Token: 0x040000AF RID: 175
		[AccessedThroughProperty("MyButton25")]
		private myButton _MyButton25;

		// Token: 0x040000B0 RID: 176
		[AccessedThroughProperty("MyButton26")]
		private myButton _MyButton26;

		// Token: 0x040000B1 RID: 177
		[AccessedThroughProperty("MyButton27")]
		private myButton _MyButton27;

		// Token: 0x040000B2 RID: 178
		[AccessedThroughProperty("MyButton10")]
		private myButton _MyButton10;

		// Token: 0x040000B3 RID: 179
		[AccessedThroughProperty("MyButton11")]
		private myButton _MyButton11;

		// Token: 0x040000B4 RID: 180
		[AccessedThroughProperty("MyButton12")]
		private myButton _MyButton12;

		// Token: 0x040000B5 RID: 181
		[AccessedThroughProperty("MyButton13")]
		private myButton _MyButton13;

		// Token: 0x040000B6 RID: 182
		[AccessedThroughProperty("MyButton14")]
		private myButton _MyButton14;

		// Token: 0x040000B7 RID: 183
		[AccessedThroughProperty("MyButton15")]
		private myButton _MyButton15;

		// Token: 0x040000B8 RID: 184
		[AccessedThroughProperty("MyButton16")]
		private myButton _MyButton16;

		// Token: 0x040000B9 RID: 185
		[AccessedThroughProperty("MyButton17")]
		private myButton _MyButton17;

		// Token: 0x040000BA RID: 186
		[AccessedThroughProperty("MyButton18")]
		private myButton _MyButton18;

		// Token: 0x040000BB RID: 187
		[AccessedThroughProperty("MyButton9")]
		private myButton _MyButton9;

		// Token: 0x040000BC RID: 188
		[AccessedThroughProperty("MyButton8")]
		private myButton _MyButton8;

		// Token: 0x040000BD RID: 189
		[AccessedThroughProperty("MyButton7")]
		private myButton _MyButton7;

		// Token: 0x040000BE RID: 190
		[AccessedThroughProperty("MyButton6")]
		private myButton _MyButton6;

		// Token: 0x040000BF RID: 191
		[AccessedThroughProperty("MyButton5")]
		private myButton _MyButton5;

		// Token: 0x040000C0 RID: 192
		[AccessedThroughProperty("MyButton4")]
		private myButton _MyButton4;

		// Token: 0x040000C1 RID: 193
		[AccessedThroughProperty("MyButton3")]
		private myButton _MyButton3;

		// Token: 0x040000C2 RID: 194
		[AccessedThroughProperty("MyButton2")]
		private myButton _MyButton2;

		// Token: 0x040000C3 RID: 195
		[AccessedThroughProperty("MyButton1")]
		private myButton _MyButton1;

		// Token: 0x040000C4 RID: 196
		[AccessedThroughProperty("TabPage2")]
		private TabPage _TabPage2;

		// Token: 0x040000C5 RID: 197
		[AccessedThroughProperty("chkKey")]
		private CheckBox _chkKey;

		// Token: 0x040000C6 RID: 198
		[AccessedThroughProperty("Column1")]
		private DataGridViewTextBoxColumn _Column1;

		// Token: 0x040000C7 RID: 199
		[AccessedThroughProperty("Column2")]
		private DataGridViewTextBoxColumn _Column2;

		// Token: 0x040000C8 RID: 200
		[AccessedThroughProperty("Label9")]
		private Label _Label9;

		// Token: 0x040000C9 RID: 201
		[AccessedThroughProperty("txtCom")]
		private TextBox _txtCom;

		// Token: 0x040000CA RID: 202
		[AccessedThroughProperty("Label8")]
		private Label _Label8;

		// Token: 0x040000CB RID: 203
		[AccessedThroughProperty("txtSeq")]
		private TextBox _txtSeq;

		// Token: 0x040000CC RID: 204
		[AccessedThroughProperty("btnDown")]
		private Button _btnDown;

		// Token: 0x040000CD RID: 205
		[AccessedThroughProperty("btnUp")]
		private Button _btnUp;

		// Token: 0x040000CE RID: 206
		[AccessedThroughProperty("btnUpdate")]
		private Button _btnUpdate;

		// Token: 0x040000CF RID: 207
		[AccessedThroughProperty("btnAdd")]
		private Button _btnAdd;

		// Token: 0x040000D0 RID: 208
		[AccessedThroughProperty("GroupBox3")]
		private GroupBox _GroupBox3;

		// Token: 0x040000D1 RID: 209
		[AccessedThroughProperty("picIco24")]
		private PictureBox _picIco24;

		// Token: 0x040000D2 RID: 210
		[AccessedThroughProperty("picIco16")]
		private PictureBox _picIco16;

		// Token: 0x040000D3 RID: 211
		[AccessedThroughProperty("lblNotFound")]
		private Label _lblNotFound;

		// Token: 0x040000D4 RID: 212
		[AccessedThroughProperty("btnDel")]
		private Button _btnDel;

		// Token: 0x040000D5 RID: 213
		[AccessedThroughProperty("dgJuks")]
		private DataGridView _dgJuks;

		// Token: 0x040000D6 RID: 214
		[AccessedThroughProperty("Label11")]
		private Label _Label11;

		// Token: 0x040000D7 RID: 215
		[AccessedThroughProperty("Label10")]
		private Label _Label10;

		// Token: 0x040000D8 RID: 216
		[AccessedThroughProperty("txtComHex")]
		private TextBox _txtComHex;

		// Token: 0x040000D9 RID: 217
		[AccessedThroughProperty("txtSeqHex")]
		private TextBox _txtSeqHex;

		// Token: 0x040000DA RID: 218
		[AccessedThroughProperty("Label12")]
		private Label _Label12;

		// Token: 0x040000DB RID: 219
		[AccessedThroughProperty("btnCancel")]
		private Button _btnCancel;

		// Token: 0x040000DC RID: 220
		[AccessedThroughProperty("chkListG")]
		private CheckBox _chkListG;

		// Token: 0x040000DD RID: 221
		[AccessedThroughProperty("ToolTips")]
		private ToolTip _ToolTips;

		// Token: 0x040000DE RID: 222
		[AccessedThroughProperty("btnInsert")]
		private Button _btnInsert;

		// Token: 0x040000DF RID: 223
		[AccessedThroughProperty("Label13")]
		private Label _Label13;

		// Token: 0x040000E0 RID: 224
		[AccessedThroughProperty("txtCounter")]
		private TextBox _txtCounter;

		// Token: 0x040000E1 RID: 225
		private Dictionary<int, string[]> blankLayout;

		// Token: 0x040000E2 RID: 226
		private bool flagChar;

		// Token: 0x040000E3 RID: 227
		private bool flagHex;

		// Token: 0x040000E4 RID: 228
		private clsLayouts WorkLay;
	}
}
