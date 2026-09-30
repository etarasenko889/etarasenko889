using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class _0xaeede77d : MonoBehaviour
{
    private Image _0x17b2c9b3;
    private void _0xf81d10c3()
    {
        if (this._0x17b2c9b3.canvasRenderer.GetColor() != this._0xfcc5392d.canvasRenderer.GetColor())
            this._0xfcc5392d.canvasRenderer.SetColor(this._0x17b2c9b3.canvasRenderer.GetColor());
    }

    private TMP_Text _0xfcc5392d;
    private void Update()
    {
        this._0xf81d10c3();
    }
}