using TMPro;
using UnityEngine;
using static _0x879a7ea3;

public class _0x46923a5e : MonoBehaviour
{
    public void _0x6a0ddadf()
    {
        this.MoneyCountText.text = _0x6cc1cd18._0xc7266c3f.ToString();
    }

    private void Start()
    {
        if (this.MoneyCountText == null)
        {
            TMP_Text _0x36892d91;
            if (this.gameObject.TryGetComponent(out _0x36892d91))
                this.MoneyCountText = _0x36892d91;
        }

        this._0x6a0ddadf();
    }

    public TMP_Text MoneyCountText;
}