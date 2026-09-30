using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// The game HUD, built as its own objects inside the template's default panel.
/// Nothing here reuses a template placeholder: the reactor counter, the energy
/// bar, the fault gutter, the channel bus and the tempo chips are all created by
/// this game and owned by it.
public sealed class _0x19ca4811
{
    private void _0x5131c178()
    {
        RectTransform _0x3ef632e7 = _0x90f57411.Node(this._0xdae3356f, _0xa06ba202._0x9e69412e(new byte[10] { 130, 179, 187, 166, 185, 149, 190, 191, 166, 165 }, 214), new Vector2(0.5f, 0f), new Vector2(0f, 500f), new Vector2(1160f, 130f));
        this._0x58a5abd4 = new Image[3];
        this._0x2b2ab1c9 = new TextMeshProUGUI[3];
        for (int _0xefd4dbf0 = 0; _0xefd4dbf0 < 3; _0xefd4dbf0++)
        {
            Image _0x8f700045 = _0x90f57411.Plate(_0x3ef632e7, _0xa06ba202._0x9e69412e(new byte[9] { 55, 6, 14, 19, 12, 32, 11, 10, 19 }, 99), new Vector2(0.5f, 0.5f), new Vector2((_0xefd4dbf0 - 1) * 384f, 0f), new Vector2(366f, 120f), this._0x8acceb20, _0x3d55b1de.WithAlpha(_0x3d55b1de.Surface, 0.95f));
            this._0x58a5abd4[_0xefd4dbf0] = _0x8f700045;
            this._0x2b2ab1c9[_0xefd4dbf0] = _0x90f57411.Caption(_0x8f700045.transform, _0xa06ba202._0x9e69412e(new byte[13] { 98, 83, 91, 70, 89, 117, 94, 95, 70, 98, 83, 78, 66 }, 54), new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(330f, 100f), _0xa06ba202._0x9e69412e(new byte[14] { 119, 108, 107, 98, 5, 20, 47, 21, 5, 97, 96, 98, 10, 118 }, 37), 32f, _0x3d55b1de.Channel(_0xefd4dbf0), TextAlignmentOptions.Center, this._0x9cc61552);
        }
    }

    private TextMeshProUGUI _0x176f1cb8;
    private const float TextLeft = 414f;
    private Image[] _0xc87b5e47;
    private const float GutterWidth = 240f;
    private TextMeshProUGUI[] _0x2b2ab1c9;
    private TextMeshProUGUI _0xdf9e5de0;
    private readonly Sprite _0x2d300b76;
    private readonly Sprite _0x0730f388;
    private TextMeshProUGUI _0x8f68e227;
    private readonly Sprite _0x7e91d23f;
    private Image[] _0x77c59186;
    public void _0xb7ad079d(string _0xfd2ed5d3)
    {
        if (this._0xf5c945ca == null || this._0x042954b7 == null)
        {
            return;
        }

        this._0x042954b7.text = _0xfd2ed5d3;
        this._0xf5c945ca.gameObject.SetActive(true);
        this._0xf5c945ca.transform.DOKill(true);
        this._0xf5c945ca.transform.localScale = Vector3.one * 0.86f;
        this._0xf5c945ca.transform.DOScale(1f, 0.28f).SetEase(Ease.OutBack);
    }

    private const float GutterCentre = 150f;
    public Button _0x4b131100 { get; private set; }

    private readonly Sprite _0x8acceb20;
    public const int EnergyCells = 15;
    public void _0xd81f3721(bool _0x1f7a7528)
    {
        if (this._0xdae3356f != null)
        {
            this._0xdae3356f.gameObject.SetActive(_0x1f7a7528);
        }
    }

    public void _0xfbba1cb1(int _0xd938b41f, int _0xf7611023)
    {
        if (this._0x8f68e227 != null)
        {
            this._0x8f68e227.text = _0xa06ba202._0x9e69412e(new byte[8] { 188, 171, 175, 173, 186, 161, 188, 206 }, 238) + (_0xd938b41f + 1) + _0xa06ba202._0x9e69412e(new byte[4] { 104, 7, 14, 104 }, 72) + _0xf7611023;
        }
    }

