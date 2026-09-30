using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// Drives one run: five reactors, a shared bank of locks and three faults.
/// A run never ends by itself - there is no clock and no draining gauge, only the
/// player's own taps can finish it - so the reactor keeps turning for as long as
/// nobody touches the screen.
public sealed class _0xb2f9b5b5 : MonoBehaviour
{
    [SerializeField]
    private Sprite _pipSprite;
    private const int ChargePerLock = 120;
    private int _0x6ac79a58;
    private const int ChargePerStreak = 40;
    private const int AssistLocks = 2;
    private void _0xc21f49ef(bool _0x2d80b0da)
    {
        if (!this._0xe5fcc7d1)
        {
            return;
        }

        this._0xe5fcc7d1 = false;
        this._0x60ea3698 = false;
        int _0xd8ca9b5b = _0x2d80b0da ? ReactorsPerRun : this._0x6083ff19;
        int _0x77a9826d = Mathf.RoundToInt(100f * this._0x5fe91ea8 / _0x19ca4811.EnergyCells);
        int _0xe68d6866 = this._0x728ac124 > 0 ? Mathf.RoundToInt(100f * this._0xa9758479 / this._0x728ac124) : 0;
        this._0x361bc395._0x76985bb5(this._0x44fa216b);
        this._0x361bc395._0x89b30cce(_0x77a9826d, _0xd8ca9b5b);
        if (this._pops == null)
        {
            return;
        }

        if (_0x2d80b0da)
        {
            this._pops._0xbc5889fb(_0x77a9826d, _0xe68d6866, this._0x44fa216b);
            this._pops._0x2deb75df();
        }
        else
        {
            this._pops._0x87cf28b0(_0xd8ca9b5b, ReactorsPerRun, _0xe68d6866, this._0x361bc395._0x25e8c63c);
            this._pops._0x94374b89();
        }
    }

    private _0xdd279fb7 _0x8cc6550d;
    private int _0x0d55aee4;
    private int _0x5fe91ea8;
    private int _0x73c77dcc = StartingLocks;
    private int _0x1651fd70()
    {
        if (this._board == null)
        {
            return 0;
        }

        for (int _0xd514b677 = 0; _0xd514b677 < _0xdd436667.RingCount; _0xd514b677++)
        {
            _0xcfe49eb1 _0xe9fa4776 = this._board._0x33e37713(_0xd514b677);
            if (_0xe9fa4776 != null && !_0xe9fa4776._0x38bad96e)
            {
                return _0xd514b677;
            }
        }

        return -1;
    }

    private const float ResolveSeconds = 1.4f;
    private void _0xf2d8e281(_0xcfe49eb1 _0x87eb7401)
    {
        this._0x8975072f = this._0x8975072f + 1;
        this._0x0d55aee4 = 0;
        _0x87eb7401._0x2b83de08(1.08f);
        this._board._0x359d03e5();
        this._0x0d5dc1e1();
    }

    private void _0x383aed82()
    {
        if (this._0x17e2debb != null && this._0x17e2debb._0x0003437b)
        {
            this._0x17e2debb._0x19b079d3();
        }
    }

    [SerializeField]
    private Sprite _pauseIcon;
    [SerializeField]
    private Sprite _beamSprite;
    [SerializeField]
    private Sprite _energyCellSprite;
    private int _0x6083ff19;
    private bool _0x60ea3698;
    private bool _0xe5fcc7d1;
    private const float AssistPullDeg = 80f;
    private void _0x9ed174d5()
    {
        if (!this._0xe5fcc7d1 || this._0xc391fdaa || this._pops == null)
        {
            return;
        }

        this._0xc391fdaa = true;
        _0x8c1ab97d _0x35365edb = _0x8c1ab97d.Instance;
        if (_0x35365edb != null)
        {
            _0x35365edb._0x9c458cc2(false);
        }

        this._pops._0x41bdcd5d(this._0x6083ff19, ReactorsPerRun, this._0x73c77dcc);
        this._pops._0x9dc63bb9();
    }

    private int _0x44fa216b;
    private int _0x2eee8b30;
    private void _0x171ff974()
    {
        _0x8c1ab97d _0x6d9e18e3 = _0x8c1ab97d.Instance;
        if (_0x6d9e18e3 != null)
        {
            _0x6d9e18e3._0x9c458cc2(true);
            _0x6d9e18e3.LoadSceneByIndex(_0x879a7ea3._0x70908a3f.SCENE_0);
        }
    }

