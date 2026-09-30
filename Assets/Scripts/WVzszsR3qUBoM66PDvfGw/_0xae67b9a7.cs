using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// Builds the menu: the charge readout, a slowly turning reactor preview, the
/// record line, the reactor strip, the play control and the settings sheet.
/// The template's own scene-loading button is kept and re-dressed rather than
/// duplicated, so there is exactly one control that starts a run.
public sealed class _0xae67b9a7 : MonoBehaviour
{
    private void _0xe335d267()
    {
        if (this._0x58f9155c != null)
        {
            this._0x58f9155c._0x1505cab7(this._0x5b767af3._0xb9afba12, this._0x5b767af3._0x62ecd0de);
            this._0x58f9155c._0x299a3313(true);
        }
    }

    private void Start()
    {
        _0xfe173679.BlankUnusedPanels();
        _0xfe173679.ThemeSplashSlider();
        _0xfe173679.DressSplash(this._font, this._coreSprite, this._pipSprite, this._plateSprite);
        Transform _0x7eabdb72 = _0xfe173679.PanelBody(_0x879a7ea3._0x6776f348.DEFAULT);
        if (_0x7eabdb72 == null)
        {
            return;
        }

        Transform _0xaaa2f341 = this._playSlot != null ? this._playSlot.transform : null;
        _0xfe173679.ClearPanelBody(_0x879a7ea3._0x6776f348.DEFAULT, _0xaaa2f341);
        for (int _0x6a687d54 = 0; _0x6a687d54 < this._0xefab0e6b.Length; _0x6a687d54++)
        {
            this._0xefab0e6b[_0x6a687d54] = this._0x6668b31e._0x625415d7(_0x6a687d54, 1);
        }

        this._0x3734e77a = this._0x5b767af3._0x8e46a79e;
        this._0x49dc698d(_0x7eabdb72);
        this._0x1f0d755a(_0x7eabdb72);
        this._0x8102d895(_0x7eabdb72);
        this._0x83a6b8ba(_0x7eabdb72);
        this._0xbfbb3760();
        this._0x58f9155c = new _0x4692a919(this._font, this._plateSprite);
        this._0x58f9155c._0xf413ba30(_0x7eabdb72, this._closeIcon);
        this._0x58f9155c._0x1505cab7(this._0x5b767af3._0xb9afba12, this._0x5b767af3._0x62ecd0de);
        this._0x58f9155c._0x59c045f0.onClick.AddListener(() => this._0x5d14dfe7());
        this._0x58f9155c._0x413b3f27.onClick.AddListener(() => this._0xdcbfd0ee());
        this._0x58f9155c._0x6b92368f.onClick.AddListener(() => this._0x8faf108a());
        this._0x58f9155c._0x08ce9546.onClick.AddListener(() => this._0x2efb815f());
        this._0x733e30cd();
    }

    [SerializeField]
    private _0xdd436667 _board;
    [SerializeField]
    private Sprite _pipSprite;
    private readonly _0x0ed6b613 _0x5b767af3 = new _0x0ed6b613();
    private const float PreviewTempo = 0.24f;
    [SerializeField]
    private Sprite _beamSprite;
    private TextMeshProUGUI _0x1698d271;
    private void _0x2efb815f()
    {
        if (this._0x58f9155c != null)
        {
            this._0x58f9155c._0x299a3313(false);
        }
    }

    private readonly _0x2d6e6a19 _0x6668b31e = new _0x2d6e6a19();
    private void Update()
    {
        if (this._board != null)
        {
            this._board.Advance(Time.deltaTime, 0);
        }
    }

