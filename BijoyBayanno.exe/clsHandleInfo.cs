using System;

namespace BijoyBayanno
{
	// Token: 0x02000008 RID: 8
	public class clsHandleInfo
	{
		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600002A RID: 42 RVA: 0x000C7AA4 File Offset: 0x000C5EA4
		// (set) Token: 0x0600002B RID: 43 RVA: 0x000C7ABC File Offset: 0x000C5EBC
		public int Handle
		{
			get
			{
				return this.lnghWnd;
			}
			set
			{
				this.lnghWnd = value;
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600002C RID: 44 RVA: 0x000C7AC8 File Offset: 0x000C5EC8
		// (set) Token: 0x0600002D RID: 45 RVA: 0x000C7AE0 File Offset: 0x000C5EE0
		public clsLayouts Status
		{
			get
			{
				return this.layStatus;
			}
			set
			{
				this.layStatus = value;
			}
		}

		// Token: 0x0600002E RID: 46 RVA: 0x000C7AEC File Offset: 0x000C5EEC
		public clsHandleInfo()
		{
			this.lnghWnd = -1;
		}

		// Token: 0x04000010 RID: 16
		private int lnghWnd;

		// Token: 0x04000011 RID: 17
		private clsLayouts layStatus;
	}
}
