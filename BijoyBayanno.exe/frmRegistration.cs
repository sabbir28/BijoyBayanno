using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Management;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using BijoyBayanno.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace BijoyBayanno
{
	// Token: 0x02000018 RID: 24
	[DesignerGenerated]
	public partial class frmRegistration : Form
	{
		// Token: 0x06000210 RID: 528 RVA: 0x000DA2EC File Offset: 0x000D86EC
		public frmRegistration()
		{
			base.Activated += this.frmRegistration_Activated;
			base.Load += this.frmRegistration_Load;
			List<WeakReference> _ENCList = frmRegistration.__ENCList;
			lock (_ENCList)
			{
				frmRegistration.__ENCList.Add(new WeakReference(this));
			}
			this.rHide = false;
			this.InitializeComponent();
		}

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x06000212 RID: 530 RVA: 0x000DA3B0 File Offset: 0x000D87B0
		// (set) Token: 0x06000213 RID: 531 RVA: 0x000DA3C8 File Offset: 0x000D87C8
		internal virtual PictureBox LogoPictureBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._LogoPictureBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._LogoPictureBox = value;
			}
		}

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x06000214 RID: 532 RVA: 0x000DA3D4 File Offset: 0x000D87D4
		// (set) Token: 0x06000215 RID: 533 RVA: 0x000DA3EC File Offset: 0x000D87EC
		internal virtual Label UsernameLabel
		{
			[DebuggerNonUserCode]
			get
			{
				return this._UsernameLabel;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._UsernameLabel = value;
			}
		}

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x06000216 RID: 534 RVA: 0x000DA3F8 File Offset: 0x000D87F8
		// (set) Token: 0x06000217 RID: 535 RVA: 0x000DA410 File Offset: 0x000D8810
		internal virtual Label PasswordLabel
		{
			[DebuggerNonUserCode]
			get
			{
				return this._PasswordLabel;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.PasswordLabel_Click);
				bool flag = this._PasswordLabel != null;
				if (flag)
				{
					this._PasswordLabel.Click -= value2;
				}
				this._PasswordLabel = value;
				flag = (this._PasswordLabel != null);
				if (flag)
				{
					this._PasswordLabel.Click += value2;
				}
			}
		}

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x06000218 RID: 536 RVA: 0x000DA470 File Offset: 0x000D8870
		// (set) Token: 0x06000219 RID: 537 RVA: 0x000DA488 File Offset: 0x000D8888
		internal virtual TextBox IDTextBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._IDTextBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._IDTextBox = value;
			}
		}

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x0600021A RID: 538 RVA: 0x000DA494 File Offset: 0x000D8894
		// (set) Token: 0x0600021B RID: 539 RVA: 0x000DA4AC File Offset: 0x000D88AC
		internal virtual TextBox PasswordTextBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._PasswordTextBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._PasswordTextBox = value;
			}
		}

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x0600021C RID: 540 RVA: 0x000DA4B8 File Offset: 0x000D88B8
		// (set) Token: 0x0600021D RID: 541 RVA: 0x000DA4D0 File Offset: 0x000D88D0
		internal virtual Button OK
		{
			[DebuggerNonUserCode]
			get
			{
				return this._OK;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.OK_Click);
				bool flag = this._OK != null;
				if (flag)
				{
					this._OK.Click -= value2;
				}
				this._OK = value;
				flag = (this._OK != null);
				if (flag)
				{
					this._OK.Click += value2;
				}
			}
		}

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x0600021E RID: 542 RVA: 0x000DA530 File Offset: 0x000D8930
		// (set) Token: 0x0600021F RID: 543 RVA: 0x000DA548 File Offset: 0x000D8948
		internal virtual Button Cancel
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Cancel;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Cancel_Click);
				bool flag = this._Cancel != null;
				if (flag)
				{
					this._Cancel.Click -= value2;
				}
				this._Cancel = value;
				flag = (this._Cancel != null);
				if (flag)
				{
					this._Cancel.Click += value2;
				}
			}
		}

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x06000221 RID: 545 RVA: 0x000DAEE0 File Offset: 0x000D92E0
		// (set) Token: 0x06000222 RID: 546 RVA: 0x000DAEF8 File Offset: 0x000D92F8
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

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x06000223 RID: 547 RVA: 0x000DAF04 File Offset: 0x000D9304
		// (set) Token: 0x06000224 RID: 548 RVA: 0x000DAF1C File Offset: 0x000D931C
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

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x06000225 RID: 549 RVA: 0x000DAF28 File Offset: 0x000D9328
		// (set) Token: 0x06000226 RID: 550 RVA: 0x000DAF40 File Offset: 0x000D9340
		internal virtual TextBox PasswordTextBox4
		{
			[DebuggerNonUserCode]
			get
			{
				return this._PasswordTextBox4;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._PasswordTextBox4 = value;
			}
		}

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x06000227 RID: 551 RVA: 0x000DAF4C File Offset: 0x000D934C
		// (set) Token: 0x06000228 RID: 552 RVA: 0x000DAF64 File Offset: 0x000D9364
		internal virtual TextBox PasswordTextBox3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._PasswordTextBox3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._PasswordTextBox3 = value;
			}
		}

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x06000229 RID: 553 RVA: 0x000DAF70 File Offset: 0x000D9370
		// (set) Token: 0x0600022A RID: 554 RVA: 0x000DAF88 File Offset: 0x000D9388
		internal virtual TextBox PasswordTextBox2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._PasswordTextBox2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._PasswordTextBox2 = value;
			}
		}

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x0600022B RID: 555 RVA: 0x000DAF94 File Offset: 0x000D9394
		// (set) Token: 0x0600022C RID: 556 RVA: 0x000DAFAC File Offset: 0x000D93AC
		internal virtual TextBox PasswordTextBox1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._PasswordTextBox1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._PasswordTextBox1 = value;
			}
		}

		// Token: 0x0600022D RID: 557 RVA: 0x000DAFB8 File Offset: 0x000D93B8
		private void OK_Click(object sender, EventArgs e)
		{
			myFunctions.Password = "RN28T29SK1XMJ6XYLK24";
			this.passColl = string.Concat(new string[]
			{
				this.PasswordTextBox.Text,
				this.PasswordTextBox1.Text,
				this.PasswordTextBox2.Text,
				this.PasswordTextBox3.Text,
				this.PasswordTextBox4.Text
			});
			bool flag = this.PasswordTextBox.Text.Length > 2 & Operators.CompareString(this.passColl, myFunctions.Password, false) == 0;
			if (flag)
			{
				try
				{
					MyProject.Computer.Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\BijoyBayanno\\Options", "Password", myFunctions.Password);
				}
				catch (Exception ex)
				{
				}
				MyProject.Forms.frmSplash.Show();
				this.Hide();
			}
			else
			{
				Interaction.MsgBox("Wrong Password", MsgBoxStyle.Critical, null);
			}
		}

		// Token: 0x0600022E RID: 558 RVA: 0x000DB0C8 File Offset: 0x000D94C8
		private void Cancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		// Token: 0x0600022F RID: 559 RVA: 0x000DB0D4 File Offset: 0x000D94D4
		private void frmRegistration_Activated(object sender, EventArgs e)
		{
			bool flag = this.rHide;
			if (flag)
			{
				this.Hide();
			}
		}

		// Token: 0x06000230 RID: 560 RVA: 0x000DB0F4 File Offset: 0x000D94F4
		private void frmRegistration_Load(object sender, EventArgs e)
		{
			this.Opacity = 0.0;
			ManagementClass managementClass = new ManagementClass("Win32_PhysicalMedia");
			string right = Conversions.ToString(MyProject.Computer.Registry.GetValue("HKEY_CURRENT_USER\\SOFTWARE\\BijoyBayanno\\Options", "Password", ""));
			myFunctions.Password = "RN28T29SK1XMJ6XYLK24";
			bool flag = Operators.CompareString(myFunctions.Password, right, false) == 0;
			if (flag)
			{
				MyProject.Forms.frmSplash.Show();
				this.rHide = true;
			}
			else
			{
				this.Opacity = 1.0;
			}
		}

		// Token: 0x06000231 RID: 561 RVA: 0x000DB190 File Offset: 0x000D9590
		private string Compress(string Str, int Lenght)
		{
			checked
			{
				string result;
				try
				{
					bool flag = Str.Length % 2 == 1;
					if (flag)
					{
						Str = Strings.Left(Str, Str.Length - 2) + Conversions.ToString(Strings.ChrW((int)(Str[Str.Length - 2] + Str[Str.Length - 2])));
					}
					string text;
					int num3;
					do
					{
						text = "";
						int num = 0;
						int num2 = Str.Length - 1;
						num3 = num;
						for (;;)
						{
							int num4 = num3;
							int num5 = num2;
							if (num4 > num5)
							{
								break;
							}
							int charCode = (int)(Str[num3] + Str[num3 + 1]);
							text += Conversions.ToString(Strings.ChrW(charCode));
							num3 += 2;
						}
						Str = text;
					}
					while (Str.Length >= Lenght);
					text = "";
					int num6 = 0;
					int num7 = Str.Length - 1;
					num3 = num6;
					for (;;)
					{
						int num8 = num3;
						int num5 = num7;
						if (num8 > num5)
						{
							break;
						}
						int value = (int)Str[num3];
						text += Conversions.ToString(value);
						num3++;
					}
					result = text;
				}
				catch (Exception ex)
				{
					Interaction.MsgBox("Please Contact Ananda Computers\r\n+88(0171)-530452", MsgBoxStyle.OkOnly, null);
					ProjectData.EndApp();
					result = Conversions.ToString(0);
				}
				return result;
			}
		}

		// Token: 0x06000232 RID: 562 RVA: 0x000DB2C8 File Offset: 0x000D96C8
		private void PasswordLabel_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x04000115 RID: 277
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x04000116 RID: 278
		[AccessedThroughProperty("LogoPictureBox")]
		private PictureBox _LogoPictureBox;

		// Token: 0x04000117 RID: 279
		[AccessedThroughProperty("UsernameLabel")]
		private Label _UsernameLabel;

		// Token: 0x04000118 RID: 280
		[AccessedThroughProperty("PasswordLabel")]
		private Label _PasswordLabel;

		// Token: 0x04000119 RID: 281
		[AccessedThroughProperty("IDTextBox")]
		private TextBox _IDTextBox;

		// Token: 0x0400011A RID: 282
		[AccessedThroughProperty("PasswordTextBox")]
		private TextBox _PasswordTextBox;

		// Token: 0x0400011B RID: 283
		[AccessedThroughProperty("OK")]
		private Button _OK;

		// Token: 0x0400011C RID: 284
		[AccessedThroughProperty("Cancel")]
		private Button _Cancel;

		// Token: 0x0400011E RID: 286
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x0400011F RID: 287
		[AccessedThroughProperty("PictureBox1")]
		private PictureBox _PictureBox1;

		// Token: 0x04000120 RID: 288
		[AccessedThroughProperty("PasswordTextBox4")]
		private TextBox _PasswordTextBox4;

		// Token: 0x04000121 RID: 289
		[AccessedThroughProperty("PasswordTextBox3")]
		private TextBox _PasswordTextBox3;

		// Token: 0x04000122 RID: 290
		[AccessedThroughProperty("PasswordTextBox2")]
		private TextBox _PasswordTextBox2;

		// Token: 0x04000123 RID: 291
		[AccessedThroughProperty("PasswordTextBox1")]
		private TextBox _PasswordTextBox1;

		// Token: 0x04000124 RID: 292
		private string MechineID;

		// Token: 0x04000125 RID: 293
		private string passColl;

		// Token: 0x04000126 RID: 294
		private bool rHide;
	}
}
