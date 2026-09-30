using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// Owns the three result cards. The template pops ship with another game's wording,
/// a grey card and a close button whose icon sprite is missing (which Unity draws
/// as a white square), so every child of the pop body is switched off and this game
/// builds its own card inside it - header, body, reward line, captioned buttons and
/// a real close glyph from a serialized sprite.
public sealed class _0x82bed0d9 : MonoBehaviour
{
    [SerializeField]
    private Sprite _plateSprite;
    [SerializeField]
    private Sprite _closeIcon;
    public void _0x12a08ad7()
    {
        if (this._0x0d2ba51e)
        {
            return;
        }

        _0xef80cd9f _0x061b013b = _0xef80cd9f.Instance;
        if (_0x061b013b == null || _0x061b013b.Pops == null)
        {
            return;
        }

        _0x72c4d902 _0xacc21f7d = _0xef80cd9f.Instance._0x35b7272f(_0x879a7ea3._0xd10e2316.WIN);
        _0x72c4d902 _0xf156d937 = _0xef80cd9f.Instance._0x35b7272f(_0x879a7ea3._0xd10e2316.LOSE);
        _0x72c4d902 _0x7b7507d7 = _0xef80cd9f.Instance._0x35b7272f(_0x879a7ea3._0xd10e2316.PAUSE);
        this._0xbc859630(_0xacc21f7d, 0, _0x38e2870d._0xe12e1f4d(new byte[11] { 152, 141, 150, 155, 255, 144, 145, 147, 150, 145, 154 }, 223), _0x38e2870d._0xe12e1f4d(new byte[9] { 228, 227, 248, 150, 247, 241, 247, 255, 248 }, 182), _0x38e2870d._0xe12e1f4d(new byte[4] { 79, 71, 76, 87 }, 2));
        this._0xbc859630(_0xf156d937, 1, _0x38e2870d._0xe12e1f4d(new byte[8] { 100, 108, 101, 125, 109, 102, 126, 103 }, 41), _0x38e2870d._0xe12e1f4d(new byte[5] { 211, 196, 213, 211, 216 }, 129), _0x38e2870d._0xe12e1f4d(new byte[4] { 169, 161, 170, 177 }, 228));
        this._0xbc859630(_0x7b7507d7, 2, _0x38e2870d._0xe12e1f4d(new byte[11] { 45, 39, 45, 42, 59, 51, 94, 54, 49, 50, 58 }, 126), _0x38e2870d._0xe12e1f4d(new byte[6] { 31, 8, 30, 24, 0, 8 }, 77), _0x38e2870d._0xe12e1f4d(new byte[4] { 144, 152, 147, 136 }, 221));
        this._0x0d2ba51e = true;
    }

    public void _0x87cf28b0(int _0x4af1368f, int _0x0a282704, int _0x00605a9e, int _0x80a775b3)
    {
        this._0x98ea5b1c(1, _0x38e2870d._0xe12e1f4d(new byte[9] { 174, 185, 189, 191, 168, 179, 174, 175, 220 }, 252) + _0x4af1368f + _0x38e2870d._0xe12e1f4d(new byte[4] { 227, 140, 133, 227 }, 195) + _0x0a282704 + _0x38e2870d._0xe12e1f4d(new byte[12] { 133, 136, 133, 228, 230, 230, 240, 247, 228, 230, 252, 133 }, 165) + _0x00605a9e + _0x38e2870d._0xe12e1f4d(new byte[1] { 109 }, 72), _0x38e2870d._0xe12e1f4d(new byte[15] { 16, 23, 1, 6, 114, 1, 6, 19, 16, 27, 30, 27, 6, 11, 114 }, 82) + _0x80a775b3 + _0x38e2870d._0xe12e1f4d(new byte[1] { 66 }, 103));
    }

    private readonly Button[] _0x7fc318fc = new Button[3];
    public Button _0xfd4ebf24
    {
        get
        {
            return this._0x7fbc1a49[2];
        }
    }

    private readonly TextMeshProUGUI[] _0xf696f21f = new TextMeshProUGUI[3];
    public Button _0xc944a03a
    {
        get
        {
            return this._0x90390fcb[0];
        }
    }

    public void _0xbc5889fb(int _0x57484aa3, int _0x2676f16f, int _0xb1dfc28d)
    {
        this._0x98ea5b1c(0, _0x38e2870d._0xe12e1f4d(new byte[10] { 124, 123, 110, 109, 102, 99, 102, 123, 118, 15 }, 47) + _0x57484aa3 + _0x38e2870d._0xe12e1f4d(new byte[13] { 108, 105, 100, 105, 8, 10, 10, 28, 27, 8, 10, 16, 105 }, 73) + _0x2676f16f + _0x38e2870d._0xe12e1f4d(new byte[1] { 120 }, 93), _0x38e2870d._0xe12e1f4d(new byte[8] { 249, 242, 251, 232, 253, 255, 154, 145 }, 186) + _0xb1dfc28d);
    }

