using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml;
using BijoyBayanno.My;
using Microsoft.VisualBasic.CompilerServices;

namespace BijoyBayanno
{
	// Token: 0x02000009 RID: 9
	public class clsLayouts
	{
		// Token: 0x0600002F RID: 47 RVA: 0x000C7B00 File Offset: 0x000C5F00
		public clsLayouts()
		{
			this.Key = new Dictionary<int, ArrayList>();
			this.Juk = new Dictionary<string, string>();
		}

		// Token: 0x06000030 RID: 48 RVA: 0x000C7B20 File Offset: 0x000C5F20
		public void Init(string Path)
		{
			XmlReader xmlReader = XmlReader.Create(Path, new XmlReaderSettings
			{
				CheckCharacters = true,
				CloseInput = true
			});
			try
			{
				try
				{
					xmlReader.ReadStartElement("KeyLayout");
					this.Name = xmlReader.ReadElementString("Name");
					xmlReader.ReadStartElement("Shortcut");
					this.Shortcut.Alt = Conversions.ToBoolean(xmlReader.ReadElementString("Alt"));
					this.Shortcut.Ctrl = Conversions.ToBoolean(xmlReader.ReadElementString("Ctrl"));
					this.Shortcut.Shift = Conversions.ToBoolean(xmlReader.ReadElementString("Shift"));
					this.Shortcut.KeyCode = Conversions.ToInteger(xmlReader.ReadElementString("KeyCode"));
					xmlReader.ReadEndElement();
					bool flag = Conversions.ToBoolean(MyProject.Computer.Registry.GetValue("HKEY_CURRENT_USER\\SOFTWARE\\BijoyEkushe\\Options\\" + this.Name, "KeyCode", false));
					if (flag)
					{
						this.Shortcut.Alt = Conversions.ToBoolean(MyProject.Computer.Registry.GetValue("HKEY_CURRENT_USER\\SOFTWARE\\BijoyEkushe\\Options\\" + this.Name, "Alt", false));
						this.Shortcut.Ctrl = Conversions.ToBoolean(MyProject.Computer.Registry.GetValue("HKEY_CURRENT_USER\\SOFTWARE\\BijoyEkushe\\Options\\" + this.Name, "Ctrl", false));
						this.Shortcut.Shift = Conversions.ToBoolean(MyProject.Computer.Registry.GetValue("HKEY_CURRENT_USER\\SOFTWARE\\BijoyEkushe\\Options\\" + this.Name, "Shift", false));
						this.Shortcut.KeyCode = Conversions.ToInteger(MyProject.Computer.Registry.GetValue("HKEY_CURRENT_USER\\SOFTWARE\\BijoyEkushe\\Options\\" + this.Name, "KeyCode", 0));
					}
					this.IconName = xmlReader.ReadElementString("IconName");
					xmlReader.ReadStartElement("Keys");
					do
					{
						ArrayList arrayList = new ArrayList();
						flag = (xmlReader.NodeType == XmlNodeType.Element | xmlReader.NodeType == XmlNodeType.Attribute);
						if (flag)
						{
							int key = Conversions.ToInteger(xmlReader.GetAttribute("KeyCode"));
							arrayList.Add(xmlReader.GetAttribute("Normal_Option"));
							arrayList.Add(xmlReader.GetAttribute("Shift_Option"));
							xmlReader.Read();
							arrayList.Insert(0, xmlReader.ReadElementString("Normal"));
							arrayList.Insert(1, xmlReader.ReadElementString("Shift"));
							this.Key.Add(key, arrayList);
						}
						xmlReader.Read();
					}
					while (Operators.CompareString(xmlReader.Name, "Keys", false) != 0);
					xmlReader.ReadEndElement();
					xmlReader.ReadStartElement("Juks");
					do
					{
						flag = (xmlReader.NodeType == XmlNodeType.Element);
						if (flag)
						{
							xmlReader.Read();
							string key2 = xmlReader.ReadElementString("Seq");
							string value = xmlReader.ReadElementString("Out");
							this.Juk.Add(key2, value);
						}
						xmlReader.Read();
					}
					while (Operators.CompareString(xmlReader.Name, "Juks", false) != 0);
				}
				catch (Exception ex)
				{
				}
				finally
				{
					xmlReader.Close();
				}
			}
			finally
			{
				bool flag = xmlReader != null;
				if (flag)
				{
					((IDisposable)xmlReader).Dispose();
				}
			}
		}

