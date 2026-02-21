using System;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace BijoyBayanno.My
{
	// Token: 0x02000022 RID: 34
	[CompilerGenerated]
	[HideModuleName]
	[StandardModule]
	[DebuggerNonUserCode]
	internal sealed class MySettingsProperty
	{
		// Token: 0x170000ED RID: 237
		// (get) Token: 0x06000270 RID: 624 RVA: 0x000C993C File Offset: 0x000C7D3C
		[HelpKeyword("My.Settings")]
		internal static MySettings Settings
		{
			get
			{
				return MySettings.Default;
			}
		}
	}
}
