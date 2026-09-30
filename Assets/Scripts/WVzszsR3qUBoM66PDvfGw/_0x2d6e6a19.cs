using UnityEngine;

/// Seeded layout generator. Every attempt at every reactor gets its own sector
/// angles, tempos, spin directions and channel order, so two neighbouring runs
/// differ by LAYOUT and not only by a number in the HUD.
public sealed class _0x2d6e6a19
{
    /// Guaranteed-playable fallback. It exists so a bad run of draws can never put
    /// an impossible reactor on screen, not as the game itself.
    private _0xdd279fb7 _0x2f72117f(int _0x5e406034, int _0x74c81de7)
    {
        _0xdd279fb7 _0xdd8c5a34 = new _0xdd279fb7();
        _0xdd8c5a34.Seed = _0x74c81de7;
        _0xdd8c5a34.LockBonus = _0x36d68603[_0x5e406034];
        _0xdd8c5a34.Rings = new _0xdd279fb7._0x2faff3f3[RingsPerReactor];
        for (int _0xdf629f85 = 0; _0xdf629f85 < RingsPerReactor; _0xdf629f85++)
        {
            _0xdd279fb7._0x2faff3f3 _0xf4ee0a31 = new _0xdd279fb7._0x2faff3f3();
            _0xf4ee0a31.SpeedDegPerSecond = _0xa816f3a9[_0x5e406034, _0xdf629f85];
            _0xf4ee0a31.SectorWidthDeg = Mathf.Max(MinSectorWidthDeg + 12f, _0x8ec1f713[_0x5e406034, _0xdf629f85]);
            _0xf4ee0a31.SectorCenterDeg = 40f + (_0xdf629f85 * 100f);
            _0xf4ee0a31.StartAngleDeg = 200f - (_0xdf629f85 * 70f);
            _0xf4ee0a31.Direction = _0xdf629f85 % 2 == 0 ? 1 : -1;
            _0xf4ee0a31.ChannelIndex = _0xdf629f85;
            _0xdd8c5a34.Rings[_0xdf629f85] = _0xf4ee0a31;
        }

        return _0xdd8c5a34;
    }

    /// A drawn reactor is playable only if every ring leaves a real reaction window,
    /// its sector is wide enough to see, and the three tempos are far enough apart
    /// that the rings do not merge into one rhythm.
    public bool _0xb6a5ecec(_0xdd279fb7 _0xafc2b741)
    {
        if (_0xafc2b741 == null || _0xafc2b741._0x8879c5f4 != RingsPerReactor)
        {
            return false;
        }

        for (int _0x24a0b0e4 = 0; _0x24a0b0e4 < _0xafc2b741._0x8879c5f4; _0x24a0b0e4++)
        {
            _0xdd279fb7._0x2faff3f3 _0x8445d439 = _0xafc2b741._0xae865f5e(_0x24a0b0e4);
            if (_0x8445d439 == null || _0x8445d439.SectorWidthDeg < MinSectorWidthDeg)
            {
                return false;
            }

            if (_0x8445d439._0xcb5f89e6 < MinWindowSeconds)
            {
                return false;
            }
        }

        for (int _0x85ad877f = 0; _0x85ad877f < _0xafc2b741._0x8879c5f4; _0x85ad877f++)
        {
            for (int _0xec991a00 = _0x85ad877f + 1; _0xec991a00 < _0xafc2b741._0x8879c5f4; _0xec991a00++)
            {
                float _0x7c92fd05 = Mathf.Abs(_0xafc2b741._0xae865f5e(_0x85ad877f).SpeedDegPerSecond - _0xafc2b741._0xae865f5e(_0xec991a00).SpeedDegPerSecond);
                if (_0x7c92fd05 < MinSpeedGapDeg)
                {
                    return false;
                }
            }
        }

        if (_0xafc2b741.LockBonus < RingsPerReactor + 1)
        {
            return false;
        }

        return true;
    }