    public Button _0xbd80b1b2
    {
        get
        {
            return this._0x90390fcb[1];
        }
    }

    public void _0x9dc63bb9()
    {
        _0x72c4d902 _0x4bda27b6 = _0xef80cd9f.Instance._0x35b7272f(_0x879a7ea3._0xd10e2316.PAUSE);
        if (_0x4bda27b6 == null)
        {
            return;
        }

        _0xef80cd9f.Instance._0x07905ed2(_0x879a7ea3._0xd10e2316.PAUSE);
    }

    public void _0x41bdcd5d(int _0x399caa5a, int _0x128bb544, int _0xbc3e6a14)
    {
        this._0x98ea5b1c(2, _0x38e2870d._0xe12e1f4d(new byte[8] { 225, 246, 242, 240, 231, 252, 225, 147 }, 179) + (_0x399caa5a + 1) + _0x38e2870d._0xe12e1f4d(new byte[4] { 218, 181, 188, 218 }, 250) + _0x128bb544, _0x38e2870d._0xe12e1f4d(new byte[11] { 233, 234, 230, 238, 246, 133, 233, 224, 227, 241, 133 }, 165) + _0xbc3e6a14);
    }

    private readonly Button[] _0x7fbc1a49 = new Button[3];
    public Button _0xf85db073
    {
        get
        {
            return this._0x7fbc1a49[1];
        }
    }

    public void _0x2deb75df()
    {
        _0x72c4d902 _0xa603892f = _0xef80cd9f.Instance._0x35b7272f(_0x879a7ea3._0xd10e2316.WIN);
        if (_0xa603892f == null)
        {
            return;
        }

        _0xef80cd9f.Instance._0x07905ed2(_0x879a7ea3._0xd10e2316.WIN);
    }

    public Button _0x4d70b547
    {
        get
        {
            return this._0x7fc318fc[2];
        }
    }

    private bool _0x0d2ba51e;
    [SerializeField]
    private TMP_FontAsset _font;
    public Button _0x9dfb7d7c
    {
        get
        {
            return this._0x7fbc1a49[0];
        }
    }

    public void _0x86ba9580()
    {
        _0xef80cd9f _0x0e330af3 = _0xef80cd9f.Instance;
        if (_0x0e330af3 != null)
        {
            _0x0e330af3._0x0b941a8b();
        }
    }

    private readonly Button[] _0x90390fcb = new Button[3];
    public Button _0x160300b6
    {
        get
        {
            return this._0x90390fcb[2];
        }
    }

    public void _0x94374b89()
    {
        _0x72c4d902 _0x1edd911c = _0xef80cd9f.Instance._0x35b7272f(_0x879a7ea3._0xd10e2316.LOSE);
        if (_0x1edd911c == null)
        {
            return;
        }

        _0xef80cd9f.Instance._0x07905ed2(_0x879a7ea3._0xd10e2316.LOSE);
    }

    private void _0x98ea5b1c(int _0x4175b6e8, string _0x490f6919, string _0x61ca5222)
    {
        if (this._0xf696f21f[_0x4175b6e8] != null)
        {
            this._0xf696f21f[_0x4175b6e8].text = _0x490f6919;
        }

        if (this._0xcc6b2760[_0x4175b6e8] != null)
        {
            this._0xcc6b2760[_0x4175b6e8].text = _0x61ca5222;
        }
    }

    public Button _0x1183bd37
    {
        get
        {
            return this._0x7fc318fc[1];
        }
    }

