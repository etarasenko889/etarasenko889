using System.Linq;
using UnityEngine;
using UnityEngine.InputSystem.EnhancedTouch;
using Touch = UnityEngine.InputSystem.EnhancedTouch.Touch;
using TouchPhase = UnityEngine.InputSystem.TouchPhase;

public class _0x81fdffd3 : MonoBehaviour
{
    private void Awake()
    {
        EnhancedTouchSupport.Enable();
        _0xe1534b1d = this.gameObject.GetComponent<_0x81fdffd3>();
    }

    private void _0xc969ac58(Touch? _0x1a005c20)
    {
        if (!_0x8c1ab97d.Instance._0xf09af649)
        {
            _0x1a005c20 = null;
            return;
        }

        int _0x91f2a2f8 = _0x1a005c20.Value.touchId;
        _0x1a005c20 = Touch.activeTouches.FirstOrDefault(_0xda3fd791 => _0xda3fd791.touchId == _0x91f2a2f8);
        if (!this._0x9f791531(_0x1a005c20.Value))
            _0x1a005c20 = null;
    }

    private static _0x81fdffd3 _0xe1534b1d;
    private Touch? _0xfc2a04e1()
    {
        if (!_0x8c1ab97d.Instance._0xf09af649)
            return null;
        foreach (Touch _0x1c338dc6 in Touch.activeTouches)
            if (_0x1c338dc6.ended)
                if (this._0x9f791531(_0x1c338dc6))
                    return _0x1c338dc6;
        return null;
    }

    private Touch? _0xaefd1b20(Bounds _0xb8204a66)
    {
        if (!_0x8c1ab97d.Instance._0xf09af649)
            return null;
        foreach (Touch _0x1e47d70e in Touch.activeTouches)
            if (!_0x1e47d70e.ended)
            {
                Vector3 _0x1ab13b52 = Camera.main.ScreenToWorldPoint(_0x1e47d70e.screenPosition);
                Vector3 _0x14c3b735 = new(_0x1ab13b52.x, _0x1ab13b52.y, _0xb8204a66.center.z);
                if (_0xb8204a66.Contains(_0x14c3b735) && this._0x9f791531(_0x1e47d70e))
                    return _0x1e47d70e;
            }

        return null;
    }

    private Touch? _0xe3e1f998(Bounds _0xe2728a47)
    {
        if (!_0x8c1ab97d.Instance._0xf09af649)
            return null;
        foreach (Touch _0x4b0e60ca in Touch.activeTouches)
            if (_0x4b0e60ca.ended)
            {
                Vector3 _0x625b19b7 = Camera.main.ScreenToWorldPoint(_0x4b0e60ca.screenPosition);
                Vector3 _0x1002cc45 = new(_0x625b19b7.x, _0x625b19b7.y, _0xe2728a47.center.z);
                if (_0xe2728a47.Contains(_0x1002cc45) && this._0x9f791531(_0x4b0e60ca))
                    return _0x4b0e60ca;
            }

        return null;
    }

    private bool _0xada304c0(Touch? _0x44b9171e, Bounds _0x6b70ab7a, TouchPhase _0xea9a8e53)
    {
        if (!_0x8c1ab97d.Instance._0xf09af649)
        {
            _0x44b9171e = null;
            return false;
        }

        if (_0x44b9171e != null)
            if (_0x44b9171e.Value.phase == _0xea9a8e53)
            {
                Vector3 _0x38797776 = Camera.main.ScreenToWorldPoint(_0x44b9171e.Value.screenPosition);
                Vector3 _0x7469a5a3 = new(_0x38797776.x, _0x38797776.y, _0x6b70ab7a.center.z);
                if (_0x6b70ab7a.Contains(_0x7469a5a3) && this._0x9f791531(_0x44b9171e.Value))
                    return true;
            }

        return false;
    }

    private bool _0x9f791531(Touch? _0xe81710b5)
    {
        if (!_0xe81710b5.HasValue)
            return false;
        Vector3 _0xc0a20234 = Camera.main.ScreenToWorldPoint(_0xe81710b5.Value.screenPosition);
        Vector3 _0x37593f44 = _0xc0a20234;
        _0x37593f44.z = this.CameraTouchBounds.transform.position.z;
        if (this.CameraTouchBounds.bounds.Contains(_0x37593f44))
            return true;
        _0xe81710b5 = null;
        return false;
    }

    private Touch? _0xcfb6d846(Bounds _0xdebbe899, TouchPhase _0xf09c7ec3)
    {
        if (!_0x8c1ab97d.Instance._0xf09af649)
            return null;
        foreach (Touch _0x85a4c03a in Touch.activeTouches)
            if (_0x85a4c03a.phase == _0xf09c7ec3)
            {
                Vector3 _0x5ab26d40 = Camera.main.ScreenToWorldPoint(_0x85a4c03a.screenPosition);
                Vector3 _0x156e2be3 = new(_0x5ab26d40.x, _0x5ab26d40.y, _0xdebbe899.center.z);
                if (_0xdebbe899.Contains(_0x156e2be3) && this._0x9f791531(_0x85a4c03a))
                    return _0x85a4c03a;
            }

        return null;
    }

    public BoxCollider2D CameraTouchBounds;
    private Touch? _0xecc175a1()
    {
        if (!_0x8c1ab97d.Instance._0xf09af649)
            return null;
        foreach (Touch _0xf87d88b8 in Touch.activeTouches)
            if (!_0xf87d88b8.ended)
                if (this._0x9f791531(_0xf87d88b8))
                    return _0xf87d88b8;
        return null;
    }
}