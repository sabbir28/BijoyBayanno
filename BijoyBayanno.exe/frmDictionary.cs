using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using BijoyBayanno.My.Resources;
using Microsoft.VisualBasic.CompilerServices;

namespace BijoyBayanno
{
	// Token: 0x02000013 RID: 19
	[DesignerGenerated]
	public partial class frmDictionary : Form
	{
		// Token: 0x06000035 RID: 53 RVA: 0x000CA4B8 File Offset: 0x000C88B8
		[DebuggerNonUserCode]
		public frmDictionary()
		{
			List<WeakReference> _ENCList = frmDictionary.__ENCList;
			lock (_ENCList)
			{
				frmDictionary.__ENCList.Add(new WeakReference(this));
			}
			this.InitializeComponent();
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000038 RID: 56 RVA: 0x000CA75C File Offset: 0x000C8B5C
		// (set) Token: 0x06000039 RID: 57 RVA: 0x000CA774 File Offset: 0x000C8B74
		internal virtual Label lblEnglish
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lblEnglish;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lblEnglish = value;
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x0600003A RID: 58 RVA: 0x000CA780 File Offset: 0x000C8B80
		// (set) Token: 0x0600003B RID: 59 RVA: 0x000CA798 File Offset: 0x000C8B98
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

		// Token: 0x04000045 RID: 69
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x04000047 RID: 71
		[AccessedThroughProperty("lblEnglish")]
		private Label _lblEnglish;

		// Token: 0x04000048 RID: 72
		[AccessedThroughProperty("Label1")]
		private Label _Label1;
	}
}
