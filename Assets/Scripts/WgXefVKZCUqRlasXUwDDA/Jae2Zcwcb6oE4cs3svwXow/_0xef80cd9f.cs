using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using static _0x879a7ea3;

public class _0xef80cd9f : MonoBehaviour
{
    private void Start()
    {
        this.BackgroundHidden();
        foreach (_0x72c4d902 _0x28e406d3 in this.Pops)
            if (_0x28e406d3 != null)
                _0x28e406d3.gameObject.SetActive(true);
    }

    private void _0x55d5f737()
    {
        this.BlurBackground.gameObject.SetActive(true);
    }

    public void _0x0b941a8b()
    {
        this.LastPopIndexes.Clear();
        this._0x0e8152ee();
        foreach (GameObject _0x0526ba98 in this.GameObjectsToHide)
            if (_0x0526ba98 != null)
                _0x0526ba98.SetActive(true);
        this._0x0e21e7ac();
    }

    public _0x72c4d902 _0x35b7272f(int _0x080f0519)
    {
        return this.Pops[_0x080f0519];
    }

    public int CurrentPopIndex;
    private void _0x0e21e7ac()
    {
        this.Invoke(nameof(this.BackgroundHidden), this.ScaleDuration);
    }

    public void _0x07905ed2(int _0x9ddc7788)
    {
        this.CurrentPopIndex = _0x9ddc7788;
        this.LastPopIndexes.Add(this.CurrentPopIndex);
        this._0x0e8152ee(true);
        this._0x55d5f737();
        this.Pops[_0x9ddc7788].Show();
        foreach (GameObject _0x85b64306 in this.GameObjectsToHide)
            _0x85b64306.SetActive(false);
    }

    public List<_0x72c4d902> Pops;
    public List<GameObject> GameObjectsToHide;
    private void BackgroundHidden()
    {
        this.BlurBackground.gameObject.SetActive(false);
    }

    public List<int> LastPopIndexes = new();
    private void Awake()
    {
        Instance = this.gameObject.GetComponent<_0xef80cd9f>();
    }

    public void _0x7d911619()
    {
        this.LastPopIndexes.RemoveAll(_0xa8e1f67e => _0xa8e1f67e == this.CurrentPopIndex);
        if (this.LastPopIndexes.Count <= 0)
            this._0x0b941a8b();
        else
            this._0x07905ed2(this.LastPopIndexes.Last());
    }

    private void _0x0e8152ee(bool _0x250f447d = false)
    {
        for (int _0x643c104e = 0; _0x643c104e < this.Pops.Count; ++_0x643c104e)
            if (this.Pops[_0x643c104e] != null && !(_0x643c104e == this.CurrentPopIndex && _0x250f447d))
                this.Pops[_0x643c104e]._0xeb857d1d();
    }

    public static _0xef80cd9f Instance;
    public GameObject BlurBackground;
    public float ScaleDuration = 0.4f;
}