// Decompiled with JetBrains decompiler
// Type: explori.Program
// Assembly: explori, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 53B7CCDE-6B3E-4F99-BDEC-93401BE53DE5
// Assembly location: C:\Users\Admin\Desktop\WannaSmile\wannaSmile.exe

using System;
using System.Windows.Forms;

namespace explori
{
  internal static class Program
  {
    [STAThread]
    private static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run((Form) new Form1());
    }
  }
}
