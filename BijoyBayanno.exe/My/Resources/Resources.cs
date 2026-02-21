using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace BijoyBayanno.My.Resources
{
	// Token: 0x02000020 RID: 32
	[DebuggerNonUserCode]
	[CompilerGenerated]
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0")]
	[StandardModule]
	[HideModuleName]
	internal sealed class Resources
	{
		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x06000258 RID: 600 RVA: 0x000C947C File Offset: 0x000C787C
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static ResourceManager ResourceManager
		{
			get
			{
				bool flag = object.ReferenceEquals(Resources.resourceMan, null);
				if (flag)
				{
					ResourceManager resourceManager = new ResourceManager("BijoyBayanno.Resources", typeof(Resources).Assembly);
					Resources.resourceMan = resourceManager;
				}
				return Resources.resourceMan;
			}
		}

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x06000259 RID: 601 RVA: 0x000C94C4 File Offset: 0x000C78C4
		// (set) Token: 0x0600025A RID: 602 RVA: 0x000C94DC File Offset: 0x000C78DC
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static CultureInfo Culture
		{
			get
			{
				return Resources.resourceCulture;
			}
			set
			{
				Resources.resourceCulture = value;
			}
		}

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x0600025B RID: 603 RVA: 0x000C94E8 File Offset: 0x000C78E8
		internal static Icon BanN
		{
			get
			{
				object objectValue = RuntimeHelpers.GetObjectValue(Resources.ResourceManager.GetObject("BanN", Resources.resourceCulture));
				return (Icon)objectValue;
			}
		}

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x0600025C RID: 604 RVA: 0x000C951C File Offset: 0x000C791C
		internal static Bitmap Bar
		{
			get
			{
				object objectValue = RuntimeHelpers.GetObjectValue(Resources.ResourceManager.GetObject("Bar", Resources.resourceCulture));
				return (Bitmap)objectValue;
			}
		}

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x0600025D RID: 605 RVA: 0x000C9550 File Offset: 0x000C7950
		internal static Bitmap Capture
		{
			get
			{
				object objectValue = RuntimeHelpers.GetObjectValue(Resources.ResourceManager.GetObject("Capture", Resources.resourceCulture));
				return (Bitmap)objectValue;
			}
		}

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x0600025E RID: 606 RVA: 0x000C9584 File Offset: 0x000C7984
		internal static Bitmap Close
		{
			get
			{
				object objectValue = RuntimeHelpers.GetObjectValue(Resources.ResourceManager.GetObject("Close", Resources.resourceCulture));
				return (Bitmap)objectValue;
			}
		}

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x0600025F RID: 607 RVA: 0x000C95B8 File Offset: 0x000C79B8
		internal static Bitmap Close2
		{
			get
			{
				object objectValue = RuntimeHelpers.GetObjectValue(Resources.ResourceManager.GetObject("Close2", Resources.resourceCulture));
				return (Bitmap)objectValue;
			}
		}

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x06000260 RID: 608 RVA: 0x000C95EC File Offset: 0x000C79EC
		internal static Bitmap Close3
		{
			get
			{
				object objectValue = RuntimeHelpers.GetObjectValue(Resources.ResourceManager.GetObject("Close3", Resources.resourceCulture));
				return (Bitmap)objectValue;
			}
		}

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x06000261 RID: 609 RVA: 0x000C9620 File Offset: 0x000C7A20
		internal static Bitmap DragBar
		{
			get
			{
				object objectValue = RuntimeHelpers.GetObjectValue(Resources.ResourceManager.GetObject("DragBar", Resources.resourceCulture));
				return (Bitmap)objectValue;
			}
		}

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x06000262 RID: 610 RVA: 0x000C9654 File Offset: 0x000C7A54
		internal static Bitmap kb
		{
			get
			{
				object objectValue = RuntimeHelpers.GetObjectValue(Resources.ResourceManager.GetObject("kb", Resources.resourceCulture));
				return (Bitmap)objectValue;
			}
		}

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x06000263 RID: 611 RVA: 0x000C9688 File Offset: 0x000C7A88
		internal static Bitmap Main
		{
			get
			{
				object objectValue = RuntimeHelpers.GetObjectValue(Resources.ResourceManager.GetObject("Main", Resources.resourceCulture));
				return (Bitmap)objectValue;
			}
		}

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x06000264 RID: 612 RVA: 0x000C96BC File Offset: 0x000C7ABC
		internal static Bitmap Main16
		{
			get
			{
				object objectValue = RuntimeHelpers.GetObjectValue(Resources.ResourceManager.GetObject("Main16", Resources.resourceCulture));
				return (Bitmap)objectValue;
			}
		}

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x06000265 RID: 613 RVA: 0x000C96F0 File Offset: 0x000C7AF0
		internal static Bitmap Minimize
		{
			get
			{
				object objectValue = RuntimeHelpers.GetObjectValue(Resources.ResourceManager.GetObject("Minimize", Resources.resourceCulture));
				return (Bitmap)objectValue;
			}
		}

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x06000266 RID: 614 RVA: 0x000C9724 File Offset: 0x000C7B24
		internal static Bitmap show
		{
			get
			{
				object objectValue = RuntimeHelpers.GetObjectValue(Resources.ResourceManager.GetObject("show", Resources.resourceCulture));
				return (Bitmap)objectValue;
			}
		}

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x06000267 RID: 615 RVA: 0x000C9758 File Offset: 0x000C7B58
		internal static Bitmap SysTray
		{
			get
			{
				object objectValue = RuntimeHelpers.GetObjectValue(Resources.ResourceManager.GetObject("SysTray", Resources.resourceCulture));
				return (Bitmap)objectValue;
			}
		}

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x06000268 RID: 616 RVA: 0x000C978C File Offset: 0x000C7B8C
		internal static Bitmap tools
		{
			get
			{
				object objectValue = RuntimeHelpers.GetObjectValue(Resources.ResourceManager.GetObject("tools", Resources.resourceCulture));
				return (Bitmap)objectValue;
			}
		}

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x06000269 RID: 617 RVA: 0x000C97C0 File Offset: 0x000C7BC0
		internal static Bitmap TopBar
		{
			get
			{
				object objectValue = RuntimeHelpers.GetObjectValue(Resources.ResourceManager.GetObject("TopBar", Resources.resourceCulture));
				return (Bitmap)objectValue;
			}
		}

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x0600026A RID: 618 RVA: 0x000C97F4 File Offset: 0x000C7BF4
		internal static Bitmap Win
		{
			get
			{
				object objectValue = RuntimeHelpers.GetObjectValue(Resources.ResourceManager.GetObject("Win", Resources.resourceCulture));
				return (Bitmap)objectValue;
			}
		}

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x0600026B RID: 619 RVA: 0x000C9828 File Offset: 0x000C7C28
		internal static Bitmap XKey
		{
			get
			{
				object objectValue = RuntimeHelpers.GetObjectValue(Resources.ResourceManager.GetObject("XKey", Resources.resourceCulture));
				return (Bitmap)objectValue;
			}
		}

		// Token: 0x04000150 RID: 336
		private static ResourceManager resourceMan;

		// Token: 0x04000151 RID: 337
		private static CultureInfo resourceCulture;
	}
}
