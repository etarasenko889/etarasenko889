using UnityEngine;

[ExecuteInEditMode]
[RequireComponent(typeof(Camera))]
public class _0x23b3e901 : MonoBehaviour
{
    private Vector3 _0xa5a4b4da { get; set; }
    private Vector3 _0x2dc12eed { get; set; }
    private Vector3 _0xfd6e058e { get; set; }
    private Vector3 _0xc76febb2 { get; set; }
    private Vector3 _0x908e1b34 { get; set; }

    private float _0x3504a4ef = 1;
    private Color _0x25de5a99 = Color.white;
    public enum _0x98086914
    {
        Landscape,
        Portrait
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = this._0x25de5a99;
        Matrix4x4 _0x2b376fce = Gizmos.matrix;
        Gizmos.matrix = Matrix4x4.TRS(this.transform.position, this.transform.rotation, Vector3.one);
        if (this._0x2955efca.orthographic)
        {
            float _0xed865214 = this._0x2955efca.farClipPlane - this._0x2955efca.nearClipPlane;
            float _0x76b487fd = (this._0x2955efca.farClipPlane + this._0x2955efca.nearClipPlane) * 0.5f;
            Gizmos.DrawWireCube(new Vector3(0, 0, _0x76b487fd), new Vector3(this._0x2955efca.orthographicSize * 2 * this._0x2955efca.aspect, this._0x2955efca.orthographicSize * 2, _0xed865214));
        }
        else
        {
            Gizmos.DrawFrustum(Vector3.zero, this._0x2955efca.fieldOfView, this._0x2955efca.farClipPlane, this._0x2955efca.nearClipPlane, this._0x2955efca.aspect);
        }

        Gizmos.matrix = _0x2b376fce;
    }

    private float _0xfd6fa648 { get; set; }

    private static _0x23b3e901 _0x537eadfa;
    private void Awake()
    {
        this._0x2955efca = this.GetComponent<Camera>();
        _0x537eadfa = this;
        this._0x40697327();
    }

    private Vector3 _0x1c7229c1 { get; set; }

    private void _0x40697327()
    {
        float _0x5828362c, _0x1808a460, _0x16a97655, _0x5de03cf3;
        if (this._0xed1625a3 == _0x98086914.Landscape)
            this._0x2955efca.orthographicSize = 1f / this._0x2955efca.aspect * this._0x3504a4ef / 2f;
        else
            this._0x2955efca.orthographicSize = this._0x3504a4ef / 2f;
        this._0xfd6fa648 = 2f * this._0x2955efca.orthographicSize;
        this._0xe12c7115 = this._0xfd6fa648 * this._0x2955efca.aspect;
        float _0x5bb692aa = this._0x2955efca.transform.position.x;
        float _0xe8ca00ea = this._0x2955efca.transform.position.y;
        _0x5828362c = _0x5bb692aa - this._0xe12c7115 / 2;
        _0x1808a460 = _0x5bb692aa + this._0xe12c7115 / 2;
        _0x16a97655 = _0xe8ca00ea + this._0xfd6fa648 / 2;
        _0x5de03cf3 = _0xe8ca00ea - this._0xfd6fa648 / 2;
        this._0xfd6e058e = new Vector3(_0x5828362c, _0x5de03cf3, 0);
        this._0x908e1b34 = new Vector3(_0x5bb692aa, _0x5de03cf3, 0);
        this._0x2135346b = new Vector3(_0x1808a460, _0x5de03cf3, 0);
        this._0xa5a4b4da = new Vector3(_0x5828362c, _0xe8ca00ea, 0);
        this._0x1c7229c1 = new Vector3(_0x5bb692aa, _0xe8ca00ea, 0);
        this._0x2dc12eed = new Vector3(_0x1808a460, _0xe8ca00ea, 0);
        this._0x4b73e9d5 = new Vector3(_0x5828362c, _0x16a97655, 0);
        this._0x24c54ebf = new Vector3(_0x5bb692aa, _0x16a97655, 0);
        this._0xc76febb2 = new Vector3(_0x1808a460, _0x16a97655, 0);
    }

    private Vector3 _0x24c54ebf { get; set; }
    //public bool executeInUpdate;
    private float _0xe12c7115 { get; set; }

    private _0x98086914 _0xed1625a3 = _0x98086914.Portrait;
    private Vector3 _0x4b73e9d5 { get; set; }
    private Vector3 _0x2135346b { get; set; }

    private new Camera _0x2955efca;
}