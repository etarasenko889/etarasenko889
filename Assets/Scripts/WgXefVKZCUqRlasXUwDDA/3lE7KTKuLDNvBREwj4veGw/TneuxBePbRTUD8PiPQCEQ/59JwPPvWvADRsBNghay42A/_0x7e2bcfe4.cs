using UnityEngine;
using UnityEngine.UI;

public class _0x7e2bcfe4 : MonoBehaviour
{
    private void Start()
    {
        this.Button.onClick.AddListener(() => _0x8c1ab97d.Instance._0x9c458cc2(this.IsPhysicsRunOnClick));
    }

    public Button Button;
    private void Awake()
    {
        if (this.Button == null)
            if (!this.TryGetComponent(out this.Button))
                this.Button = this.GetComponentInChildren<Button>();
    }

    public bool IsPhysicsRunOnClick;
}