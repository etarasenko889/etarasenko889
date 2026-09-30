using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// Small construction helpers for the UGUI this game builds at runtime.
/// Everything is expressed in the canvas reference resolution (1242 x 2688), so
/// one set of numbers reads the same on every device.
public static class _0x90f57411
{
    /// A plain rect. Anchors collapse to a single point, so the size is always the
    /// one written here and never inherited from a parent that happens to stretch.
    public static RectTransform Node(Transform _0x4336b871, string _0xb3f0ac22, Vector2 _0x806a7042, Vector2 _0xafd70992, Vector2 _0x72d94ad4)
    {
        GameObject _0x4e373806 = new GameObject(_0xb3f0ac22, typeof(RectTransform));
        RectTransform _0x8761713d = _0x4e373806.GetComponent<RectTransform>();
        _0x8761713d.SetParent(_0x4336b871, false);
        _0x8761713d.anchorMin = _0x806a7042;
        _0x8761713d.anchorMax = _0x806a7042;
        _0x8761713d.pivot = new Vector2(0.5f, 0.5f);
        _0x8761713d.anchoredPosition = _0xafd70992;
        _0x8761713d.sizeDelta = _0x72d94ad4;
        _0x8761713d.localScale = Vector3.one;
        return _0x8761713d;
    }

    /// Square icon button. The glyph is a later sibling than the fill (draw order).
    public static Button IconAction(Transform _0xf65dff38, string _0xf30c4e38, Vector2 _0x50c7fe0c, Vector2 _0x58aba11b, float _0x736cf150, Sprite _0x109fd486, Color _0x7d747bab, Sprite _0x0330f278, Color _0xcffb013e)
    {
        Button _0x5509db7b = Action(_0xf65dff38, _0xf30c4e38, _0x50c7fe0c, _0x58aba11b, new Vector2(_0x736cf150, _0x736cf150), _0x109fd486, _0x7d747bab, string.Empty, 32f, _0x3d55b1de.Cream, null);
        Image _0xade536d6 = Picture(_0x5509db7b.transform, _0xf30c4e38 + _0xc8ce8fb0._0xa4a11015(new byte[6] { 115, 75, 64, 85, 92, 68 }, 44), new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(_0x736cf150 * 0.56f, _0x736cf150 * 0.56f), _0x0330f278, _0xcffb013e);
        _0xade536d6.raycastTarget = false;
        return _0x5509db7b;
    }

    public static Image Plate(Transform _0x8aa3d2a4, string _0xc1c7078f, Vector2 _0x99f4c91c, Vector2 _0xb56ca29c, Vector2 _0xbc382d22, Sprite _0xc41f4b4b, Color _0x333ec9d9)
    {
        RectTransform _0x27126843 = Node(_0x8aa3d2a4, _0xc1c7078f, _0x99f4c91c, _0xb56ca29c, _0xbc382d22);
        Image _0x195dea64 = _0x27126843.gameObject.AddComponent<Image>();
        _0x195dea64.sprite = _0xc41f4b4b;
        _0x195dea64.type = _0xc41f4b4b != null ? Image.Type.Sliced : Image.Type.Simple;
        _0x195dea64.pixelsPerUnitMultiplier = 1.35f;
        _0x195dea64.color = _0x333ec9d9;
        _0x195dea64.raycastTarget = false;
        return _0x195dea64;
    }

    public const float RefWidth = 1242f;
    public const float RefHeight = 2688f;
    public static Image Picture(Transform _0x06211c2a, string _0xa43186ac, Vector2 _0x73f57a5d, Vector2 _0xa8740082, Vector2 _0x696f1620, Sprite _0xf11cfe45, Color _0x92045b60)
    {
        RectTransform _0xad13d834 = Node(_0x06211c2a, _0xa43186ac, _0x73f57a5d, _0xa8740082, _0x696f1620);
        Image _0x6a49954b = _0xad13d834.gameObject.AddComponent<Image>();
        _0x6a49954b.sprite = _0xf11cfe45;
        _0x6a49954b.type = Image.Type.Simple;
        _0x6a49954b.preserveAspect = true;
        _0x6a49954b.color = _0x92045b60;
        _0x6a49954b.raycastTarget = false;
        return _0x6a49954b;
    }