    private void _0x49dc698d(Transform _0x732061cf)
    {
        Image _0x2fa74920 = _0x90f57411.Plate(_0x732061cf, _0x60468327._0x24d2aeb7(new byte[11] { 134, 173, 164, 183, 162, 160, 149, 169, 164, 177, 160 }, 197), new Vector2(0.5f, 1f), new Vector2(-330f, -150f), new Vector2(520f, 112f), this._plateSprite, _0x3d55b1de.WithAlpha(_0x3d55b1de.Surface, 0.95f));
        this._0x1698d271 = _0x90f57411.Caption(_0x2fa74920.transform, _0x60468327._0x24d2aeb7(new byte[11] { 237, 198, 207, 220, 201, 203, 248, 207, 194, 219, 203 }, 174), new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(470f, 88f), _0x60468327._0x24d2aeb7(new byte[8] { 83, 88, 81, 66, 87, 85, 48, 32 }, 16), 40f, _0x3d55b1de.Gold, TextAlignmentOptions.Center, this._font);
        Button _0x2daaeba3 = _0x90f57411.IconAction(_0x732061cf, _0x60468327._0x24d2aeb7(new byte[12] { 167, 145, 128, 128, 157, 154, 147, 135, 167, 152, 155, 128 }, 244), new Vector2(0.5f, 1f), new Vector2(490f, -150f), 112f, this._plateSprite, _0x3d55b1de.WithAlpha(_0x3d55b1de.Surface, 0.95f), this._gearIcon, _0x3d55b1de.Cream);
        _0x2daaeba3.onClick.AddListener(() => this._0xe335d267());
    }

    private void _0x1f0d755a(Transform _0xb546bd5f)
    {
        this._0x69761b23 = _0x90f57411.Caption(_0xb546bd5f, _0x60468327._0x24d2aeb7(new byte[8] { 191, 152, 142, 137, 177, 148, 147, 152 }, 253), new Vector2(0.5f, 1f), new Vector2(0f, -1345f), new Vector2(1040f, 84f), _0x60468327._0x24d2aeb7(new byte[11] { 174, 175, 192, 178, 181, 174, 179, 192, 185, 165, 180 }, 224), 40f, _0x3d55b1de.Gold, TextAlignmentOptions.Center, this._font);
        this._0xa40e4b46 = _0x90f57411.Caption(_0xb546bd5f, _0x60468327._0x24d2aeb7(new byte[10] { 222, 255, 253, 248, 255, 244, 221, 248, 255, 244 }, 145), new Vector2(0.5f, 1f), new Vector2(0f, -1425f), new Vector2(1040f, 60f), _0x60468327._0x24d2aeb7(new byte[17] { 17, 6, 2, 0, 23, 12, 17, 16, 99, 12, 13, 15, 10, 13, 6, 99, 115 }, 67), 30f, _0x3d55b1de.Muted, TextAlignmentOptions.Center, this._font);
    }

    private readonly _0xdd279fb7[] _0xefab0e6b = new _0xdd279fb7[_0x0ed6b613.ReactorCount];
    [SerializeField]
    private _0xce1ffac3 _playSlot;
    private void _0x83a6b8ba(Transform _0xbb521690)
    {
        this._0xcca95fc1 = _0x90f57411.Caption(_0xbb521690, _0x60468327._0x24d2aeb7(new byte[13] { 199, 234, 226, 237, 235, 252, 225, 254, 237, 196, 225, 230, 237 }, 136), new Vector2(0.5f, 0f), new Vector2(0f, 520f), new Vector2(1040f, 130f), _0x60468327._0x24d2aeb7(new byte[48] { 228, 227, 246, 245, 254, 251, 254, 237, 242, 151, 130, 151, 229, 242, 246, 244, 227, 248, 229, 228, 189, 133, 133, 151, 251, 248, 244, 252, 228, 151, 154, 151, 132, 151, 241, 246, 226, 251, 227, 228, 151, 246, 251, 251, 248, 224, 242, 243 }, 183), 32f, _0x3d55b1de.Muted, TextAlignmentOptions.Center, this._font);
        _0x90f57411.Caption(_0xbb521690, _0x60468327._0x24d2aeb7(new byte[11] { 86, 122, 123, 97, 103, 122, 121, 89, 124, 123, 112 }, 21), new Vector2(0.5f, 0f), new Vector2(0f, 330f), new Vector2(1040f, 64f), _0x60468327._0x24d2aeb7(new byte[36] { 172, 185, 168, 216, 172, 183, 216, 180, 183, 187, 179, 216, 185, 216, 170, 177, 182, 191, 216, 177, 182, 216, 172, 176, 189, 216, 180, 177, 172, 216, 171, 189, 187, 172, 183, 170 }, 248), 30f, _0x3d55b1de.WithAlpha(_0x3d55b1de.Cream, 0.88f), TextAlignmentOptions.Center, this._font);
    }

