using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// The pre-run briefing. It states the gesture and what it does (the control here
/// is a tap on the field, not on a button), and it prints the tempo of all three
/// rings BEFORE the run starts, which is the whole promise of the game.
/// It also clears itself after twenty seconds with no input, so a run can never be
/// stuck behind it.
public sealed class _0xa36bc711
{
    private readonly TMP_FontAsset _0xaa32d790;
    public void _0x23b901d3(Transform _0x28657e63)
    {
        this._0x256d2a4b = _0x90f57411.Stretch(_0x28657e63, _0xfac85045._0x6ae0da6d(new byte[15] { 239, 223, 196, 200, 203, 196, 195, 202, 226, 219, 200, 223, 193, 204, 212 }, 173));
        this._0x21e96618 = this._0x256d2a4b.gameObject.AddComponent<Image>();
        this._0x21e96618.color = _0x3d55b1de.WithAlpha(_0x3d55b1de.Base, 0.88f);
        this._0x21e96618.raycastTarget = true;
        this._0x21e96618.canvasRenderer.cullTransparentMesh = false;
        Image _0x6312d33e = _0x90f57411.Plate(this._0x256d2a4b, _0xfac85045._0x6ae0da6d(new byte[12] { 131, 179, 168, 164, 167, 168, 175, 166, 130, 160, 179, 165 }, 193), new Vector2(0.5f, 0.5f), new Vector2(0f, 90f), new Vector2(1020f, 1180f), this._0x8c4414b4, _0x3d55b1de.WithAlpha(_0x3d55b1de.Surface, 0.97f));
        this._0x794e19e2 = _0x90f57411.Caption(_0x6312d33e.transform, _0xfac85045._0x6ae0da6d(new byte[13] { 87, 103, 124, 112, 115, 124, 123, 114, 65, 124, 97, 121, 112 }, 21), new Vector2(0.5f, 1f), new Vector2(0f, -120f), new Vector2(880f, 96f), _0xfac85045._0x6ae0da6d(new byte[14] { 1, 22, 18, 16, 7, 28, 1, 115, 98, 115, 28, 21, 115, 102 }, 83), 56f, _0x3d55b1de.Cream, TextAlignmentOptions.Center, this._0xaa32d790);
        this._0x25e08a66 = new TextMeshProUGUI[3];
        for (int _0xef88426d = 0; _0xef88426d < this._0x25e08a66.Length; _0xef88426d++)
        {
            this._0x25e08a66[_0xef88426d] = _0x90f57411.Caption(_0x6312d33e.transform, _0xfac85045._0x6ae0da6d(new byte[12] { 156, 172, 183, 187, 184, 183, 176, 185, 140, 183, 176, 185 }, 222), new Vector2(0.5f, 1f), new Vector2(0f, -280f - (_0xef88426d * 96f)), new Vector2(880f, 80f), _0xfac85045._0x6ae0da6d(new byte[27] { 121, 98, 101, 108, 11, 26, 11, 11, 11, 27, 11, 111, 110, 108, 4, 120, 11, 11, 11, 120, 110, 104, 127, 100, 121, 11, 27 }, 43), 36f, _0x3d55b1de.Channel(_0xef88426d), TextAlignmentOptions.Center, this._0xaa32d790);
        }

        _0x90f57411.Caption(_0x6312d33e.transform, _0xfac85045._0x6ae0da6d(new byte[15] { 109, 93, 70, 74, 73, 70, 65, 72, 124, 91, 74, 95, 96, 65, 74 }, 47), new Vector2(0.5f, 1f), new Vector2(0f, -620f), new Vector2(900f, 80f), _0xfac85045._0x6ae0da6d(new byte[45] { 242, 237, 227, 151, 130, 147, 227, 148, 139, 134, 141, 227, 151, 139, 134, 227, 142, 130, 145, 136, 134, 145, 227, 128, 145, 140, 144, 144, 134, 144, 201, 151, 139, 134, 227, 143, 138, 151, 227, 144, 134, 128, 151, 140, 145 }, 195), 34f, _0x3d55b1de.Cream, TextAlignmentOptions.Center, this._0xaa32d790);
        _0x90f57411.Caption(_0x6312d33e.transform, _0xfac85045._0x6ae0da6d(new byte[15] { 247, 199, 220, 208, 211, 220, 219, 210, 230, 193, 208, 197, 225, 194, 218 }, 181), new Vector2(0.5f, 1f), new Vector2(0f, -760f), new Vector2(900f, 80f), _0xfac85045._0x6ae0da6d(new byte[46] { 189, 161, 175, 195, 192, 204, 196, 175, 206, 195, 195, 175, 219, 199, 221, 202, 202, 175, 221, 198, 193, 200, 220, 133, 219, 192, 175, 204, 192, 193, 193, 202, 204, 219, 175, 219, 199, 202, 175, 204, 199, 206, 193, 193, 202, 195 }, 143), 34f, _0x3d55b1de.Cream, TextAlignmentOptions.Center, this._0xaa32d790);
        this._0xb0632100 = _0x90f57411.Caption(_0x6312d33e.transform, _0xfac85045._0x6ae0da6d(new byte[14] { 53, 5, 30, 18, 17, 30, 25, 16, 59, 30, 26, 30, 3, 4 }, 119), new Vector2(0.5f, 1f), new Vector2(0f, -890f), new Vector2(900f, 72f), _0xfac85045._0x6ae0da6d(new byte[24] { 46, 45, 33, 41, 49, 66, 80, 80, 66, 66, 66, 36, 35, 55, 46, 54, 49, 66, 82, 66, 45, 36, 66, 81 }, 98), 34f, _0x3d55b1de.Gold, TextAlignmentOptions.Center, this._0xaa32d790);
        this._0xdc60a31a = _0x90f57411.Action(this._0x256d2a4b, _0xfac85045._0x6ae0da6d(new byte[13] { 246, 198, 221, 209, 210, 221, 218, 211, 231, 192, 213, 198, 192 }, 180), new Vector2(0.5f, 0f), new Vector2(0f, 372f), new Vector2(640f, 150f), this._0x8c4414b4, _0x3d55b1de.Teal, _0xfac85045._0x6ae0da6d(new byte[9] { 251, 252, 233, 250, 252, 136, 250, 253, 230 }, 168), 48f, _0x3d55b1de.Ink, this._0xaa32d790);
        this._0x256d2a4b.gameObject.SetActive(false);
    }

