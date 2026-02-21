using System;
using System.Collections;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic.CompilerServices;

namespace BijoyBayanno
{
	// Token: 0x0200001A RID: 26
	[StandardModule]
	internal sealed class mHandleInfo
	{
		// Token: 0x0600023C RID: 572
		[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		private static extern int IsWindow(int hWnd);

		// Token: 0x0600023D RID: 573 RVA: 0x000C82D4 File Offset: 0x000C66D4
		public static bool AddInfo(long Handle, clsLayouts Status)
		{
			try
			{
				try
				{
					foreach (object obj in mHandleInfo.layInfo)
					{
						clsHandleInfo clsHandleInfo = (clsHandleInfo)obj;
						bool flag = (long)clsHandleInfo.Handle == Handle;
						if (flag)
						{
							mHandleInfo.layInfo.Remove(clsHandleInfo);
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
			catch (Exception ex)
			{
			}
			clsHandleInfo clsHandleInfo2 = new clsHandleInfo();
			clsHandleInfo2.Handle = checked((int)Handle);
			clsHandleInfo2.Status = Status;
			mHandleInfo.layInfo.Add(clsHandleInfo2);
			try
			{
				foreach (object obj2 in mHandleInfo.layInfo)
				{
					clsHandleInfo clsHandleInfo = (clsHandleInfo)obj2;
					bool flag = mHandleInfo.IsWindow(clsHandleInfo.Handle) == 0;
					if (flag)
					{
						mHandleInfo.layInfo.Remove(clsHandleInfo);
					}
				}
			}
			finally
			{
				IEnumerator enumerator2;
				bool flag = enumerator2 is IDisposable;
				if (flag)
				{
					(enumerator2 as IDisposable).Dispose();
				}
			}
			bool result;
			return result;
		}

		// Token: 0x0600023E RID: 574 RVA: 0x000C841C File Offset: 0x000C681C
		public static clsLayouts FindInfo(long Handle)
		{
			try
			{
				foreach (object obj in mHandleInfo.layInfo)
				{
					clsHandleInfo clsHandleInfo = (clsHandleInfo)obj;
					bool flag = (long)clsHandleInfo.Handle == Handle;
					if (flag)
					{
						return clsHandleInfo.Status;
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
			return null;
		}

		// Token: 0x0600023F RID: 575 RVA: 0x000C849C File Offset: 0x000C689C
		public static bool RemoveInfo(long Handle)
		{
			try
			{
				IEnumerator enumerator = mHandleInfo.layInfo.GetEnumerator();
				if (enumerator.MoveNext())
				{
					clsHandleInfo clsHandleInfo = (clsHandleInfo)enumerator.Current;
					bool flag = (long)clsHandleInfo.Handle == Handle;
					if (flag)
					{
						mHandleInfo.layInfo.Remove(clsHandleInfo);
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

		// Token: 0x0400012B RID: 299
		public static ArrayList layInfo = new ArrayList();
	}
}
