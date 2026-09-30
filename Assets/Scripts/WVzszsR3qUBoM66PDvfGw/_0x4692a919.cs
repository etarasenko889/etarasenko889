using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// Menu settings sheet. Three rows, all of which change something the player can
/// SEE straight away: haptics confirm with a pulse, assist changes the width of the
/// lit sector in the preview, and resetting progress redraws the reactor strip.
/// There is no sound row: this game has no audio at all.
public sealed class _0x4692a919
{
    public _0x4692a919(TMP_FontAsset _0x3bb7220a, Sprite _0x4b501edb)
    {
        this._0xa0e32758 = _0x3bb7220a;
        this._0x7adc578d = _0x4b501edb;
    }

    public Button _0x08ce9546 { get; private set; }
    public Button _0x59c045f0 { get; private set; }

    public void _0xf413ba30(Transform _0x16008698, Sprite _0x16f7698c)
    {
        this._0xfffffd8a = _0x90f57411.Stretch(_0x16008698, _0x6fbe1bec._0xea09fe31(new byte[13] { 87, 97, 112, 112, 109, 106, 99, 119, 87, 108, 97, 97, 112 }, 4));
        Image _0xe723e6e0 = this._0xfffffd8a.gameObject.AddComponent<Image>();
        _0xe723e6e0.color = _0x3d55b1de.WithAlpha(_0x3d55b1de.Base, 0.9f);
        _0xe723e6e0.raycastTarget = true;
        _0xe723e6e0.canvasRenderer.cullTransparentMesh = false;
        Image _0x18c01883 = _0x90f57411.Plate(this._0xfffffd8a, _0x6fbe1bec._0xea09fe31(new byte[12] { 87, 97, 112, 112, 109, 106, 99, 119, 71, 101, 118, 96 }, 4), new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(1000f, 1020f), this._0x7adc578d, _0x3d55b1de.WithAlpha(_0x3d55b1de.Surface, 0.97f));
        _0x90f57411.Caption(_0x18c01883.transform, _0x6fbe1bec._0xea09fe31(new byte[13] { 158, 168, 185, 185, 164, 163, 170, 190, 153, 164, 185, 161, 168 }, 205), new Vector2(0.5f, 1f), new Vector2(0f, -110f), new Vector2(800f, 90f), _0x6fbe1bec._0xea09fe31(new byte[13] { 39, 43, 42, 48, 54, 43, 40, 68, 52, 37, 42, 33, 40 }, 100), 52f, _0x3d55b1de.Cream, TextAlignmentOptions.Center, this._0xa0e32758);
        this._0x59c045f0 = _0x90f57411.Action(_0x18c01883.transform, _0x6fbe1bec._0xea09fe31(new byte[10] { 237, 196, 213, 209, 204, 198, 214, 247, 202, 210 }, 165), new Vector2(0.5f, 1f), new Vector2(0f, -280f), new Vector2(840f, 132f), this._0x7adc578d, _0x3d55b1de.Violet, string.Empty, 36f, _0x3d55b1de.Cream, this._0xa0e32758);
        this._0x3a860f3e = this._0x59c045f0.targetGraphic as Image;
        this._0x5a65f28e = _0x90f57411.Caption(this._0x59c045f0.transform, _0x6fbe1bec._0xea09fe31(new byte[11] { 235, 194, 211, 215, 202, 192, 208, 247, 198, 219, 215 }, 163), new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(780f, 100f), _0x6fbe1bec._0xea09fe31(new byte[10] { 97, 104, 121, 125, 96, 106, 122, 9, 102, 103 }, 41), 38f, _0x3d55b1de.Cream, TextAlignmentOptions.Center, this._0xa0e32758);
        this._0x413b3f27 = _0x90f57411.Action(_0x18c01883.transform, _0x6fbe1bec._0xea09fe31(new byte[9] { 127, 77, 77, 87, 77, 74, 108, 81, 73 }, 62), new Vector2(0.5f, 1f), new Vector2(0f, -440f), new Vector2(840f, 132f), this._0x7adc578d, _0x3d55b1de.Violet, string.Empty, 36f, _0x3d55b1de.Cream, this._0xa0e32758);
        this._0x5b120be6 = this._0x413b3f27.targetGraphic as Image;
        this._0x0b20e864 = _0x90f57411.Caption(this._0x413b3f27.transform, _0x6fbe1bec._0xea09fe31(new byte[10] { 142, 188, 188, 166, 188, 187, 155, 170, 183, 187 }, 207), new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(780f, 100f), _0x6fbe1bec._0xea09fe31(new byte[9] { 198, 212, 212, 206, 212, 211, 167, 200, 201 }, 135), 38f, _0x3d55b1de.Cream, TextAlignmentOptions.Center, this._0xa0e32758);
        this._0x6b92368f = _0x90f57411.Action(_0x18c01883.transform, _0x6fbe1bec._0xea09fe31(new byte[8] { 114, 69, 83, 69, 84, 114, 79, 87 }, 32), new Vector2(0.5f, 1f), new Vector2(0f, -600f), new Vector2(840f, 132f), this._0x7adc578d, _0x3d55b1de.Alert, _0x6fbe1bec._0xea09fe31(new byte[14] { 90, 77, 91, 77, 92, 40, 88, 90, 71, 79, 90, 77, 91, 91 }, 8), 38f, _0x3d55b1de.Cream, this._0xa0e32758);
        _0x90f57411.Caption(_0x18c01883.transform, _0x6fbe1bec._0xea09fe31(new byte[12] { 150, 160, 177, 177, 172, 171, 162, 182, 139, 170, 177, 160 }, 197), new Vector2(0.5f, 0f), new Vector2(0f, 160f), new Vector2(860f, 120f), _0x6fbe1bec._0xea09fe31(new byte[64] { 160, 178, 178, 168, 178, 181, 193, 182, 168, 165, 164, 175, 178, 193, 181, 169, 164, 193, 167, 168, 179, 178, 181, 193, 179, 164, 160, 162, 181, 174, 179, 235, 178, 164, 162, 181, 174, 179, 193, 182, 169, 168, 173, 164, 193, 184, 174, 180, 193, 173, 164, 160, 179, 175, 193, 181, 169, 164, 193, 181, 164, 172, 177, 174 }, 225), 30f, _0x3d55b1de.Muted, TextAlignmentOptions.Center, this._0xa0e32758);
        this._0x08ce9546 = _0x90f57411.IconAction(_0x18c01883.transform, _0x6fbe1bec._0xea09fe31(new byte[13] { 166, 144, 129, 129, 156, 155, 146, 134, 182, 153, 154, 134, 144 }, 245), new Vector2(1f, 1f), new Vector2(-84f, -84f), 96f, this._0x7adc578d, _0x3d55b1de.WithAlpha(_0x3d55b1de.SurfaceEdge, 0.95f), _0x16f7698c, _0x3d55b1de.Cream);
        this._0xfffffd8a.gameObject.SetActive(false);
    }

