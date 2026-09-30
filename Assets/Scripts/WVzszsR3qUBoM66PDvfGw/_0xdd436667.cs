using DG.Tweening;
using UnityEngine;

/// Builds the reactor out of world sprites. Every size is derived from the scene
/// camera (ortho half height / half width), never from the native pixel size of a
/// sprite, and every sorting order comes from the named constants below so nothing
/// can drift over the pops.
public sealed class _0xdd436667 : MonoBehaviour
{
    private const int OrderMarker = -8;
    [SerializeField]
    private SpriteRenderer _nodePrefab;
    public void _0xfeb26ba4()
    {
        if (this._0x771de790 != null)
        {
            this._0x771de790.DOKill(true);
            this._0x771de790.color = _0x3d55b1de.WithAlpha(_0x3d55b1de.Gold, 0f);
            this._0x771de790.transform.localScale = Vector3.one * 0.2f;
            this._0x771de790.DOFade(0.85f, 0.25f);
            this._0x771de790.transform.DOScale(1.2f, 0.4f).SetEase(Ease.OutQuad);
            this._0x771de790.DOFade(0f, 0.6f).SetDelay(0.5f);
        }

        if (this._0xebee0dcb != null)
        {
            this._0xebee0dcb.DOKill(false);
            this._0xebee0dcb.DOColor(_0x3d55b1de.Gold, 0.2f).SetLoops(4, LoopType.Yoyo);
        }
    }

    public void _0x359d03e5()
    {
        if (this._0x26bbe6a1 != null)
        {
            this._0x26bbe6a1.DOKill(true);
            this._0x26bbe6a1.DOPunchPosition(new Vector3(this._0xcd38f9bc * 0.06f, 0f, 0f), 0.2f, 12, 0.6f);
        }
    }

    [SerializeField]
    private SpriteRenderer _linkPrefab;
    private SpriteRenderer _0xebee0dcb;
    private static readonly float[] _0x5e6693c1 =
    {
        0.932f,
        0.685f,
        0.438f
    };
    private SpriteRenderer _0xd0605388(SpriteRenderer _0x269e9ec3, string _0xb919320c, int _0x580a8ab6)
    {
        if (_0x269e9ec3 == null)
        {
            return null;
        }

        SpriteRenderer _0x2aba501a = Instantiate(_0x269e9ec3, this._0x26bbe6a1);
        _0x2aba501a.gameObject.name = _0xb919320c;
        _0x2aba501a.sortingOrder = Mathf.Clamp(_0x580a8ab6, -19, -1);
        _0x2aba501a.transform.localScale = Vector3.one;
        return _0x2aba501a;
    }

    private const int OrderNode = -7;
    private const float PipFill = 0.62f;
    [SerializeField]
    private SpriteRenderer _pipPrefab;
    private float _0xcd38f9bc;
    [SerializeField]
    private SpriteRenderer _markerPrefab;
    private SpriteRenderer _0x771de790;
    public void _0x8b477434(int _0xa7ea5376)
    {
        for (int _0x6845da37 = 0; _0x6845da37 < RingCount; _0x6845da37++)
        {
            _0xcfe49eb1 _0x734f116e = this._0x06990f7b[_0x6845da37];
            if (_0x734f116e != null)
            {
                _0x734f116e._0x4f062b18(_0x6845da37 == _0xa7ea5376);
            }
        }
    }

    [SerializeField]
    private float _centreWorldY = 0.15f;
    public const int PipsPerRing = 48;
    private const int OrderFx = -3;
    private Transform _0x26bbe6a1;
    private const int OrderTrack = -14;
    private const int OrderHalo = -16;
    private const float BoardWidthFraction = 0.86f;
    public _0xcfe49eb1 _0x33e37713(int _0xc1fc01ee)
    {
        if (_0xc1fc01ee < 0 || _0xc1fc01ee >= this._0x06990f7b.Length)
        {
            return null;
        }

        return this._0x06990f7b[_0xc1fc01ee];
    }