    private RectTransform _0xdae3356f;
    private TextMeshProUGUI _0xf5bf7eeb;
    public _0x19ca4811(TMP_FontAsset _0x21622bab, Sprite _0xb1ee591d, Sprite _0x53069d2d, Sprite _0xd7855a08, Sprite _0xad17df00)
    {
        this._0x9cc61552 = _0x21622bab;
        this._0x8acceb20 = _0xb1ee591d;
        this._0x2d300b76 = _0x53069d2d;
        this._0x7e91d23f = _0xd7855a08;
        this._0x0730f388 = _0xad17df00;
    }

    public RectTransform _0xd6d4dd28
    {
        get
        {
            return this._0xdae3356f;
        }
    }

    private readonly TMP_FontAsset _0x9cc61552;
    /// Fault pips and the limit texts live in two horizontal lanes that never share
    /// x space: the gutter ends at GutterCentre + GutterWidth / 2 and the text
    /// column starts well to the right of it.
    private void _0x9956c2f5()
    {
        RectTransform _0x774e6ce0 = _0x90f57411.Node(this._0xdae3356f, _0xa06ba202._0x9e69412e(new byte[8] { 75, 110, 106, 110, 115, 85, 104, 112 }, 7), new Vector2(0.5f, 1f), new Vector2(0f, -452f), new Vector2(1080f, 70f));
        this._0xe7220caa = new Image[3];
        for (int _0x7f069a01 = 0; _0x7f069a01 < this._0xe7220caa.Length; _0x7f069a01++)
        {
            this._0xe7220caa[_0x7f069a01] = _0x90f57411.Plate(_0x774e6ce0, _0xa06ba202._0x9e69412e(new byte[8] { 98, 69, 81, 72, 80, 116, 77, 84 }, 36), new Vector2(0f, 0.5f), new Vector2((GutterCentre - (GutterWidth * 0.5f)) + 30f + (_0x7f069a01 * 78f), 0f), new Vector2(52f, 52f), this._0x7e91d23f, _0x3d55b1de.WithAlpha(_0x3d55b1de.SurfaceEdge, 0.9f));
        }

        this._0x176f1cb8 = _0x90f57411.Caption(_0x774e6ce0, _0xa06ba202._0x9e69412e(new byte[10] { 22, 49, 37, 60, 36, 6, 49, 60, 37, 53 }, 80), new Vector2(0f, 0.5f), new Vector2(TextLeft + 170f, 0f), new Vector2(340f, 60f), _0xa06ba202._0x9e69412e(new byte[13] { 98, 101, 113, 104, 112, 119, 4, 20, 4, 107, 98, 4, 23 }, 36), 30f, _0x3d55b1de.Muted, TextAlignmentOptions.Left, this._0x9cc61552);
        this._0xf5bf7eeb = _0x90f57411.Caption(_0x774e6ce0, _0xa06ba202._0x9e69412e(new byte[9] { 182, 149, 153, 145, 172, 155, 150, 143, 159 }, 250), new Vector2(1f, 0.5f), new Vector2(-40f, 0f), new Vector2(420f, 64f), _0xa06ba202._0x9e69412e(new byte[13] { 149, 150, 154, 146, 138, 249, 149, 156, 159, 141, 249, 235, 235 }, 217), 34f, _0x3d55b1de.Gold, TextAlignmentOptions.Right, this._0x9cc61552);
    }

    private Image[] _0x58a5abd4;
    public void _0x96646382(int _0x42bbb75c, int _0x0fc2f658, float _0x31eb2fe6, bool _0x37297798, Color _0x5a1bc3ef)
    {
        if (this._0x2b2ab1c9 == null || _0x42bbb75c < 0 || _0x42bbb75c >= this._0x2b2ab1c9.Length)
        {
            return;
        }

        string _0x3c60db0c = _0x37297798 ? _0xa06ba202._0x9e69412e(new byte[6] { 248, 251, 247, 255, 241, 240 }, 180) : Mathf.RoundToInt(_0x31eb2fe6) + _0xa06ba202._0x9e69412e(new byte[6] { 88, 60, 61, 63, 87, 43 }, 120);
        this._0x2b2ab1c9[_0x42bbb75c].text = _0xa06ba202._0x9e69412e(new byte[5] { 202, 209, 214, 223, 184 }, 152) + _0x0fc2f658 + _0xa06ba202._0x9e69412e(new byte[1] { 140 }, 134) + _0x3c60db0c;
        _0xe064bb1a.ApplyOutline(this._0x2b2ab1c9[_0x42bbb75c], _0x37297798 ? _0x3d55b1de.Muted : _0x5a1bc3ef);
        if (this._0x58a5abd4 != null && this._0x58a5abd4[_0x42bbb75c] != null)
        {
            this._0x58a5abd4[_0x42bbb75c].color = _0x37297798 ? _0x3d55b1de.WithAlpha(_0x3d55b1de.Surface, 0.55f) : _0x3d55b1de.WithAlpha(_0x3d55b1de.Surface, 0.95f);
        }
    }

