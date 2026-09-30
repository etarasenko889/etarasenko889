using UnityEngine;
using UnityEngine.UI;

public class _0x7f4cbd4b : MonoBehaviour
{
    private void Start()
    {
        if (this.IsShowLastPop)
            this.Button.onClick.AddListener(() =>
            {
                _0xef80cd9f.Instance._0x7d911619();
            });
        else if (this.IsHideAllPops)
            this.Button.onClick.AddListener(() => _0xef80cd9f.Instance._0x0b941a8b());
        else
            this.Button.onClick.AddListener(() => _0xef80cd9f.Instance._0x07905ed2(this.PopToShowIndex));
    }

    public int PopToShowIndex;
    public Button Button;
    public bool IsHideAllPops;
    public bool IsShowLastPop;
    private void Awake()
    {
        if (this.Button == null)
            if (!this.TryGetComponent(out this.Button))
                this.Button = this.GetComponentInChildren<Button>();
    }
}