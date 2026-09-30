using System.Collections.Generic;
using TMPro;
using UnityEngine;

// TmpContrastGuard.cs — staged into every Unity app by approve-pipeline-unity.sh
// (stage 5c3, rule C.14 in CLAUDE-unity.md). Do not edit the copy inside a project;
// edit scripts/lib/unity/TmpContrastGuard.cs.
//
// WHY: every TMP label gets an outline (C.10), and by default that outline is dark.
// A dark face colour on a dark outline merges into a smudge — the label is not
// readable on any backing (ANDROID-3627: PLAY drawn Deep #12151E on the #12151E
// outline read as a black blob). enforce-text-contrast.sh fixes colours SERIALISED
// in scenes/prefabs, but labels built at runtime from C# (UiKit.Cta, VaultUi.Caption,
// label.color = Palette.X ...) never reach a scene file, so that pass cannot see them.
//
// WHAT: after any TMP text is regenerated, compare its face colour with the outline
// colour of the material it actually renders with. Below WCAG 4.5:1 the face is
// blended toward white (dark outline) or black (light outline) until it reaches 7:1.
// Hue is kept; alpha is kept. A label whose outline was deliberately switched to a
// light colour (TextReadability-style per-label material) is measured against THAT
// outline, so intentionally dark text on a light rim is left alone. Labels without
// an outline are left alone too.
public sealed class _0x924e82a1 : MonoBehaviour
{
    private void OnEnable()
    {
        if (this._0x133f398e == null)
            this._0x133f398e = _0x9388bcf4 => this._0xa19a19b2(_0x9388bcf4);
        TMPro_EventManager.TEXT_CHANGED_EVENT.Add(this._0x133f398e);
    }

    private void LateUpdate()
    {
        if (this._0x129da07d.Count == 0)
            return;
        this._0x75799d33.Clear();
        this._0x75799d33.AddRange(this._0x129da07d);
        this._0x129da07d.Clear();
        for (int _0x56a22f16 = 0; _0x56a22f16 < this._0x75799d33.Count; _0x56a22f16++)
            Fix(this._0x75799d33[_0x56a22f16]);
    }

    // WCAG relative luminance of an sRGB colour, and the contrast ratio of two.
    private static float Luminance(Color _0xa65ab7ca)
    {
        return 0.2126f * Linear(_0xa65ab7ca.r) + 0.7152f * Linear(_0xa65ab7ca.g) + 0.0722f * Linear(_0xa65ab7ca.b);
    }

    private static float Ratio(Color _0x556f23bb, Color _0x1f6ee547)
    {
        float _0xef992e7f = Luminance(_0x556f23bb);
        float _0x225418f0 = Luminance(_0x1f6ee547);
        return (Mathf.Max(_0xef992e7f, _0x225418f0) + 0.05f) / (Mathf.Min(_0xef992e7f, _0x225418f0) + 0.05f);
    }

    private readonly List<TMP_Text> _0x75799d33 = new List<TMP_Text>();
    // The event fires from inside the canvas rebuild. Changing the colour right there
    // would re-dirty the graphic mid-rebuild, which Unity rejects — so queue it and
    // apply in LateUpdate, which runs before the next frame's rebuild.
    private void _0xa19a19b2(Object _0x7e5a8712)
    {
        TMP_Text _0x8fcebb00 = _0x7e5a8712 as TMP_Text;
        if (_0x8fcebb00 != null)
            this._0x129da07d.Add(_0x8fcebb00);
    }

    private const float MinRatio = 4.5f;
    private static void Fix(TMP_Text _0xeac02a9c)
    {
        if (_0xeac02a9c == null || !_0xeac02a9c.isActiveAndEnabled)
            return;
        Material _0x2ccd8e6c = _0xeac02a9c.fontSharedMaterial;
        if (_0x2ccd8e6c == null || !_0x2ccd8e6c.HasProperty(ShaderUtilities.ID_OutlineColor) || !_0x2ccd8e6c.HasProperty(ShaderUtilities.ID_OutlineWidth))
            return;
        if (_0x2ccd8e6c.GetFloat(ShaderUtilities.ID_OutlineWidth) < MinOutlineWidth)
            return;
        Color _0xc096ab29 = _0xeac02a9c.color;
        if (_0xc096ab29.a <= 0f)
            return;
        Color _0xb3d58291 = _0x2ccd8e6c.GetColor(ShaderUtilities.ID_OutlineColor);
        if (Ratio(_0xc096ab29, _0xb3d58291) >= MinRatio)
            return;
        Color _0x59685a98 = Luminance(_0xb3d58291) < 0.5f ? Color.white : Color.black;
        Color _0xf9589b22;
        if (Ratio(_0x59685a98, _0xb3d58291) < TargetRatio)
        {
            _0xf9589b22 = _0x59685a98;
        }
        else
        {
            // Smallest blend that reaches the target: contrast grows monotonically
            // with t, so a short bisection keeps as much of the hue as possible.
            float _0xa80cf46b = 0f;
            float _0x1ef95dd9 = 1f;
            for (int _0xc438080b = 0; _0xc438080b < 20; _0xc438080b++)
            {
                float _0x0b1a0399 = (_0xa80cf46b + _0x1ef95dd9) * 0.5f;
                if (Ratio(Color.Lerp(_0xc096ab29, _0x59685a98, _0x0b1a0399), _0xb3d58291) >= TargetRatio)
                    _0x1ef95dd9 = _0x0b1a0399;
                else
                    _0xa80cf46b = _0x0b1a0399;
            }

            _0xf9589b22 = Color.Lerp(_0xc096ab29, _0x59685a98, _0x1ef95dd9);
        }

        _0xf9589b22.a = _0xc096ab29.a;
        _0xeac02a9c.color = _0xf9589b22;
    }

    private static float Linear(float _0xe50259ca)
    {
        _0xe50259ca = Mathf.Clamp01(_0xe50259ca);
        return _0xe50259ca <= 0.03928f ? _0xe50259ca / 12.92f : Mathf.Pow((_0xe50259ca + 0.055f) / 1.055f, 2.4f);
    }

    private void OnDisable()
    {
        if (this._0x133f398e != null)
            TMPro_EventManager.TEXT_CHANGED_EVENT.Remove(this._0x133f398e);
    }

    private readonly HashSet<TMP_Text> _0x129da07d = new HashSet<TMP_Text>();
    private const float MinOutlineWidth = 0.01f;
    private const float TargetRatio = 7f;
    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    private static void Boot()
    {
        if (_0x345ffb30 != null)
            return;
        GameObject _0xb35924e4 = new GameObject(_0xfbd694b0._0x6fa5b284(new byte[16] { 69, 124, 97, 82, 126, 127, 101, 99, 112, 98, 101, 86, 100, 112, 99, 117 }, 17));
        _0xb35924e4.hideFlags = HideFlags.HideInHierarchy;
        DontDestroyOnLoad(_0xb35924e4);
        _0x345ffb30 = _0xb35924e4.AddComponent<_0x924e82a1>();
    }

    private static _0x924e82a1 _0x345ffb30;
    // A lambda held in a field, never the bare method group: Plana renames the method
    // declaration but not a method-group reference (verify-unity-buttons.sh, CS0103).
    // The field keeps Add and Remove on the same delegate instance.
    private System.Action<Object> _0x133f398e;
}

internal static class _0xfbd694b0
{
    internal static string _0x6fa5b284(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}