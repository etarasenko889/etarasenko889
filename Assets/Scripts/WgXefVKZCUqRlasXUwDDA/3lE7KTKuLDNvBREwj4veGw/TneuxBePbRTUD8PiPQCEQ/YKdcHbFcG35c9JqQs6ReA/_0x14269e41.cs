using UnityEngine;
using UnityEngine.UI;

public class _0x14269e41 : MonoBehaviour
{
    public Button TutorialEndButton;
    public int EndTutorialPanelIndex = 1;
    private void Start()
    {
        if (this.NextTutorialButton != null)
        {
            if (this.IsTutorialEndPanel)
            {
                this.NextTutorialButton.onClick.AddListener(() => _0xa80fd29e.Instance._0xa19e587c(this.EndTutorialPanelIndex));
                this.NextTutorialButton.onClick.AddListener(() => _0x8c1ab97d.Instance._0xeb6067ad());
            }
            else
            {
                this.NextTutorialButton.onClick.AddListener(() => _0xa80fd29e.Instance._0xa19e587c(this.NextTutorialPanelIndex));
            }
        }

        if (this.TutorialEndButton != null)
        {
            this.TutorialEndButton.onClick.AddListener(() => _0xa80fd29e.Instance._0xa19e587c(this.EndTutorialPanelIndex));
            this.TutorialEndButton.onClick.AddListener(() => _0x8c1ab97d.Instance._0xeb6067ad());
        }
    }

    public int NextTutorialPanelIndex;
    public Button NextTutorialButton;
    public bool IsTutorialEndPanel;
}