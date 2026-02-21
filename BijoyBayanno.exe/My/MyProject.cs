using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;

namespace BijoyBayanno.My
{
	// Token: 0x02000004 RID: 4
	[StandardModule]
	[GeneratedCode("MyTemplate", "8.0.0.0")]
	[HideModuleName]
	internal sealed class MyProject
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000007 RID: 7 RVA: 0x000C9E44 File Offset: 0x000C8244
		[HelpKeyword("My.Computer")]
		internal static MyComputer Computer
		{
			[DebuggerHidden]
			get
			{
				return MyProject.m_ComputerObjectProvider.GetInstance;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000008 RID: 8 RVA: 0x000C9E60 File Offset: 0x000C8260
		[HelpKeyword("My.Application")]
		internal static MyApplication Application
		{
			[DebuggerHidden]
			get
			{
				return MyProject.m_AppObjectProvider.GetInstance;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000009 RID: 9 RVA: 0x000C9E7C File Offset: 0x000C827C
		[HelpKeyword("My.User")]
		internal static User User
		{
			[DebuggerHidden]
			get
			{
				return MyProject.m_UserObjectProvider.GetInstance;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600000A RID: 10 RVA: 0x000C9E98 File Offset: 0x000C8298
		[HelpKeyword("My.Forms")]
		internal static MyProject.MyForms Forms
		{
			[DebuggerHidden]
			get
			{
				return MyProject.m_MyFormsObjectProvider.GetInstance;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600000B RID: 11 RVA: 0x000C9EB4 File Offset: 0x000C82B4
		[HelpKeyword("My.WebServices")]
		internal static MyProject.MyWebServices WebServices
		{
			[DebuggerHidden]
			get
			{
				return MyProject.m_MyWebServicesObjectProvider.GetInstance;
			}
		}

		// Token: 0x04000002 RID: 2
		private static readonly MyProject.ThreadSafeObjectProvider<MyComputer> m_ComputerObjectProvider = new MyProject.ThreadSafeObjectProvider<MyComputer>();

		// Token: 0x04000003 RID: 3
		private static readonly MyProject.ThreadSafeObjectProvider<MyApplication> m_AppObjectProvider = new MyProject.ThreadSafeObjectProvider<MyApplication>();

		// Token: 0x04000004 RID: 4
		private static readonly MyProject.ThreadSafeObjectProvider<User> m_UserObjectProvider = new MyProject.ThreadSafeObjectProvider<User>();

		// Token: 0x04000005 RID: 5
		private static MyProject.ThreadSafeObjectProvider<MyProject.MyForms> m_MyFormsObjectProvider = new MyProject.ThreadSafeObjectProvider<MyProject.MyForms>();

		// Token: 0x04000006 RID: 6
		private static readonly MyProject.ThreadSafeObjectProvider<MyProject.MyWebServices> m_MyWebServicesObjectProvider = new MyProject.ThreadSafeObjectProvider<MyProject.MyWebServices>();

		// Token: 0x02000005 RID: 5
		[MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		internal sealed class MyForms
		{
			// Token: 0x17000006 RID: 6
			// (get) Token: 0x0600000C RID: 12 RVA: 0x000C9ED0 File Offset: 0x000C82D0
			// (set) Token: 0x06000013 RID: 19 RVA: 0x000C9FE8 File Offset: 0x000C83E8
			public frmDictionary frmDictionary
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_frmDictionary = MyProject.MyForms.Create__Instance__<frmDictionary>(this.m_frmDictionary);
					return this.m_frmDictionary;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_frmDictionary;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<frmDictionary>(ref this.m_frmDictionary);
					}
				}
			}

			// Token: 0x17000007 RID: 7
			// (get) Token: 0x0600000D RID: 13 RVA: 0x000C9EF8 File Offset: 0x000C82F8
			// (set) Token: 0x06000014 RID: 20 RVA: 0x000CA02C File Offset: 0x000C842C
			public frmDlg frmDlg
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_frmDlg = MyProject.MyForms.Create__Instance__<frmDlg>(this.m_frmDlg);
					return this.m_frmDlg;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_frmDlg;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<frmDlg>(ref this.m_frmDlg);
					}
				}
			}

			// Token: 0x17000008 RID: 8
			// (get) Token: 0x0600000E RID: 14 RVA: 0x000C9F20 File Offset: 0x000C8320
			// (set) Token: 0x06000015 RID: 21 RVA: 0x000CA070 File Offset: 0x000C8470
			public frmLayoutCreator frmLayoutCreator
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_frmLayoutCreator = MyProject.MyForms.Create__Instance__<frmLayoutCreator>(this.m_frmLayoutCreator);
					return this.m_frmLayoutCreator;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_frmLayoutCreator;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<frmLayoutCreator>(ref this.m_frmLayoutCreator);
					}
				}
			}

			// Token: 0x17000009 RID: 9
			// (get) Token: 0x0600000F RID: 15 RVA: 0x000C9F48 File Offset: 0x000C8348
			// (set) Token: 0x06000016 RID: 22 RVA: 0x000CA0B4 File Offset: 0x000C84B4
			public frmMain frmMain
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_frmMain = MyProject.MyForms.Create__Instance__<frmMain>(this.m_frmMain);
					return this.m_frmMain;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_frmMain;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<frmMain>(ref this.m_frmMain);
					}
				}
			}

			// Token: 0x1700000A RID: 10
			// (get) Token: 0x06000010 RID: 16 RVA: 0x000C9F70 File Offset: 0x000C8370
			// (set) Token: 0x06000017 RID: 23 RVA: 0x000CA0F8 File Offset: 0x000C84F8
			public frmOptions frmOptions
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_frmOptions = MyProject.MyForms.Create__Instance__<frmOptions>(this.m_frmOptions);
					return this.m_frmOptions;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_frmOptions;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<frmOptions>(ref this.m_frmOptions);
					}
				}
			}

			// Token: 0x1700000B RID: 11
			// (get) Token: 0x06000011 RID: 17 RVA: 0x000C9F98 File Offset: 0x000C8398
			// (set) Token: 0x06000018 RID: 24 RVA: 0x000CA13C File Offset: 0x000C853C
			public frmRegistration frmRegistration
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_frmRegistration = MyProject.MyForms.Create__Instance__<frmRegistration>(this.m_frmRegistration);
					return this.m_frmRegistration;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_frmRegistration;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<frmRegistration>(ref this.m_frmRegistration);
					}
				}
			}

			// Token: 0x1700000C RID: 12
			// (get) Token: 0x06000012 RID: 18 RVA: 0x000C9FC0 File Offset: 0x000C83C0
			// (set) Token: 0x06000019 RID: 25 RVA: 0x000CA180 File Offset: 0x000C8580
			public frmSplash frmSplash
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_frmSplash = MyProject.MyForms.Create__Instance__<frmSplash>(this.m_frmSplash);
					return this.m_frmSplash;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_frmSplash;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<frmSplash>(ref this.m_frmSplash);
					}
				}
			}

			// Token: 0x0600001A RID: 26 RVA: 0x000CA1C4 File Offset: 0x000C85C4
			[DebuggerHidden]
			private static T Create__Instance__<T>(T Instance) where T : Form, new()
			{
				bool flag = Instance == null || Instance.IsDisposed;
				if (flag)
				{
					bool flag2 = MyProject.MyForms.m_FormBeingCreated != null;
					if (flag2)
					{
						bool flag3 = MyProject.MyForms.m_FormBeingCreated.ContainsKey(typeof(T));
						if (flag3)
						{
							throw new InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate", new string[0]));
						}
					}
					else
					{
						MyProject.MyForms.m_FormBeingCreated = new Hashtable();
					}
					MyProject.MyForms.m_FormBeingCreated.Add(typeof(T), null);
					try
					{
						return Activator.CreateInstance<T>();
					}
					catch (TargetInvocationException ex) when (ex.InnerException != null)
					{
						string resourceString = Utils.GetResourceString("WinForms_SeeInnerException", new string[]
						{
							ex.InnerException.Message
						});
						throw new InvalidOperationException(resourceString, ex.InnerException);
					}
					finally
					{
						MyProject.MyForms.m_FormBeingCreated.Remove(typeof(T));
					}
				}
				return Instance;
			}

			// Token: 0x0600001B RID: 27 RVA: 0x000CA300 File Offset: 0x000C8700
			[DebuggerHidden]
			private void Dispose__Instance__<T>(ref T instance) where T : Form
			{
				instance.Dispose();
				instance = default(T);
			}

			// Token: 0x0600001C RID: 28 RVA: 0x000CA32C File Offset: 0x000C872C
			[EditorBrowsable(EditorBrowsableState.Never)]
			[DebuggerHidden]
			public MyForms()
			{
			}

			// Token: 0x0600001D RID: 29 RVA: 0x000CA338 File Offset: 0x000C8738
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override bool Equals(object o)
			{
				return base.Equals(RuntimeHelpers.GetObjectValue(o));
			}

			// Token: 0x0600001E RID: 30 RVA: 0x000CA358 File Offset: 0x000C8758
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override int GetHashCode()
			{
				return base.GetHashCode();
			}

			// Token: 0x0600001F RID: 31 RVA: 0x000CA370 File Offset: 0x000C8770
			[EditorBrowsable(EditorBrowsableState.Never)]
			internal new Type GetType()
			{
				return typeof(MyProject.MyForms);
			}

			// Token: 0x06000020 RID: 32 RVA: 0x000CA38C File Offset: 0x000C878C
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override string ToString()
			{
				return base.ToString();
			}

			// Token: 0x04000007 RID: 7
			public frmDictionary m_frmDictionary;

			// Token: 0x04000008 RID: 8
			public frmDlg m_frmDlg;

			// Token: 0x04000009 RID: 9
			public frmLayoutCreator m_frmLayoutCreator;

			// Token: 0x0400000A RID: 10
			public frmMain m_frmMain;

			// Token: 0x0400000B RID: 11
			public frmOptions m_frmOptions;

			// Token: 0x0400000C RID: 12
			public frmRegistration m_frmRegistration;

			// Token: 0x0400000D RID: 13
			public frmSplash m_frmSplash;

			// Token: 0x0400000E RID: 14
			[ThreadStatic]
			private static Hashtable m_FormBeingCreated;
		}

		// Token: 0x02000006 RID: 6
		[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		internal sealed class MyWebServices
		{
			// Token: 0x06000021 RID: 33 RVA: 0x000CA3A4 File Offset: 0x000C87A4
			[EditorBrowsable(EditorBrowsableState.Never)]
			[DebuggerHidden]
			public override bool Equals(object o)
			{
				return base.Equals(RuntimeHelpers.GetObjectValue(o));
			}

			// Token: 0x06000022 RID: 34 RVA: 0x000CA3C4 File Offset: 0x000C87C4
			[DebuggerHidden]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override int GetHashCode()
			{
				return base.GetHashCode();
			}

			// Token: 0x06000023 RID: 35 RVA: 0x000CA3DC File Offset: 0x000C87DC
			[EditorBrowsable(EditorBrowsableState.Never)]
			[DebuggerHidden]
			internal new Type GetType()
			{
				return typeof(MyProject.MyWebServices);
			}

			// Token: 0x06000024 RID: 36 RVA: 0x000CA3F8 File Offset: 0x000C87F8
			[DebuggerHidden]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override string ToString()
			{
				return base.ToString();
			}

			// Token: 0x06000025 RID: 37 RVA: 0x000CA410 File Offset: 0x000C8810
			[DebuggerHidden]
			private static T Create__Instance__<T>(T instance) where T : new()
			{
				bool flag = instance == null;
				T result;
				if (flag)
				{
					result = Activator.CreateInstance<T>();
				}
				else
				{
					result = instance;
				}
				return result;
			}

			// Token: 0x06000026 RID: 38 RVA: 0x000CA43C File Offset: 0x000C883C
			[DebuggerHidden]
			private void Dispose__Instance__<T>(ref T instance)
			{
				instance = default(T);
			}

			// Token: 0x06000027 RID: 39 RVA: 0x000CA45C File Offset: 0x000C885C
			[DebuggerHidden]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public MyWebServices()
			{
			}
		}

		// Token: 0x02000007 RID: 7
		[ComVisible(false)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		internal sealed class ThreadSafeObjectProvider<T> where T : new()
		{
			// Token: 0x1700000D RID: 13
			// (get) Token: 0x06000028 RID: 40 RVA: 0x000CA468 File Offset: 0x000C8868
			internal T GetInstance
			{
				[DebuggerHidden]
				get
				{
					bool flag = MyProject.ThreadSafeObjectProvider<T>.m_ThreadStaticValue == null;
					if (flag)
					{
						MyProject.ThreadSafeObjectProvider<T>.m_ThreadStaticValue = Activator.CreateInstance<T>();
					}
					return MyProject.ThreadSafeObjectProvider<T>.m_ThreadStaticValue;
				}
			}

			// Token: 0x06000029 RID: 41 RVA: 0x000CA49C File Offset: 0x000C889C
			[EditorBrowsable(EditorBrowsableState.Never)]
			[DebuggerHidden]
			public ThreadSafeObjectProvider()
			{
			}

			// Token: 0x0400000F RID: 15
			[ThreadStatic]
			[CompilerGenerated]
			private static T m_ThreadStaticValue;
		}
	}
}