    [SerializeField]
    private TMP_FontAsset _font;
    [SerializeField]
    private Sprite _badgeSprite;
    [SerializeField]
    private Sprite _plateSprite;
    private void _0x0012e1a5(int _0x412ca0aa)
    {
        this._0x3734e77a = Mathf.Clamp(_0x412ca0aa, 0, this._0x289f3994.Length - 1);
        this._0x5b767af3._0x8e46a79e = this._0x3734e77a;
        this._0x733e30cd();
    }

    private readonly _0xcdaf2db1[] _0x289f3994 = new _0xcdaf2db1[_0x0ed6b613.ReactorCount];
    private int _0x3734e77a;
    [SerializeField]
    private Sprite _coreSprite;
    /// Assist widens the lit sector on the first reactor. Switching it changes the
    /// preview immediately, so the toggle answers on screen and not only in words.
    private void _0xdcbfd0ee()
    {
        this._0x5b767af3._0x62ecd0de = !this._0x5b767af3._0x62ecd0de;
        this._0x58f9155c._0x1505cab7(this._0x5b767af3._0xb9afba12, this._0x5b767af3._0x62ecd0de);
        this._0x58f9155c._0x413b3f27.transform.DOKill(true);
        this._0x58f9155c._0x413b3f27.transform.DOPunchScale(Vector3.one * 0.06f, 0.26f, 8, 0.7f);
        this._0x733e30cd();
    }