    /// A pressable surface: fill image (also the press target) plus an optional
    /// icon and caption. Icon and caption are LATER siblings than the fill, so the
    /// background can never cover its own label.
    public static Button Action(Transform _0x07456a7b, string _0x99b45b36, Vector2 _0x412e233f, Vector2 _0x53adcb9d, Vector2 _0x1bd5f2fb, Sprite _0xba499c42, Color _0x7cef5be6, string _0xefaca297, float _0x97c3670b, Color _0xb0c294f3, TMP_FontAsset _0x9119832f)
    {
        RectTransform _0x722a2ea2 = Node(_0x07456a7b, _0x99b45b36, _0x412e233f, _0x53adcb9d, _0x1bd5f2fb);
        Image _0xb69b9a5a = _0x722a2ea2.gameObject.AddComponent<Image>();
        _0xb69b9a5a.sprite = _0xba499c42;
        _0xb69b9a5a.type = _0xba499c42 != null ? Image.Type.Sliced : Image.Type.Simple;
        _0xb69b9a5a.pixelsPerUnitMultiplier = 1.35f;
        _0xb69b9a5a.color = _0x7cef5be6;
        _0xb69b9a5a.raycastTarget = true;
        _0xb69b9a5a.canvasRenderer.cullTransparentMesh = false;
        Button _0x6bdd9563 = _0x722a2ea2.gameObject.AddComponent<Button>();
        _0x6bdd9563.targetGraphic = _0xb69b9a5a;
        ColorBlock _0x91e3b99f = _0x6bdd9563.colors;
        _0x91e3b99f.normalColor = Color.white;
        _0x91e3b99f.highlightedColor = new Color(1f, 1f, 1f, 1f);
        _0x91e3b99f.pressedColor = new Color(0.72f, 0.72f, 0.72f, 1f);
        _0x91e3b99f.selectedColor = Color.white;
        _0x91e3b99f.disabledColor = new Color(0.55f, 0.55f, 0.55f, 0.6f);
        _0x91e3b99f.fadeDuration = 0.08f;
        _0x6bdd9563.colors = _0x91e3b99f;
        if (!string.IsNullOrEmpty(_0xefaca297))
        {
            Caption(_0x722a2ea2, _0x99b45b36 + _0xc8ce8fb0._0xa4a11015(new byte[5] { 195, 232, 249, 228, 232 }, 156), new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(_0x1bd5f2fb.x - 40f, _0x1bd5f2fb.y - 24f), _0xefaca297, _0x97c3670b, _0xb0c294f3, TextAlignmentOptions.Center, _0x9119832f);
        }

        return _0x6bdd9563;
    }

    public static TextMeshProUGUI Caption(Transform _0xb9f02387, string _0xec579e75, Vector2 _0xc0dcf9c1, Vector2 _0x770d255e, Vector2 _0x7f256081, string _0xf4fbe542, float _0xe863125c, Color _0x6824c3d2, TextAlignmentOptions _0x11934b96, TMP_FontAsset _0x16743adb)
    {
        RectTransform _0xc8b48b6f = Node(_0xb9f02387, _0xec579e75, _0xc0dcf9c1, _0x770d255e, _0x7f256081);
        TextMeshProUGUI _0x30977ef5 = _0xc8b48b6f.gameObject.AddComponent<TextMeshProUGUI>();
        if (_0x16743adb != null)
        {
            _0x30977ef5.font = _0x16743adb;
        }

        _0x30977ef5.text = _0xf4fbe542;
        _0x30977ef5.alignment = _0x11934b96;
        _0x30977ef5.raycastTarget = false;
        _0xe064bb1a.ApplyLayout(_0x30977ef5, _0xe863125c);
        _0xe064bb1a.ApplyOutline(_0x30977ef5, _0x6824c3d2);
        return _0x30977ef5;
    }

    /// Full-surface tap target. A fully transparent image is culled by the
    /// raycaster, so it carries a trace of alpha and keeps its mesh alive.
    public static Image TapSurface(Transform _0x34558db8, string _0x2ae8f7ff)
    {
        RectTransform _0x538b5a7f = Stretch(_0x34558db8, _0x2ae8f7ff);
        Image _0x510bfcdf = _0x538b5a7f.gameObject.AddComponent<Image>();
        _0x510bfcdf.color = new Color(0f, 0f, 0f, 0.004f);
        _0x510bfcdf.raycastTarget = true;
        _0x510bfcdf.canvasRenderer.cullTransparentMesh = false;
        return _0x510bfcdf;
    }

    /// A rect stretched over its whole parent. Needed for hosts created with
    /// new GameObject(...): they start 100x100 and every child would then resolve
    /// its anchors against 100x100 instead of the panel.
    public static RectTransform Stretch(Transform _0x9a6539bc, string _0x46228287)
    {
        GameObject _0xbcf3668b = new GameObject(_0x46228287, typeof(RectTransform));
        RectTransform _0x9192c140 = _0xbcf3668b.GetComponent<RectTransform>();
        _0x9192c140.SetParent(_0x9a6539bc, false);
        _0x9192c140.anchorMin = Vector2.zero;
        _0x9192c140.anchorMax = Vector2.one;
        _0x9192c140.offsetMin = Vector2.zero;
        _0x9192c140.offsetMax = Vector2.zero;
        _0x9192c140.localScale = Vector3.one;
        return _0x9192c140;
    }

    public static void SetActive(Component _0xb21557f0, bool _0x411e785e)
    {
        if (_0xb21557f0 != null && _0xb21557f0.gameObject.activeSelf != _0x411e785e)
        {
            _0xb21557f0.gameObject.SetActive(_0x411e785e);
        }
    }
}

internal static class _0xc8ce8fb0
{
    internal static string _0xa4a11015(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}