using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class _0x2b190913 : MonoBehaviour
{
    public GameObject OuterBackground;
    public void _0x27756275()
    {
        this._0x24922664();
        this.Content.SetActive(true);
        DOTween.Kill(this.Content.transform, true);
        this.Content.transform.localScale = Vector3.one;
        _0xa80fd29e.Instance._0x12a8d7fd(_0xa80fd29e.Instance.CurrentPanelIndex);
    }

    public void _0x3010f5bf()
    {
        this._0x9a6ab306();
        DOTween.Kill(this.Content.transform, true);
        this.Content.transform.DOScale(0f, this.ScaleDuration).SetEase(this.Ease).OnComplete(() =>
        {
            this.Content.SetActive(false);
        });
    }

    public bool IsScaledDownOnAwake = true;
    private bool _0x220f879d => this.Content.transform.localScale.x > 0.5f && this.Content.transform.localScale.y > 0.5f;

    private void _0x1f02f455()
    {
        if (this.OuterBackground != null)
        {
            Image _0xafb73728 = this.OuterBackground.GetComponent<Image>();
            DOTween.Kill(_0xafb73728, true);
            _0xafb73728.DOFade(0f, 0.01f);
        }

        DOTween.Kill(this.Content.transform, true);
        this.Content.transform.DOScale(0f, 0.01f);
    }

    private void Awake()
    {
        this.Content.SetActive(true);
        if (this.OuterBackground != null)
            this.OuterBackground.gameObject.SetActive(true);
        if (this.IsScaledDownOnAwake)
            this._0x1f02f455();
    }

    public GameObject Content;
    public TMP_Text HeaderText;
    private void _0x1d958562()
    {
        if (this.OuterBackground != null)
        {
            Image _0xfc0b7073 = this.OuterBackground.GetComponent<Image>();
            DOTween.Kill(_0xfc0b7073, true);
            _0xfc0b7073.DOFade(1f, this.ScaleDuration / 2f);
        }
    }

    private void _0x9a6ab306()
    {
        if (this.OuterBackground != null)
        {
            Image _0xd83e205c = this.OuterBackground.GetComponent<Image>();
            DOTween.Kill(_0xd83e205c, true);
            _0xd83e205c.DOFade(0f, this.ScaleDuration);
        }
    }

    public void Show()
    {
        this._0x1d958562();
        if (this.Content != null)
        {
            DOTween.Kill(this.Content.transform, true);
            this.Content.SetActive(true);
            this.Content.transform.DOScale(1f, this.ScaleDuration).SetEase(this.Ease).OnComplete(() =>
            {
                _0xa80fd29e.Instance._0x12a8d7fd(_0xa80fd29e.Instance.CurrentPanelIndex);
            });
        }
    }

    private void _0x24922664()
    {
        if (this.OuterBackground != null)
        {
            Image _0xfffc73ba = this.OuterBackground.GetComponent<Image>();
            DOTween.Kill(_0xfffc73ba, true);
            _0xfffc73ba.DOFade(1f, 0f);
        }
    }

    public float ScaleDuration = 0.4f;
    public Ease Ease = Ease.OutSine;
    public TMP_Text MainText;
}