    [SerializeField]
    private Sprite _gearIcon;
    private TextMeshProUGUI _0xa40e4b46;
    private void _0x8102d895(Transform _0x073198b6)
    {
        RectTransform _0x3880a716 = _0x90f57411.Node(_0x073198b6, _0x60468327._0x24d2aeb7(new byte[12] { 192, 247, 243, 241, 230, 253, 224, 193, 230, 224, 251, 226 }, 146), new Vector2(0.5f, 1f), new Vector2(0f, -1600f), new Vector2(1160f, 310f));
        for (int _0x3969f6de = 0; _0x3969f6de < this._0x289f3994.Length; _0x3969f6de++)
        {
            int _0x34c641f3 = _0x3969f6de;
            Image _0x0579cebe = _0x90f57411.Plate(_0x3880a716, _0x60468327._0x24d2aeb7(new byte[11] { 91, 108, 104, 106, 125, 102, 123, 74, 104, 123, 109 }, 9), new Vector2(0.5f, 0.5f), new Vector2((_0x3969f6de - 2) * 214f, 0f), new Vector2(196f, 290f), this._plateSprite, _0x3d55b1de.WithAlpha(_0x3d55b1de.Violet, 0.5f));
            Image _0x37ce0dda = _0x90f57411.Plate(_0x0579cebe.transform, _0x60468327._0x24d2aeb7(new byte[15] { 0, 55, 51, 49, 38, 61, 32, 17, 51, 32, 54, 20, 51, 49, 55 }, 82), new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(176f, 270f), this._plateSprite, _0x3d55b1de.WithAlpha(_0x3d55b1de.Surface, 0.96f));
            _0x37ce0dda.raycastTarget = true;
            _0x37ce0dda.canvasRenderer.cullTransparentMesh = false;
            Button _0x938dc904 = _0x37ce0dda.gameObject.AddComponent<Button>();
            _0x938dc904.targetGraphic = _0x37ce0dda;
            ColorBlock _0x3f8d5fcb = _0x938dc904.colors;
            _0x3f8d5fcb.normalColor = Color.white;
            _0x3f8d5fcb.pressedColor = new Color(0.75f, 0.75f, 0.75f, 1f);
            _0x3f8d5fcb.fadeDuration = 0.08f;
            _0x938dc904.colors = _0x3f8d5fcb;
            _0x938dc904.onClick.AddListener(() => this._0x0012e1a5(_0x34c641f3));
            Image _0x3faf9240 = _0x90f57411.Picture(_0x37ce0dda.transform, _0x60468327._0x24d2aeb7(new byte[12] { 198, 241, 245, 247, 224, 251, 230, 214, 245, 240, 243, 241 }, 148), new Vector2(0.5f, 1f), new Vector2(0f, -56f), new Vector2(92f, 92f), this._badgeSprite, _0x3d55b1de.Cream);
            TextMeshProUGUI _0x72f13b7d = _0x90f57411.Caption(_0x3faf9240.transform, _0x60468327._0x24d2aeb7(new byte[13] { 106, 93, 89, 91, 76, 87, 74, 118, 77, 85, 90, 93, 74 }, 56), new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(80f, 72f), _0x60468327._0x24d2aeb7(new byte[1] { 22 }, 39), 40f, _0x3d55b1de.Ink, TextAlignmentOptions.Center, this._font);
            Image[] _0xfb6a3a00 = new Image[_0x2d6e6a19.RingsPerReactor];
            for (int _0xfe06f71d = 0; _0xfe06f71d < _0xfb6a3a00.Length; _0xfe06f71d++)
            {
                _0xfb6a3a00[_0xfe06f71d] = _0x90f57411.Plate(_0x37ce0dda.transform, _0x60468327._0x24d2aeb7(new byte[8] { 214, 231, 239, 242, 237, 192, 227, 240 }, 130), new Vector2(0.5f, 1f), new Vector2(0f, -132f - (_0xfe06f71d * 24f)), new Vector2(120f, 14f), this._beamSprite, _0x3d55b1de.Channel(_0xfe06f71d));
            }

            TextMeshProUGUI _0x5b3ad9a1 = _0x90f57411.Caption(_0x37ce0dda.transform, _0x60468327._0x24d2aeb7(new byte[9] { 86, 116, 103, 113, 70, 101, 112, 112, 113 }, 21), new Vector2(0.5f, 1f), new Vector2(0f, -210f), new Vector2(168f, 42f), _0x60468327._0x24d2aeb7(new byte[9] { 252, 255, 235, 143, 159, 128, 159, 128, 159 }, 175), 26f, _0x3d55b1de.Cream, TextAlignmentOptions.Center, this._font);
            TextMeshProUGUI _0x911348a2 = _0x90f57411.Caption(_0x37ce0dda.transform, _0x60468327._0x24d2aeb7(new byte[12] { 7, 37, 54, 32, 20, 54, 43, 35, 54, 33, 55, 55 }, 68), new Vector2(0.5f, 1f), new Vector2(0f, -248f), new Vector2(168f, 42f), _0x60468327._0x24d2aeb7(new byte[6] { 132, 135, 139, 131, 141, 140 }, 200), 26f, _0x3d55b1de.Muted, TextAlignmentOptions.Center, this._font);
            _0xcdaf2db1 _0x14832b13 = new _0xcdaf2db1(_0x0579cebe, _0x3faf9240, _0xfb6a3a00, _0x72f13b7d, _0x5b3ad9a1, _0x911348a2);
            _0x14832b13._0x47f66e68 = _0x938dc904;
            this._0x289f3994[_0x3969f6de] = _0x14832b13;
        }
    }

    private TextMeshProUGUI _0x69761b23;
    private void _0x8faf108a()
    {
        this._0x5b767af3._0x447c48e5();
        this._0x3734e77a = 0;
        this._0x733e30cd();
        this._0x58f9155c._0x6b92368f.transform.DOKill(true);
        this._0x58f9155c._0x6b92368f.transform.DOPunchScale(Vector3.one * 0.08f, 0.3f, 8, 0.7f);
    }

