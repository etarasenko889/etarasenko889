using DG.Tweening;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class _0xece3c3b8 : MonoBehaviour
{
    public void _0x530d0836()
    {
        {
#if B_LOGS
            {
                Debug.Log($"[Test] Animate Force");
            }
#endif
        }

        this._0x243e9580?.Kill();
        if (AnimationSlider != null)
            this.AnimationSlider.value = 1f;
        _0xf7cbef39 = false;
    }

    private void Awake()
    {
        Instance = this.gameObject.GetComponent<_0xece3c3b8>();
    }

    public GameObject Error;
    private void _0x384695b9()
    {
        this.AnimationSlider.value = 0.05f;
        _0xf7cbef39 = !_0xf7cbef39;
        this._0x243e9580 = DOTween.Sequence().Append(DOTween.To(() => this.AnimationSlider.value, _0xf913fe38 => this.AnimationSlider.value = _0xf913fe38, 1f, this.FirstAnimationTime)).SetEase(Ease.Linear).OnComplete(() =>
        {
            _0xdccd1f27._0xc024bc96?._0x16a97471();
        });
    }

    public float DefaultAnimationTime = 0.4f;
    public static _0xece3c3b8 Instance;
    public GameObject Background;
    public void _0x4e4950d0()
    {
        this._0x243e9580?.Kill();
        this.AnimationSlider.value = _0xf7cbef39 ? this.SecondPassSliderValue : 0.05f;
    }

    public float SecondPassSliderValue = 0.5f;
    public Slider AnimationSlider;
    public float FirstAnimationTime = 10.0f;
    private void Start()
    {
        if (SceneManager.GetActiveScene().buildIndex == _0x879a7ea3._0x70908a3f.SCENE_0 && !_0xf7cbef39)
        {
            this._0x384695b9();
        }
        else
        {
            this._0xea26e704();
        }
    }

    public GameObject Content;
    public void _0xa433d650()
    {
        this._0x243e9580?.Play();
    }

    public void _0xe18ca594()
    {
        this._0x243e9580?.Pause();
    }

    public void _0xea26e704()
    {
        this._0x4e4950d0();
        bool _0xe7ced835 = _0xf7cbef39;
        this._0x243e9580 = DOTween.Sequence().Append(DOTween.To(() => this.AnimationSlider.value, _0xf913fe38 => this.AnimationSlider.value = _0xf913fe38, _0xe7ced835 ? 1f : this.SecondPassSliderValue, this.DefaultAnimationTime)).SetEase(Ease.Linear);
        _0xf7cbef39 = !_0xf7cbef39;
    }

    private static bool _0xf7cbef39 = false;
    private Sequence _0x243e9580;
}