    public Image _0x99cbb9a4 { get; private set; }

    public void _0xcc27412c(int _0x23111c0b)
    {
        if (this._0x77c59186 != null)
        {
            for (int _0xd60d21fd = 0; _0xd60d21fd < this._0x77c59186.Length; _0xd60d21fd++)
            {
                bool _0x71a33cd9 = _0xd60d21fd < _0x23111c0b;
                float _0x318d3d77 = this._0x77c59186.Length > 1 ? (float)_0xd60d21fd / (this._0x77c59186.Length - 1) : 0f;
                this._0x77c59186[_0xd60d21fd].color = _0x71a33cd9 ? Color.Lerp(_0x3d55b1de.Teal, _0x3d55b1de.Gold, _0x318d3d77) : _0x3d55b1de.WithAlpha(_0x3d55b1de.SurfaceEdge, 0.65f);
            }
        }

        int _0x10f1ca8c = Mathf.RoundToInt(100f * _0x23111c0b / EnergyCells);
        if (this._0xdf9e5de0 != null)
        {
            this._0xdf9e5de0.text = _0xa06ba202._0x9e69412e(new byte[7] { 47, 36, 47, 56, 45, 51, 74 }, 106) + _0x10f1ca8c + _0xa06ba202._0x9e69412e(new byte[1] { 128 }, 165);
        }
    }

    private void _0xca89ae2d()
    {
        RectTransform _0x90e75f1f = _0x90f57411.Node(this._0xdae3356f, _0xa06ba202._0x9e69412e(new byte[9] { 2, 41, 34, 53, 32, 62, 21, 40, 48 }, 71), new Vector2(0.5f, 1f), new Vector2(0f, -352f), new Vector2(1080f, 60f));
        _0x90f57411.Plate(_0x90e75f1f, _0xa06ba202._0x9e69412e(new byte[11] { 51, 24, 19, 4, 17, 15, 34, 4, 23, 21, 29 }, 118), new Vector2(0f, 0.5f), new Vector2(450f, 0f), new Vector2(900f, 44f), this._0x8acceb20, _0x3d55b1de.WithAlpha(_0x3d55b1de.SurfaceEdge, 0.9f));
        this._0x77c59186 = new Image[EnergyCells];
        float _0x6e87b6e3 = 860f / EnergyCells;
        for (int _0x3ed17197 = 0; _0x3ed17197 < EnergyCells; _0x3ed17197++)
        {
            Image _0x898062d6 = _0x90f57411.Plate(_0x90e75f1f, _0xa06ba202._0x9e69412e(new byte[10] { 25, 50, 57, 46, 59, 37, 31, 57, 48, 48 }, 92), new Vector2(0f, 0.5f), new Vector2(30f + (_0x6e87b6e3 * (_0x3ed17197 + 0.5f)), 0f), new Vector2(_0x6e87b6e3 - 8f, 30f), this._0x2d300b76, _0x3d55b1de.WithAlpha(_0x3d55b1de.SurfaceEdge, 0.65f));
            this._0x77c59186[_0x3ed17197] = _0x898062d6;
        }

        this._0xdf9e5de0 = _0x90f57411.Caption(_0x90e75f1f, _0xa06ba202._0x9e69412e(new byte[11] { 87, 124, 119, 96, 117, 107, 68, 115, 126, 103, 119 }, 18), new Vector2(1f, 0.5f), new Vector2(-40f, 0f), new Vector2(300f, 56f), _0xa06ba202._0x9e69412e(new byte[9] { 241, 250, 241, 230, 243, 237, 148, 132, 145 }, 180), 30f, _0x3d55b1de.Teal, TextAlignmentOptions.Right, this._0x9cc61552);
    }

