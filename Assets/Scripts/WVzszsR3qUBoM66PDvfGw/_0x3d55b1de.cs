using UnityEngine;

/// Fixed palette for every screen of this game (RETRO_NEON preset, hex overrides
/// from the brief). Colours live here so panels, pops, world sprites and the
/// splash bar cannot drift apart.
public static class _0x3d55b1de
{
    /// Colour of energy channel 0..2. Used for rings, chips and the channel bus so
    /// one ring always reads as one channel.
    public static Color Channel(int _0x6136ba0d)
    {
        int _0x5031d726 = ((_0x6136ba0d % 3) + 3) % 3;
        if (_0x5031d726 == 0)
        {
            return Teal;
        }

        if (_0x5031d726 == 1)
        {
            return Gold;
        }

        return Violet;
    }

    public static readonly Color Surface = new Color(0.086f, 0.106f, 0.180f, 1f);
    public static readonly Color Violet = new Color(0.439f, 0.282f, 0.773f, 1f);
    public static readonly Color Alert = new Color(0.898f, 0.227f, 0.310f, 1f);
    public static Color WithAlpha(Color _0xcaee3435, float _0x4ab13a42)
    {
        return new Color(_0xcaee3435.r, _0xcaee3435.g, _0xcaee3435.b, _0x4ab13a42);
    }

    public static readonly Color Shade = new Color(0.020f, 0.027f, 0.055f, 1f);
    public static readonly Color Base = new Color(0.067f, 0.082f, 0.133f, 1f);
    public static readonly Color Teal = new Color(0.165f, 0.769f, 0.710f, 1f);
    public static readonly Color Ink = new Color(0.067f, 0.082f, 0.133f, 1f);
    public static readonly Color Gold = new Color(0.949f, 0.765f, 0.306f, 1f);
    public static readonly Color Cream = new Color(0.969f, 0.933f, 0.859f, 1f);
    public static readonly Color Muted = new Color(0.604f, 0.639f, 0.749f, 1f);
    public static readonly Color SurfaceEdge = new Color(0.118f, 0.141f, 0.251f, 1f);
    public static readonly Color TrackDark = new Color(0.118f, 0.141f, 0.251f, 0.9f);
}