    private static readonly float[, ] _0x8f6558a9 =
    {
        {
            54f,
            70f,
            86f
        },
        {
            64f,
            82f,
            100f
        },
        {
            74f,
            94f,
            114f
        },
        {
            84f,
            106f,
            128f
        },
        {
            96f,
            120f,
            142f
        },
    };
    public _0xdd279fb7 _0x625415d7(int _0xb1fb4710, int _0xf31986fa)
    {
        int _0x3eb90840 = Mathf.Clamp(_0xb1fb4710, 0, _0x36d68603.Length - 1);
        int _0xe6cd8527 = (_0xb1fb4710 * 7919) ^ (_0xf31986fa * 104729);
        System.Random _0xb754ead5 = new System.Random(_0xe6cd8527);
        _0xdd279fb7 _0x7f7e21a9 = null;
        for (int _0xc5be4f0c = 0; _0xc5be4f0c < MaxDraws; _0xc5be4f0c++)
        {
            _0x7f7e21a9 = this._0x78874c24(_0x3eb90840, _0xe6cd8527, _0xb754ead5);
            if (this._0xb6a5ecec(_0x7f7e21a9))
            {
                break;
            }

            _0x7f7e21a9 = null;
        }

        if (_0x7f7e21a9 == null)
        {
            _0x7f7e21a9 = this._0x2f72117f(_0x3eb90840, _0xe6cd8527);
        }

#if B_LOGS
        Debug.Log(_0x54f6a4b4._0x96824def(new byte[15] { 221, 244, 227, 231, 229, 242, 233, 244, 219, 166, 245, 227, 227, 226, 187 }, 134) + _0xe6cd8527 + _0x54f6a4b4._0x96824def(new byte[9] { 123, 41, 62, 58, 56, 47, 52, 41, 102 }, 91) + _0xb1fb4710 + _0x54f6a4b4._0x96824def(new byte[9] { 95, 30, 11, 11, 26, 18, 15, 11, 66 }, 127) + _0xf31986fa);
#endif
        return _0x7f7e21a9;
    }

    // Difficulty bands, one row per reactor: speed floor/ceiling per ring plus the
    // sector width each ring starts from. Counts come from the design, positions do not.
    private static readonly float[, ] _0xa816f3a9 =
    {
        {
            42f,
            58f,
            74f
        },
        {
            52f,
            70f,
            88f
        },
        {
            62f,
            82f,
            102f
        },
        {
            72f,
            94f,
            116f
        },
        {
            82f,
            106f,
            128f
        },
    };
    private const float MinSectorWidthDeg = 48f;
    public const int RingsPerReactor = 3;
    private _0xdd279fb7 _0x78874c24(int _0xa38bb462, int _0x9fcab075, System.Random _0x5cbe4fe6)
    {
        int[] _0x037fc0b4 =
        {
            0,
            1,
            2
        };
        for (int _0x7ee93882 = _0x037fc0b4.Length - 1; _0x7ee93882 > 0; _0x7ee93882--)
        {
            int _0x92dde0a0 = _0x5cbe4fe6.Next(_0x7ee93882 + 1);
            int _0xacc1bf95 = _0x037fc0b4[_0x7ee93882];
            _0x037fc0b4[_0x7ee93882] = _0x037fc0b4[_0x92dde0a0];
            _0x037fc0b4[_0x92dde0a0] = _0xacc1bf95;
        }

        _0xdd279fb7 _0xfb527002 = new _0xdd279fb7();
        _0xfb527002.Seed = _0x9fcab075;
        _0xfb527002.LockBonus = _0x36d68603[_0xa38bb462];
        _0xfb527002.Rings = new _0xdd279fb7._0x2faff3f3[RingsPerReactor];
        for (int _0xd1e8e8c6 = 0; _0xd1e8e8c6 < RingsPerReactor; _0xd1e8e8c6++)
        {
            _0xdd279fb7._0x2faff3f3 _0xd3eca83a = new _0xdd279fb7._0x2faff3f3();
            float _0x20d9d332 = _0xa816f3a9[_0xa38bb462, _0xd1e8e8c6];
            float _0xe131ef42 = _0x8f6558a9[_0xa38bb462, _0xd1e8e8c6];
            _0xd3eca83a.SpeedDegPerSecond = _0x20d9d332 + ((float)_0x5cbe4fe6.NextDouble() * (_0xe131ef42 - _0x20d9d332));
            _0xd3eca83a.SectorWidthDeg = _0x8ec1f713[_0xa38bb462, _0xd1e8e8c6] + (((float)_0x5cbe4fe6.NextDouble() * 16f) - 8f);
            _0xd3eca83a.SectorCenterDeg = (float)_0x5cbe4fe6.Next(0, 360);
            _0xd3eca83a.StartAngleDeg = (float)_0x5cbe4fe6.Next(0, 360);
            _0xd3eca83a.Direction = _0x5cbe4fe6.Next(2) == 0 ? 1 : -1;
            _0xd3eca83a.ChannelIndex = _0x037fc0b4[_0xd1e8e8c6];
            _0xfb527002.Rings[_0xd1e8e8c6] = _0xd3eca83a;
        }

        return _0xfb527002;
    }

    private static readonly int[] _0x36d68603 =
    {
        5,
        5,
        4,
        4,
        4
    };
    private const float MinSpeedGapDeg = 8f;
    private const float MinWindowSeconds = 0.35f;
    private const int MaxDraws = 20;
    private static readonly float[, ] _0x8ec1f713 =
    {
        {
            120f,
            104f,
            90f
        },
        {
            108f,
            92f,
            78f
        },
        {
            96f,
            82f,
            68f
        },
        {
            84f,
            72f,
            60f
        },
        {
            74f,
            62f,
            52f
        },
    };
}

internal static class _0x54f6a4b4
{
    internal static string _0x96824def(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}