    /// Creates every world object once. Sizes come from the camera: half height is
    /// the orthographic size, half width is that times the aspect.
    public void _0x060f2223()
    {
        if (this._0x658bdfba)
        {
            return;
        }

        Camera _0x556ee1ac = Camera.main;
        float _0xad0f2d32 = _0x556ee1ac != null ? _0x556ee1ac.orthographicSize : 5f;
        float _0x6a094ce7 = _0x556ee1ac != null && _0x556ee1ac.aspect > 0.01f ? _0x556ee1ac.aspect : (9f / 19.5f);
        float _0xb1eaf0db = _0xad0f2d32 * _0x6a094ce7;
        this._0xcd38f9bc = _0xb1eaf0db * this._widthFraction;
        this._0x002d3098 = new Vector2(0f, this._centreWorldY);
        this._0x26bbe6a1 = new GameObject(_0x296cc508._0x48a698bf(new byte[12] { 166, 145, 149, 151, 128, 155, 134, 178, 157, 145, 152, 144 }, 244)).transform;
        this._0x26bbe6a1.SetParent(this.transform, false);
        this._0x26bbe6a1.position = Vector3.zero;
        this._0xec24fc4a = this._0xd0605388(this._burstPrefab, _0x296cc508._0x48a698bf(new byte[9] { 91, 116, 120, 113, 121, 85, 124, 113, 114 }, 29), OrderHalo);
        if (this._0xec24fc4a != null)
        {
            this._0x6b53396b(this._0xec24fc4a, this._0xcd38f9bc * 2.1f);
            this._0xec24fc4a.transform.position = this._0x002d3098;
            this._0xec24fc4a.color = _0x3d55b1de.WithAlpha(_0x3d55b1de.Violet, 0.22f);
        }

        for (int _0xb38cbe04 = 0; _0xb38cbe04 < RingCount; _0xb38cbe04++)
        {
            float _0x0ecba74b = this._0xcd38f9bc * _0x5e6693c1[_0xb38cbe04];
            SpriteRenderer[] _0xe831b382 = new SpriteRenderer[PipsPerRing];
            float _0x19c5da73 = (2f * Mathf.PI * _0x0ecba74b / PipsPerRing) * PipFill;
            for (int _0x9fe90012 = 0; _0x9fe90012 < PipsPerRing; _0x9fe90012++)
            {
                SpriteRenderer _0x3621ab6e = this._0xd0605388(this._pipPrefab, _0x296cc508._0x48a698bf(new byte[3] { 200, 241, 232 }, 152), OrderTrack + _0xb38cbe04);
                if (_0x3621ab6e == null)
                {
                    continue;
                }

                this._0x6b53396b(_0x3621ab6e, _0x19c5da73);
                float _0x6b607792 = (360f / PipsPerRing) * _0x9fe90012;
                float _0x4f4ca400 = _0x6b607792 * Mathf.Deg2Rad;
                _0x3621ab6e.transform.position = this._0x002d3098 + (new Vector2(Mathf.Sin(_0x4f4ca400), Mathf.Cos(_0x4f4ca400)) * _0x0ecba74b);
                _0x3621ab6e.transform.rotation = Quaternion.Euler(0f, 0f, -_0x6b607792);
                _0xe831b382[_0x9fe90012] = _0x3621ab6e;
            }

            SpriteRenderer _0xf2c44556 = this._0xd0605388(this._markerPrefab, _0x296cc508._0x48a698bf(new byte[6] { 180, 152, 139, 146, 156, 139 }, 249), OrderMarker);
            if (_0xf2c44556 != null)
            {
                this._0x6b53396b(_0xf2c44556, this._0xcd38f9bc * 0.17f);
            }

            SpriteRenderer _0x1b7fa120 = this._0xd0605388(this._nodePrefab, _0x296cc508._0x48a698bf(new byte[5] { 23, 56, 53, 57, 36 }, 84), OrderNode);
            if (_0x1b7fa120 != null)
            {
                this._0x6b53396b(_0x1b7fa120, this._0xcd38f9bc * 0.14f);
                _0x1b7fa120.gameObject.SetActive(false);
            }

            SpriteRenderer _0xc99ee05c = this._0xd0605388(this._linkPrefab, _0x296cc508._0x48a698bf(new byte[7] { 120, 84, 85, 95, 78, 82, 79 }, 59), OrderLink);
            if (_0xc99ee05c != null)
            {
                _0xc99ee05c.drawMode = SpriteDrawMode.Sliced;
                _0xc99ee05c.size = new Vector2(_0x0ecba74b, this._0xcd38f9bc * 0.055f);
                _0xc99ee05c.gameObject.SetActive(false);
            }

            this._0x06990f7b[_0xb38cbe04] = new _0xcfe49eb1(_0xe831b382, _0xf2c44556, _0x1b7fa120, _0xc99ee05c, this._0x002d3098, _0x0ecba74b, 1f);
        }

        this._0x771de790 = this._0xd0605388(this._burstPrefab, _0x296cc508._0x48a698bf(new byte[9] { 83, 126, 100, 116, 127, 118, 101, 112, 114 }, 23), OrderFx);
        if (this._0x771de790 != null)
        {
            this._0x6b53396b(this._0x771de790, this._0xcd38f9bc * 1.2f);
            this._0x771de790.transform.position = this._0x002d3098;
            this._0x771de790.color = _0x3d55b1de.WithAlpha(_0x3d55b1de.Gold, 0f);
        }

        this._0xebee0dcb = this._0xd0605388(this._corePrefab, _0x296cc508._0x48a698bf(new byte[4] { 254, 210, 207, 216 }, 189), OrderCore);
        if (this._0xebee0dcb != null)
        {
            this._0x47b38274 = this._0xcd38f9bc * 0.45f;
            this._0x6b53396b(this._0xebee0dcb, this._0x47b38274);
            this._0xebee0dcb.transform.position = this._0x002d3098;
            this._0xebee0dcb.color = _0x3d55b1de.Cream;
            this._0xebee0dcb.transform.DOScale(1.05f, 1.1f).SetEase(Ease.InOutSine).SetLoops(-1, LoopType.Yoyo);
        }

        this._0x658bdfba = true;
    }

