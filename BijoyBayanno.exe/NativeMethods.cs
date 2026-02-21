using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace BijoyBayanno
{
	// Token: 0x0200000B RID: 11
	public class NativeMethods
	{
		// Token: 0x06000032 RID: 50 RVA: 0x000C82B8 File Offset: 0x000C66B8
		[DebuggerNonUserCode]
		public NativeMethods()
		{
		}

		// Token: 0x06000033 RID: 51
		[DllImport("user32.dll", SetLastError = true)]
		internal static extern int SendInput(int cInputs, ref NativeMethods.INPUT pInputs, int cbSize);

		// Token: 0x0200000C RID: 12
		[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 28)]
		internal struct INPUT
		{
			// Token: 0x0400001D RID: 29
			[FieldOffset(0)]
			public NativeMethods.InputType dwType;

			// Token: 0x0400001E RID: 30
			[FieldOffset(4)]
			public NativeMethods.MOUSEINPUT mi;

			// Token: 0x0400001F RID: 31
			[FieldOffset(4)]
			public NativeMethods.KEYBDINPUT ki;

			// Token: 0x04000020 RID: 32
			[FieldOffset(4)]
			public NativeMethods.HARDWAREINPUT hi;
		}

		// Token: 0x0200000D RID: 13
		[StructLayout(LayoutKind.Sequential, Pack = 1)]
		internal struct MOUSEINPUT
		{
			// Token: 0x04000021 RID: 33
			public int dx;

			// Token: 0x04000022 RID: 34
			public int dy;

			// Token: 0x04000023 RID: 35
			public int mouseData;

			// Token: 0x04000024 RID: 36
			public NativeMethods.MOUSEEVENTF dwFlags;

			// Token: 0x04000025 RID: 37
			public int time;

			// Token: 0x04000026 RID: 38
			public IntPtr dwExtraInfo;
		}

		// Token: 0x0200000E RID: 14
		[StructLayout(LayoutKind.Sequential, Pack = 1)]
		internal struct KEYBDINPUT
		{
			// Token: 0x04000027 RID: 39
			public short wVk;

			// Token: 0x04000028 RID: 40
			public short wScan;

			// Token: 0x04000029 RID: 41
			public NativeMethods.KEYEVENTF dwFlags;

			// Token: 0x0400002A RID: 42
			public int time;

			// Token: 0x0400002B RID: 43
			public IntPtr dwExtraInfo;
		}

		// Token: 0x0200000F RID: 15
		[StructLayout(LayoutKind.Sequential, Pack = 1)]
		internal struct HARDWAREINPUT
		{
			// Token: 0x0400002C RID: 44
			public int uMsg;

			// Token: 0x0400002D RID: 45
			public short wParamL;

			// Token: 0x0400002E RID: 46
			public short wParamH;
		}

		// Token: 0x02000010 RID: 16
		internal enum InputType
		{
			// Token: 0x04000030 RID: 48
			Mouse,
			// Token: 0x04000031 RID: 49
			Keyboard,
			// Token: 0x04000032 RID: 50
			Hardware
		}

		// Token: 0x02000011 RID: 17
		[Flags]
		internal enum MOUSEEVENTF
		{
			// Token: 0x04000034 RID: 52
			MOVE = 1,
			// Token: 0x04000035 RID: 53
			LEFTDOWN = 2,
			// Token: 0x04000036 RID: 54
			LEFTUP = 4,
			// Token: 0x04000037 RID: 55
			RIGHTDOWN = 8,
			// Token: 0x04000038 RID: 56
			RIGHTUP = 16,
			// Token: 0x04000039 RID: 57
			MIDDLEDOWN = 32,
			// Token: 0x0400003A RID: 58
			MIDDLEUP = 64,
			// Token: 0x0400003B RID: 59
			XDOWN = 128,
			// Token: 0x0400003C RID: 60
			XUP = 256,
			// Token: 0x0400003D RID: 61
			VIRTUALDESK = 1024,
			// Token: 0x0400003E RID: 62
			WHEEL = 2048,
			// Token: 0x0400003F RID: 63
			ABSOLUTE = 32768
		}

		// Token: 0x02000012 RID: 18
		[Flags]
		internal enum KEYEVENTF
		{
			// Token: 0x04000041 RID: 65
			EXTENDEDKEY = 1,
			// Token: 0x04000042 RID: 66
			KEYUP = 2,
			// Token: 0x04000043 RID: 67
			UNICODE = 4,
			// Token: 0x04000044 RID: 68
			SCANCODE = 8
		}
	}
}