    private void _0x733e30cd()
    {
        int _0xdb904f17 = this._0x5b767af3._0x65c86873;
        if (this._0x3734e77a > _0xdb904f17)
        {
            this._0x3734e77a = _0xdb904f17;
            this._0x5b767af3._0x8e46a79e = this._0x3734e77a;
        }

        for (int _0xaa4c0ee5 = 0; _0xaa4c0ee5 < this._0x289f3994.Length; _0xaa4c0ee5++)
        {
            if (this._0x289f3994[_0xaa4c0ee5] == null)
            {
                continue;
            }

            this._0x289f3994[_0xaa4c0ee5]._0xdb45a83f(_0xaa4c0ee5, this._0xefab0e6b[_0xaa4c0ee5], _0xaa4c0ee5 <= _0xdb904f17, _0xaa4c0ee5 <= _0xdb904f17 ? 3 : 0);
            this._0x289f3994[_0xaa4c0ee5]._0x392186ab(_0xaa4c0ee5 == this._0x3734e77a);
        }

        if (this._0x1698d271 != null)
        {
            this._0x1698d271.text = _0x60468327._0x24d2aeb7(new byte[7] { 210, 217, 208, 195, 214, 212, 177 }, 145) + this._0x5b767af3._0x539c9f85;
        }

        int _0x73a0d33e = this._0x5b767af3._0x25e8c63c;
        if (this._0x69761b23 != null)
        {
            this._0x69761b23.text = _0x73a0d33e > 0 ? _0x60468327._0x24d2aeb7(new byte[15] { 234, 237, 251, 252, 136, 251, 252, 233, 234, 225, 228, 225, 252, 241, 136 }, 168) + _0x73a0d33e + _0x60468327._0x24d2aeb7(new byte[1] { 5 }, 32) : _0x60468327._0x24d2aeb7(new byte[11] { 173, 172, 195, 177, 182, 173, 176, 195, 186, 166, 183 }, 227);
        }

        if (this._0xa40e4b46 != null)
        {
            this._0xa40e4b46.text = _0x60468327._0x24d2aeb7(new byte[16] { 159, 136, 140, 142, 153, 130, 159, 158, 237, 130, 131, 129, 132, 131, 136, 237 }, 205) + this._0x5b767af3._0xd1b5b454;
        }

        if (this._0xcca95fc1 != null)
        {
            int _0xab7f4b0a = _0x0ed6b613.ReactorCount - this._0x3734e77a;
            this._0xcca95fc1.text = _0x60468327._0x24d2aeb7(new byte[10] { 207, 200, 221, 222, 213, 208, 213, 198, 217, 188 }, 156) + _0xab7f4b0a + _0x60468327._0x24d2aeb7(new byte[10] { 97, 19, 4, 0, 2, 21, 14, 19, 18, 75 }, 65) + _0xb2f9b5b5.StartingLocks + _0x60468327._0x24d2aeb7(new byte[9] { 69, 41, 42, 38, 46, 54, 69, 72, 69 }, 101) + _0xb2f9b5b5.FaultCap + _0x60468327._0x24d2aeb7(new byte[15] { 140, 234, 237, 249, 224, 248, 255, 140, 237, 224, 224, 227, 251, 233, 232 }, 172);
        }

        if (this._board != null)
        {
            this._board._0xf5da6f19(this._0xdcdb24af(this._0xefab0e6b[this._0x3734e77a]));
            this._board._0x8b477434(0);
        }
    }

    private void _0x5d14dfe7()
    {
        this._0x5b767af3._0xb9afba12 = !this._0x5b767af3._0xb9afba12;
        this._0x58f9155c._0x1505cab7(this._0x5b767af3._0xb9afba12, this._0x5b767af3._0x62ecd0de);
        if (this._0x5b767af3._0xb9afba12)
        {
            try
            {
                Handheld.Vibrate();
            }
            catch (System.Exception)
            {
            }
        }

        this._0x58f9155c._0x59c045f0.transform.DOKill(true);
        this._0x58f9155c._0x59c045f0.transform.DOPunchScale(Vector3.one * 0.06f, 0.26f, 8, 0.7f);
    }

