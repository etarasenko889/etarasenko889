using DG.Tweening;
using UnityEngine;

/// One stabiliser ring: a track of pips, a lit sector drawn from the same pips, a
/// marker travelling at the ring's own tempo, and the clamp node left behind when
/// the ring is locked.
public sealed class _0xcfe49eb1
{
    private float _0x8652712d;
    private readonly SpriteRenderer _0x600b511b;
    private readonly SpriteRenderer _0xee018370;
    public _0xcfe49eb1(SpriteRenderer[] _0xbc74299c, SpriteRenderer _0x3093fa44, SpriteRenderer _0xb574dd79, SpriteRenderer _0x3aca5c53, Vector2 _0xc1bfb2b1, float _0xd25524cc, float _0x433ef0e7)
    {
        this._0xf12cd56a = _0xbc74299c;
        this._0xe0722afd = _0x3093fa44;
        this._0xee018370 = _0xb574dd79;
        this._0x600b511b = _0x3aca5c53;
        this._0x7ac7685b = _0xc1bfb2b1;
        this._0x3c6c80f6 = _0xd25524cc;
        this._0x57464da5 = _0x433ef0e7;
    }

    private readonly Vector2 _0x7ac7685b;
    private readonly SpriteRenderer _0xe0722afd;
    private void _0xfa699319()
    {
        if (this._0xe0722afd == null)
        {
            return;
        }

        this._0xe0722afd.transform.position = this._0x176f0a7e(this._0x8652712d);
        this._0xe0722afd.transform.rotation = Quaternion.Euler(0f, 0f, -this._0x8652712d);
    }

    private bool _0xb4f77503;
    private Vector2 _0x176f0a7e(float _0x9e5f88a9)
    {
        float _0x5957ba2e = _0x9e5f88a9 * Mathf.Deg2Rad;
        return this._0x7ac7685b + (new Vector2(Mathf.Sin(_0x5957ba2e), Mathf.Cos(_0x5957ba2e)) * this._0x3c6c80f6);
    }

    public void Advance(float _0xbdabddef)
    {
        if (this._0x1f86741f || this._0x4c07f5f5 == null)
        {
            return;
        }

        this._0x8652712d = Mathf.Repeat(this._0x8652712d + (this._0x4c07f5f5.SpeedDegPerSecond * this._0x4c07f5f5.Direction * _0xbdabddef), 360f);
        this._0xfa699319();
    }

    public bool _0x38bad96e
    {
        get
        {
            return this._0x1f86741f;
        }
    }

    private readonly float _0x57464da5;
    /// Repaints the whole pip ring: dim for the track, channel colour inside the
    /// lit sector. Locked rings keep their sector lit so the contour reads as done.
    private void _0xf409e632()
    {
        if (this._0xf12cd56a == null)
        {
            return;
        }

        float _0xe44a2ba9 = this._0x4c07f5f5 != null ? this._0x4c07f5f5.SectorWidthDeg * 0.5f : 0f;
        Color _0x445fcf21 = this._0x70e803b9;
        float _0xd3afe7d0 = this._0xb4f77503 || this._0x1f86741f ? 0.85f : 0.55f;
        for (int _0x559e1b69 = 0; _0x559e1b69 < this._0xf12cd56a.Length; _0x559e1b69++)
        {
            SpriteRenderer _0x0e31025d = this._0xf12cd56a[_0x559e1b69];
            if (_0x0e31025d == null)
            {
                continue;
            }

            float _0xa6df7c7a = (360f / this._0xf12cd56a.Length) * _0x559e1b69;
            bool _0xb8536ed0 = this._0x4c07f5f5 != null && Mathf.Abs(_0xdd279fb7.AngleOffset(_0xa6df7c7a, this._0x4c07f5f5.SectorCenterDeg)) <= _0xe44a2ba9;
            _0x0e31025d.color = _0xb8536ed0 ? _0x3d55b1de.WithAlpha(_0x445fcf21, this._0x1f86741f ? 0.9f : 1f) : _0x3d55b1de.WithAlpha(_0x3d55b1de.SurfaceEdge, _0xd3afe7d0);
        }
    }

    public void _0x2b83de08(float _0x7541f8c4)
    {
        if (this._0x4c07f5f5 != null)
        {
            this._0x4c07f5f5.SpeedDegPerSecond = this._0x4c07f5f5.SpeedDegPerSecond * _0x7541f8c4;
        }
    }

