using Avalonia.Media;
using Avalonia.Media.Immutable;
using System.Runtime.CompilerServices;

namespace Cliff.Design.Utils
{
    public static class ColorUtils
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ISolidColorBrush ToBrush(this uint value)
        {
            return new ImmutableSolidColorBrush(Color.FromUInt32(value));
        }
    }
}
