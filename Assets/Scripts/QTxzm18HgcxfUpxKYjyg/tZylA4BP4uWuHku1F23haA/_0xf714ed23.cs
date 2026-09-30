using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[RequireComponent(typeof(Canvas))]
public class _0xf714ed23 : MonoBehaviour
{
    private static bool _0x21b48a8e;
    private static Rect _0xbdfd9ac2 = Rect.zero;
    private static ScreenOrientation _0xec59245a = ScreenOrientation.LandscapeLeft;
    private static void SafeAreaChanged()
    {
        _0xbdfd9ac2 = Screen.safeArea;
        ApplySafeAreaToAll();
    }

    private RectTransform _0x80ced9aa;
    private RectTransform _0xf69e2647;
    private static readonly List<_0xf714ed23> _0x451c3df9 = new();
    private void _0x82036bd1()
    {
        if (this._0x80ced9aa == null)
            return;
        float screenWidth = Screen.width;
        float screenHeight = Screen.height;
        if (screenWidth <= 0f || screenHeight <= 0f)
            return;
        Rect _0x2536e3b6 = Screen.safeArea;
        Vector2 _0x4cfc810a = _0x2536e3b6.position;
        Vector2 _0x9b211a4a = _0x2536e3b6.position + _0x2536e3b6.size;
        _0x4cfc810a.x /= screenWidth;
        _0x4cfc810a.y /= screenHeight;
        _0x9b211a4a.x /= screenWidth;
        _0x9b211a4a.y /= screenHeight;
        this._0x80ced9aa.anchorMin = _0x4cfc810a;
        this._0x80ced9aa.anchorMax = _0x9b211a4a;
        this._0x80ced9aa.offsetMin = Vector2.zero;
        this._0x80ced9aa.offsetMax = Vector2.zero;
        if (this._0x9ed8399f == null)
            return;
        Vector2 _0xdd9e0ec4 = _0x9b211a4a - _0x4cfc810a;
        float _0x80ab11ea = 2f - _0xdd9e0ec4.x;
        float _0x615e91fd = 2f - _0xdd9e0ec4.y;
        this._0x9ed8399f.referenceResolution = this._0xbed2dde8 * new Vector2(_0x80ab11ea, _0x615e91fd);
    }

    private Canvas _0x0187a55e;
    private static void OrientationChanged()
    {
        _0xec59245a = Screen.orientation;
        _0x43a5aecd.x = Screen.width;
        _0x43a5aecd.y = Screen.height;
        _0xbdfd9ac2 = Screen.safeArea;
        ApplySafeAreaToAll();
        _0xb56e1327.Invoke();
    }

    private static void ApplySafeAreaToAll()
    {
        for (int _0x38ff6c11 = 0; _0x38ff6c11 < _0x451c3df9.Count; _0x38ff6c11++)
            _0x451c3df9[_0x38ff6c11]._0x82036bd1();
    }

    private void Update()
    {
        if (_0x451c3df9.Count == 0 || _0x451c3df9[0] != this)
            return;
        if (Application.isMobilePlatform && Screen.orientation != _0xec59245a)
            OrientationChanged();
        if (Screen.safeArea != _0xbdfd9ac2)
            SafeAreaChanged();
        if (Screen.width != _0x43a5aecd.x || Screen.height != _0x43a5aecd.y)
            ResolutionChanged();
    }

    private void Start()
    {
    }

    private static void ResolutionChanged()
    {
        _0x43a5aecd.x = Screen.width;
        _0x43a5aecd.y = Screen.height;
        _0xbdfd9ac2 = Screen.safeArea;
        ApplySafeAreaToAll();
        _0xb56e1327.Invoke();
    }

    private static UnityEvent _0xb56e1327 = new();
    private Vector2 _0xbed2dde8;
    private static Vector2 _0x43a5aecd = Vector2.zero;
    private void Awake()
    {
        if (!_0x451c3df9.Contains(this))
            _0x451c3df9.Add(this);
        this._0x0187a55e = this.GetComponent<Canvas>();
        this._0x9ed8399f = this.GetComponent<CanvasScaler>();
        if (this._0x9ed8399f != null)
            this._0xbed2dde8 = this._0x9ed8399f.referenceResolution;
        this._0xf69e2647 = this.GetComponent<RectTransform>();
        this._0x80ced9aa = this.transform.Find(_0x5c0d4d92._0xb57aeba7(new byte[8] { 75, 121, 126, 125, 89, 106, 125, 121 }, 24)) as RectTransform;
        if (!_0x21b48a8e)
        {
            _0xec59245a = Screen.orientation;
            _0x43a5aecd.x = Screen.width;
            _0x43a5aecd.y = Screen.height;
            _0xbdfd9ac2 = Screen.safeArea;
            _0x21b48a8e = true;
        }

        this._0x82036bd1();
    }

    private CanvasScaler _0x9ed8399f;
    private void OnDestroy()
    {
        if (_0x451c3df9 != null && _0x451c3df9.Contains(this))
            _0x451c3df9.Remove(this);
    }
}

internal static class _0x5c0d4d92
{
    internal static string _0xb57aeba7(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}