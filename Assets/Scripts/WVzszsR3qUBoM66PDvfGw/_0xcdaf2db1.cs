using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// One card of the reactor strip in the menu. It shows the reactor number, the
/// relative tempo of its three rings and how far the player has got, and it lights
/// up when chosen so the tap has a visible answer.
public sealed class _0xcdaf2db1
{
    private readonly Image[] _0xb092bac7;
    public void _0x392186ab(bool _0x622ed695)
    {
        if (this._0x1c695711 == null)
        {
            return;
        }

        Color _0x39949bf7;
        if (!this._0x34a70380)
        {
            _0x39949bf7 = _0x3d55b1de.WithAlpha(_0x3d55b1de.Surface, 0.45f);
        }
        else if (_0x622ed695)
        {
            _0x39949bf7 = _0x3d55b1de.WithAlpha(_0x3d55b1de.Teal, 0.95f);
        }
        else
        {
            _0x39949bf7 = _0x3d55b1de.WithAlpha(_0x3d55b1de.Violet, 0.5f);
        }

        this._0x1c695711.DOKill(true);
        this._0x1c695711.color = _0x39949bf7;
        if (_0x622ed695)
        {
            this._0x1c695711.transform.DOKill(true);
            this._0x1c695711.transform.localScale = Vector3.one;
            this._0x1c695711.transform.DOPunchScale(Vector3.one * 0.08f, 0.3f, 8, 0.7f);
        }
    }

    public Button _0x47f66e68 { get; set; }

    private readonly TextMeshProUGUI _0xf35f08f4;
    public _0xcdaf2db1(Image _0x909b5479, Image _0xce70d798, Image[] _0x56de837d, TextMeshProUGUI _0xb9487391, TextMeshProUGUI _0xce95c597, TextMeshProUGUI _0x3ef38c1f)
    {
        this._0x1c695711 = _0x909b5479;
        this._0x72c9dbbe = _0xce70d798;
        this._0xb092bac7 = _0x56de837d;
        this._0x28181846 = _0xb9487391;
        this._0xc20ceb16 = _0xce95c597;
        this._0xf35f08f4 = _0x3ef38c1f;
    }

    private readonly Image _0x72c9dbbe;
    private readonly TextMeshProUGUI _0xc20ceb16;
    private readonly TextMeshProUGUI _0x28181846;
    private readonly Image _0x1c695711;
    private bool _0x34a70380;
    public void _0xdb45a83f(int _0x25a5a8b2, _0xdd279fb7 _0xd0db7e69, bool _0x7035ddf9, int _0x1d369e0e)
    {
        this._0x34a70380 = _0x7035ddf9;
        if (this._0x28181846 != null)
        {
            this._0x28181846.text = (_0x25a5a8b2 + 1).ToString();
        }

        if (this._0xb092bac7 != null && _0xd0db7e69 != null)
        {
            for (int _0x34e05e74 = 0; _0x34e05e74 < this._0xb092bac7.Length; _0x34e05e74++)
            {
                _0xdd279fb7._0x2faff3f3 _0xc7f2802b = _0xd0db7e69._0xae865f5e(_0x34e05e74);
                float _0xd583d8ad = _0xc7f2802b != null ? _0xc7f2802b.SpeedDegPerSecond : 60f;
                float width = Mathf.Lerp(48f, 148f, Mathf.InverseLerp(40f, 150f, _0xd583d8ad));
                RectTransform _0xaa1ca0e3 = this._0xb092bac7[_0x34e05e74].rectTransform;
                _0xaa1ca0e3.sizeDelta = new Vector2(width, 14f);
                this._0xb092bac7[_0x34e05e74].color = _0x7035ddf9 ? _0x3d55b1de.Channel(_0xc7f2802b != null ? _0xc7f2802b.ChannelIndex : _0x34e05e74) : _0x3d55b1de.WithAlpha(_0x3d55b1de.Muted, 0.45f);
            }
        }

        if (this._0xc20ceb16 != null && _0xd0db7e69 != null)
        {
            this._0xc20ceb16.text = _0x82d0e93d._0x5f610cea(new byte[4] { 3, 0, 20, 112 }, 80) + Mathf.RoundToInt(_0xd0db7e69._0xae865f5e(0) != null ? _0xd0db7e69._0xae865f5e(0).SpeedDegPerSecond : 0f) + _0x82d0e93d._0x5f610cea(new byte[1] { 35 }, 12) + Mathf.RoundToInt(_0xd0db7e69._0xae865f5e(1) != null ? _0xd0db7e69._0xae865f5e(1).SpeedDegPerSecond : 0f) + _0x82d0e93d._0x5f610cea(new byte[1] { 44 }, 3) + Mathf.RoundToInt(_0xd0db7e69._0xae865f5e(2) != null ? _0xd0db7e69._0xae865f5e(2).SpeedDegPerSecond : 0f);
        }

        if (this._0xf35f08f4 != null)
        {
            this._0xf35f08f4.text = _0x7035ddf9 ? _0x82d0e93d._0x5f610cea(new byte[5] { 248, 255, 233, 238, 154 }, 186) + _0x1d369e0e + _0x82d0e93d._0x5f610cea(new byte[5] { 23, 120, 113, 23, 4 }, 55) : _0x82d0e93d._0x5f610cea(new byte[6] { 201, 202, 198, 206, 192, 193 }, 133);
            _0xe064bb1a.ApplyOutline(this._0xf35f08f4, _0x7035ddf9 ? _0x3d55b1de.Cream : _0x3d55b1de.Muted);
        }

        if (this._0x72c9dbbe != null)
        {
            this._0x72c9dbbe.color = _0x7035ddf9 ? _0x3d55b1de.Cream : _0x3d55b1de.WithAlpha(_0x3d55b1de.Muted, 0.6f);
        }

        this._0x392186ab(false);
    }
}

internal static class _0x82d0e93d
{
    internal static string _0x5f610cea(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}