    /// Signed distance from the marker to the centre of the lit sector, in degrees.
    public float _0xba39a0de()
    {
        if (this._0x4c07f5f5 == null)
        {
            return 999f;
        }

        return _0xdd279fb7.AngleOffset(this._0x8652712d, this._0x4c07f5f5.SectorCenterDeg);
    }

    public void _0xd7b26900(_0xdd279fb7._0x2faff3f3 _0x50078f23)
    {
        this._0x4c07f5f5 = _0x50078f23;
        this._0x1f86741f = false;
        this._0xb4f77503 = false;
        this._0x8652712d = _0x50078f23 != null ? _0x50078f23.StartAngleDeg : 0f;
        if (this._0xee018370 != null)
        {
            this._0xee018370.gameObject.SetActive(false);
        }

        if (this._0x600b511b != null)
        {
            this._0x600b511b.gameObject.SetActive(false);
        }

        if (this._0xe0722afd != null)
        {
            this._0xe0722afd.gameObject.SetActive(true);
            this._0xe0722afd.color = this._0x70e803b9;
        }

        this._0xf409e632();
        this._0xfa699319();
    }

    public _0xdd279fb7._0x2faff3f3 _0xf05240bf
    {
        get
        {
            return this._0x4c07f5f5;
        }
    }

    public void _0xfc454d7d()
    {
        if (this._0x4c07f5f5 == null)
        {
            return;
        }

        this._0x8652712d = this._0x4c07f5f5.SectorCenterDeg;
        this._0xfa699319();
    }

    private readonly float _0x3c6c80f6;
    public void _0xc334ddcb()
    {
        this._0x1f86741f = true;
        if (this._0xe0722afd != null)
        {
            this._0xe0722afd.gameObject.SetActive(false);
        }

        Vector2 _0x4c4dbf42 = this._0x176f0a7e(this._0x8652712d);
        if (this._0xee018370 != null)
        {
            this._0xee018370.gameObject.SetActive(true);
            this._0xee018370.color = this._0x70e803b9;
            this._0xee018370.transform.position = _0x4c4dbf42;
            this._0xee018370.transform.localScale = Vector3.zero;
            this._0xee018370.transform.DOScale(1f, 0.28f).SetEase(Ease.OutBack);
        }

        if (this._0x600b511b != null)
        {
            this._0x600b511b.gameObject.SetActive(true);
            this._0x600b511b.color = _0x3d55b1de.WithAlpha(this._0x70e803b9, 0.9f);
            Vector2 _0x7aa37e67 = (_0x4c4dbf42 + this._0x7ac7685b) * 0.5f;
            this._0x600b511b.transform.position = _0x7aa37e67;
            float _0xa78d8946 = Vector2.Distance(_0x4c4dbf42, this._0x7ac7685b);
            float _0x159453a6 = this._0x600b511b.size.y > 0.001f ? this._0x600b511b.size.y : 0.12f;
            this._0x600b511b.size = new Vector2(_0xa78d8946, _0x159453a6);
            Vector2 _0x72f76ab9 = _0x4c4dbf42 - this._0x7ac7685b;
            this._0x600b511b.transform.rotation = Quaternion.Euler(0f, 0f, Mathf.Atan2(_0x72f76ab9.y, _0x72f76ab9.x) * Mathf.Rad2Deg);
        }

        this._0xf409e632();
    }

    private readonly SpriteRenderer[] _0xf12cd56a;
    private bool _0x1f86741f;
    private _0xdd279fb7._0x2faff3f3 _0x4c07f5f5;
    public void _0x4f062b18(bool _0x7afb31e6)
    {
        this._0xb4f77503 = _0x7afb31e6;
        if (this._0xe0722afd != null)
        {
            float _0xddad035d = this._0x57464da5 * (_0x7afb31e6 ? 1.15f : 1f);
            this._0xe0722afd.transform.localScale = Vector3.one * _0xddad035d;
            this._0xe0722afd.color = _0x3d55b1de.WithAlpha(this._0x70e803b9, _0x7afb31e6 ? 1f : 0.45f);
        }

        this._0xf409e632();
    }

    public float _0xee83ad93
    {
        get
        {
            return this._0x8652712d;
        }
    }

    public Color _0x70e803b9
    {
        get
        {
            return _0x3d55b1de.Channel(this._0x4c07f5f5 != null ? this._0x4c07f5f5.ChannelIndex : 0);
        }
    }
}