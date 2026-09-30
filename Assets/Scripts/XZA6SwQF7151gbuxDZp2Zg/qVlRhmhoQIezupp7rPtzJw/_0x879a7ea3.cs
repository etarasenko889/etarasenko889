using System;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public static class _0x879a7ea3
{
    public static class _0x70908a3f
    {
        public static readonly int SCENE_0 = 0;
        public static readonly int SCENE_1 = 1;
    }

    public class _0x188d8823
    {
        private static readonly _0x188d8823 _0xaa95f810 = new();
        public static readonly _0x188d8823[] ALL_SCENES_SETTING_SINGLETONS =
        {
            _0xaa95f810,
            _0xaa95f810,
            _0xaa95f810,
        };
        private int _0xabf8f0c8 => 0;
        private int _0xa6952c08 => 10;
        private string _0x76ae5085 => _0x0a287b22._0xef66a2e2(new byte[4] { 129, 169, 162, 185 }, 204);
        private string _0xc8f5eb2d => _0x0a287b22._0xef66a2e2(new byte[8] { 86, 95, 76, 95, 86, 97, 42, 103 }, 26);

        private int _0xd7e7f614
        {
            get
            {
                if (!PlayerPrefs.HasKey(_0x0a287b22._0xef66a2e2(new byte[25] { 53, 3, 4, 4, 19, 24, 2, 49, 26, 25, 20, 23, 26, 53, 30, 23, 6, 2, 19, 4, 63, 24, 18, 19, 14 }, 118)))
                    PlayerPrefs.SetInt(_0x0a287b22._0xef66a2e2(new byte[25] { 255, 201, 206, 206, 217, 210, 200, 251, 208, 211, 222, 221, 208, 255, 212, 221, 204, 200, 217, 206, 245, 210, 216, 217, 196 }, 188), 0);
                return PlayerPrefs.GetInt(_0x0a287b22._0xef66a2e2(new byte[25] { 59, 13, 10, 10, 29, 22, 12, 63, 20, 23, 26, 25, 20, 59, 16, 25, 8, 12, 29, 10, 49, 22, 28, 29, 0 }, 120));
            }

            set => PlayerPrefs.SetInt(_0x0a287b22._0xef66a2e2(new byte[25] { 252, 202, 205, 205, 218, 209, 203, 248, 211, 208, 221, 222, 211, 252, 215, 222, 207, 203, 218, 205, 246, 209, 219, 218, 199 }, 191), value);
        }

        public int _0xe5bcbe2a
        {
            get
            {
                if (!PlayerPrefs.HasKey($"{this._0x76ae5085}CurrentLevelIndex"))
                    PlayerPrefs.SetInt($"{this._0x76ae5085}CurrentLevelIndex", 0);
                return PlayerPrefs.GetInt($"{this._0x76ae5085}CurrentLevelIndex");
            }

            set => PlayerPrefs.SetInt($"{this._0x76ae5085}CurrentLevelIndex", value);
        }

        public int _0x049ab033
        {
            get
            {
                if (!PlayerPrefs.HasKey($"{this._0x76ae5085}BestScore"))
                    this._0x049ab033 = 0;
                return PlayerPrefs.GetInt($"{this._0x76ae5085}BestScore");
            }

            set => PlayerPrefs.SetInt($"{this._0x76ae5085}BestScore", value);
        }

        public bool _0xc450b058
        {
            get
            {
                if (!PlayerPrefs.HasKey($"{this._0x76ae5085}IsGameTutorPassed"))
                    PlayerPrefs.SetInt($"{this._0x76ae5085}IsGameTutorPassed", Convert.ToInt32(false));
                return PlayerPrefs.GetInt($"{this._0x76ae5085}IsGameTutorPassed") == 1;
            }

            set => PlayerPrefs.SetInt($"{this._0x76ae5085}IsGameTutorPassed", Convert.ToInt32(value));
        }
    }

    public static class _0x6cc1cd18
    {
        public static int _0xc7266c3f
        {
            get
            {
                if (!PlayerPrefs.HasKey(_0x0a287b22._0xef66a2e2(new byte[5] { 120, 84, 82, 85, 72 }, 59)))
                    PlayerPrefs.SetInt(_0x0a287b22._0xef66a2e2(new byte[5] { 25, 53, 51, 52, 41 }, 90), 0);
                return PlayerPrefs.GetInt(_0x0a287b22._0xef66a2e2(new byte[5] { 175, 131, 133, 130, 159 }, 236));
            }

            set
            {
                PlayerPrefs.SetInt(_0x0a287b22._0xef66a2e2(new byte[5] { 189, 145, 151, 144, 141 }, 254), value);
                _0x8c1ab97d.Instance._0xf3d23356();
            }
        }
    }

    public static class _0xd10e2316
    {
        public static readonly int PAUSE = 6;
        public static readonly int WIN = 7;
        public static readonly int LOSE = 8;
    }

    public static class _0x6776f348
    {
        public static readonly int SPLASH = 0;
        public static readonly int DEFAULT = 1;
        public static readonly int EMPTY = 2;
        public static readonly int TUTORIAL0 = 13;
        public static readonly int TUTORIAL1 = 14;
        public static readonly int TUTORIAL2 = 15;
        public static readonly int TUTORIAL3 = 16;
        public static readonly int TUTORIAL4 = 17;
        public static readonly int TUTORIAL5 = 18;
        public static readonly int TUTORIAL6 = 19;
    }
}

internal static class _0x0a287b22
{
    internal static string _0xef66a2e2(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}