		// Token: 0x06000031 RID: 49 RVA: 0x000C7EDC File Offset: 0x000C62DC
		public void Update()
		{
			this.Key.Clear();
			this.Juk.Clear();
			XmlReaderSettings xmlReaderSettings = new XmlReaderSettings();
			xmlReaderSettings.CheckCharacters = true;
			xmlReaderSettings.CloseInput = true;
			XmlReader xmlReader = XmlReader.Create(this.Path, xmlReaderSettings);
			try
			{
				try
				{
					xmlReader.ReadStartElement("KeyLayout");
					this.Name = xmlReader.ReadElementString("Name");
					xmlReader.ReadStartElement("Shortcut");
					this.Shortcut.Alt = Conversions.ToBoolean(xmlReader.ReadElementString("Alt"));
					this.Shortcut.Ctrl = Conversions.ToBoolean(xmlReader.ReadElementString("Ctrl"));
					this.Shortcut.Shift = Conversions.ToBoolean(xmlReader.ReadElementString("Shift"));
					this.Shortcut.KeyCode = Conversions.ToInteger(xmlReader.ReadElementString("KeyCode"));
					xmlReader.ReadEndElement();
					bool flag = Conversions.ToBoolean(MyProject.Computer.Registry.GetValue("HKEY_CURRENT_USER\\SOFTWARE\\BijoyEkushe\\Options\\" + this.Name, "Alt", false));
					if (flag)
					{
						this.Shortcut.Alt = Conversions.ToBoolean(MyProject.Computer.Registry.GetValue("HKEY_CURRENT_USER\\SOFTWARE\\BijoyEkushe\\Options\\" + this.Name, "Alt", false));
						this.Shortcut.Ctrl = Conversions.ToBoolean(MyProject.Computer.Registry.GetValue("HKEY_CURRENT_USER\\SOFTWARE\\BijoyEkushe\\Options\\" + this.Name, "Ctrl", false));
						this.Shortcut.Shift = Conversions.ToBoolean(MyProject.Computer.Registry.GetValue("HKEY_CURRENT_USER\\SOFTWARE\\BijoyEkushe\\Options\\" + this.Name, "Shift", false));
						this.Shortcut.KeyCode = Conversions.ToInteger(MyProject.Computer.Registry.GetValue("HKEY_CURRENT_USER\\SOFTWARE\\BijoyEkushe\\Options\\" + this.Name, "KeyCode", 0));
					}
					this.IconName = xmlReader.ReadElementString("IconName");
					xmlReader.ReadStartElement("Keys");
					do
					{
						ArrayList arrayList = new ArrayList();
						flag = (xmlReader.NodeType == XmlNodeType.Element | xmlReader.NodeType == XmlNodeType.Attribute);
						if (flag)
						{
							int key = Conversions.ToInteger(xmlReader.GetAttribute("KeyCode"));
							arrayList.Add(xmlReader.GetAttribute("Normal_Option"));
							arrayList.Add(xmlReader.GetAttribute("Shift_Option"));
							xmlReader.Read();
							arrayList.Insert(0, xmlReader.ReadElementString("Normal"));
							arrayList.Insert(1, xmlReader.ReadElementString("Shift"));
							this.Key.Add(key, arrayList);
						}
						xmlReader.Read();
					}
					while (Operators.CompareString(xmlReader.Name, "Keys", false) != 0);
					xmlReader.ReadEndElement();
					xmlReader.ReadStartElement("Juks");
					do
					{
						flag = (xmlReader.NodeType == XmlNodeType.Element);
						if (flag)
						{
							xmlReader.Read();
							string key2 = xmlReader.ReadElementString("Seq");
							string value = xmlReader.ReadElementString("Out");
							this.Juk.Add(key2, value);
						}
						xmlReader.Read();
					}
					while (Operators.CompareString(xmlReader.Name, "Juks", false) != 0);
				}
				catch (Exception ex)
				{
				}
				finally
				{
					xmlReader.Close();
				}
			}
			finally
			{
				bool flag = xmlReader != null;
				if (flag)
				{
					((IDisposable)xmlReader).Dispose();
				}
			}
		}

		// Token: 0x04000012 RID: 18
		public string Name;

		// Token: 0x04000013 RID: 19
		public string IconName;

		// Token: 0x04000014 RID: 20
		public int ID;

		// Token: 0x04000015 RID: 21
		public Dictionary<int, ArrayList> Key;

		// Token: 0x04000016 RID: 22
		public Dictionary<string, string> Juk;

		// Token: 0x04000017 RID: 23
		public clsLayouts.LayoutShortcut Shortcut;

		// Token: 0x04000018 RID: 24
		public string Path;

		// Token: 0x0200000A RID: 10
		public struct LayoutShortcut
		{
			// Token: 0x04000019 RID: 25
			public bool Alt;

			// Token: 0x0400001A RID: 26
			public bool Ctrl;

			// Token: 0x0400001B RID: 27
			public bool Shift;

			// Token: 0x0400001C RID: 28
			public int KeyCode;
		}
	}
}