    public void _0x04e59da5(int _0x7dac0830, int _0xf289db29, int _0x837cb7b6)
    {
        if (this._0xe7220caa != null)
        {
            for (int _0x37c8829d = 0; _0x37c8829d < this._0xe7220caa.Length; _0x37c8829d++)
            {
                bool _0x0e1dd402 = _0x37c8829d < _0x7dac0830;
                this._0xe7220caa[_0x37c8829d].color = _0x0e1dd402 ? _0x3d55b1de.Alert : _0x3d55b1de.WithAlpha(_0x3d55b1de.SurfaceEdge, 0.9f);
                if (_0x0e1dd402)
                {
                    this._0xe7220caa[_0x37c8829d].transform.DOKill(true);
                    this._0xe7220caa[_0x37c8829d].transform.DOPunchScale(Vector3.one * 0.18f, 0.28f, 8, 0.8f);
                }
            }
        }

        if (this._0x176f1cb8 != null)
        {
            this._0x176f1cb8.text = _0xa06ba202._0x9e69412e(new byte[7] { 96, 103, 115, 106, 114, 117, 6 }, 38) + _0x7dac0830 + _0xa06ba202._0x9e69412e(new byte[4] { 15, 96, 105, 15 }, 47) + _0xf289db29;
        }

        if (this._0xf5bf7eeb != null)
        {
            this._0xf5bf7eeb.text = _0xa06ba202._0x9e69412e(new byte[11] { 188, 191, 179, 187, 163, 208, 188, 181, 182, 164, 208 }, 240) + _0x837cb7b6;
        }
    }

    public void _0x78c4c88f(int _0xcd6f0839, bool _0xee326416, Color _0x233b4e4d)
    {
        if (this._0xc87b5e47 == null || _0xcd6f0839 < 0 || _0xcd6f0839 >= this._0xc87b5e47.Length)
        {
            return;
        }

        Image _0xcffe5045 = this._0xc87b5e47[_0xcd6f0839];
        _0xcffe5045.DOKill(true);
        if (_0xee326416)
        {
            _0xcffe5045.color = _0x3d55b1de.WithAlpha(_0x233b4e4d, 0.25f);
            _0xcffe5045.DOFade(1f, 0.25f);
        }
        else
        {
            _0xcffe5045.color = _0x3d55b1de.WithAlpha(_0x3d55b1de.SurfaceEdge, 0.9f);
        }
    }

    private void _0x1f861a3d()
    {
        RectTransform _0x9b7cb00b = _0x90f57411.Node(this._0xdae3356f, _0xa06ba202._0x9e69412e(new byte[10] { 37, 14, 7, 8, 8, 3, 10, 36, 19, 21 }, 102), new Vector2(0.5f, 0f), new Vector2(0f, 612f), new Vector2(1080f, 40f));
        this._0xc87b5e47 = new Image[3];
        for (int _0x824a75a6 = 0; _0x824a75a6 < this._0xc87b5e47.Length; _0x824a75a6++)
        {
            this._0xc87b5e47[_0x824a75a6] = _0x90f57411.Plate(_0x9b7cb00b, _0xa06ba202._0x9e69412e(new byte[10] { 55, 28, 21, 26, 26, 17, 24, 54, 21, 6 }, 116), new Vector2(0.5f, 0.5f), new Vector2((_0x824a75a6 - 1) * 320f, 0f), new Vector2(300f, 26f), this._0x0730f388, _0x3d55b1de.WithAlpha(_0x3d55b1de.SurfaceEdge, 0.9f));
        }
    }

