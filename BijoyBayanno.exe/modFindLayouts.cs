using System;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Windows.Forms;
using BijoyBayanno.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.FileIO;

namespace BijoyBayanno
{
	// Token: 0x0200001B RID: 27
	[StandardModule]
	internal sealed class modFindLayouts
	{
		// Token: 0x06000240 RID: 576 RVA: 0x000C8520 File Offset: 0x000C6920
		public static bool Find()
		{
			string text = myFunctions.VerifyPath(MyProject.Application.Info.DirectoryPath);
			text += "Layouts";
			bool flag = !MyProject.Computer.FileSystem.DirectoryExists(text);
			if (flag)
			{
				Interaction.MsgBox("'Layouts' folder not found", MsgBoxStyle.Critical, null);
				ProjectData.EndApp();
			}
			ReadOnlyCollection<string> files = MyProject.Computer.FileSystem.GetFiles(text, SearchOption.SearchAllSubDirectories, new string[]
			{
				"*.xml"
			});
			flag = (files.Count == 0);
			if (flag)
			{
				Interaction.MsgBox("No file found under 'Layouts' folder", MsgBoxStyle.Critical, null);
				ProjectData.EndApp();
			}
			checked
			{
				modKeyboard.LayoutNumber = files.Count + 1;
				modKeyboard.Layout = new clsLayouts[modKeyboard.LayoutNumber - 2 + 1];
				int num = 0;
				int num2 = modKeyboard.LayoutNumber - 2;
				int num3 = num;
				for (;;)
				{
					int num4 = num3;
					int num5 = num2;
					if (num4 > num5)
					{
						break;
					}
					modKeyboard.Layout[num3] = new clsLayouts();
					modKeyboard.Layout[num3].Init(files[num3]);
					modKeyboard.Layout[num3].Path = files[num3];
					MyProject.Forms.frmMain.comLayouts.Items.Add(modKeyboard.Layout[num3].Name);
					ToolStripMenuItem toolStripMenuItem = new ToolStripMenuItem();
					toolStripMenuItem.Text = modKeyboard.Layout[num3].Name;
					try
					{
						Icon icon = new Icon(myFunctions.VerifyPath(MyProject.Application.Info.DirectoryPath) + "Icons\\" + modKeyboard.Layout[num3].IconName + ".ico", 16, 16);
						toolStripMenuItem.Image = icon.ToBitmap();
					}
					catch (Exception ex)
					{
					}
					modKeyboard.Layout[num3].ID = num3;
					toolStripMenuItem.Tag = num3 + 2;
					MyProject.Forms.frmMain.NotifyMenu.Items.Insert(0, toolStripMenuItem);
					num3++;
				}
				bool result;
				return result;
			}
		}
	}
}