    private TextMeshProUGUI _0x0b20e864;
    private TextMeshProUGUI _0x5a65f28e;
    private readonly TMP_FontAsset _0xa0e32758;
    public bool _0xaf4b8a8a
    {
        get
        {
            return this._0xfffffd8a != null && this._0xfffffd8a.gameObject.activeSelf;
        }
    }

    public Button _0x6b92368f { get; private set; }

    private RectTransform _0xfffffd8a;
    public void _0x299a3313(bool _0x86fb3e9e)
    {
        if (this._0xfffffd8a == null)
        {
            return;
        }

        this._0xfffffd8a.gameObject.SetActive(_0x86fb3e9e);
        if (_0x86fb3e9e)
        {
            this._0xfffffd8a.SetAsLastSibling();
        }
    }

    public Button _0x413b3f27 { get; private set; }

    private Image _0x5b120be6;
    private Image _0x3a860f3e;
    private readonly Sprite _0x7adc578d;
    public void _0x1505cab7(bool _0xb69471d0, bool _0x5f0e1ae4)
    {
        if (this._0x5a65f28e != null)
        {
            this._0x5a65f28e.text = _0xb69471d0 ? _0x6fbe1bec._0xea09fe31(new byte[10] { 66, 75, 90, 94, 67, 73, 89, 42, 69, 68 }, 10) : _0x6fbe1bec._0xea09fe31(new byte[11] { 50, 59, 42, 46, 51, 57, 41, 90, 53, 60, 60 }, 122);
        }

        if (this._0x0b20e864 != null)
        {
            this._0x0b20e864.text = _0x5f0e1ae4 ? _0x6fbe1bec._0xea09fe31(new byte[9] { 188, 174, 174, 180, 174, 169, 221, 178, 179 }, 253) : _0x6fbe1bec._0xea09fe31(new byte[10] { 87, 69, 69, 95, 69, 66, 54, 89, 80, 80 }, 22);
        }

        if (this._0x3a860f3e != null)
        {
            this._0x3a860f3e.color = _0xb69471d0 ? _0x3d55b1de.Teal : _0x3d55b1de.WithAlpha(_0x3d55b1de.Violet, 0.55f);
        }

        if (this._0x5b120be6 != null)
        {
            this._0x5b120be6.color = _0x5f0e1ae4 ? _0x3d55b1de.Teal : _0x3d55b1de.WithAlpha(_0x3d55b1de.Violet, 0.55f);
        }
    }
}

internal static class _0x6fbe1bec
{
    internal static string _0xea09fe31(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}