    [SerializeField]
    private _0x82bed0d9 _pops;
    private void _0x3a8b8883(bool _0xfefce839)
    {
        this._0x8cc6550d = this._0x39cd3406._0x625415d7(this._0x6083ff19, this._0x6083ff19 + 1);
        if (this._board != null)
        {
            this._board._0xf5da6f19(this._0x8cc6550d);
            this._board._0x8b477434(this._0x1651fd70());
        }

        this._0x4a9c01bc._0xfbba1cb1(this._0x6083ff19, ReactorsPerRun);
        this._0x4a9c01bc._0xcc27412c(this._0x5fe91ea8);
        this._0x4a9c01bc._0x04e59da5(this._0x8975072f, FaultCap, this._0x73c77dcc);
        this._0x4a9c01bc._0xfe7df36a();
        for (int _0xb6935678 = 0; _0xb6935678 < _0x2d6e6a19.RingsPerReactor; _0xb6935678++)
        {
            _0xdd279fb7._0x2faff3f3 _0x68da6353 = this._0x8cc6550d._0xae865f5e(_0xb6935678);
            this._0x4a9c01bc._0x96646382(_0xb6935678, _0xb6935678 + 1, _0x68da6353 != null ? _0x68da6353.SpeedDegPerSecond : 0f, false, _0x3d55b1de.Channel(_0x68da6353 != null ? _0x68da6353.ChannelIndex : _0xb6935678));
            this._0x4a9c01bc._0x78c4c88f(_0xb6935678, false, _0x3d55b1de.Channel(_0xb6935678));
        }

        if (_0xfefce839 && this._0x17e2debb != null)
        {
            this._0x17e2debb.Show(this._0x6083ff19, ReactorsPerRun, this._0x8cc6550d, this._0x73c77dcc, this._0x8975072f, FaultCap);
            this._0x17e2debb._0xd21f58bb(() => this._0x383aed82());
        }
    }

    [SerializeField]
    private Sprite _missPipSprite;
    private int _0x728ac124;
    [SerializeField]
    private Sprite _plateSprite;
    private bool _0xc391fdaa;
    private void _0x60279d09()
    {
        if (this._pops != null)
        {
            this._pops._0x86ba9580();
        }

        this._0xc391fdaa = false;
        _0x8c1ab97d _0x14cf2adf = _0x8c1ab97d.Instance;
        if (_0x14cf2adf != null)
        {
            _0x14cf2adf._0x9c458cc2(true);
        }
    }

    private const int ChargeStreakCap = 200;
    [SerializeField]
    private TMP_FontAsset _font;
    private readonly _0x2d6e6a19 _0x39cd3406 = new _0x2d6e6a19();
    private const int ChargePerReactor = 500;
    [SerializeField]
    private Sprite _backIcon;
    private int _0x8975072f;
    private void Start()
    {
        _0xfe173679.BlankUnusedPanels();
        _0xfe173679.ThemeSplashSlider();
        _0xfe173679.DressSplash(this._font, this._coreSprite, this._pipSprite, this._plateSprite);
        _0xfe173679.ClearPanelBody(_0x879a7ea3._0x6776f348.DEFAULT);
        Transform _0xb1308b72 = _0xfe173679.PanelBody(_0x879a7ea3._0x6776f348.DEFAULT);
        if (_0xb1308b72 == null)
        {
            return;
        }

        this._0x4a9c01bc = new _0x19ca4811(this._font, this._plateSprite, this._energyCellSprite, this._missPipSprite, this._beamSprite);
        this._0x4a9c01bc._0x89df6a81(_0xb1308b72, this._backIcon, this._pauseIcon);
        this._0x17e2debb = new _0xa36bc711(this._font, this._plateSprite);
        this._0x17e2debb._0x23b901d3(_0xb1308b72);
        if (this._pops != null)
        {
            this._pops._0x12a08ad7();
        }

        this._0x3e9381cc();
        this._0xf8531a03();
    }

    private readonly _0x0ed6b613 _0x361bc395 = new _0x0ed6b613();
    private void _0xf8531a03()
    {
        this._0x6ac79a58 = Mathf.Clamp(this._0x361bc395._0x8e46a79e, 0, ReactorsPerRun - 1);
        this._0x6083ff19 = this._0x6ac79a58;
        this._0x73c77dcc = StartingLocks;
        this._0x8975072f = 0;
        this._0x5fe91ea8 = this._0x6ac79a58 * _0x2d6e6a19.RingsPerReactor;
        this._0x44fa216b = 0;
        this._0x0d55aee4 = 0;
        this._0xa9758479 = 0;
        this._0x728ac124 = 0;
        this._0x2eee8b30 = 0;
        this._0xe5fcc7d1 = true;
        this._0xc391fdaa = false;
        this._0x60ea3698 = false;
        this._0x3a8b8883(true);
    }

