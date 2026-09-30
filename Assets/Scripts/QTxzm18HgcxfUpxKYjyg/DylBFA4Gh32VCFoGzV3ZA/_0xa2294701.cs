using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode]
public class _0xa2294701 : MonoBehaviour
{
    private float _0x61843fd4;
    private void Update()
    {
        int _0xa4e10d21 = 1;
        if (this._0x2bed3d81.Count > 0)
        {
            string _0x815af1a6 = this._0xa916b006.text;
            foreach (string _0x85327676 in this._0x2bed3d81)
                while (_0x815af1a6.Contains(_0x85327676))
                    _0x815af1a6 = _0x815af1a6.Replace(_0x85327676, "");
            _0xa4e10d21 = _0x815af1a6.Length;
        }
        else
        {
            _0xa4e10d21 = this._0xa916b006.text.Length;
        }

        float _0x93a99ef8 = Mathf.Clamp(this._0x61843fd4 + this._0xadcf90fc * _0xa4e10d21, this._0x7a83329a, this._0xcd7041aa);
        if (!Mathf.Approximately(this._0x945d03f1.aspectRatio, _0x93a99ef8))
            this._0x945d03f1.aspectRatio = _0x93a99ef8;
    }

    private TMP_Text _0xa916b006;
    private float _0x7a83329a = 1.5f;
    private AspectRatioFitter _0x945d03f1;
    private List<string> _0x2bed3d81 = new();
    private float _0xadcf90fc = 0.6f;
    private float _0xcd7041aa = 4;
}