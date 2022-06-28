using Avalonia;
using Avalonia.Media.Imaging;
using Avalonia.Platform;
using System;
using System.Runtime.CompilerServices;

namespace Cliff.Design.Utils
{
    public static class ImageUtils
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bitmap FromAvaRes(string res)
        {
            return new Bitmap(AvaloniaLocator.Current.GetService<IAssetLoader>().Open(new Uri(res)));
        }
    }
}
