using UnityEngine;

/// Everything this game remembers between sessions. A plain instance class, not a
/// singleton: each director owns one and asks it for values.
public sealed class _0x0ed6b613
{
    public int _0x8e46a79e
    {
        get
        {
            return Mathf.Clamp(PlayerPrefs.GetInt(SelectedReactorKey, 0), 0, ReactorCount - 1);
        }

        set
        {
            PlayerPrefs.SetInt(SelectedReactorKey, Mathf.Clamp(value, 0, ReactorCount - 1));
        }
    }

    public const int ReactorCount = 5;
    public int _0x25e8c63c
    {
        get
        {
            return PlayerPrefs.GetInt(BestStabilityKey, 0);
        }

        set
        {
            PlayerPrefs.SetInt(BestStabilityKey, Mathf.Clamp(value, 0, 100));
        }
    }

    public bool _0x62ecd0de
    {
        get
        {
            return PlayerPrefs.GetInt(AssistKey, 1) == 1;
        }

        set
        {
            PlayerPrefs.SetInt(AssistKey, value ? 1 : 0);
        }
    }

    private static readonly string BestStabilityKey = _0x979b8c9b._0x498b101a(new byte[17] { 167, 163, 138, 183, 176, 166, 161, 138, 166, 161, 180, 183, 188, 185, 188, 161, 172 }, 213);
    public bool _0xb9afba12
    {
        get
        {
            return PlayerPrefs.GetInt(HapticsKey, 1) == 1;
        }

        set
        {
            PlayerPrefs.SetInt(HapticsKey, value ? 1 : 0);
        }
    }

    public void _0x447c48e5()
    {
        PlayerPrefs.DeleteKey(BestStabilityKey);
        PlayerPrefs.DeleteKey(ReactorsOnlineKey);
        PlayerPrefs.DeleteKey(SelectedReactorKey);
        PlayerPrefs.DeleteKey(UnlockedReactorKey);
        _0x879a7ea3._0x6cc1cd18._0xc7266c3f = 0;
        PlayerPrefs.Save();
    }

    /// Highest reactor the player may start from. Reactor 0 is always open.
    public int _0x65c86873
    {
        get
        {
            return Mathf.Clamp(PlayerPrefs.GetInt(UnlockedReactorKey, 0), 0, ReactorCount - 1);
        }

        set
        {
            PlayerPrefs.SetInt(UnlockedReactorKey, Mathf.Clamp(value, 0, ReactorCount - 1));
        }
    }

    private static readonly string SelectedReactorKey = _0x979b8c9b._0x498b101a(new byte[19] { 118, 114, 91, 119, 97, 104, 97, 103, 112, 97, 96, 91, 118, 97, 101, 103, 112, 107, 118 }, 4);
    private static readonly string ReactorsOnlineKey = _0x979b8c9b._0x498b101a(new byte[18] { 20, 16, 57, 20, 3, 7, 5, 18, 9, 20, 21, 57, 9, 8, 10, 15, 8, 3 }, 102);
    public int _0x539c9f85
    {
        get
        {
            return _0x879a7ea3._0x6cc1cd18._0xc7266c3f;
        }
    }

    private static readonly string AssistKey = _0x979b8c9b._0x498b101a(new byte[9] { 172, 168, 129, 191, 173, 173, 183, 173, 170 }, 222);
    public void _0x89b30cce(int _0x9ebcd8cd, int _0xf51ac8da)
    {
        if (_0x9ebcd8cd > this._0x25e8c63c)
        {
            this._0x25e8c63c = _0x9ebcd8cd;
        }

        this._0xd1b5b454 = this._0xd1b5b454 + _0xf51ac8da;
        int _0x79598770 = Mathf.Clamp(_0xf51ac8da, 0, ReactorCount - 1);
        if (_0x79598770 > this._0x65c86873)
        {
            this._0x65c86873 = _0x79598770;
        }

        PlayerPrefs.Save();
    }

    public int _0xd1b5b454
    {
        get
        {
            return PlayerPrefs.GetInt(ReactorsOnlineKey, 0);
        }

        set
        {
            PlayerPrefs.SetInt(ReactorsOnlineKey, Mathf.Max(0, value));
        }
    }

    public void _0x76985bb5(int _0x86f02933)
    {
        if (_0x86f02933 <= 0)
        {
            return;
        }

        _0x879a7ea3._0x6cc1cd18._0xc7266c3f = _0x879a7ea3._0x6cc1cd18._0xc7266c3f + _0x86f02933;
        PlayerPrefs.Save();
    }

    private static readonly string HapticsKey = _0x979b8c9b._0x498b101a(new byte[10] { 167, 163, 138, 189, 180, 165, 161, 188, 182, 166 }, 213);
    private static readonly string UnlockedReactorKey = _0x979b8c9b._0x498b101a(new byte[19] { 142, 138, 163, 137, 146, 144, 147, 159, 151, 153, 152, 163, 142, 153, 157, 159, 136, 147, 142 }, 252);
}

internal static class _0x979b8c9b
{
    internal static string _0x498b101a(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}