    private bool _0x658bdfba;
    private float _0x47b38274;
    public float _0xfbcb6e2e
    {
        get
        {
            return this._0xcd38f9bc;
        }
    }

    [SerializeField]
    private SpriteRenderer _burstPrefab;
    private const int OrderLink = -10;
    /// Sizes a sprite to a target WIDTH in world units while keeping the aspect of
    /// the imported PNG, so nothing is stretched into an egg.
    private void _0x6b53396b(SpriteRenderer _0xa2164ab5, float _0xa356e792)
    {
        if (_0xa2164ab5 == null || _0xa2164ab5.sprite == null)
        {
            return;
        }

        Vector2 _0x5e59cb74 = _0xa2164ab5.sprite.bounds.size;
        float _0x20c17625 = _0x5e59cb74.x > 0.0001f ? _0x5e59cb74.y / _0x5e59cb74.x : 1f;
        _0xa2164ab5.drawMode = SpriteDrawMode.Sliced;
        _0xa2164ab5.size = new Vector2(_0xa356e792, _0xa356e792 * _0x20c17625);
    }

    public Vector2 _0x6bd7405a
    {
        get
        {
            return this._0x002d3098;
        }
    }

    [SerializeField]
    private float _widthFraction = BoardWidthFraction;
    [SerializeField]
    private SpriteRenderer _corePrefab;
    public void _0xf5da6f19(_0xdd279fb7 _0x0bb18b3a)
    {
        this._0x060f2223();
        for (int _0xfa96941e = 0; _0xfa96941e < RingCount; _0xfa96941e++)
        {
            _0xcfe49eb1 _0x7d9b4ce9 = this._0x06990f7b[_0xfa96941e];
            if (_0x7d9b4ce9 != null)
            {
                _0x7d9b4ce9._0xd7b26900(_0x0bb18b3a != null ? _0x0bb18b3a._0xae865f5e(_0xfa96941e) : null);
            }
        }
    }

    private SpriteRenderer _0xec24fc4a;
    private readonly _0xcfe49eb1[] _0x06990f7b = new _0xcfe49eb1[RingCount];
    private Vector2 _0x002d3098;
    private const int OrderCore = -6;
    public void Advance(float _0x7ad8159c, int _0x3898fa1a)
    {
        for (int _0x097c09c5 = 0; _0x097c09c5 < RingCount; _0x097c09c5++)
        {
            _0xcfe49eb1 _0xebe2f0de = this._0x06990f7b[_0x097c09c5];
            if (_0xebe2f0de == null)
            {
                continue;
            }

            _0xebe2f0de.Advance(_0x7ad8159c);
        }

        this._0x8b477434(_0x3898fa1a);
    }

    public const int RingCount = 3;
}

internal static class _0x296cc508
{
    internal static string _0x48a698bf(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}