    private readonly TextMeshProUGUI[] _0xb133ccc4 = new TextMeshProUGUI[3];
    /// Builds one card. The template's own chrome inside the pop body - its BOT_BTNS
    /// row and its TOP_BTNS close button - is switched off first, so the panel ends
    /// up with ONE consistent set of controls instead of two overlapping ones.
    private void _0xbc859630(_0x72c4d902 _0x8aebd62b, int _0x55a1f230, string _0xc4df384c, string _0x8d0d0cf3, string _0x7d7e612b)
    {
        if (_0x8aebd62b == null || _0x8aebd62b.Content == null)
        {
            return;
        }

        Transform _0x35a46623 = _0x8aebd62b.Content.transform;
        for (int _0x322d2d6a = _0x35a46623.childCount - 1; _0x322d2d6a >= 0; _0x322d2d6a--)
        {
            _0x35a46623.GetChild(_0x322d2d6a).gameObject.SetActive(false);
        }

        RectTransform _0xfacafd42 = _0x90f57411.Stretch(_0x35a46623, _0x38e2870d._0xe12e1f4d(new byte[10] { 205, 250, 236, 234, 243, 235, 215, 240, 236, 235 }, 159));
        Image _0x013a4f35 = _0x90f57411.Plate(_0xfacafd42, _0x38e2870d._0xe12e1f4d(new byte[10] { 22, 33, 55, 49, 40, 48, 7, 37, 54, 32 }, 68), new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(1000f, 1200f), this._plateSprite, _0x3d55b1de.WithAlpha(_0x3d55b1de.Surface, 0.98f));
        _0x90f57411.Picture(_0x013a4f35.transform, _0x38e2870d._0xe12e1f4d(new byte[10] { 26, 45, 59, 61, 36, 60, 15, 36, 39, 63 }, 72), new Vector2(0.5f, 1f), new Vector2(0f, -330f), new Vector2(330f, 330f), this._burstSprite, _0x3d55b1de.WithAlpha(_0x3d55b1de.Gold, 0.5f));
        _0x90f57411.Picture(_0x013a4f35.transform, _0x38e2870d._0xe12e1f4d(new byte[10] { 172, 155, 141, 139, 146, 138, 189, 145, 140, 155 }, 254), new Vector2(0.5f, 1f), new Vector2(0f, -330f), new Vector2(240f, 240f), this._coreSprite, _0x3d55b1de.Cream);
        this._0xb133ccc4[_0x55a1f230] = _0x90f57411.Caption(_0x013a4f35.transform, _0x38e2870d._0xe12e1f4d(new byte[12] { 199, 240, 230, 224, 249, 225, 221, 240, 244, 241, 240, 231 }, 149), new Vector2(0.5f, 1f), new Vector2(0f, -140f), new Vector2(860f, 110f), _0xc4df384c, 62f, _0x3d55b1de.Cream, TextAlignmentOptions.Center, this._font);
        this._0xf696f21f[_0x55a1f230] = _0x90f57411.Caption(_0x013a4f35.transform, _0x38e2870d._0xe12e1f4d(new byte[10] { 64, 119, 97, 103, 126, 102, 80, 125, 118, 107 }, 18), new Vector2(0.5f, 1f), new Vector2(0f, -560f), new Vector2(880f, 90f), _0x38e2870d._0xe12e1f4d(new byte[12] { 78, 73, 92, 95, 84, 81, 84, 73, 68, 61, 45, 56 }, 29), 40f, _0x3d55b1de.Teal, TextAlignmentOptions.Center, this._font);
        this._0xcc6b2760[_0x55a1f230] = _0x90f57411.Caption(_0x013a4f35.transform, _0x38e2870d._0xe12e1f4d(new byte[12] { 178, 133, 147, 149, 140, 148, 163, 136, 129, 146, 135, 133 }, 224), new Vector2(0.5f, 1f), new Vector2(0f, -670f), new Vector2(880f, 80f), _0x38e2870d._0xe12e1f4d(new byte[8] { 41, 34, 43, 56, 45, 47, 74, 90 }, 106), 36f, _0x3d55b1de.Gold, TextAlignmentOptions.Center, this._font);
        this._0x7fc318fc[_0x55a1f230] = _0x90f57411.Action(_0x013a4f35.transform, _0x38e2870d._0xe12e1f4d(new byte[13] { 43, 28, 10, 12, 21, 13, 41, 11, 16, 20, 24, 11, 0 }, 121), new Vector2(0.5f, 0f), new Vector2(-250f, 140f), new Vector2(430f, 140f), this._plateSprite, _0x3d55b1de.Teal, _0x8d0d0cf3, 42f, _0x3d55b1de.Ink, this._font);
        this._0x7fbc1a49[_0x55a1f230] = _0x90f57411.Action(_0x013a4f35.transform, _0x38e2870d._0xe12e1f4d(new byte[15] { 188, 139, 157, 155, 130, 154, 189, 139, 141, 129, 128, 138, 143, 156, 151 }, 238), new Vector2(0.5f, 0f), new Vector2(250f, 140f), new Vector2(430f, 140f), this._plateSprite, _0x3d55b1de.Violet, _0x7d7e612b, 42f, _0x3d55b1de.Cream, this._font);
        this._0x90390fcb[_0x55a1f230] = _0x90f57411.IconAction(_0x013a4f35.transform, _0x38e2870d._0xe12e1f4d(new byte[11] { 162, 149, 131, 133, 156, 132, 179, 156, 159, 131, 149 }, 240), new Vector2(1f, 1f), new Vector2(-82f, -82f), 96f, this._plateSprite, _0x3d55b1de.WithAlpha(_0x3d55b1de.SurfaceEdge, 0.95f), this._closeIcon, _0x3d55b1de.Cream);
        _0x013a4f35.transform.localScale = Vector3.one;
    }

    private readonly TextMeshProUGUI[] _0xcc6b2760 = new TextMeshProUGUI[3];
    public Button _0xd5bdf65e
    {
        get
        {
            return this._0x7fc318fc[0];
        }
    }

    [SerializeField]
    private Sprite _burstSprite;
    [SerializeField]
    private Sprite _coreSprite;
}

internal static class _0x38e2870d
{
    internal static string _0xe12e1f4d(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}