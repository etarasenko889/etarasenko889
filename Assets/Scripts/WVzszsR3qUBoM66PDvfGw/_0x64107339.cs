using UnityEngine;
using UnityEngine.EventSystems;

/// Turns a full-surface UI graphic into the game's tap control. The whole field is
/// the control here - there is no button to aim at - and routing it through the
/// event system keeps it working on every device without touching legacy input.
public sealed class _0x64107339 : MonoBehaviour, IPointerClickHandler
{
    private System.Action _0x2e81aa2f;
    public void OnPointerClick(PointerEventData _0xf06bce72)
    {
        if (this._0x2e81aa2f != null)
        {
            this._0x2e81aa2f.Invoke();
        }
    }

    public void _0x364c24b1(System.Action _0x15eebad1)
    {
        this._0x2e81aa2f = _0x15eebad1;
    }
}