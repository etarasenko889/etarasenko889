using System.Collections;
using System.Collections.Generic;
using System.Linq;
using DG.Tweening;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using static _0x879a7ea3;

public class _0x8c1ab97d : MonoBehaviour
{
    public static bool IsAfterLevelComplete;
    public static _0x8c1ab97d Instance;
    [HideInInspector]
    public List<_0x46923a5e> MoneyCountContainers = new();
    private void Awake()
    {
        Instance = this.gameObject.GetComponent<_0x8c1ab97d>();
        this.RootGameObject = GameObject.FindWithTag(_0xb8d82a88._0x142ebb40(new byte[4] { 72, 117, 117, 110 }, 26));
        if (this._0xe504933a == _0x70908a3f.SCENE_0)
            this._0x9c458cc2(true);
        else
            this._0x9c458cc2(false);
        this.MoneyCountContainers = this.RootGameObject.GetComponentsInChildren<_0x46923a5e>(true).ToList();
    }

    private void _0x96d0c056(Transform _0xf7eb1bb4)
    {
        Transform[] _0x83f5d656 = _0xf7eb1bb4.GetComponentsInChildren<Transform>();
        foreach (Transform _0x985c5038 in _0x83f5d656)
            if (_0x985c5038 != null && DOTween.IsTweening(_0x985c5038))
            {
                if (this._0xf09af649)
                    DOTween.Play(_0x985c5038);
                else
                    DOTween.Pause(_0x985c5038);
            }
    }

    public void _0xeb6067ad()
    {
        _0xd345ba37._0xc450b058 = true;
    }

    public static bool IsAfterLevelFailed = false;
    [HideInInspector]
    public GameObject RootGameObject; // tag - "Root"
    public void LoadSceneByIndex(int _0x17d0f577)
    {
        //if (SceneManager.GetActiveScene().buildIndex == sceneIndex)
        //    AdsInitializer.Instance?.ShowAd();
        this.StartCoroutine(this._0x53feea96(_0x17d0f577));
    }

    public static _0x188d8823 _0xd345ba37 => _0x188d8823.ALL_SCENES_SETTING_SINGLETONS[Instance._0xe504933a];

    private static _0x188d8823 GAME_INDEX_SETTINGS(int _0x81fa8187)
    {
        return _0x188d8823.ALL_SCENES_SETTING_SINGLETONS[_0x81fa8187];
    }

    public Button ShowResetTutorialButton;
    public Transform Environment;
    public void _0x9c458cc2(bool _0xf9d05f9f)
    {
        this._0xf09af649 = _0xf9d05f9f;
        this._0xb00923c2(!this._0xf09af649);
        Physics2D.simulationMode = this._0xf09af649 ? SimulationMode2D.FixedUpdate : SimulationMode2D.Script;
        if (this.EnvironmentWithTweensToToggle != null)
            this._0x96d0c056(this.EnvironmentWithTweensToToggle);
    }

    private static _0x188d8823 _0x0dd3c2c8 => _0x188d8823.ALL_SCENES_SETTING_SINGLETONS[0];
    public int _0xe504933a => SceneManager.GetActiveScene().buildIndex;

    private IEnumerator _0x0e9ac878(string _0x6263b925)
    {
        _0xa80fd29e.Instance._0xa19e587c(_0x6776f348.SPLASH);
        //AudioController.Instance.SaveLastMusicTimes();
        AsyncOperation _0x2e4ca47f = SceneManager.LoadSceneAsync(_0x6263b925);
        while (!_0x2e4ca47f.isDone)
            yield return null;
    }

    private IEnumerator _0x53feea96(int _0x1c41cbc2)
    {
        _0xa80fd29e.Instance._0xa19e587c(_0x6776f348.SPLASH);
        AsyncOperation _0xaf478d68 = SceneManager.LoadSceneAsync(_0x1c41cbc2);
        while (!_0xaf478d68.isDone)
            yield return null;
    }

    public void _0xdf9a5bbd()
    {
        this.LoadSceneByIndex(SceneManager.GetActiveScene().buildIndex);
    }

    public void _0xf3d23356()
    {
        foreach (_0x46923a5e _0x29b9da31 in this.MoneyCountContainers)
            _0x29b9da31._0x6a0ddadf();
    }

    private void _0xb00923c2(bool _0x170a8bae)
    {
        Rigidbody2D[] _0x742b9dae = this.RootGameObject.GetComponentsInChildren<Rigidbody2D>(true);
        foreach (Rigidbody2D _0xa21e52b8 in _0x742b9dae)
            if (_0x170a8bae)
                _0xa21e52b8.constraints = RigidbodyConstraints2D.FreezeAll;
            else
                _0xa21e52b8.constraints = RigidbodyConstraints2D.None;
    }

    private static void MakeGrid(List<RectTransform> _0xbbc4aa00, AspectRatioFitter _0x70f32f95, float _0xf8c26490, int _0x47d9c637, int _0xaa363c6d)
    {
        _0x70f32f95.aspectMode = AspectRatioFitter.AspectMode.WidthControlsHeight;
        _0x70f32f95.aspectRatio = _0xf8c26490;
        foreach (RectTransform _0xe74edbee in _0xbbc4aa00)
        {
            int _0xa0408a40 = _0xe74edbee.transform.GetSiblingIndex();
            _0xe74edbee.anchorMin = new Vector3(Mathf.FloorToInt((float)_0xa0408a40 % _0x47d9c637) * (1f / _0x47d9c637), (_0xaa363c6d - (Mathf.FloorToInt((float)_0xa0408a40 / _0x47d9c637) % _0xaa363c6d + 1f)) * (1f / _0xaa363c6d));
            _0xe74edbee.anchorMax = new Vector3(Mathf.FloorToInt((float)_0xa0408a40 % _0x47d9c637 + 1f) * (1f / _0x47d9c637), (_0xaa363c6d - Mathf.FloorToInt((float)_0xa0408a40 / _0x47d9c637) % _0xaa363c6d) * (1f / _0xaa363c6d));
            _0xe74edbee.offsetMin = Vector2.zero;
            _0xe74edbee.offsetMax = Vector2.zero;
        }
    }

    public Button DeleteProgressDataButton;
    public Transform EnvironmentWithTweensToToggle;
    private void _0x83247566()
    {
        IsAfterLevelComplete = true;
        Instance.LoadSceneByIndex(_0x70908a3f.SCENE_0);
    }

    private void Start()
    {
        if (this._0xe504933a != _0x70908a3f.SCENE_0)
            Screen.orientation = ScreenOrientation.Portrait;
        this.DeleteProgressDataButton?.onClick.AddListener(() =>
        {
            PlayerPrefs.DeleteAll();
            //AudioController.Instance.UpdateMusics();
            //AudioController.Instance.UpdateSfxes();
            Instance.LoadSceneByIndex(_0x70908a3f.SCENE_0);
        });
        this.ShowResetTutorialButton?.onClick.AddListener(() =>
        {
            _0xd345ba37._0xc450b058 = false;
            _0xef80cd9f.Instance._0x0b941a8b();
            _0xa80fd29e.Instance._0xa19e587c(_0x6776f348.TUTORIAL0);
        });
    }

    public Canvas MainCanvas;
    private static void ExitGame()
    {
        Application.Quit();
    }

    public bool _0xf09af649 { get; private set; }
}

internal static class _0xb8d82a88
{
    internal static string _0x142ebb40(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}