    private _0x4692a919 _0x58f9155c;
    /// The template's play control ships invisible - every layer of its own chrome
    /// is switched off. A face is added as a CHILD of it, so the click still lands
    /// on the template button and this game never loads the scene itself.
    private void _0xbfbb3760()
    {
        if (this._playSlot == null)
        {
            return;
        }

        Transform _0xc7d48763 = this._playSlot.transform;
        Image _0x3ac49dfa = _0x90f57411.Plate(_0xc7d48763, _0x60468327._0x24d2aeb7(new byte[8] { 154, 166, 171, 179, 140, 171, 169, 175 }, 202), new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(770f, 168f), this._plateSprite, _0x3d55b1de.Teal);
        _0x3ac49dfa.raycastTarget = true;
        _0x3ac49dfa.canvasRenderer.cullTransparentMesh = false;
        _0x90f57411.Caption(_0x3ac49dfa.transform, _0x60468327._0x24d2aeb7(new byte[9] { 25, 37, 40, 48, 5, 40, 43, 44, 37 }, 73), new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(700f, 110f), _0x60468327._0x24d2aeb7(new byte[4] { 250, 230, 235, 243 }, 170), 64f, _0x3d55b1de.Ink, TextAlignmentOptions.Center, this._font);
        _0x3ac49dfa.transform.localScale = Vector3.one;
        _0x3ac49dfa.transform.DOScale(1.03f, 1.2f).SetEase(Ease.InOutSine).SetLoops(-1, LoopType.Yoyo);
    }

    private TextMeshProUGUI _0xcca95fc1;
    [SerializeField]
    private Sprite _closeIcon;
    /// A slowed copy of a reactor for the menu. A fast idle would keep the screen
    /// in motion the whole time; this turns just enough to read as alive.
    private _0xdd279fb7 _0xdcdb24af(_0xdd279fb7 _0xa4c95744)
    {
        _0xdd279fb7 _0x080af594 = new _0xdd279fb7();
        _0x080af594.LockBonus = _0xa4c95744 != null ? _0xa4c95744.LockBonus : 5;
        _0x080af594.Seed = _0xa4c95744 != null ? _0xa4c95744.Seed : 0;
        _0x080af594.Rings = new _0xdd279fb7._0x2faff3f3[_0x2d6e6a19.RingsPerReactor];
        for (int _0x16f22cc8 = 0; _0x16f22cc8 < _0x080af594.Rings.Length; _0x16f22cc8++)
        {
            _0xdd279fb7._0x2faff3f3 _0x348e9bcc = _0xa4c95744 != null ? _0xa4c95744._0xae865f5e(_0x16f22cc8) : null;
            _0xdd279fb7._0x2faff3f3 _0x2503142e = new _0xdd279fb7._0x2faff3f3();
            _0x2503142e.SpeedDegPerSecond = (_0x348e9bcc != null ? _0x348e9bcc.SpeedDegPerSecond : 60f) * PreviewTempo;
            _0x2503142e.SectorWidthDeg = _0x348e9bcc != null ? _0x348e9bcc.SectorWidthDeg : 90f;
            _0x2503142e.SectorCenterDeg = _0x348e9bcc != null ? _0x348e9bcc.SectorCenterDeg : 0f;
            _0x2503142e.StartAngleDeg = _0x348e9bcc != null ? _0x348e9bcc.StartAngleDeg : 0f;
            _0x2503142e.Direction = _0x348e9bcc != null ? _0x348e9bcc.Direction : 1;
            _0x2503142e.ChannelIndex = _0x348e9bcc != null ? _0x348e9bcc.ChannelIndex : _0x16f22cc8;
            _0x080af594.Rings[_0x16f22cc8] = _0x2503142e;
        }

        if (this._0x58f9155c != null && !this._0x5b767af3._0x62ecd0de)
        {
            for (int _0x1c864052 = 0; _0x1c864052 < _0x080af594.Rings.Length; _0x1c864052++)
            {
                _0x080af594.Rings[_0x1c864052].SectorWidthDeg = _0x080af594.Rings[_0x1c864052].SectorWidthDeg * 0.7f;
            }
        }

        return _0x080af594;
    }
}

internal static class _0x60468327
{
    internal static string _0x24d2aeb7(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}