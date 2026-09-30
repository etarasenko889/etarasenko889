using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using static _0x879a7ea3;

public class _0xa80fd29e : MonoBehaviour
{
    public int CurrentPanelIndex;
    private void _0x85a38fad(int _0xf1fc739f)
    {
        if (_0xf1fc739f == _0x6776f348.SPLASH)
            _0xece3c3b8.Instance._0x4e4950d0();
        if (_0x8c1ab97d.Instance._0xe504933a == _0x70908a3f.SCENE_0)
        {
        }
    }

    private _0x2b190913 _0x42c2c68c(int _0xef11c28c)
    {
        return this.Panels[_0xef11c28c];
    }

    private void _0x88e770b1(int _0x6e039378)
    {
        this.LastPanelIndexes.Add(_0x6e039378);
        this.CurrentPanelIndex = _0x6e039378;
        for (int _0xe762a603 = 0; _0xe762a603 < this.Panels.Count; _0xe762a603++)
            if (_0xe762a603 != _0x6e039378 && this.Panels[_0xe762a603] != null)
                this.Panels[_0xe762a603]._0x3010f5bf();
    }

    public float ScaleDuration = 0.4f;
    public void _0x2f051001()
    {
        this.LastPanelIndexes.RemoveAll(_0xa8e1f67e => _0xa8e1f67e == this.CurrentPanelIndex);
        int _0x4c27cc78 = this.LastPanelIndexes.Last();
        this._0x85a38fad(_0x4c27cc78);
        this._0x88e770b1(_0x4c27cc78);
        this.CurrentPanelIndex = _0x4c27cc78;
        this.Panels[_0x4c27cc78].Show();
    }

    private void _0x0641c03b(int _0x08b5b663)
    {
        this.LastPanelIndexes.Add(_0x08b5b663);
        this.CurrentPanelIndex = _0x08b5b663;
        for (int _0x792bcfdf = 0; _0x792bcfdf < this.Panels.Count; _0x792bcfdf++)
            if (_0x792bcfdf != _0x08b5b663 && this.Panels[_0x792bcfdf] != null)
                this.Panels[_0x792bcfdf]._0x3010f5bf();
    }

    public void _0x12a8d7fd(int _0xabe9d0bc)
    {
        if (_0xabe9d0bc == _0x6776f348.SPLASH && _0x8c1ab97d.Instance._0xe504933a != _0x70908a3f.SCENE_0)
            _0xece3c3b8.Instance._0xea26e704();
        if (_0x8c1ab97d.Instance._0xe504933a != _0x70908a3f.SCENE_0)
        {
            if (_0xabe9d0bc == _0x6776f348.SPLASH || _0xabe9d0bc == _0x6776f348.TUTORIAL0)
                _0x8c1ab97d.Instance._0x9c458cc2(false);
            else if (_0xabe9d0bc == _0x6776f348.DEFAULT)
                _0x8c1ab97d.Instance._0x9c458cc2(true);
        }
    }

    private void _0x88fca217()
    {
        this._0x3deb1c60(_0x6776f348.SPLASH);
        if (_0x8c1ab97d.Instance._0xe504933a == _0x70908a3f.SCENE_0)
        {
        }
        else
        {
            this.Invoke(nameof(this.SwitchSplash), _0xece3c3b8.Instance.DefaultAnimationTime);
        }
    }

    private void Start()
    {
        this._0x88fca217();
    }

    public List<_0x2b190913> Panels;
    public static _0xa80fd29e Instance;
    public float StaticBlurMaterialInitialValue;
    private void SwitchSplash()
    {
        if (_0x7d2b5afa.Instance.IsTutorialEnabled && !_0x8c1ab97d._0xd345ba37._0xc450b058)
            this._0xa19e587c(_0x6776f348.TUTORIAL0);
        else
            this._0xa19e587c(_0x6776f348.DEFAULT);
    }

    private void _0x3deb1c60(int _0xac5adf1b)
    {
        this._0x0641c03b(_0xac5adf1b);
        this._0x85a38fad(_0xac5adf1b);
        this.CurrentPanelIndex = _0xac5adf1b;
        this.Panels[_0xac5adf1b]._0x27756275();
    }

    [HideInInspector]
    public List<int> LastPanelIndexes = new()
    {
        1
    };
    public bool IsShowSplashOnStart = true;
    private void Awake()
    {
        Instance = this.gameObject.GetComponent<_0xa80fd29e>();
    }

    public void _0xa19e587c(int _0x141a63d0)
    {
        this._0x0641c03b(_0x141a63d0);
        this._0x85a38fad(_0x141a63d0);
        this.CurrentPanelIndex = _0x141a63d0;
        this.Panels[_0x141a63d0].Show();
    }
}