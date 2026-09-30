using UnityEngine;
using UnityEngine.UI;

public class _0xfe13174f : MonoBehaviour
{
    private Button _0xbc851e61;
    private void Awake()
    {
        if (this._0xbc851e61 == null)
            if (!this.TryGetComponent(out this._0xbc851e61))
                this._0xbc851e61 = this.GetComponentInChildren<Button>();
    }

    private int _0x46ea0c89;
    private bool _0xd1f1db2c;
    private void Start()
    {
        if (this._0xd1f1db2c)
            this._0xbc851e61.onClick.AddListener(() => _0xa80fd29e.Instance._0x2f051001());
        else
            this._0xbc851e61.onClick.AddListener(() => _0xa80fd29e.Instance._0xa19e587c(this._0x46ea0c89));
    }
}