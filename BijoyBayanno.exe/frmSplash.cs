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
	// Token: 0x02000019 RID: 25
	[DesignerGenerated]
	public partial class frmSplash : Form
	{
		// Token: 0x06000234 RID: 564 RVA: 0x000DB2DC File Offset: 0x000D96DC
		public frmSplash()
		{
			base.Load += this.frmSplash_Load;
			List<WeakReference> _ENCList = frmSplash.__ENCList;
			lock (_ENCList)
			{
				frmSplash.__ENCList.Add(new WeakReference(this));
			}
			this.i = 0;
			this.InitializeComponent();
		}

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x06000237 RID: 567 RVA: 0x000DB4B8 File Offset: 0x000D98B8
		// (set) Token: 0x06000238 RID: 568 RVA: 0x000DB4D0 File Offset: 0x000D98D0
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

		// Token: 0x06000239 RID: 569 RVA: 0x000DB530 File Offset: 0x000D9930
		private void FadeTimer_Tick(object sender, EventArgs e)
		{
			bool flag = this.Opacity < 1.0;
			if (flag)
			{
				try
				{
					this.Opacity += 0.01;
				}
				catch (Exception ex)
				{
					this.Opacity = 1.0;
				}
			}
			else
			{
				flag = (this.i < 10000);
				checked
				{
					if (flag)
					{
						this.i += 100;
					}
					else
					{
						this.FadeTimer.Enabled = false;
						try
						{
							modKeyboard.defLayout = Conversions.ToInteger(MyProject.Computer.Registry.GetValue("HKEY_CURRENT_USER\\SOFTWARE\\BijoyEkushe\\Options", "DefaultLayout", null));
							MyProject.Forms.frmMain.Left = Conversions.ToInteger(MyProject.Computer.Registry.GetValue("HKEY_CURRENT_USER\\SOFTWARE\\BijoyEkushe\\Options", "Position", 250));
							MyProject.Forms.frmMain.CheckHandle.Enabled = Conversions.ToBoolean(MyProject.Computer.Registry.GetValue("HKEY_CURRENT_USER\\SOFTWARE\\BijoyEkushe\\Options", "LAM", false));
							myFunctions.TrayMode = Conversions.ToBoolean(MyProject.Computer.Registry.GetValue("HKEY_CURRENT_USER\\SOFTWARE\\BijoyEkushe\\Options", "TrayMode", false));
							modKeyboard.AM = Conversions.ToInteger(MyProject.Computer.Registry.GetValue("HKEY_CURRENT_USER\\SOFTWARE\\BijoyEkushe\\Options", "ApplicationMode", 1));
							flag = (modKeyboard.AM == 3);
							if (flag)
							{
								MyProject.Forms.frmMain.NotifyIcon.Visible = true;
								MyProject.Forms.frmMain.Opacity = 0.0;
								MyProject.Forms.frmMain.Visible = false;
							}
							else
							{
								flag = (modKeyboard.AM == 2);
								if (flag)
								{
									MyProject.Forms.frmMain.Opacity = 1.0;
									MyProject.Forms.frmMain.Visible = true;
								}
								else
								{
									flag = myFunctions.TrayMode;
									if (flag)
									{
										MyProject.Forms.frmMain.NotifyIcon.Visible = true;
										MyProject.Forms.frmMain.Opacity = 0.0;
										MyProject.Forms.frmMain.Visible = false;
									}
									else
									{
										MyProject.Forms.frmMain.Opacity = 1.0;
										MyProject.Forms.frmMain.Visible = true;
									}
									modKeyboard.AM = 1;
								}
							}
						}
						catch (Exception ex2)
						{
						}
						MyProject.Forms.frmMain.Show();
					}
				}
			}
		}

		// Token: 0x0600023A RID: 570 RVA: 0x000DB810 File Offset: 0x000D9C10
		private void frmSplash_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x04000127 RID: 295
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x04000129 RID: 297
		[AccessedThroughProperty("FadeTimer")]
		private Timer _FadeTimer;

		// Token: 0x0400012A RID: 298
		private int i;
	}
}
