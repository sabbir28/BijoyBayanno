using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;
using BijoyBayanno.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace BijoyBayanno
{
	// Token: 0x0200001C RID: 28
	[StandardModule]
	internal sealed class modKeyboard
	{
		// Token: 0x06000242 RID: 578
		[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		public static extern int UnhookWindowsHookEx(int hHook);

		// Token: 0x06000243 RID: 579
		[DllImport("user32", CharSet = CharSet.Ansi, EntryPoint = "SetWindowsHookExA", ExactSpelling = true, SetLastError = true)]
		public static extern int SetWindowsHookEx(int idHook, modKeyboard.KeyboardHookDelegate lpfn, int hmod, int dwThreadId);

		// Token: 0x06000244 RID: 580
		[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		public static extern int GetAsyncKeyState(int vKey);

		// Token: 0x06000245 RID: 581
		[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		public static extern int CallNextHookEx(int hHook, int nCode, int wParam, modKeyboard.KBDLLHOOKSTRUCT lParam);

		// Token: 0x06000246 RID: 582
		[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		public static extern int GetForegroundWindow();

		// Token: 0x06000247 RID: 583
		[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		public static extern void keybd_event(byte bVk, byte bScan, int dwFlags, int dwExtraInfo);

		// Token: 0x06000248 RID: 584
		[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		public static extern IntPtr SendMessage(IntPtr hWnd, int Msg, UIntPtr wParam, IntPtr lParam);

		// Token: 0x06000249 RID: 585 RVA: 0x000C8738 File Offset: 0x000C6B38
		private static void DoKeyBoard(NativeMethods.KEYEVENTF flags, int key)
		{
			NativeMethods.INPUT input = default(NativeMethods.INPUT);
			NativeMethods.KEYBDINPUT ki = default(NativeMethods.KEYBDINPUT);
			input.dwType = NativeMethods.InputType.Keyboard;
			input.ki = ki;
			input.ki.wVk = 0;
			input.ki.wScan = checked((short)key);
			input.ki.time = 0;
			input.ki.dwFlags = flags;
			input.ki.dwExtraInfo = IntPtr.Zero;
			int cbSize = Marshal.SizeOf(typeof(NativeMethods.INPUT));
			int num = NativeMethods.SendInput(1, ref input, cbSize);
			bool flag = num == 0;
			if (flag)
			{
				Debug.WriteLine(Marshal.GetLastWin32Error());
			}
		}

		// Token: 0x0600024A RID: 586 RVA: 0x000C87E4 File Offset: 0x000C6BE4
		private static void DoKeyBoardA(NativeMethods.KEYEVENTF flags, short key)
		{
			NativeMethods.INPUT input = default(NativeMethods.INPUT);
			NativeMethods.KEYBDINPUT ki = default(NativeMethods.KEYBDINPUT);
			input.dwType = NativeMethods.InputType.Keyboard;
			input.ki = ki;
			input.ki.wVk = Convert.ToInt16(key);
			input.ki.wScan = 0;
			input.ki.time = 0;
			input.ki.dwFlags = flags;
			input.ki.dwExtraInfo = IntPtr.Zero;
			int cbSize = Marshal.SizeOf(typeof(NativeMethods.INPUT));
			int num = NativeMethods.SendInput(1, ref input, cbSize);
			bool flag = num == 0;
			if (flag)
			{
				Debug.WriteLine(Marshal.GetLastWin32Error());
			}
		}

		// Token: 0x0600024B RID: 587 RVA: 0x000C8894 File Offset: 0x000C6C94
		private static bool ReQue(string Text)
		{
			modKeyboard.Que += Text;
			modKeyboard.Que = Strings.Right(modKeyboard.Que, 20);
			bool result;
			return result;
		}

		// Token: 0x0600024C RID: 588 RVA: 0x000C88C4 File Offset: 0x000C6CC4
		public static bool IsHooked(ref modKeyboard.KBDLLHOOKSTRUCT Hookstruct)
		{
			checked
			{
				bool result;
				try
				{
					int num = 0;
					int num2 = modKeyboard.LayoutNumber - 2;
					int num3 = num;
					for (;;)
					{
						int num4 = num3;
						int num5 = num2;
						if (num4 > num5)
						{
							goto Block_4;
						}
						bool flag = MyProject.Computer.Keyboard.CtrlKeyDown == modKeyboard.Layout[num3].Shortcut.Ctrl & MyProject.Computer.Keyboard.AltKeyDown == modKeyboard.Layout[num3].Shortcut.Alt & MyProject.Computer.Keyboard.ShiftKeyDown == modKeyboard.Layout[num3].Shortcut.Shift & Hookstruct.vkCode == modKeyboard.Layout[num3].Shortcut.KeyCode;
						if (flag)
						{
							break;
						}
						num3++;
					}
					bool flag2 = MyProject.Forms.frmMain.comLayouts.SelectedIndex == modKeyboard.Layout[num3].ID + 1;
					if (flag2)
					{
						modKeyboard.defLayout = MyProject.Forms.frmMain.comLayouts.SelectedIndex;
						mHandleInfo.RemoveInfo(unchecked((long)modKeyboard.GetForegroundWindow()));
						MyProject.Forms.frmMain.comLayouts.SelectedIndex = 0;
					}
					else
					{
						MyProject.Forms.frmMain.comLayouts.SelectedIndex = modKeyboard.Layout[num3].ID + 1;
						mHandleInfo.AddInfo(unchecked((long)modKeyboard.GetForegroundWindow()), modKeyboard.Layout[num3]);
						modKeyboard.Que = new string('♠', 20);
					}
					return true;
					Block_4:
					flag2 = (!MyProject.Computer.Keyboard.CtrlKeyDown & !MyProject.Computer.Keyboard.AltKeyDown & modKeyboard.curLayout != -1);
					if (flag2)
					{
						bool flag = Hookstruct.vkCode == 8;
						if (flag)
						{
							modKeyboard.ReQue("♠");
						}
						flag2 = (Hookstruct.vkCode == 13);
						if (flag2)
						{
							modKeyboard.ReQue("\r\n");
						}
						flag2 = (!modKeyboard.Layout[modKeyboard.curLayout].Key.ContainsKey(32) & Hookstruct.vkCode == 32);
						if (flag2)
						{
							modKeyboard.ReQue(" ");
						}
						flag2 = MyProject.Computer.Keyboard.ShiftKeyDown;
						bool flag3;
						if (flag2)
						{
							flag = modKeyboard.Layout[modKeyboard.curLayout].Key.ContainsKey(Hookstruct.vkCode);
							if (flag)
							{
								string text = Conversions.ToString(modKeyboard.Layout[modKeyboard.curLayout].Key[Hookstruct.vkCode][3]);
								flag2 = (Operators.CompareString(Strings.Left(text, 5), "DeInc", false) == 0);
								if (flag2)
								{
									flag = (!modKeyboard.delayKey & modKeyboard.delayTimer == 4);
									if (flag)
									{
										modKeyboard.delayKey = true;
										modKeyboard.delayTimer = Conversions.ToInteger(Operators.AddObject(4, Conversion.Int(Strings.Right(text, 1))));
										modKeyboard.Pass = true;
										modKeyboard.DoKeyBoardA((NativeMethods.KEYEVENTF)0, 8);
										modKeyboard.DoKeyBoardA(NativeMethods.KEYEVENTF.KEYUP, 8);
										modKeyboard.Pass = false;
									}
								}
								else
								{
									flag2 = (Operators.CompareString(text, "MoveL", false) == 0);
									if (flag2)
									{
										modKeyboard.Pass = true;
										modKeyboard.DoKeyBoardA((NativeMethods.KEYEVENTF)0, 37);
										modKeyboard.DoKeyBoardA(NativeMethods.KEYEVENTF.KEYUP, 37);
										modKeyboard.Pass = false;
										modKeyboard.flagLeft = true;
									}
								}
								flag2 = (Operators.CompareString(text, "Delay", false) == 0);
								if (flag2)
								{
									flag = (modKeyboard.delayTimer == 5);
									if (flag)
									{
										modKeyboard.lastDelayOut = modKeyboard.delayOut;
									}
									modKeyboard.delayKey = true;
									modKeyboard.delayTimer = 5;
									modKeyboard.delayOut = Conversions.ToString(modKeyboard.Layout[modKeyboard.curLayout].Key[Hookstruct.vkCode][1]);
									modKeyboard.ReQue(modKeyboard.delayOut);
									flag3 = true;
								}
								else
								{
									string text2 = Conversions.ToString(modKeyboard.Layout[modKeyboard.curLayout].Key[Hookstruct.vkCode][1]);
									flag2 = modKeyboard.flagLeft;
									if (flag2)
									{
										try
										{
											modKeyboard.Que = Strings.Left(modKeyboard.Que, modKeyboard.Que.Length - 2) + text2 + Strings.Right(modKeyboard.Que, 2);
											modKeyboard.Que = Strings.Right(modKeyboard.Que, 20);
										}
										catch (Exception ex)
										{
										}
									}
									else
									{
										modKeyboard.ReQue(text2);
									}
									modKeyboard.SendKey(text2);
									flag2 = (modKeyboard.delayTimer > 0);
									if (flag2)
									{
										modKeyboard.delayTimer--;
									}
									flag3 = true;
								}
								flag2 = (Operators.CompareString(text, "MoveL", false) == 0);
								if (flag2)
								{
									modKeyboard.Pass = true;
									modKeyboard.DoKeyBoardA((NativeMethods.KEYEVENTF)0, 39);
									modKeyboard.DoKeyBoardA(NativeMethods.KEYEVENTF.KEYUP, 39);
									modKeyboard.Pass = false;
									modKeyboard.flagLeft = false;
								}
								flag2 = (Operators.CompareString(text, "Xtra", false) == 0);
								if (flag2)
								{
									modKeyboard.ReQue("‌");
								}
							}
						}
						else
						{
							flag2 = modKeyboard.Layout[modKeyboard.curLayout].Key.ContainsKey(Hookstruct.vkCode);
							if (flag2)
							{
								string text3 = Conversions.ToString(modKeyboard.Layout[modKeyboard.curLayout].Key[Hookstruct.vkCode][2]);
								flag2 = (Operators.CompareString(Strings.Left(text3, 5), "DeInc", false) == 0);
								if (flag2)
								{
									flag = (!modKeyboard.delayKey & modKeyboard.delayTimer == 4);
									if (flag)
									{
										modKeyboard.delayKey = true;
										modKeyboard.delayTimer = Conversions.ToInteger(Operators.AddObject(4, Conversion.Int(Strings.Right(text3, 1))));
										modKeyboard.Pass = true;
										modKeyboard.DoKeyBoardA((NativeMethods.KEYEVENTF)0, 8);
										modKeyboard.DoKeyBoardA(NativeMethods.KEYEVENTF.KEYUP, 8);
										modKeyboard.Pass = false;
									}
								}
								else
								{
									flag2 = (Operators.CompareString(text3, "MoveL", false) == 0);
									if (flag2)
									{
										modKeyboard.Pass = true;
										modKeyboard.DoKeyBoardA((NativeMethods.KEYEVENTF)0, 37);
										modKeyboard.DoKeyBoardA(NativeMethods.KEYEVENTF.KEYUP, 37);
										modKeyboard.Pass = false;
									}
								}
								flag2 = (Operators.CompareString(text3, "Delay", false) == 0);
								if (flag2)
								{
									flag = (modKeyboard.delayTimer == 5);
									if (flag)
									{
										modKeyboard.lastDelayOut = modKeyboard.delayOut;
									}
									modKeyboard.delayKey = true;
									modKeyboard.delayTimer = 5;
									modKeyboard.delayOut = Conversions.ToString(modKeyboard.Layout[modKeyboard.curLayout].Key[Hookstruct.vkCode][0]);
									flag2 = (Operators.CompareString(text3, "MoveL", false) == 0);
									if (flag2)
									{
										modKeyboard.Que = Strings.Left(modKeyboard.Que, modKeyboard.Que.Length - 1) + modKeyboard.delayOut + Strings.Right(modKeyboard.Que, 1);
										modKeyboard.Que = Strings.Right(modKeyboard.Que, 20);
									}
									else
									{
										modKeyboard.ReQue(modKeyboard.delayOut);
									}
									flag3 = true;
								}
								else
								{
									string text2 = Conversions.ToString(modKeyboard.Layout[modKeyboard.curLayout].Key[Hookstruct.vkCode][0]);
									flag2 = (Operators.CompareString(text3, "MoveL", false) == 0);
									if (flag2)
									{
										modKeyboard.Que = Strings.Left(modKeyboard.Que, modKeyboard.Que.Length - 1) + text2 + Strings.Right(modKeyboard.Que, 1);
										modKeyboard.Que = Strings.Right(modKeyboard.Que, 20);
									}
									else
									{
										modKeyboard.ReQue(text2);
									}
									modKeyboard.SendKey(text2);
									flag2 = (modKeyboard.delayTimer > 0);
									if (flag2)
									{
										modKeyboard.delayTimer--;
									}
									flag3 = true;
								}
								flag2 = (Operators.CompareString(text3, "MoveL", false) == 0);
								if (flag2)
								{
									modKeyboard.Pass = true;
									modKeyboard.DoKeyBoardA((NativeMethods.KEYEVENTF)0, 39);
									modKeyboard.DoKeyBoardA(NativeMethods.KEYEVENTF.KEYUP, 39);
									modKeyboard.Pass = false;
								}
								flag2 = (Operators.CompareString(text3, "Xtra", false) == 0);
								if (flag2)
								{
									modKeyboard.ReQue("‌");
								}
							}
						}
						flag2 = (modKeyboard.Layout[modKeyboard.curLayout].Juk.Count > 0);
						if (flag2)
						{
							int num6 = 5;
							int num5;
							int num11;
							do
							{
								string text2 = Strings.Right(modKeyboard.Que, num6);
								flag2 = modKeyboard.Layout[modKeyboard.curLayout].Juk.ContainsKey(text2);
								if (flag2)
								{
									flag = (modKeyboard.delayTimer == 5);
									if (flag)
									{
										num6--;
									}
									flag2 = (modKeyboard.delayTimer == 3);
									if (flag2)
									{
										modKeyboard.lastDelayOut = "";
										modKeyboard.delayOut = "";
									}
									flag2 = text2.Contains("‌");
									if (flag2)
									{
										num6--;
									}
									Thread.Sleep(10);
									int num7 = 1;
									int num8 = num6;
									int num9 = num7;
									for (;;)
									{
										int num10 = num9;
										num5 = num8;
										if (num10 > num5)
										{
											break;
										}
										modKeyboard.Pass = true;
										modKeyboard.DoKeyBoardA(NativeMethods.KEYEVENTF.UNICODE, 8);
										modKeyboard.DoKeyBoardA(NativeMethods.KEYEVENTF.KEYUP, 8);
										modKeyboard.Pass = false;
										num9++;
									}
									text2 = modKeyboard.Layout[modKeyboard.curLayout].Juk[text2];
									flag2 = !text2.EndsWith(modKeyboard.lastDelayOut);
									if (flag2)
									{
										flag = (modKeyboard.delayKey & modKeyboard.lastDelayOut.Length > 0 & modKeyboard.delayTimer == 5);
										if (flag)
										{
											modKeyboard.delayKey = false;
											modKeyboard.SendKey(modKeyboard.lastDelayOut);
											modKeyboard.lastDelayOut = "";
										}
										else
										{
											flag2 = (modKeyboard.delayKey & modKeyboard.delayTimer == 4);
											if (flag2)
											{
												modKeyboard.delayKey = false;
												modKeyboard.SendKey(modKeyboard.delayOut);
												modKeyboard.delayOut = "";
											}
										}
									}
									else
									{
										modKeyboard.lastDelayOut = "";
										flag2 = (modKeyboard.delayTimer == 4);
										if (flag2)
										{
											modKeyboard.SendKey(modKeyboard.delayOut);
											modKeyboard.delayOut = "";
										}
									}
									flag2 = (modKeyboard.delayTimer == 5 & modKeyboard.delayKey);
									if (flag2)
									{
										modKeyboard.delayKey = false;
									}
									modKeyboard.SendKey(text2);
									modKeyboard.ReQue(text2);
									modKeyboard.delayKey = false;
									modKeyboard.delayTimer = 0;
								}
								num6 += -1;
								num11 = num6;
								num5 = 2;
							}
							while (num11 >= num5);
						}
						flag2 = modKeyboard.delayKey;
						if (flag2)
						{
							flag = (modKeyboard.delayTimer == 4);
							if (flag)
							{
								modKeyboard.ReQue(modKeyboard.delayOut);
								modKeyboard.SendKey(modKeyboard.delayOut);
								modKeyboard.delayKey = false;
							}
						}
						flag2 = flag3;
						if (flag2)
						{
							return true;
						}
					}
					result = false;
				}
				catch (Exception ex2)
				{
				}
				return result;
			}
		}

		// Token: 0x0600024D RID: 589 RVA: 0x000C92D8 File Offset: 0x000C76D8
		private static void SendKey(string Text)
		{
			int num = 1;
			int length = Text.Length;
			int num2 = num;
			checked
			{
				for (;;)
				{
					int num3 = num2;
					int num4 = length;
					if (num3 > num4)
					{
						break;
					}
					modKeyboard.SendKeyByte((short)Strings.AscW(Strings.Mid(Text, num2, 1)));
					num2++;
				}
			}
		}

		// Token: 0x0600024E RID: 590 RVA: 0x000C9314 File Offset: 0x000C7714
		private static void SendKeyByte(short KeyCode)
		{
			modKeyboard.Pass = true;
			modKeyboard.DoKeyBoard(NativeMethods.KEYEVENTF.UNICODE, (int)KeyCode);
			modKeyboard.DoKeyBoard(NativeMethods.KEYEVENTF.KEYUP, (int)KeyCode);
			modKeyboard.Pass = false;
		}

		// Token: 0x0600024F RID: 591 RVA: 0x000C9334 File Offset: 0x000C7734
		public static int KeyboardCallback(int Code, int wParam, ref modKeyboard.KBDLLHOOKSTRUCT lParam)
		{
			bool flag = Code == 0 & wParam == 256 & !modKeyboard.Pass;
			if (flag)
			{
				Debug.WriteLine("Calling IsHooked");
				flag = modKeyboard.IsHooked(ref lParam);
				if (flag)
				{
					return 1;
				}
			}
			return modKeyboard.CallNextHookEx(modKeyboard.KeyboardHandle, Code, wParam, lParam);
		}

		// Token: 0x06000250 RID: 592 RVA: 0x000C9390 File Offset: 0x000C7790
		public static void HookKeyboard()
		{
			modKeyboard.callback = new modKeyboard.KeyboardHookDelegate(modKeyboard.KeyboardCallback);
			modKeyboard.KeyboardHandle = modKeyboard.SetWindowsHookEx(13, modKeyboard.callback, Marshal.GetHINSTANCE(Assembly.GetExecutingAssembly().GetModules()[0]).ToInt32(), 0);
			modKeyboard.CheckHooked();
		}

		// Token: 0x06000251 RID: 593 RVA: 0x000C93E4 File Offset: 0x000C77E4
		public static void CheckHooked()
		{
			bool flag = Conversions.ToBoolean(modKeyboard.Hooked());
			if (flag)
			{
				Debug.WriteLine("Keyboard hooked");
			}
			else
			{
				Debug.WriteLine("Keyboard hook failed: " + Conversions.ToString(Information.Err().LastDllError));
			}
		}

		// Token: 0x06000252 RID: 594 RVA: 0x000C9430 File Offset: 0x000C7830
		private static object Hooked()
		{
			return modKeyboard.KeyboardHandle != 0;
		}

		// Token: 0x06000253 RID: 595 RVA: 0x000C9450 File Offset: 0x000C7850
		public static void UnhookKeyboard()
		{
			bool flag = Conversions.ToBoolean(modKeyboard.Hooked());
			if (flag)
			{
				modKeyboard.UnhookWindowsHookEx(modKeyboard.KeyboardHandle);
			}
		}

		// Token: 0x0400012C RID: 300
		public static clsLayouts[] Layout;

		// Token: 0x0400012D RID: 301
		public static int LayoutNumber;

		// Token: 0x0400012E RID: 302
		public static string Que;

		// Token: 0x0400012F RID: 303
		public static int curLayout;

		// Token: 0x04000130 RID: 304
		public static int defLayout;

		// Token: 0x04000131 RID: 305
		public static int AM;

		// Token: 0x04000132 RID: 306
		private static bool delayKey;

		// Token: 0x04000133 RID: 307
		private static int delayTimer;

		// Token: 0x04000134 RID: 308
		private static string delayOut;

		// Token: 0x04000135 RID: 309
		private static string lastDelayOut = "";

		// Token: 0x04000136 RID: 310
		private static bool flagLeft;

		// Token: 0x04000137 RID: 311
		public const int KEYEVENTF_EXTENDEDKEY = 1;

		// Token: 0x04000138 RID: 312
		public const int KEYEVENTF_KEYUP = 2;

		// Token: 0x04000139 RID: 313
		public const int KEYEVENTF_UNICODE = 4;

		// Token: 0x0400013A RID: 314
		public const int KEYEVENTF_SCANCODE = 8;

		// Token: 0x0400013B RID: 315
		public const int WM_SETTEXT = 12;

		// Token: 0x0400013C RID: 316
		public static bool Pass;

		// Token: 0x0400013D RID: 317
		private const int HC_ACTION = 0;

		// Token: 0x0400013E RID: 318
		private const int LLKHF_EXTENDED = 1;

		// Token: 0x0400013F RID: 319
		private const int LLKHF_INJECTED = 16;

		// Token: 0x04000140 RID: 320
		private const int LLKHF_ALTDOWN = 32;

		// Token: 0x04000141 RID: 321
		private const int LLKHF_UP = 128;

		// Token: 0x04000142 RID: 322
		private const int WM_KEYUP = 257;

		// Token: 0x04000143 RID: 323
		private const int WM_KEYDOWN = 256;

		// Token: 0x04000144 RID: 324
		public const int VK_TAB = 9;

		// Token: 0x04000145 RID: 325
		public const int VK_CONTROL = 17;

		// Token: 0x04000146 RID: 326
		public const int VK_ESCAPE = 27;

		// Token: 0x04000147 RID: 327
		public const int VK_DELETE = 46;

		// Token: 0x04000148 RID: 328
		private const int WH_KEYBOARD_LL = 13;

		// Token: 0x04000149 RID: 329
		public static int KeyboardHandle;

		// Token: 0x0400014A RID: 330
		[MarshalAs(UnmanagedType.FunctionPtr)]
		private static modKeyboard.KeyboardHookDelegate callback;

		// Token: 0x0200001D RID: 29
		public struct KBDLLHOOKSTRUCT
		{
			// Token: 0x0400014B RID: 331
			public int vkCode;

			// Token: 0x0400014C RID: 332
			public int scanCode;

			// Token: 0x0400014D RID: 333
			public int flags;

			// Token: 0x0400014E RID: 334
			public int time;

			// Token: 0x0400014F RID: 335
			public int dwExtraInfo;
		}

		// Token: 0x0200001E RID: 30
		// (Invoke) Token: 0x06000257 RID: 599
		public delegate int KeyboardHookDelegate(int Code, int wParam, ref modKeyboard.KBDLLHOOKSTRUCT lParam);
	}
}
