// Decompiled with JetBrains decompiler
// Type: explori.Properties.Resources
// Assembly: explori, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 53B7CCDE-6B3E-4F99-BDEC-93401BE53DE5
// Assembly location: C:\Users\Admin\Desktop\WannaSmile\wannaSmile.exe

using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace explori.Properties
{
  [GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
  [DebuggerNonUserCode]
  [CompilerGenerated]
  internal class Resources
  {
    private static ResourceManager resourceMan;
    private static CultureInfo resourceCulture;

    internal Resources()
    {
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static ResourceManager ResourceManager
    {
      get
      {
        if (object.ReferenceEquals((object) explori.Properties.Resources.resourceMan, (object) null))
          explori.Properties.Resources.resourceMan = new ResourceManager("explori.Properties.Resources", typeof (explori.Properties.Resources).Assembly);
        return explori.Properties.Resources.resourceMan;
      }
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static CultureInfo Culture
    {
      get => explori.Properties.Resources.resourceCulture;
      set => explori.Properties.Resources.resourceCulture = value;
    }

    internal static Bitmap FaviconLoli1 => (Bitmap) explori.Properties.Resources.ResourceManager.GetObject(nameof (FaviconLoli1), explori.Properties.Resources.resourceCulture);
  }
}