    [SerializeField]
    private Sprite _coreSprite;
    private void _0xc2aa6de0()
    {
        bool _0x5e2656af = this._0x1651fd70() < 0;
        if (_0x5e2656af)
        {
            this._0x60ea3698 = true;
            this._0x44fa216b = this._0x44fa216b + ChargePerReactor;
            this._board._0xfeb26ba4();
            this._0x4a9c01bc._0xb7ad079d(_0xf011f4f6._0xb0fdfb22(new byte[14] { 177, 166, 162, 160, 183, 172, 177, 195, 176, 183, 162, 161, 175, 166 }, 227));
            DOVirtual.DelayedCall(ResolveSeconds, () => this._0xb86847dd());
            return;
        }

        if (this._0x8975072f >= FaultCap || this._0x73c77dcc <= 0)
        {
            this._0xc21f49ef(false);
        }
    }

    private int _0xa9758479;
    private void _0xb86847dd()
    {
        this._0x4a9c01bc._0xfe7df36a();
        if (this._0x6083ff19 + 1 >= ReactorsPerRun)
        {
            this._0xc21f49ef(true);
            return;
        }

        this._0x6083ff19 = this._0x6083ff19 + 1;
        this._0x60ea3698 = false;
        this._0x3a8b8883(false);
    }

    private void Update()
    {
        if (this._board == null || this._0xc391fdaa)
        {
            return;
        }

        this._board.Advance(Time.deltaTime, this._0x1651fd70());
    }

    private void _0x0d5dc1e1()
    {
        if (!this._0x361bc395._0xb9afba12)
        {
            return;
        }

        try
        {
            Handheld.Vibrate();
        }
        catch (System.Exception)
        {
        }
    }

    private _0xa36bc711 _0x17e2debb;
    private void _0xb0b67dec()
    {
        _0x8c1ab97d _0x3dfe893a = _0x8c1ab97d.Instance;
        if (_0x3dfe893a != null)
        {
            _0x3dfe893a.LoadSceneByIndex(_0x879a7ea3._0x70908a3f.SCENE_1);
        }
    }

    private void _0x70c9af21()
    {
        int _0xa75aba26 = this._0x1651fd70();
        _0xcfe49eb1 _0xa66e9883 = _0xa75aba26 >= 0 ? this._board._0x33e37713(_0xa75aba26) : null;
        if (_0xa66e9883 == null || _0xa66e9883._0xf05240bf == null)
        {
            return;
        }

        float _0x899252b4 = Mathf.Abs(_0xa66e9883._0xba39a0de());
        float _0xa5744867 = _0xa66e9883._0xf05240bf.SectorWidthDeg * 0.5f;
        bool _0x1896b741 = this._0x361bc395._0x62ecd0de && this._0x6083ff19 == this._0x6ac79a58 && this._0x2eee8b30 < AssistLocks;
        bool _0xd7f26279 = _0x899252b4 <= _0xa5744867;
        if (!_0xd7f26279 && _0x1896b741 && _0x899252b4 <= _0xa5744867 + AssistPullDeg)
        {
            _0xa66e9883._0xfc454d7d();
            _0xd7f26279 = true;
        }

        if (_0x1896b741)
        {
            this._0x2eee8b30 = this._0x2eee8b30 + 1;
        }

        this._0x728ac124 = this._0x728ac124 + 1;
        this._0x73c77dcc = Mathf.Max(0, this._0x73c77dcc - 1);
        if (_0xd7f26279)
        {
            this._0x12ab0961(_0xa75aba26, _0xa66e9883);
        }
        else
        {
            this._0xf2d8e281(_0xa66e9883);
        }

        this._0x4a9c01bc._0x04e59da5(this._0x8975072f, FaultCap, this._0x73c77dcc);
        this._0x4a9c01bc._0xcc27412c(this._0x5fe91ea8);
        this._0xc2aa6de0();
    }

