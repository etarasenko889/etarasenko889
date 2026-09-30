using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// Everything this game does TO the scene template: clearing panels it does not
/// use, blanking the filler copy the template ships on its unused tutorial pages,
/// theming the splash loading bar, and dressing the splash with an abstract mark.
///
/// Panels are always addressed by their SETTINGS index, never by object name, so
/// none of this depends on names surviving obfuscation.
public static class _0xfe173679
{
    /// Switches off whatever the template put into a panel body so this game can
    /// build its own. Anything holding a pop is left alone: pops are addressed by
    /// index and must survive.
    public static void ClearPanelBody(int _0x74d1b37a)
    {
        ClearPanelBody(_0x74d1b37a, null);
    }

    /// Splash bar: accent fill on a dark track with real alpha. The template ships
    /// both at white, the track at alpha 0.004, which reads as no bar at all.
    /// The bar keeps the size the prefab gives it - resizing its root would collapse
    /// the fill area, which insets itself inside that root.
    public static void ThemeSplashSlider()
    {
        Transform _0xcb7716bf = PanelBody(_0x879a7ea3._0x6776f348.SPLASH);
        if (_0xcb7716bf == null)
        {
            return;
        }

        Slider _0xa79689b7 = _0xcb7716bf.GetComponentInChildren<Slider>(true);
        if (_0xa79689b7 == null)
        {
            return;
        }

        Image _0x1abeb359 = _0xa79689b7.fillRect != null ? _0xa79689b7.fillRect.GetComponent<Image>() : null;
        if (_0x1abeb359 != null)
        {
            _0x1abeb359.color = _0x3d55b1de.Teal;
        }

        Transform _0x2eef6da1 = _0xa79689b7.fillRect != null ? _0xa79689b7.fillRect.parent : null;
        Image _0xaa924432 = _0x2eef6da1 != null ? _0x2eef6da1.GetComponent<Image>() : null;
        if (_0xaa924432 != null)
        {
            _0xaa924432.color = _0x3d55b1de.TrackDark;
        }
    }

    /// The same, but keeping one branch alive - the menu needs the template's own
    /// scene-loading button, which this game re-dresses instead of replacing.
    public static void ClearPanelBody(int _0x7abecc22, Transform _0x981346c7)
    {
        Transform _0x69e3163a = PanelBody(_0x7abecc22);
        if (_0x69e3163a == null)
        {
            return;
        }

        for (int _0xf0bdcc50 = _0x69e3163a.childCount - 1; _0xf0bdcc50 >= 0; _0xf0bdcc50--)
        {
            Transform _0x349ef42b = _0x69e3163a.GetChild(_0xf0bdcc50);
            if (_0x349ef42b == null)
            {
                continue;
            }

            if (_0x349ef42b.GetComponentInChildren<_0x72c4d902>(true) != null)
            {
                continue;
            }

            if (_0x981346c7 != null && (_0x349ef42b == _0x981346c7 || _0x981346c7.IsChildOf(_0x349ef42b)))
            {
                continue;
            }

            _0x349ef42b.gameObject.SetActive(false);
        }
    }

    /// Every tutorial page the template declares. This game explains its control
    /// in its own briefing overlay and leaves SETUP_OBJECT.IsTutorialEnabled at 0,
    /// so these pages are never shown - but their template copy must not survive
    /// into the build either, and blanking them costs nothing.
    private static readonly int[] _0xca53f2b1 =
    {
        _0x879a7ea3._0x6776f348.TUTORIAL0,
        _0x879a7ea3._0x6776f348.TUTORIAL1,
        _0x879a7ea3._0x6776f348.TUTORIAL2,
        _0x879a7ea3._0x6776f348.TUTORIAL3,
        _0x879a7ea3._0x6776f348.TUTORIAL4,
        _0x879a7ea3._0x6776f348.TUTORIAL5,
        _0x879a7ea3._0x6776f348.TUTORIAL6,
    };
    public static Transform PanelBody(int _0xf9069dbe)
    {
        _0xa80fd29e _0x483796b5 = _0xa80fd29e.Instance;
        if (_0x483796b5 == null || _0x483796b5.Panels == null)
        {
            return null;
        }

        if (_0xf9069dbe < 0 || _0xf9069dbe >= _0x483796b5.Panels.Count)
        {
            return null;
        }

        _0x2b190913 _0xf9b0627f = _0x483796b5.Panels[_0xf9069dbe];
        if (_0xf9b0627f == null || _0xf9b0627f.Content == null)
        {
            return null;
        }

        return _0xf9b0627f.Content.transform;
    }

