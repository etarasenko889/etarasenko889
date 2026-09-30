using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class _0xce1ffac3 : MonoBehaviour
{
    private void Awake()
    {
        if (this.Button == null)
            if (!this.TryGetComponent(out this.Button))
                this.Button = this.GetComponentInChildren<Button>();
    }

    public bool IsLoadCurrentScene;
    private void Start()
    {
        if (this.IsLoadCurrentScene)
            this.Button.onClick.AddListener(() =>
            {
                _0x8c1ab97d.Instance.LoadSceneByIndex(SceneManager.GetActiveScene().buildIndex);
            });
        else
            this.Button.onClick.AddListener(() => _0x8c1ab97d.Instance.LoadSceneByIndex(this.LoadSceneId));
    }

    public Button Button;
    public int LoadSceneId;
}