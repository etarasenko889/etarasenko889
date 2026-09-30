using TMPro;
using UnityEngine;

/// Outline + wrap discipline for labels built at runtime. The shared font material
/// carries ONE outline colour, so a dark label would drown in it: every label gets
/// its own material instance with an outline picked against its own face colour.
public static class _0xe064bb1a
{
    /// Word wrap OFF, autosize ON, floor at the readable minimum. Line breaks are
    /// written by hand with an explicit escape inside the string.
    public static void ApplyLayout(TMP_Text _0xb86d67b8, float _0xa91ac1e3)
    {
        if (_0xb86d67b8 == null)
        {
            return;
        }

        _0xb86d67b8.enableWordWrapping = false;
        _0xb86d67b8.overflowMode = TextOverflowModes.Overflow;
        _0xb86d67b8.enableAutoSizing = true;
        _0xb86d67b8.fontSizeMin = UiFontFloor;
        _0xb86d67b8.fontSizeMax = Mathf.Max(UiFontFloor, _0xa91ac1e3);
        _0xb86d67b8.fontSize = Mathf.Max(UiFontFloor, _0xa91ac1e3);
    }

    public static void ApplyOutline(TMP_Text _0x104cfd3a, Color _0x0b75adf6)
    {
        if (_0x104cfd3a == null)
        {
            return;
        }

        _0x104cfd3a.color = _0x0b75adf6;
        float _0xeb99681c = (0.299f * _0x0b75adf6.r) + (0.587f * _0x0b75adf6.g) + (0.114f * _0x0b75adf6.b);
        Color _0x1b0aa89e = _0xeb99681c < 0.5f ? _0x3d55b1de.Cream : _0x3d55b1de.Ink;
        Material _0x9b6522bf = _0x104cfd3a.fontMaterial;
        if (_0x9b6522bf == null)
        {
            return;
        }

        _0x9b6522bf.EnableKeyword(ShaderUtilities.Keyword_Outline);
        _0x9b6522bf.SetColor(ShaderUtilities.ID_OutlineColor, _0x1b0aa89e);
        _0x9b6522bf.SetFloat(ShaderUtilities.ID_OutlineWidth, 0.18f);
        _0x9b6522bf.SetFloat(ShaderUtilities.ID_FaceDilate, 0.2f);
    }

    public const float UiFontFloor = 24f;
}