    /// An abstract mark for the splash: a core inside a ring of pips, plus one
    /// functional line. No game name anywhere - branding here is shape and colour.
    public static void DressSplash(TMP_FontAsset _0x1be6a64b, Sprite _0x54c4d952, Sprite _0xf7fd2536, Sprite _0x615892e6)
    {
        Transform _0x136a0895 = PanelBody(_0x879a7ea3._0x6776f348.SPLASH);
        if (_0x136a0895 == null)
        {
            return;
        }

        RectTransform _0x2b4cc0cb = _0x90f57411.Stretch(_0x136a0895, _0x0b1fce70._0x89e0fbf1(new byte[10] { 10, 41, 53, 56, 42, 49, 20, 56, 43, 50 }, 89));
        _0x2b4cc0cb.SetAsFirstSibling();
        Image _0xd1e7dd95 = _0x2b4cc0cb.gameObject.AddComponent<Image>();
        _0xd1e7dd95.color = _0x3d55b1de.WithAlpha(_0x3d55b1de.Base, 0.55f);
        _0xd1e7dd95.raycastTarget = false;
        RectTransform _0x21a2b5cc = _0x90f57411.Node(_0x2b4cc0cb, _0x0b1fce70._0x89e0fbf1(new byte[10] { 115, 80, 76, 65, 83, 72, 114, 73, 78, 71 }, 32), new Vector2(0.5f, 0.5f), new Vector2(0f, 240f), new Vector2(560f, 560f));
        for (int _0x0fc5e4c1 = 0; _0x0fc5e4c1 < 24; _0x0fc5e4c1++)
        {
            float _0x8351a030 = (360f / 24f) * _0x0fc5e4c1;
            float _0xd432f01c = _0x8351a030 * Mathf.Deg2Rad;
            Image _0x3a298047 = _0x90f57411.Plate(_0x21a2b5cc, _0x0b1fce70._0x89e0fbf1(new byte[9] { 168, 139, 151, 154, 136, 147, 171, 146, 139 }, 251), new Vector2(0.5f, 0.5f), new Vector2(Mathf.Sin(_0xd432f01c) * 260f, Mathf.Cos(_0xd432f01c) * 260f), new Vector2(46f, 16f), _0xf7fd2536, _0x3d55b1de.WithAlpha(_0x0fc5e4c1 % 4 == 0 ? _0x3d55b1de.Gold : _0x3d55b1de.Teal, 0.85f));
            _0x3a298047.rectTransform.localRotation = Quaternion.Euler(0f, 0f, -_0x8351a030);
        }

        _0x90f57411.Picture(_0x21a2b5cc, _0x0b1fce70._0x89e0fbf1(new byte[10] { 211, 240, 236, 225, 243, 232, 195, 239, 242, 229 }, 128), new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(320f, 320f), _0x54c4d952, _0x3d55b1de.Cream);
        _0x90f57411.Caption(_0x2b4cc0cb, _0x0b1fce70._0x89e0fbf1(new byte[10] { 7, 36, 56, 53, 39, 60, 24, 61, 58, 49 }, 84), new Vector2(0.5f, 0.5f), new Vector2(0f, -190f), new Vector2(760f, 74f), _0x0b1fce70._0x89e0fbf1(new byte[12] { 27, 28, 27, 6, 27, 19, 30, 27, 8, 27, 28, 21 }, 82), 38f, _0x3d55b1de.Cream, TextAlignmentOptions.Center, _0x1be6a64b);
        _0x90f57411.Plate(_0x2b4cc0cb, _0x0b1fce70._0x89e0fbf1(new byte[10] { 183, 148, 136, 133, 151, 140, 182, 145, 136, 129 }, 228), new Vector2(0.5f, 0.5f), new Vector2(0f, -256f), new Vector2(420f, 8f), _0x615892e6, _0x3d55b1de.WithAlpha(_0x3d55b1de.Violet, 0.8f));
        // The loading bar must stay the last child of the splash body, or the mark
        // drawn above would sit on top of it.
        Transform _0x9157e174 = _0x136a0895.GetComponentInChildren<Slider>(true) != null ? _0x136a0895.GetComponentInChildren<Slider>(true).transform : null;
        if (_0x9157e174 != null)
        {
            Transform _0xd585324b = _0x9157e174;
            while (_0xd585324b.parent != null && _0xd585324b.parent != _0x136a0895)
            {
                _0xd585324b = _0xd585324b.parent;
            }

            _0xd585324b.SetAsLastSibling();
        }
    }

    /// Wipes the filler strings out of every template page this game does not dress
    /// itself. The page stays in the pool: the controller addresses panels by index
    /// and a removed page would break its navigation.
    public static void BlankUnusedPanels()
    {
        for (int _0x9b6dcd75 = 0; _0x9b6dcd75 < _0xca53f2b1.Length; _0x9b6dcd75++)
        {
            Transform _0x8e7b412a = PanelBody(_0xca53f2b1[_0x9b6dcd75]);
            if (_0x8e7b412a == null)
            {
                continue;
            }

            TMP_Text[] _0xd20e4923 = _0x8e7b412a.GetComponentsInChildren<TMP_Text>(true);
            for (int _0xb61340e7 = 0; _0xb61340e7 < _0xd20e4923.Length; _0xb61340e7++)
            {
                if (_0xd20e4923[_0xb61340e7] != null)
                {
                    _0xd20e4923[_0xb61340e7].text = string.Empty;
                }
            }
        }
    }
}

internal static class _0x0b1fce70
{
    internal static string _0x89e0fbf1(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}