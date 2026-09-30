using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class _0xb5ac61db : MonoBehaviour
{
    [HideInInspector]
    public int ScoreCurrent;
    private void Start()
    {
        this.IsGameEnd = false;
        this.TimeLeft = this._0x9c9f67b7;
        this.CurrentGameIndex = _0x8c1ab97d.Instance._0xe504933a;
        foreach (Button _0x61316ebe in this.HomeButtons)
            _0x61316ebe.onClick.AddListener(() =>
            {
                this._0x4b1599f4();
            });
        foreach (Button _0xc8f995c2 in this.PauseButtons)
            _0xc8f995c2.onClick.AddListener(() =>
            {
                _0x8c1ab97d.Instance._0x9c458cc2(false);
                _0xef80cd9f.Instance._0x07905ed2(_0x879a7ea3._0xd10e2316.PAUSE);
            });
        this._0xd1ea451f();
        this.LevelNumberText.ForEach(_0x4b86ce9a => _0x4b86ce9a.text = $"LVL {_0x8c1ab97d._0xd345ba37._0xe5bcbe2a + 1}");
        if (_0x7d2b5afa.Instance.IsTimerEnabled)
        {
            this._0x33072606();
            this.StartCoroutine(this._0x0c47b425());
        }
    }

    private void _0x1d409ac7()
    {
        if (this.ScoreCurrent >= this._0xb94502d0)
            this._0x14a1ae31();
        else
            this._0x48f957ea();
    }

    private void Awake()
    {
        _0x32a1add6 = this.gameObject.GetComponent<_0xb5ac61db>();
    }

    private void _0xd1ea451f()
    {
        if (_0x7d2b5afa.Instance.IsCheckScoreEnabled)
            this.ScoreText.ForEach(_0x4b86ce9a => _0x4b86ce9a.text = $"{this.ScoreCurrent}/{this._0xb94502d0}");
        else
            this.ScoreText.ForEach(_0x4b86ce9a => _0x4b86ce9a.text = $"{this.ScoreCurrent}");
    }

    private int _0xb94502d0 => this.CustomTargetScore + _0x8c1ab97d._0xd345ba37._0xe5bcbe2a * 10;

    private void _0xf4ffffa7()
    {
        if (this.ScoreCurrent > _0x8c1ab97d._0xd345ba37._0x049ab033)
            _0x8c1ab97d._0xd345ba37._0x049ab033 = this.ScoreCurrent;
        if (_0x7d2b5afa.Instance.IsCheckScoreEnabled)
            if (this.ScoreCurrent >= this._0xb94502d0)
                this._0x14a1ae31();
    }

    public int CustomTargetScore = 10;
    public void _0x4b1599f4()
    {
        _0x8c1ab97d.Instance._0x9c458cc2(true);
        _0x8c1ab97d.Instance.LoadSceneByIndex(_0x879a7ea3._0x70908a3f.SCENE_0);
    }

    [HideInInspector]
    public int TimeLeft;
    public List<Button> PauseButtons = new();
    [HideInInspector]
    public int CurrentGameIndex;
    public void _0x21142282(int scoreToAdd)
    {
        if (!this.IsGameEnd)
        {
            this.ScoreCurrent += scoreToAdd;
            this._0xd1ea451f();
            this._0xf4ffffa7();
        }
    }

    public void _0x14a1ae31()
    {
        if (!this.IsGameEnd)
        {
            this._0x4df4c7ca();
            _0x8c1ab97d.IsAfterLevelComplete = true;
            _0x8c1ab97d.IsAfterLevelFailed = false;
            _0x72c4d902 _0xc08f8102 = _0xef80cd9f.Instance._0x35b7272f(_0x879a7ea3._0xd10e2316.WIN).GetComponent<_0x72c4d902>();
            if (_0x7d2b5afa.Instance.IsCheckScoreEnabled)
                _0xc08f8102.ContentMainText.text = $"{this.ScoreCurrent}/{this._0xb94502d0}";
            else
                _0xc08f8102.ContentMainText.text = $"{this.ScoreCurrent}";
            if (_0x7d2b5afa.Instance.IsBestScoreEnabled)
            {
                if (this.ScoreCurrent > _0x879a7ea3._0x6cc1cd18._0xc7266c3f)
                    _0x879a7ea3._0x6cc1cd18._0xc7266c3f = this.ScoreCurrent;
                _0xc08f8102.ContentAdditionalText.text = $"{_0x879a7ea3._0x6cc1cd18._0xc7266c3f}";
            }
            else
            {
                _0xc08f8102.ContentAdditionalText.text = $"{this._0x95a6cb64}";
                _0x879a7ea3._0x6cc1cd18._0xc7266c3f += this._0x95a6cb64;
            }

            if (_0x7d2b5afa.Instance.IsLevelIncrementOnWin)
                ++_0x8c1ab97d._0xd345ba37._0xe5bcbe2a;
            _0xef80cd9f.Instance._0x07905ed2(_0x879a7ea3._0xd10e2316.WIN);
        }
    }

    private int _0x95a6cb64 => this.ScoreCurrent;

    public List<Button> HomeButtons = new();
    [HideInInspector]
    public bool IsGameEnd;
    private IEnumerator _0x0c47b425()
    {
        this._0x33072606();
        while (!this.IsGameEnd && this.TimeLeft > 0 && _0x8c1ab97d.Instance._0xe504933a == this.CurrentGameIndex)
        {
            yield return new WaitForSeconds(1f);
            if (_0x8c1ab97d.Instance._0xf09af649)
            {
                if (this.IsGameEnd)
                    break;
                this.TimeLeft--;
                this._0x33072606();
            }
        }

        if (!this.IsGameEnd)
            this._0x48f957ea();
    }

    private int _0x9c9f67b7 => this.CustomTimeInitial + _0x8c1ab97d._0xd345ba37._0xe5bcbe2a * 10;

    public List<TMP_Text> ScoreText = new();
    private void _0x33072606()
    {
        this.TimerText.ForEach(_0x4b86ce9a => _0x4b86ce9a.text = TimeSpan.FromSeconds(this.TimeLeft).ToString(_0x64e42e93._0xfe0c46c9(new byte[6] { 187, 187, 138, 236, 165, 165 }, 214)));
    }

    public List<TMP_Text> LevelNumberText = new();
    public List<TMP_Text> TimerText = new();
    public void _0x48f957ea()
    {
        if (_0x7d2b5afa.Instance.IsOnlyWinGameEndEnabled)
            this._0x14a1ae31();
        if (!this.IsGameEnd)
        {
            this._0x4df4c7ca();
            _0x8c1ab97d.IsAfterLevelComplete = false;
            _0x8c1ab97d.IsAfterLevelFailed = true;
            _0x72c4d902 _0xf54afbae = _0xef80cd9f.Instance._0x35b7272f(_0x879a7ea3._0xd10e2316.LOSE).GetComponent<_0x72c4d902>();
            if (_0x7d2b5afa.Instance.IsCheckScoreEnabled)
                _0xf54afbae.ContentMainText.text = $"{this.ScoreCurrent}/{this._0xb94502d0}";
            else
                _0xf54afbae.ContentMainText.text = $"{this.ScoreCurrent}";
            _0xf54afbae.ContentAdditionalText.text = $"{0}";
            _0x879a7ea3._0x6cc1cd18._0xc7266c3f += 0;
            _0xef80cd9f.Instance._0x07905ed2(_0x879a7ea3._0xd10e2316.LOSE);
        }
    }

    private static _0xb5ac61db _0x32a1add6;
    private void _0x4df4c7ca()
    {
        this.IsGameEnd = true;
        _0x8c1ab97d.IsAfterLevelComplete = true;
    }

    public List<TMP_Text> SubtitleText = new();
    public int CustomTimeInitial = 30;
}

internal static class _0x64e42e93
{
    internal static string _0xfe0c46c9(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}