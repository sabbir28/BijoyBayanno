using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace BijoyBayanno
{
	// Token: 0x02000024 RID: 36
	[StandardModule]
	internal sealed class myFunctions
	{
		// Token: 0x06000284 RID: 644
		[DllImport("user32", CharSet = CharSet.Ansi, EntryPoint = "SendMessageA", ExactSpelling = true, SetLastError = true)]
		public static extern int SendMessage(int hWnd, int wMsg, int wParam, int lParam);

		// Token: 0x06000285 RID: 645
		[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		public static extern int ReleaseCapture();

		// Token: 0x06000286 RID: 646
		[DllImport("user32", CharSet = CharSet.Ansi, EntryPoint = "FindWindowExA", ExactSpelling = true, SetLastError = true)]
		private static extern int FindWindowEx(int hWnd1, int hWnd2, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpsz1, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpsz2);

		// Token: 0x06000287 RID: 647
		[DllImport("user32", CharSet = CharSet.Ansi, EntryPoint = "GetWindowLongA", ExactSpelling = true, SetLastError = true)]
		public static extern int GetWindowLong(int hwnd, int nIndex);

		// Token: 0x06000288 RID: 648
		[DllImport("user32", CharSet = CharSet.Ansi, EntryPoint = "SetWindowLongA", ExactSpelling = true, SetLastError = true)]
		public static extern int SetWindowLong(int hwnd, int nIndex, int dwNewLong);

		// Token: 0x06000289 RID: 649 RVA: 0x000C9958 File Offset: 0x000C7D58
		public static bool Drag(Form Client)
		{
			myFunctions.ReleaseCapture();
			long num = (long)myFunctions.SendMessage((int)Client.Handle, 161, 2, 0);
			Client.Top = 0;
			bool result;
			return result;
		}

		// Token: 0x0600028A RID: 650 RVA: 0x000C9990 File Offset: 0x000C7D90
		public static string VerifyPath(string Path)
		{
			bool flag = !Path.EndsWith("\\");
			if (flag)
			{
				Path += "\\";
			}
			return Path;
		}

		// Token: 0x0600028B RID: 651 RVA: 0x000C99C4 File Offset: 0x000C7DC4
		public static string Encrypt(string Number)
		{
			object obj = Strings.LCase(Strings.StrReverse(Number));
			object obj2 = "";
			object obj3 = 0;
			object obj4 = 0;
			do
			{
				obj3 = Operators.AddObject(obj3, 1);
				obj4 = Operators.AddObject(obj4, 2);
				object left = Strings.Asc(Strings.Mid(Conversions.ToString(obj), Conversions.ToInteger(obj3), 1));
				int num = Conversions.ToInteger(Operators.AddObject(left, obj4));
				do
				{
					num = Conversions.ToInteger(Operators.AddObject(Conversion.Int(Strings.Left(Conversions.ToString(num), 1)), Conversion.Int(Strings.Right(Conversions.ToString(num), 1))));
				}
				while (num.ToString().Length != 1);
				obj2 = Operators.ConcatenateObject(obj2, num);
			}
			while (Operators.ConditionalCompareObjectNotEqual(obj3, Strings.Len(RuntimeHelpers.GetObjectValue(obj)), false));
			obj2 = checked(Strings.StrReverse(Strings.Right(Conversions.ToString(obj2), (int)Math.Round((double)Strings.Len(RuntimeHelpers.GetObjectValue(obj2)) / 2.0))) + Strings.StrReverse(Strings.Left(Conversions.ToString(obj2), (int)Math.Round((double)Strings.Len(RuntimeHelpers.GetObjectValue(obj2)) / 2.0))));
			return Conversions.ToString(obj2);
		}

		// Token: 0x0600028C RID: 652 RVA: 0x000C9B24 File Offset: 0x000C7F24
		public static void SetControlStyle(Control TargetControl, myFunctions.Style NewStyleType)
		{
			bool flag = TargetControl is TextBox;
			int hwnd;
			if (flag)
			{
				hwnd = (int)TargetControl.Handle;
			}
			else
			{
				flag = (TargetControl is ComboBox);
				if (flag)
				{
					int hWnd = (int)TargetControl.Handle;
					int hWnd2 = 0;
					string text = null;
					string text2 = null;
					hwnd = myFunctions.FindWindowEx(hWnd, hWnd2, ref text, ref text2);
				}
			}
			int num = myFunctions.GetWindowLong(hwnd, -16);
			num |= (int)NewStyleType;
			int num2 = myFunctions.SetWindowLong(hwnd, -16, num);
			TargetControl.Refresh();
		}

		// Token: 0x0600028D RID: 653 RVA: 0x000C9B9C File Offset: 0x000C7F9C
		public static int DefineKey(string Key)
		{
			bool flag = Operators.CompareString(Key, "F1", false) == 0;
			int result;
			if (flag)
			{
				result = 112;
			}
			else
			{
				flag = (Operators.CompareString(Key, "F2", false) == 0);
				if (flag)
				{
					result = 113;
				}
				else
				{
					flag = (Operators.CompareString(Key, "F3", false) == 0);
					if (flag)
					{
						result = 114;
					}
					else
					{
						flag = (Operators.CompareString(Key, "F4", false) == 0);
						if (flag)
						{
							result = 115;
						}
						else
						{
							flag = (Operators.CompareString(Key, "F5", false) == 0);
							if (flag)
							{
								result = 116;
							}
							else
							{
								flag = (Operators.CompareString(Key, "F6", false) == 0);
								if (flag)
								{
									result = 117;
								}
								else
								{
									flag = (Operators.CompareString(Key, "F7", false) == 0);
									if (flag)
									{
										result = 118;
									}
									else
									{
										flag = (Operators.CompareString(Key, "F8", false) == 0);
										if (flag)
										{
											result = 119;
										}
										else
										{
											flag = (Operators.CompareString(Key, "F9", false) == 0);
											if (flag)
											{
												result = 120;
											}
											else
											{
												flag = (Operators.CompareString(Key, "F10", false) == 0);
												if (flag)
												{
													result = 121;
												}
												else
												{
													flag = (Operators.CompareString(Key, "F11", false) == 0);
													if (flag)
													{
														result = 122;
													}
													else
													{
														flag = (Operators.CompareString(Key, "F12", false) == 0);
														if (flag)
														{
															result = 123;
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
			return result;
		}

		// Token: 0x0400015D RID: 349
		public static bool TrayMode;

		// Token: 0x0400015E RID: 350
		public static string Password;

		// Token: 0x0400015F RID: 351
		private const int WM_NCLBUTTONDOWN = 161;

		// Token: 0x04000160 RID: 352
		private const int HTCAPTION = 2;

		// Token: 0x04000161 RID: 353
		private const int GWL_STYLE = -16;

		// Token: 0x02000025 RID: 37
		public enum Style
		{
			// Token: 0x04000163 RID: 355
			ES_UPPERCASE = 8,
			// Token: 0x04000164 RID: 356
			ES_NUMBER = 8192
		}
	}
}