    public const int StartingLocks = 22;
    public const int ReactorsPerRun = 5;
    [SerializeField]
    private _0xdd436667 _board;
    public const int FaultCap = 3;
    private void _0x3e9381cc()
    {
        if (this._0x4a9c01bc._0x99cbb9a4 != null)
        {
            _0x64107339 _0x391cbb06 = this._0x4a9c01bc._0x99cbb9a4.gameObject.AddComponent<_0x64107339>();
            _0x391cbb06._0x364c24b1(() => this._0x163ff356());
        }

        if (this._0x4a9c01bc._0x348cbe99 != null)
        {
            this._0x4a9c01bc._0x348cbe99.onClick.AddListener(() => this._0x171ff974());
        }

        if (this._0x4a9c01bc._0x4b131100 != null)
        {
            this._0x4a9c01bc._0x4b131100.onClick.AddListener(() => this._0x9ed174d5());
        }

        if (this._0x17e2debb._0x21e96618 != null)
        {
            Button _0x1f0b450b = this._0x17e2debb._0x21e96618.gameObject.AddComponent<Button>();
            _0x1f0b450b.targetGraphic = this._0x17e2debb._0x21e96618;
            _0x1f0b450b.transition = Selectable.Transition.None;
            _0x1f0b450b.onClick.AddListener(() => this._0x383aed82());
        }

        if (this._0x17e2debb._0xdc60a31a != null)
        {
            this._0x17e2debb._0xdc60a31a.onClick.AddListener(() => this._0x383aed82());
        }

        if (this._pops == null)
        {
            return;
        }

        if (this._pops._0x4d70b547 != null)
        {
            this._pops._0x4d70b547.onClick.AddListener(() => this._0x60279d09());
        }

        if (this._pops._0x160300b6 != null)
        {
            this._pops._0x160300b6.onClick.AddListener(() => this._0x60279d09());
        }

        if (this._pops._0xfd4ebf24 != null)
        {
            this._pops._0xfd4ebf24.onClick.AddListener(() => this._0x171ff974());
        }

        if (this._pops._0xd5bdf65e != null)
        {
            this._pops._0xd5bdf65e.onClick.AddListener(() => this._0xb0b67dec());
        }

        if (this._pops._0xc944a03a != null)
        {
            this._pops._0xc944a03a.onClick.AddListener(() => this._0x171ff974());
        }

        if (this._pops._0x9dfb7d7c != null)
        {
            this._pops._0x9dfb7d7c.onClick.AddListener(() => this._0x171ff974());
        }

        if (this._pops._0x1183bd37 != null)
        {
            this._pops._0x1183bd37.onClick.AddListener(() => this._0xb0b67dec());
        }

        if (this._pops._0xbd80b1b2 != null)
        {
            this._pops._0xbd80b1b2.onClick.AddListener(() => this._0x171ff974());
        }

        if (this._pops._0xf85db073 != null)
        {
            this._pops._0xf85db073.onClick.AddListener(() => this._0x171ff974());
        }
    }

    private _0x19ca4811 _0x4a9c01bc;
    private void _0x163ff356()
    {
        if (this._0x17e2debb != null && this._0x17e2debb._0x0003437b)
        {
            this._0x383aed82();
            return;
        }

        if (!this._0xe5fcc7d1 || this._0xc391fdaa || this._0x60ea3698)
        {
            return;
        }

        this._0x70c9af21();
    }

    private void _0x12ab0961(int _0x6ba0e7bb, _0xcfe49eb1 _0xa96a8b1b)
    {
        _0xa96a8b1b._0xc334ddcb();
        this._0xa9758479 = this._0xa9758479 + 1;
        this._0x5fe91ea8 = Mathf.Min(_0x19ca4811.EnergyCells, this._0x5fe91ea8 + 1);
        this._0x44fa216b = this._0x44fa216b + ChargePerLock + Mathf.Min(ChargeStreakCap, ChargePerStreak * this._0x0d55aee4);
        this._0x0d55aee4 = this._0x0d55aee4 + 1;
        this._0x4a9c01bc._0x78c4c88f(_0x6ba0e7bb, true, _0xa96a8b1b._0x70e803b9);
        this._0x4a9c01bc._0x96646382(_0x6ba0e7bb, _0x6ba0e7bb + 1, _0xa96a8b1b._0xf05240bf.SpeedDegPerSecond, true, _0xa96a8b1b._0x70e803b9);
        this._board._0x8b477434(this._0x1651fd70());
    }
}

internal static class _0xf011f4f6
{
    internal static string _0xb0fdfb22(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}