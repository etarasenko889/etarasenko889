using UnityEngine;

/// One generated reactor: three rings, each with its own tempo, its own lit sector
/// and its own channel colour. Positions and speeds come from the generator, never
/// from constants in the build code.
public sealed class _0xdd279fb7
{
    public int LockBonus;
    /// Smallest signed distance from an angle to the sector centre, in degrees.
    public static float AngleOffset(float _0x35c3dec1, float _0x14586409)
    {
        float _0x3046c3b8 = Mathf.Repeat(_0x35c3dec1 - _0x14586409 + 180f, 360f) - 180f;
        return _0x3046c3b8;
    }

    public sealed class _0x2faff3f3
    {
        public float SpeedDegPerSecond;
        public float SectorCenterDeg;
        public float SectorWidthDeg;
        public float StartAngleDeg;
        public int Direction;
        public int ChannelIndex;
        /// Reaction window in seconds: how long the marker stays inside the sector.
        public float _0xcb5f89e6
        {
            get
            {
                return this.SpeedDegPerSecond > 0.01f ? this.SectorWidthDeg / this.SpeedDegPerSecond : 0f;
            }
        }
    }

    public int Seed;
    public int _0x8879c5f4
    {
        get
        {
            return this.Rings != null ? this.Rings.Length : 0;
        }
    }

    public _0x2faff3f3[] Rings = new _0x2faff3f3[0];
    public _0x2faff3f3 _0xae865f5e(int _0xb52a0332)
    {
        if (this.Rings == null || _0xb52a0332 < 0 || _0xb52a0332 >= this.Rings.Length)
        {
            return null;
        }

        return this.Rings[_0xb52a0332];
    }
}