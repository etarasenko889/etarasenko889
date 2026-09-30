using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Canvas))]
public class _0x3f1b32a8 : MonoBehaviour
{
    private static UnityEvent _0x533dfdfb = new();
    private RectTransform _0x7f5ab094;
    private static void SafeAreaChanged()
    {
        _0xa8a8b5ee = Screen.safeArea;
        for (int _0xbe3bf51a = 0; _0xbe3bf51a < _0x1b32afe2.Count; _0xbe3bf51a++)
            _0x1b32afe2[_0xbe3bf51a]._0xe7cf3c3d();
    }

    private static Rect _0xa8a8b5ee = Rect.zero;
    private static void OrientationChanged()
    {
        _0x5555dd6d = Screen.orientation;
        _0x3fc9b5d7.x = Screen.width;
        _0x3fc9b5d7.y = Screen.height;
        _0x533dfdfb.Invoke();
    }

    private Canvas _0x44f5ffe8;
    private void Update()
    {
        if (_0x1b32afe2[0] != this)
            return;
        if (Application.isMobilePlatform && Screen.orientation != _0x5555dd6d)
            OrientationChanged();
        if (Screen.safeArea != _0xa8a8b5ee)
            SafeAreaChanged();
        if (Screen.width != _0x3fc9b5d7.x || Screen.height != _0x3fc9b5d7.y)
            ResolutionChanged();
    }

    private void Awake()
    {
        if (!_0x1b32afe2.Contains(this))
            _0x1b32afe2.Add(this);
        this._0x44f5ffe8 = this.GetComponent<Canvas>();
        this._0x376d42d0 = this.GetComponent<RectTransform>();
        this._0x7f5ab094 = this.transform.Find(_0x942c32cd._0xdba870df(new byte[8] { 9, 59, 60, 63, 27, 40, 63, 59 }, 90)) as RectTransform;
        if (!_0xf2a67326)
        {
            _0x5555dd6d = Screen.orientation;
            _0x3fc9b5d7.x = Screen.width;
            _0x3fc9b5d7.y = Screen.height;
            _0xa8a8b5ee = Screen.safeArea;
            _0xf2a67326 = true;
        }

        this._0xe7cf3c3d();
    }

    private void OnDestroy()
    {
        if (_0x1b32afe2 != null && _0x1b32afe2.Contains(this))
            _0x1b32afe2.Remove(this);
    }

    private static Vector2 _0x3fc9b5d7 = Vector2.zero;
    private static ScreenOrientation _0x5555dd6d = ScreenOrientation.LandscapeLeft;
    private RectTransform _0x376d42d0;
    private static readonly List<_0x3f1b32a8> _0x1b32afe2 = new();
    private static bool _0xf2a67326;
    private void _0xe7cf3c3d()
    {
        if (this._0x7f5ab094 == null)
            return;
        Rect _0x26e92a09 = Screen.safeArea;
        Vector2 _0x596845df = _0x26e92a09.position;
        Vector2 _0xbe6d5dac = _0x26e92a09.position + _0x26e92a09.size;
        _0x596845df.x /= this._0x44f5ffe8.pixelRect.width;
        _0x596845df.y /= this._0x44f5ffe8.pixelRect.height;
        _0xbe6d5dac.x /= this._0x44f5ffe8.pixelRect.width;
        _0xbe6d5dac.y /= this._0x44f5ffe8.pixelRect.height;
        this._0x7f5ab094.anchorMin = _0x596845df;
        this._0x7f5ab094.anchorMax = _0xbe6d5dac;
    }

    private static void ResolutionChanged()
    {
        _0x3fc9b5d7.x = Screen.width;
        _0x3fc9b5d7.y = Screen.height;
        _0x533dfdfb.Invoke();
    }
}

internal static class _0x942c32cd
{
    internal static string _0xdba870df(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}