    private TextMeshProUGUI _0xb0632100;
    private readonly Sprite _0x8c4414b4;
    /// Arms the no-input clear. The overlay is informative, not a gate: if nobody
    /// touches it, the run starts by itself.
    public void _0xd21f58bb(System.Action _0x626afb89)
    {
        if (this._0x015de698 != null)
        {
            this._0x015de698.Kill();
            this._0x015de698 = null;
        }

        this._0x015de698 = DOVirtual.DelayedCall(AutoClearSeconds, () =>
        {
            if (this._0x3a2b458a && _0x626afb89 != null)
            {
                _0x626afb89.Invoke();
            }
        });
    }

    private TextMeshProUGUI[] _0x25e08a66;
    public Image _0x21e96618 { get; private set; }

    public void Show(int _0x802262be, int _0x5e2361f5, _0xdd279fb7 _0xf36ddbb8, int _0x985a209a, int _0xb1614e6d, int _0x1e6aaa05)
    {
        if (this._0x256d2a4b == null)
        {
            return;
        }

        this._0x3a2b458a = true;
        this._0x256d2a4b.gameObject.SetActive(true);
        this._0x256d2a4b.SetAsLastSibling();
        if (this._0x794e19e2 != null)
        {
            this._0x794e19e2.text = _0xfac85045._0x6ae0da6d(new byte[8] { 234, 253, 249, 251, 236, 247, 234, 152 }, 184) + (_0x802262be + 1) + _0xfac85045._0x6ae0da6d(new byte[4] { 58, 85, 92, 58 }, 26) + _0x5e2361f5;
        }

        for (int _0x9c3a52a6 = 0; _0x9c3a52a6 < this._0x25e08a66.Length; _0x9c3a52a6++)
        {
            _0xdd279fb7._0x2faff3f3 _0xf3386a4f = _0xf36ddbb8 != null ? _0xf36ddbb8._0xae865f5e(_0x9c3a52a6) : null;
            if (_0xf3386a4f == null)
            {
                this._0x25e08a66[_0x9c3a52a6].text = _0xfac85045._0x6ae0da6d(new byte[5] { 52, 47, 40, 33, 70 }, 102) + (_0x9c3a52a6 + 1) + _0xfac85045._0x6ae0da6d(new byte[10] { 76, 76, 76, 63, 56, 45, 34, 40, 46, 53 }, 108);
                continue;
            }

            this._0x25e08a66[_0x9c3a52a6].text = _0xfac85045._0x6ae0da6d(new byte[5] { 5, 30, 25, 16, 119 }, 87) + (_0x9c3a52a6 + 1) + _0xfac85045._0x6ae0da6d(new byte[3] { 103, 103, 103 }, 71) + Mathf.RoundToInt(_0xf3386a4f.SpeedDegPerSecond) + _0xfac85045._0x6ae0da6d(new byte[16] { 137, 237, 236, 238, 134, 250, 137, 137, 137, 250, 236, 234, 253, 230, 251, 137 }, 169) + Mathf.RoundToInt(_0xf3386a4f.SectorWidthDeg);
            _0xe064bb1a.ApplyOutline(this._0x25e08a66[_0x9c3a52a6], _0x3d55b1de.Channel(_0xf3386a4f.ChannelIndex));
        }

        if (this._0xb0632100 != null)
        {
            this._0xb0632100.text = _0xfac85045._0x6ae0da6d(new byte[6] { 107, 104, 100, 108, 116, 7 }, 39) + _0x985a209a + _0xfac85045._0x6ae0da6d(new byte[10] { 119, 119, 119, 17, 22, 2, 27, 3, 4, 119 }, 87) + _0xb1614e6d + _0xfac85045._0x6ae0da6d(new byte[4] { 78, 33, 40, 78 }, 110) + _0x1e6aaa05;
        }
    }

    public void _0x19b079d3()
    {
        this._0x3a2b458a = false;
        if (this._0x015de698 != null)
        {
            this._0x015de698.Kill();
            this._0x015de698 = null;
        }

        if (this._0x256d2a4b != null)
        {
            this._0x256d2a4b.gameObject.SetActive(false);
        }
    }

    public Button _0xdc60a31a { get; private set; }

    private bool _0x3a2b458a;
    private RectTransform _0x256d2a4b;
    public bool _0x0003437b
    {
        get
        {
            return this._0x3a2b458a;
        }
    }

    private Tween _0x015de698;
    public _0xa36bc711(TMP_FontAsset _0x4a7b23ee, Sprite _0x8be3764f)
    {
        this._0xaa32d790 = _0x4a7b23ee;
        this._0x8c4414b4 = _0x8be3764f;
    }

    private const float AutoClearSeconds = 20f;
    private TextMeshProUGUI _0x794e19e2;
}

internal static class _0xfac85045
{
    internal static string _0x6ae0da6d(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}