    private Image[] _0xe7220caa;
    public void _0x89df6a81(Transform _0x18fa142d, Sprite _0x91e4effa, Sprite _0xbde0149f)
    {
        this._0xdae3356f = _0x90f57411.Stretch(_0x18fa142d, _0xa06ba202._0x9e69412e(new byte[10] { 141, 186, 190, 188, 171, 176, 173, 151, 170, 187 }, 223));
        // The tap surface is the FIRST child, so every control built afterwards is
        // drawn on top of it and wins the raycast.
        this._0x99cbb9a4 = _0x90f57411.TapSurface(this._0xdae3356f, _0xa06ba202._0x9e69412e(new byte[11] { 138, 169, 165, 173, 146, 167, 182, 156, 169, 168, 163 }, 198));
        this._0x348cbe99 = _0x90f57411.IconAction(this._0xdae3356f, _0xa06ba202._0x9e69412e(new byte[8] { 46, 13, 15, 7, 63, 0, 3, 24 }, 108), new Vector2(0.5f, 1f), new Vector2(-490f, -148f), 116f, this._0x8acceb20, _0x3d55b1de.WithAlpha(_0x3d55b1de.Surface, 0.95f), _0x91e4effa, _0x3d55b1de.Cream);
        this._0x4b131100 = _0x90f57411.IconAction(this._0xdae3356f, _0xa06ba202._0x9e69412e(new byte[9] { 181, 132, 144, 150, 128, 182, 137, 138, 145 }, 229), new Vector2(0.5f, 1f), new Vector2(490f, -148f), 116f, this._0x8acceb20, _0x3d55b1de.WithAlpha(_0x3d55b1de.Surface, 0.95f), _0xbde0149f, _0x3d55b1de.Cream);
        this._0x8f68e227 = _0x90f57411.Caption(this._0xdae3356f, _0xa06ba202._0x9e69412e(new byte[14] { 141, 186, 190, 188, 171, 176, 173, 156, 176, 170, 177, 171, 186, 173 }, 223), new Vector2(0.5f, 1f), new Vector2(0f, -148f), new Vector2(640f, 74f), _0xa06ba202._0x9e69412e(new byte[14] { 112, 103, 99, 97, 118, 109, 112, 2, 19, 2, 109, 100, 2, 23 }, 34), 40f, _0x3d55b1de.Cream, TextAlignmentOptions.Center, this._0x9cc61552);
        this._0xca89ae2d();
        this._0x9956c2f5();
        this._0x1f861a3d();
        this._0x5131c178();
        _0x90f57411.Caption(this._0xdae3356f, _0xa06ba202._0x9e69412e(new byte[11] { 51, 31, 30, 4, 2, 31, 28, 56, 25, 30, 4 }, 112), new Vector2(0.5f, 0f), new Vector2(0f, 128f), new Vector2(980f, 60f), _0xa06ba202._0x9e69412e(new byte[36] { 18, 7, 22, 102, 7, 8, 31, 17, 14, 3, 20, 3, 102, 18, 9, 102, 10, 9, 5, 13, 102, 18, 14, 3, 102, 7, 5, 18, 15, 16, 3, 102, 20, 15, 8, 1 }, 70), 30f, _0x3d55b1de.WithAlpha(_0x3d55b1de.Cream, 0.88f), TextAlignmentOptions.Center, this._0x9cc61552);
        this._0xf5c945ca = _0x90f57411.Plate(this._0xdae3356f, _0xa06ba202._0x9e69412e(new byte[12] { 163, 132, 145, 132, 133, 131, 178, 145, 158, 158, 149, 130 }, 240), new Vector2(0.5f, 0.5f), new Vector2(0f, 520f), new Vector2(760f, 120f), this._0x8acceb20, _0x3d55b1de.WithAlpha(_0x3d55b1de.Surface, 0.94f));
        this._0x042954b7 = _0x90f57411.Caption(this._0xf5c945ca.transform, _0xa06ba202._0x9e69412e(new byte[16] { 96, 71, 82, 71, 70, 64, 113, 82, 93, 93, 86, 65, 103, 86, 75, 71 }, 51), new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(700f, 90f), _0xa06ba202._0x9e69412e(new byte[14] { 45, 58, 62, 60, 43, 48, 45, 95, 44, 43, 62, 61, 51, 58 }, 127), 46f, _0x3d55b1de.Gold, TextAlignmentOptions.Center, this._0x9cc61552);
        this._0xf5c945ca.gameObject.SetActive(false);
    }

    private TextMeshProUGUI _0x042954b7;
    private Image _0xf5c945ca;
    public void _0xfe7df36a()
    {
        if (this._0xf5c945ca != null)
        {
            this._0xf5c945ca.gameObject.SetActive(false);
        }
    }

    public Button _0x348cbe99 { get; private set; }
}

internal static class _0xa06ba202
{
    internal static string _0x9e69412e(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}