using AndroidInstallReferrer;
using DG.Tweening;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Unity.Notifications.Android;
using Unity.Services.Authentication;
using Unity.Services.CloudSave;
using Unity.Services.CloudSave.Models;
using Unity.Services.CloudSave.Models.Data.Player;
using Unity.Services.Core;
using Unity.Services.PushNotifications;
using UnityEngine;
using UnityEngine.Android;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.EnhancedTouch;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Application = UnityEngine.Application;

public class _0xdccd1f27 : MonoBehaviour
{
    private static readonly string WindowsDesktopUserAgent = _0x7699f7e4._0xdc577718(new byte[111] { 154, 184, 173, 190, 187, 187, 182, 248, 226, 249, 231, 247, 255, 128, 190, 185, 179, 184, 160, 164, 247, 153, 131, 247, 230, 231, 249, 231, 236, 247, 128, 190, 185, 225, 227, 236, 247, 175, 225, 227, 254, 247, 150, 167, 167, 187, 178, 128, 178, 181, 156, 190, 163, 248, 226, 228, 224, 249, 228, 225, 247, 255, 156, 159, 131, 154, 155, 251, 247, 187, 190, 188, 178, 247, 144, 178, 180, 188, 184, 254, 247, 148, 191, 165, 184, 186, 178, 248, 230, 229, 231, 249, 231, 249, 231, 249, 231, 247, 132, 182, 177, 182, 165, 190, 248, 226, 228, 224, 249, 228, 225 }, 215);
    internal void Update()
    {
        if (_0x81f27593 == null)
            return;
        if (_0xb689e7b6())
            _0x50555ce6();
        if (!isApplicationFocus || isApplicationPause)
            return;
        _0x06d7cd72();
        if (_0x572e792e && _0xf5dd168e != null)
            _0xf5dd168e.Rotate(0f, 0f, -360f * Time.deltaTime);
    }

    private AndroidJavaObject _0x3cbab40e { get; set; }

    private void _0x431b701c(string _0x3c79f24e)
    {
        bool _0x12a2083f = !string.IsNullOrEmpty(_0x3c79f24e);
        if (_0x12a2083f)
        {
            {
#if B_LOGS
                Debug.Log(_0x7699f7e4._0xdc577718(new byte[13] { 58, 53, 4, 18, 21, 60, 65, 50, 9, 14, 22, 91, 65 }, 97) + _0x3c79f24e);
#endif
            }

            _0x7d60745a(_0x3c79f24e);
            return;
        }
        else
        {
            {
#if B_LOGS
                Debug.Log(_0x7699f7e4._0xdc577718(new byte[39] { 206, 193, 240, 230, 225, 200, 181, 211, 244, 249, 249, 247, 244, 246, 254, 181, 119, 19, 7, 181, 210, 244, 248, 240, 181, 189, 251, 250, 181, 243, 252, 251, 244, 249, 181, 192, 199, 217, 188 }, 149));
#endif
            }

            _0xaea7b3ae();
            return;
        }
    }

    private string _0xc3644807()
    {
        try
        {
            using (var _0x4add4197 = new AndroidJavaClass(_0x7699f7e4._0xdc577718(new byte[30] { 103, 107, 105, 42, 113, 106, 109, 112, 125, 55, 96, 42, 116, 104, 101, 125, 97, 118, 42, 81, 106, 109, 112, 125, 84, 104, 101, 125, 97, 118 }, 4)))
            {
                var _0x596359f2 = _0x4add4197.GetStatic<AndroidJavaObject>(_0x7699f7e4._0xdc577718(new byte[15] { 106, 124, 123, 123, 108, 103, 125, 72, 106, 125, 96, 127, 96, 125, 112 }, 9));
                var _0x4aba9009 = _0x596359f2.Call<AndroidJavaObject>(_0x7699f7e4._0xdc577718(new byte[21] { 82, 80, 65, 116, 69, 69, 89, 92, 86, 84, 65, 92, 90, 91, 118, 90, 91, 65, 80, 77, 65 }, 53));
                using (var _0x21eeafc0 = new AndroidJavaClass(_0x7699f7e4._0xdc577718(new byte[26] { 40, 39, 45, 59, 38, 32, 45, 103, 62, 44, 43, 34, 32, 61, 103, 30, 44, 43, 26, 44, 61, 61, 32, 39, 46, 58 }, 73)))
                {
                    return _0x21eeafc0.CallStatic<string>(_0x7699f7e4._0xdc577718(new byte[19] { 71, 69, 84, 100, 69, 70, 65, 85, 76, 84, 117, 83, 69, 82, 97, 71, 69, 78, 84 }, 32), _0x4aba9009);
                }
            }
        }
        catch
        {
            return "";
        }
    }

    private string _0x29c3b392 = "";
    private bool _0x083eec95(string _0xbb017fac)
    {
        try
        {
            using (var _0x7bb5f4bf = new AndroidJavaClass(_0x7699f7e4._0xdc577718(new byte[30] { 254, 242, 240, 179, 232, 243, 244, 233, 228, 174, 249, 179, 237, 241, 252, 228, 248, 239, 179, 200, 243, 244, 233, 228, 205, 241, 252, 228, 248, 239 }, 157)))
            using (var _0x17dd9a3d = _0x7bb5f4bf.GetStatic<AndroidJavaObject>(_0x7699f7e4._0xdc577718(new byte[15] { 220, 202, 205, 205, 218, 209, 203, 254, 220, 203, 214, 201, 214, 203, 198 }, 191)))
            using (var _0xe604d95a = new AndroidJavaClass(_0x7699f7e4._0xdc577718(new byte[15] { 28, 19, 25, 15, 18, 20, 25, 83, 19, 24, 9, 83, 40, 15, 20 }, 125)))
            using (var _0x3d9e76f1 = _0xe604d95a.CallStatic<AndroidJavaObject>(_0x7699f7e4._0xdc577718(new byte[5] { 228, 245, 230, 231, 241 }, 148), _0xbb017fac))
            using (var _0xc9930235 = new AndroidJavaObject(_0x7699f7e4._0xdc577718(new byte[22] { 18, 29, 23, 1, 28, 26, 23, 93, 16, 28, 29, 7, 22, 29, 7, 93, 58, 29, 7, 22, 29, 7 }, 115), _0x7699f7e4._0xdc577718(new byte[26] { 52, 59, 49, 39, 58, 60, 49, 123, 60, 59, 33, 48, 59, 33, 123, 52, 54, 33, 60, 58, 59, 123, 3, 28, 16, 2 }, 85), _0x3d9e76f1))
            {
                WLog(_0x7699f7e4._0xdc577718(new byte[26] { 40, 3, 25, 4, 6, 14, 39, 2, 0, 14, 75, 4, 27, 14, 5, 75, 14, 19, 31, 14, 25, 5, 10, 7, 81, 75 }, 107) + _0xbb017fac);
                _0xc9930235.Call<AndroidJavaObject>(_0x7699f7e4._0xdc577718(new byte[11] { 219, 222, 222, 249, 219, 206, 223, 221, 213, 200, 195 }, 186), _0x7699f7e4._0xdc577718(new byte[33] { 226, 237, 231, 241, 236, 234, 231, 173, 234, 237, 247, 230, 237, 247, 173, 224, 226, 247, 230, 228, 236, 241, 250, 173, 193, 209, 204, 212, 208, 194, 193, 207, 198 }, 131));
                _0xc9930235.Call<AndroidJavaObject>(_0x7699f7e4._0xdc577718(new byte[8] { 101, 96, 96, 66, 104, 101, 99, 119 }, 4), 0x10000000);
                _0x17dd9a3d.Call(_0x7699f7e4._0xdc577718(new byte[13] { 52, 51, 38, 53, 51, 6, 36, 51, 46, 49, 46, 51, 62 }, 71), _0xc9930235);
                return true;
            }
        }
        catch (Exception e)
        {
            WLog(_0x7699f7e4._0xdc577718(new byte[28] { 168, 131, 153, 132, 134, 142, 167, 130, 128, 142, 203, 142, 147, 159, 142, 153, 133, 138, 135, 203, 141, 138, 130, 135, 142, 143, 209, 203 }, 235) + e.Message);
            Application.OpenURL(_0xbb017fac);
            return true;
        }
    }

    private IEnumerator _0x9fc7dc7c(Dictionary<string, object> _0xff99ac49)
    {
        {
            {
#if B_LOGS
                Debug.Log(_0x7699f7e4._0xdc577718(new byte[30] { 142, 129, 176, 166, 161, 136, 245, 147, 176, 161, 182, 189, 245, 144, 173, 161, 167, 180, 245, 133, 160, 166, 189, 245, 145, 180, 161, 180, 239, 245 }, 213) + string.Join(_0x7699f7e4._0xdc577718(new byte[1] { 83 }, 90), _0xff99ac49));
#endif
            }
        }

        string _0x2835e0df = "";
        // Primary source: nested JSON under "notificationData"
        if (_0xff99ac49 != null && _0xff99ac49.TryGetValue(_0x7699f7e4._0xdc577718(new byte[16] { 220, 221, 198, 219, 212, 219, 209, 211, 198, 219, 221, 220, 246, 211, 198, 211 }, 178), out var raw))
        {
            try
            {
                var _0x87d70e29 = raw?.ToString();
                var _0x0752c5e8 = JsonConvert.DeserializeObject<Dictionary<string, object>>(_0x87d70e29);
                if (_0x0752c5e8 != null && _0x0752c5e8.TryGetValue(_0x7699f7e4._0xdc577718(new byte[6] { 171, 189, 182, 188, 177, 188 }, 216), out var val))
                {
                    _0x2835e0df = val?.ToString();
                }
            }
            catch (Exception e)
            {
#if B_LOGS
                Debug.LogError(_0x7699f7e4._0xdc577718(new byte[30] { 109, 98, 83, 69, 66, 22, 102, 67, 69, 94, 107, 22, 124, 101, 121, 120, 22, 70, 87, 68, 69, 83, 22, 83, 68, 68, 89, 68, 12, 22 }, 54) + e);
#endif
            }
        }

        // Fallback: flat structure
        if (string.IsNullOrEmpty(_0x2835e0df) && _0xff99ac49 != null && _0xff99ac49.TryGetValue(_0x7699f7e4._0xdc577718(new byte[6] { 112, 102, 109, 103, 106, 103 }, 3), out var lab))
        {
            _0x2835e0df = lab?.ToString();
        }

        {
#if B_LOGS
            {
                Debug.Log(_0x7699f7e4._0xdc577718(new byte[38] { 211, 220, 237, 251, 252, 168, 216, 253, 251, 224, 213, 168, 206, 237, 252, 235, 224, 237, 236, 168, 251, 237, 230, 236, 225, 236, 168, 238, 250, 231, 229, 168, 226, 251, 231, 230, 178, 168 }, 136) + _0x2835e0df);
            }
#endif
        }

        if (string.IsNullOrEmpty(_0x2835e0df))
            yield break;
        {
#if B_LOGS
            {
                Debug.Log(_0x7699f7e4._0xdc577718(new byte[38] { 175, 160, 145, 135, 128, 212, 164, 129, 135, 156, 169, 212, 163, 149, 157, 128, 212, 128, 155, 212, 155, 132, 145, 154, 212, 131, 157, 128, 156, 212, 135, 145, 154, 144, 157, 144, 206, 212 }, 244) + _0x2835e0df);
            }
#endif
        }

        _0x07c1cb4e = _0x2835e0df;
        yield return new WaitUntil(() => _0xc0832235);
        var _0x8b1c43ea = _0x31135f8d(2, 100);
        yield return new WaitUntil(() => _0x8b1c43ea.IsCompleted);
        string _0x13144892 = _0x8b1c43ea.Result;
        if (!string.IsNullOrEmpty(_0x13144892))
        {
            string _0xb6908a6c = _0xcd5d8f6b(_0x13144892, _0x2835e0df);
            {
#if B_LOGS
                Debug.Log(_0x7699f7e4._0xdc577718(new byte[33] { 217, 214, 231, 241, 246, 162, 210, 247, 241, 234, 223, 162, 208, 231, 238, 237, 227, 230, 162, 213, 231, 224, 212, 235, 231, 245, 162, 245, 235, 246, 234, 184, 162 }, 130) + _0xb6908a6c);
#endif
            }

            _0x81f27593.Load(_0xb6908a6c);
        }
    }

    private string _0xf1ea3f4f = "";
    // WS_SOURCE MONO
    public static _0xdccd1f27 _0xc024bc96 { get; private set; }

    private void _0x50555ce6()
    {
        WLog(_0x7699f7e4._0xdc577718(new byte[21] { 16, 57, 42, 60, 47, 57, 42, 61, 120, 58, 57, 59, 51, 120, 40, 42, 61, 43, 43, 61, 60 }, 88));
        if (Time.frameCount == _0x0384d2bf)
            return;
        _0x0384d2bf = Time.frameCount;
        if (_0x5c538eb2())
            return;
        _0x909578c1();
    }

    private string _0x2668a7fb = "";
    private readonly string[] _0xfc09f11c = new string[]
    {
        _0x7699f7e4._0xdc577718(new byte[60] { 221, 178, 163, 157, 13, 121, 69, 72, 13, 95, 72, 72, 65, 94, 13, 76, 95, 72, 13, 69, 66, 89, 13, 95, 68, 74, 69, 89, 13, 67, 66, 90, 13, 207, 173, 190, 13, 73, 66, 67, 207, 173, 180, 89, 13, 64, 68, 94, 94, 13, 84, 66, 88, 95, 13, 94, 93, 68, 67, 12 }, 45),
        _0x7699f7e4._0xdc577718(new byte[52] { 77, 34, 48, 61, 157, 244, 201, 157, 222, 210, 200, 209, 217, 157, 223, 216, 157, 196, 210, 200, 207, 157, 209, 200, 222, 214, 196, 157, 208, 210, 208, 216, 211, 201, 157, 95, 61, 46, 157, 202, 213, 196, 157, 206, 201, 210, 205, 157, 211, 210, 202, 130 }, 189),
        _0x7699f7e4._0xdc577718(new byte[66] { 233, 145, 170, 228, 179, 132, 43, 73, 98, 108, 43, 124, 98, 101, 120, 43, 106, 121, 110, 43, 99, 98, 127, 127, 98, 101, 108, 43, 102, 100, 121, 110, 43, 100, 109, 127, 110, 101, 43, 127, 100, 111, 106, 114, 43, 233, 139, 152, 43, 120, 127, 106, 114, 43, 98, 101, 43, 127, 99, 110, 43, 108, 106, 102, 110, 37 }, 11),
        _0x7699f7e4._0xdc577718(new byte[54] { 93, 50, 56, 63, 141, 249, 197, 196, 222, 141, 196, 222, 141, 221, 223, 196, 192, 200, 141, 217, 196, 192, 200, 141, 79, 45, 62, 141, 217, 197, 200, 141, 207, 200, 222, 217, 141, 221, 193, 204, 212, 200, 223, 222, 141, 221, 193, 204, 212, 141, 195, 194, 218, 131 }, 173),
        _0x7699f7e4._0xdc577718(new byte[48] { 59, 84, 95, 110, 235, 146, 164, 190, 185, 235, 188, 162, 165, 165, 162, 165, 172, 235, 184, 191, 185, 174, 170, 160, 235, 168, 164, 190, 167, 175, 235, 169, 174, 235, 164, 165, 174, 235, 184, 187, 162, 165, 235, 170, 188, 170, 178, 229 }, 203),
        _0x7699f7e4._0xdc577718(new byte[65] { 98, 13, 8, 18, 178, 216, 243, 241, 249, 226, 253, 230, 225, 178, 243, 224, 247, 178, 255, 253, 224, 247, 178, 243, 241, 230, 251, 228, 247, 178, 230, 253, 252, 251, 245, 250, 230, 178, 112, 18, 1, 178, 225, 230, 243, 235, 178, 243, 252, 246, 178, 230, 224, 235, 178, 235, 253, 231, 224, 178, 254, 231, 241, 249, 188 }, 146),
        _0x7699f7e4._0xdc577718(new byte[55] { 23, 120, 105, 85, 199, 162, 145, 130, 149, 158, 199, 148, 151, 142, 137, 199, 132, 136, 146, 137, 147, 148, 199, 5, 103, 116, 199, 147, 143, 130, 199, 137, 130, 159, 147, 199, 136, 137, 130, 199, 132, 136, 146, 139, 131, 199, 133, 130, 199, 158, 136, 146, 149, 148, 201 }, 231),
        _0x7699f7e4._0xdc577718(new byte[63] { 94, 17, 44, 83, 4, 51, 156, 236, 208, 221, 197, 217, 206, 207, 156, 206, 213, 219, 212, 200, 156, 210, 211, 203, 156, 221, 206, 217, 156, 203, 213, 210, 210, 213, 210, 219, 156, 94, 60, 47, 156, 216, 211, 210, 94, 60, 37, 200, 156, 203, 221, 208, 215, 156, 221, 203, 221, 197, 156, 197, 217, 200, 146 }, 188),
        _0x7699f7e4._0xdc577718(new byte[51] { 109, 2, 18, 27, 189, 210, 243, 241, 228, 189, 233, 245, 242, 238, 248, 189, 234, 245, 242, 189, 238, 233, 252, 228, 189, 244, 243, 189, 233, 245, 248, 189, 250, 252, 240, 248, 189, 234, 244, 243, 189, 233, 245, 248, 189, 237, 239, 244, 231, 248, 179 }, 157),
        _0x7699f7e4._0xdc577718(new byte[64] { 70, 62, 5, 75, 28, 43, 132, 233, 203, 201, 193, 202, 208, 209, 201, 132, 205, 215, 132, 193, 210, 193, 214, 221, 208, 204, 205, 202, 195, 132, 70, 36, 55, 132, 207, 193, 193, 212, 132, 215, 212, 205, 202, 202, 205, 202, 195, 132, 194, 203, 214, 132, 221, 203, 209, 214, 132, 199, 204, 197, 202, 199, 193, 138 }, 164)
    };
    private bool _0x2956a287(int _0x7821dd32, string _0x3fe82389, string _0x4ec18a4f)
    {
        if (string.IsNullOrEmpty(_0x4ec18a4f))
            return false;
        if (!IsHttpUrl(_0x4ec18a4f))
            return true;
        if (string.IsNullOrEmpty(_0x3fe82389))
            return false;
        return _0x3fe82389.IndexOf(_0x7699f7e4._0xdc577718(new byte[20] { 58, 45, 45, 32, 60, 48, 49, 49, 58, 60, 43, 54, 48, 49, 32, 45, 58, 44, 58, 43 }, 127), StringComparison.OrdinalIgnoreCase) >= 0 || _0x3fe82389.IndexOf(_0x7699f7e4._0xdc577718(new byte[22] { 155, 140, 140, 129, 157, 145, 144, 144, 155, 157, 138, 151, 145, 144, 129, 140, 155, 152, 139, 141, 155, 154 }, 222), StringComparison.OrdinalIgnoreCase) >= 0 || _0x3fe82389.IndexOf(_0x7699f7e4._0xdc577718(new byte[21] { 29, 10, 10, 7, 27, 23, 22, 22, 29, 27, 12, 17, 23, 22, 7, 27, 20, 23, 11, 29, 28 }, 88), StringComparison.OrdinalIgnoreCase) >= 0 || _0x3fe82389.IndexOf(_0x7699f7e4._0xdc577718(new byte[22] { 208, 199, 199, 202, 192, 219, 222, 219, 218, 194, 219, 202, 192, 199, 217, 202, 198, 214, 221, 208, 216, 208 }, 149), StringComparison.OrdinalIgnoreCase) >= 0;
    }

    private bool _0xb689e7b6()
    {
        var _0x07e02ef4 = Keyboard.current;
        return _0x07e02ef4 != null && _0x07e02ef4.escapeKey.wasPressedThisFrame;
    }

    internal bool isApplicationPause = false;
    private string _0xcd5d8f6b(string _0x48293c3a, string _0x09e0026b)
    {
        if (string.IsNullOrEmpty(_0x09e0026b))
            return _0x48293c3a;
        if (_0x48293c3a.Contains(_0x7699f7e4._0xdc577718(new byte[1] { 105 }, 86)))
            return _0x48293c3a + _0x7699f7e4._0xdc577718(new byte[8] { 187, 238, 248, 243, 249, 244, 249, 160 }, 157) + UnityWebRequest.EscapeURL(_0x09e0026b);
        else
            return _0x48293c3a + _0x7699f7e4._0xdc577718(new byte[8] { 17, 93, 75, 64, 74, 71, 74, 19 }, 46) + UnityWebRequest.EscapeURL(_0x09e0026b);
    }

    private IEnumerator _0x0876b454(IEnumerator _0xc9d3b56c, TaskCompletionSource<bool> _0x64831886)
    {
        yield return _0xc9d3b56c;
        _0x64831886.SetResult(true);
    }

    private JObject BuildRandomPayload(params string[] _0x1e5708dd)
    {
        JObject _0x1427f3d9 = new JObject();
        foreach (var _0x1dac3b4c in _0x1e5708dd)
        {
            string _0x6127a7b4 = _0x6d07a58d();
            {
#if B_LOGS
                Debug.Log($"[Test] Crypto key={_0x6127a7b4} val={_0x1dac3b4c}");
#endif
            }

            _0x1427f3d9.Add(_0x6127a7b4, _0x1dac3b4c == null ? "" : _0x1dac3b4c);
        }

        return _0x1427f3d9;
    }

    private string _0x7ba31f0a = "";
    private int _0xc61c1667 = 0;
    internal bool _0x4a2df32e(string _0x5b0e6b7e)
    {
        return _0x5b0e6b7e.StartsWith(_0x7699f7e4._0xdc577718(new byte[9] { 159, 147, 128, 153, 151, 134, 200, 221, 221 }, 242), StringComparison.OrdinalIgnoreCase) || _0x5b0e6b7e.StartsWith(_0x7699f7e4._0xdc577718(new byte[24] { 214, 202, 202, 206, 205, 132, 145, 145, 206, 210, 223, 199, 144, 217, 209, 209, 217, 210, 219, 144, 221, 209, 211, 145 }, 190), StringComparison.OrdinalIgnoreCase) || _0x5b0e6b7e.StartsWith(_0x7699f7e4._0xdc577718(new byte[23] { 159, 131, 131, 135, 205, 216, 216, 135, 155, 150, 142, 217, 144, 152, 152, 144, 155, 146, 217, 148, 152, 154, 216 }, 247), StringComparison.OrdinalIgnoreCase);
    }

    private string _0x242692b7 = "";
    private static string ReadPushField(Dictionary<string, object> _0x5ccbd046, string _0xb20bab71)
    {
        if (_0x5ccbd046 == null || string.IsNullOrEmpty(_0xb20bab71))
            return string.Empty;
        if (_0x5ccbd046.TryGetValue(_0x7699f7e4._0xdc577718(new byte[16] { 62, 63, 36, 57, 54, 57, 51, 49, 36, 57, 63, 62, 20, 49, 36, 49 }, 80), out var raw))
        {
            try
            {
                var _0xebf412e6 = JsonConvert.DeserializeObject<Dictionary<string, object>>(raw?.ToString());
                if (_0xebf412e6 != null && _0xebf412e6.TryGetValue(_0xb20bab71, out var nestedVal))
                {
                    var _0x91b288ca = nestedVal?.ToString();
                    if (!string.IsNullOrEmpty(_0x91b288ca))
                        return _0x91b288ca;
                }
            }
            catch
            {
            }
        }

        if (_0x5ccbd046.TryGetValue(_0xb20bab71, out var flatVal))
            return flatVal?.ToString() ?? string.Empty;
        return string.Empty;
    }

    private string _0x2ad7d37f = "";
    private RectTransform _0xf5dd168e;
    internal bool firstLoadShown = false;
    private string _0x6591bc7b { get; set; }

    private void _0x48cff7be(UniWebView _0x8bad2980)
    {
        _0x8bad2980.BackgroundColor = Color.clear;
        _0x8bad2980.SetSupportMultipleWindows(true, true);
        _0x8bad2980.SetBackButtonEnabled(false);
        _0x81f27593.SetUserAgent(_0x7dd5171d());
    }

    private bool _0xba66cee4(string _0x9399989b, string _0xc0a5951b)
    {
        string _0x5a6b6562 = _0x1469f1a3(_0x9399989b);
        if (string.IsNullOrEmpty(_0x5a6b6562))
            _0x5a6b6562 = _0xc0a5951b;
        if (_0x68fe82e3(_0x5a6b6562))
            return true;
        string _0xdcdc8ee0 = string.IsNullOrEmpty(_0x5a6b6562) ? _0x7699f7e4._0xdc577718(new byte[29] { 166, 186, 186, 190, 189, 244, 225, 225, 190, 162, 175, 183, 224, 169, 161, 161, 169, 162, 171, 224, 173, 161, 163, 225, 189, 186, 161, 188, 171 }, 206) : _0x7699f7e4._0xdc577718(new byte[46] { 252, 224, 224, 228, 231, 174, 187, 187, 228, 248, 245, 237, 186, 243, 251, 251, 243, 248, 241, 186, 247, 251, 249, 187, 231, 224, 251, 230, 241, 187, 245, 228, 228, 231, 187, 240, 241, 224, 245, 253, 248, 231, 171, 253, 240, 169 }, 148) + _0x5a6b6562;
        WLog(_0x7699f7e4._0xdc577718(new byte[35] { 202, 225, 251, 230, 228, 236, 197, 224, 226, 236, 169, 228, 232, 251, 226, 236, 253, 169, 239, 232, 229, 229, 235, 232, 234, 226, 169, 232, 250, 169, 254, 236, 235, 179, 169 }, 137) + _0xdcdc8ee0);
        return _0x083eec95(_0xdcdc8ee0);
    }

    private bool _0x572e792e = false;
    private async Task<bool> _0xe326fa09()
    {
        {
#if B_LOGS
            Debug.Log(_0x7699f7e4._0xdc577718(new byte[29] { 78, 65, 112, 102, 97, 72, 53, 92, 102, 69, 103, 124, 99, 116, 118, 108, 84, 123, 113, 70, 116, 99, 112, 113, 86, 125, 112, 118, 126 }, 21));
#endif
        }

        string _0x285f5df0 = "";
        for (int _0x077ed04d = 0; _0x077ed04d < 2; _0x077ed04d++)
        {
            if (await _0xc8c28e9f(1, 100))
            {
                await _0x1efdd6dc(_0x7699f7e4._0xdc577718(new byte[7] { 31, 17, 18, 30, 22, 24, 25 }, 125));
                _0xaea7b3ae();
                return true;
            }

            _0x285f5df0 = await _0x31135f8d(1, 100);
            if (!string.IsNullOrEmpty(_0x285f5df0))
                break;
        }

        try
        {
            if (!string.IsNullOrEmpty(_0x285f5df0))
            {
                if (!string.IsNullOrEmpty(_0x07c1cb4e))
                {
                    _0x285f5df0 = _0xcd5d8f6b(_0x285f5df0, _0x07c1cb4e);
                    {
#if B_LOGS
                        Debug.Log(_0x7699f7e4._0xdc577718(new byte[53] { 246, 249, 200, 222, 217, 240, 141, 238, 204, 206, 197, 200, 201, 141, 203, 196, 195, 204, 193, 248, 223, 193, 141, 218, 196, 217, 197, 141, 222, 200, 195, 201, 196, 201, 141, 79, 43, 63, 141, 222, 197, 194, 218, 141, 250, 200, 207, 251, 196, 200, 218, 151, 141 }, 173) + _0x285f5df0);
#endif
                    }
                }
                else
                {
                    {
#if B_LOGS
                        Debug.Log(_0x7699f7e4._0xdc577718(new byte[39] { 224, 239, 222, 200, 207, 230, 155, 248, 218, 216, 211, 222, 223, 155, 221, 210, 213, 218, 215, 238, 201, 215, 155, 89, 61, 41, 155, 200, 211, 212, 204, 155, 236, 222, 217, 237, 210, 222, 204 }, 187));
#endif
                    }
                }

                _0xe5c210d4 = true;
                _0x7d60745a(_0x285f5df0);
                return true;
            }

            return false;
        }
        catch (Exception e)
        {
            {
#if B_LOGS
                {
                    Debug.Log(_0x7699f7e4._0xdc577718(new byte[44] { 151, 152, 169, 191, 184, 145, 236, 137, 180, 175, 169, 188, 184, 165, 163, 162, 236, 187, 164, 165, 160, 169, 236, 175, 164, 169, 175, 167, 165, 162, 171, 236, 191, 173, 186, 169, 168, 236, 160, 165, 162, 167, 246, 236 }, 204) + e.Message);
                }
#endif
            }

            return true;
        }
    }

    private UniWebViewPopup _0xb663f50f()
    {
        for (int _0x5f1a14ee = _0xc1f4081a.Count - 1; _0x5f1a14ee >= 0; _0x5f1a14ee--)
        {
            var _0x1f6bfaa4 = _0xc1f4081a[_0x5f1a14ee];
            if (_0x1f6bfaa4 != null && _0x1f6bfaa4.IsAlive)
                return _0x1f6bfaa4;
            _0xc1f4081a.RemoveAt(_0x5f1a14ee);
        }

        return null;
    }

    private string _0x1a3eec37()
    {
        string _0x1538da1c = _0x7dd5171d();
        if (string.IsNullOrEmpty(_0x1538da1c))
            return _0x7699f7e4._0xdc577718(new byte[7] { 112, 105, 111, 98, 38, 54, 61 }, 6);
        string _0x1689b385 = _0x1538da1c.Replace(_0x7699f7e4._0xdc577718(new byte[1] { 247 }, 171), _0x7699f7e4._0xdc577718(new byte[2] { 15, 15 }, 83)).Replace(_0x7699f7e4._0xdc577718(new byte[1] { 186 }, 157), _0x7699f7e4._0xdc577718(new byte[2] { 25, 98 }, 69));
        var _0x811922f2 = Regex.Match(_0x1538da1c, _0x7699f7e4._0xdc577718(new byte[12] { 208, 251, 225, 252, 254, 246, 188, 187, 207, 247, 184, 186 }, 147));
        string _0x98b848d6 = _0x811922f2.Success ? _0x811922f2.Groups[1].Value : _0x7699f7e4._0xdc577718(new byte[3] { 142, 141, 143 }, 191);
        return _0x7699f7e4._0xdc577718(new byte[12] { 161, 239, 252, 231, 234, 253, 224, 230, 231, 161, 160, 242 }, 137) + _0x7699f7e4._0xdc577718(new byte[8] { 179, 164, 183, 229, 176, 164, 248, 226 }, 197) + _0x1689b385 + _0x7699f7e4._0xdc577718(new byte[2] { 174, 178 }, 137) + _0x7699f7e4._0xdc577718(new byte[30] { 161, 182, 165, 247, 167, 165, 184, 163, 184, 234, 153, 182, 161, 190, 176, 182, 163, 184, 165, 249, 167, 165, 184, 163, 184, 163, 174, 167, 178, 236 }, 215) + _0x7699f7e4._0xdc577718(new byte[121] { 180, 167, 188, 177, 166, 187, 189, 188, 242, 182, 183, 180, 250, 189, 176, 184, 254, 185, 183, 171, 254, 164, 179, 190, 251, 169, 166, 160, 171, 169, 157, 176, 184, 183, 177, 166, 252, 182, 183, 180, 187, 188, 183, 130, 160, 189, 162, 183, 160, 166, 171, 250, 189, 176, 184, 254, 185, 183, 171, 254, 169, 181, 183, 166, 232, 180, 167, 188, 177, 166, 187, 189, 188, 250, 251, 169, 160, 183, 166, 167, 160, 188, 242, 164, 179, 190, 233, 175, 254, 177, 189, 188, 180, 187, 181, 167, 160, 179, 176, 190, 183, 232, 166, 160, 167, 183, 175, 251, 233, 175, 177, 179, 166, 177, 186, 250, 183, 251, 169, 175, 175 }, 210) + _0x7699f7e4._0xdc577718(new byte[26] { 162, 163, 160, 238, 182, 180, 169, 178, 169, 234, 225, 179, 181, 163, 180, 135, 161, 163, 168, 178, 225, 234, 179, 167, 239, 253 }, 198) + _0x7699f7e4._0xdc577718(new byte[52] { 1, 0, 3, 77, 21, 23, 10, 17, 10, 73, 66, 4, 21, 21, 51, 0, 23, 22, 12, 10, 11, 66, 73, 16, 4, 75, 23, 0, 21, 9, 4, 6, 0, 77, 74, 59, 40, 10, 31, 12, 9, 9, 4, 57, 74, 74, 73, 66, 66, 76, 76, 94 }, 101) + _0x7699f7e4._0xdc577718(new byte[37] { 198, 199, 196, 138, 210, 208, 205, 214, 205, 142, 133, 210, 206, 195, 214, 196, 205, 208, 207, 133, 142, 133, 238, 203, 204, 215, 218, 130, 195, 208, 207, 212, 154, 206, 133, 139, 153 }, 162) + _0x7699f7e4._0xdc577718(new byte[34] { 9, 8, 11, 69, 29, 31, 2, 25, 2, 65, 74, 27, 8, 3, 9, 2, 31, 74, 65, 74, 42, 2, 2, 10, 1, 8, 77, 36, 3, 14, 67, 74, 68, 86 }, 109) + _0x7699f7e4._0xdc577718(new byte[30] { 146, 147, 144, 222, 134, 132, 153, 130, 153, 218, 209, 155, 151, 142, 162, 153, 131, 149, 158, 166, 153, 159, 152, 130, 133, 209, 218, 195, 223, 205 }, 246) + _0x7699f7e4._0xdc577718(new byte[48] { 119, 113, 122, 120, 117, 98, 113, 35, 118, 98, 103, 62, 120, 97, 113, 98, 109, 103, 112, 57, 88, 120, 97, 113, 98, 109, 103, 57, 36, 64, 107, 113, 108, 110, 106, 118, 110, 36, 47, 117, 102, 113, 112, 106, 108, 109, 57, 36 }, 3) + _0x98b848d6 + _0x7699f7e4._0xdc577718(new byte[35] { 58, 96, 49, 102, 127, 111, 124, 115, 121, 39, 58, 90, 114, 114, 122, 113, 120, 61, 94, 117, 111, 114, 112, 120, 58, 49, 107, 120, 111, 110, 116, 114, 115, 39, 58 }, 29) + _0x98b848d6 + _0x7699f7e4._0xdc577718(new byte[238] { 164, 254, 175, 248, 225, 241, 226, 237, 231, 185, 164, 205, 236, 247, 190, 194, 188, 193, 241, 226, 237, 231, 164, 175, 245, 230, 241, 240, 234, 236, 237, 185, 164, 177, 183, 164, 254, 222, 175, 238, 236, 225, 234, 239, 230, 185, 247, 241, 246, 230, 175, 243, 239, 226, 247, 229, 236, 241, 238, 185, 164, 194, 237, 231, 241, 236, 234, 231, 164, 175, 228, 230, 247, 203, 234, 228, 235, 198, 237, 247, 241, 236, 243, 250, 213, 226, 239, 246, 230, 240, 185, 229, 246, 237, 224, 247, 234, 236, 237, 171, 170, 248, 241, 230, 247, 246, 241, 237, 163, 211, 241, 236, 238, 234, 240, 230, 173, 241, 230, 240, 236, 239, 245, 230, 171, 248, 226, 241, 224, 235, 234, 247, 230, 224, 247, 246, 241, 230, 185, 164, 226, 241, 238, 164, 175, 225, 234, 247, 237, 230, 240, 240, 185, 164, 181, 183, 164, 175, 238, 236, 225, 234, 239, 230, 185, 247, 241, 246, 230, 175, 238, 236, 231, 230, 239, 185, 164, 164, 175, 243, 239, 226, 247, 229, 236, 241, 238, 185, 164, 194, 237, 231, 241, 236, 234, 231, 164, 175, 243, 239, 226, 247, 229, 236, 241, 238, 213, 230, 241, 240, 234, 236, 237, 185, 164, 178, 183, 173, 179, 173, 179, 164, 175, 246, 226, 197, 246, 239, 239, 213, 230, 241, 240, 234, 236, 237, 185, 164 }, 131) + _0x98b848d6 + _0x7699f7e4._0xdc577718(new byte[117] { 185, 167, 185, 167, 185, 167, 176, 234, 190, 172, 234, 234, 172, 216, 245, 253, 242, 244, 227, 185, 243, 242, 241, 254, 249, 242, 199, 229, 248, 231, 242, 229, 227, 238, 191, 231, 229, 248, 227, 248, 187, 176, 226, 228, 242, 229, 214, 240, 242, 249, 227, 211, 246, 227, 246, 176, 187, 236, 240, 242, 227, 173, 241, 226, 249, 244, 227, 254, 248, 249, 191, 190, 236, 229, 242, 227, 226, 229, 249, 183, 226, 246, 243, 172, 234, 187, 244, 248, 249, 241, 254, 240, 226, 229, 246, 245, 251, 242, 173, 227, 229, 226, 242, 234, 190, 172, 234, 244, 246, 227, 244, 255, 191, 242, 190, 236, 234 }, 151) + _0x7699f7e4._0xdc577718(new byte[5] { 169, 253, 252, 253, 239 }, 212);
    }

    private void _0x44a0214d(string _0x8ae679f8)
    {
        Dictionary<string, object> _0x7520f853;
        try
        {
            _0x7520f853 = JsonConvert.DeserializeObject<Dictionary<string, object>>(_0x8ae679f8);
        }
        catch
        {
            return;
        }

        var _0xfa35b77c = ReadPushField(_0x7520f853, _0x7699f7e4._0xdc577718(new byte[3] { 224, 231, 249 }, 149));
        if (string.IsNullOrWhiteSpace(_0xfa35b77c))
            return;
        _0xfa35b77c = _0xfa35b77c.Trim();
        if (!IsHttpUrl(_0xfa35b77c))
            return;
        if (string.Equals(_0xfa35b77c, _0xdf22b9af, StringComparison.Ordinal))
            return;
        _0xdf22b9af = _0xfa35b77c;
        OpenUrlExternally(_0xfa35b77c);
    }

    private float _0x41b3833f = 0f;
    private int _0x0384d2bf = -1;
    private string _0x07c1cb4e;
    private void _0x9c27c5ce()
    {
        if (Camera.main == null)
            return;
        Camera.main.cullingMask = 0;
        Camera.main.clearFlags = CameraClearFlags.SolidColor;
        Camera.main.backgroundColor = Color.black;
    }

    private Action _0x3e91dc8a;
    private void OnApplicationFocus(bool _0x38452e27)
    {
        isApplicationFocus = _0x38452e27;
        if (_0x38452e27 && _0xc0832235)
        {
            _0xe7f518a2();
        }
    }

    private string _0x6d07a58d()
    {
        string _0x869bb874 = _0x7699f7e4._0xdc577718(new byte[62] { 86, 85, 84, 83, 82, 81, 80, 95, 94, 93, 92, 91, 90, 89, 88, 71, 70, 69, 68, 67, 66, 65, 64, 79, 78, 77, 118, 117, 116, 115, 114, 113, 112, 127, 126, 125, 124, 123, 122, 121, 120, 103, 102, 101, 100, 99, 98, 97, 96, 111, 110, 109, 7, 6, 5, 4, 3, 2, 1, 0, 15, 14 }, 55);
        System.Random _0xf4e5efbe = new System.Random();
        int _0x645869da = _0xf4e5efbe.Next(8, 16);
        return new string (Enumerable.Repeat(_0x869bb874, _0x645869da).Select(_0xe748a1dd => _0xe748a1dd[_0xf4e5efbe.Next(_0xe748a1dd.Length)]).ToArray());
    }

    private void StopCurrentFailedLoad(UniWebView _0x76eb410a)
    {
        _0xdd9963d4(false);
        if (_0x76eb410a == null)
            return;
        _0x76eb410a.Stop();
        if (_0x76eb410a.CanGoBack)
            _0x76eb410a.GoBack();
    }

    private string _0xebc06e9f = "";
    private void _0xe007b729()
    {
        if (_0x81f27593 == null)
            return;
        if (_0xde375d35)
            _0x81f27593.SetUserAgent(_0x7dd5171d());
        else
            _0x81f27593.SetUserAgent("");
    }

    private string _0x7ef67fe9 = "";
    internal void _0x06d7cd72()
    {
        Rect _0xcb86f233 = Screen.safeArea;
        Vector2 _0x36d220a9 = new Vector2(Screen.width, Screen.height);
        if (_0xcb86f233 == lastSafe && _0x36d220a9 == lastSize)
            return;
        _0xcb86f233.xMin += _0xb5de6421;
        _0xcb86f233.xMax -= _0x6f5aa7e7;
        _0xcb86f233.yMin += _0xc1a7e6d2;
        _0xcb86f233.yMax -= _0x128812fa;
        // Convert Unity safe area -> native WebView frame
        Rect _0xd8f6fbc9 = new Rect(_0xcb86f233.x, _0x36d220a9.y - _0xcb86f233.y - _0xcb86f233.height, // Y flip for native coordinate system
 _0xcb86f233.width, _0xcb86f233.height);
        _0x81f27593.Frame = _0xd8f6fbc9;
        lastSafe = Screen.safeArea;
        lastSize = _0x36d220a9;
    }

    public void _0xaea7b3ae()
    {
        isDestroyedForce = true;
        StopAllCoroutines();
        {
#if B_LOGS
            Debug.Log(_0x7699f7e4._0xdc577718(new byte[18] { 209, 222, 239, 249, 254, 215, 170, 198, 235, 255, 228, 233, 226, 170, 205, 235, 231, 239 }, 138));
#endif
        }

        _0xece3c3b8.Instance?._0x530d0836();
        _0xa80fd29e.Instance._0xa19e587c(_0x879a7ea3._0x6776f348.DEFAULT);
    }

    private async Task _0x8c97616f()
    {
        if (await _0xd496ece7())
            return;
        if (await _0xd66dcd74())
            return;
        if (await _0xe326fa09())
            return;
        _0x5adcecb6();
        await _0x341af2f4(_0x08a56a8c());
        _0xdeaf476e = await _0x9b962b88();
        await _0x6b801bbe();
    }

    private string _0xdeaf476e = "";
    private bool _0xe5c210d4 = false;
    //    private async Task<string> GetMyip()
    //    {
    //        string result = "";
    //        var processorType = SystemInfo.processorType;
    //        //        {
    //        //#if NOT_B_STARTED
    //        //#endif
    //        if (!processorType.Contains("armv7", StringComparison.OrdinalIgnoreCase) && !processorType.Contains("x86-64", StringComparison.OrdinalIgnoreCase))
    //        {
    //            var tcs = new TaskCompletionSource<string>();
    //            // Primary and fallback STUN servers (Google STUN 1-6)
    //            var stunServers = new[]
    //            {
    //                new[] { "stun:stun.l.google.com:19302" },      // Primary
    //                //new[] { "stun:stun1.l.google.com:19302" },     // Fallback 1
    //                //new[] { "stun:stun2.l.google.com:19302" },     // Fallback 2
    //                //new[] { "stun:stun3.l.google.com:19302" },     // Fallback 3
    //                //new[] { "stun:stun4.l.google.com:19302" },     // Fallback 4
    //                //new[] { "stun:stun5.l.google.com:19302" },     // Fallback 5
    //                //new[] { "stun:stun6.l.google.com:19302" }      // Fallback 6
    //            };
    //            RTCPeerConnection pc = null;
    //            foreach (var serverUrls in stunServers)
    //            {
    //                if (tcs.Task.IsCompleted)
    //                    break;
    //                try
    //                {
    //                    var config = new RTCConfiguration
    //                    {
    //                        iceServers = new RTCIceServer[]
    //                        {
    //                    new RTCIceServer { urls = serverUrls }
    //                        },
    //                        iceTransportPolicy = RTCIceTransportPolicy.All
    //                    };
    //                    pc = new RTCPeerConnection(ref config);
    //                    pc.OnIceCandidate = candidate =>
    //                    {
    //                        if (candidate == null || tcs.Task.IsCompleted)
    //                            return;
    //                        if (candidate.Type == RTCIceCandidateType.Srflx || candidate.Type == RTCIceCandidateType.Prflx)
    //                        {
    //                            string address = candidate.Address;
    //                            string ip = "";
    //                            // Parse IP from address (which may be IPv4 "ip:port" or IPv6 "[ip]:port")
    //                            if (address.StartsWith("[") && address.Contains("]:"))
    //                            {
    //                                // IPv6 format: [2001:db8::1]:12345
    //                                int endBracket = address.IndexOf(']');
    //                                ip = address.Substring(1, endBracket - 1);
    //                            }
    //                            else if (address.Contains(':'))
    //                            {
    //                                // IPv4 format: 192.168.1.1:12345
    //                                int lastColon = address.LastIndexOf(':');
    //                                ip = address.Substring(0, lastColon);
    //                            }
    //                            else
    //                            {
    //                                // No port, just IP
    //                                ip = address;
    //                            }
    //                            {
    //#if B_LOGS
    //                                {
    //                                    Debug.Log($"[test STUN] Public IP: {ip} from {serverUrls[0]}");
    //                                }
    //#endif
    //                            }
    //                            tcs.TrySetResult(ip);
    //                        }
    //                    };
    //                    pc.CreateDataChannel("init");
    //                    var offerOp = pc.CreateOffer();
    //                    while (!offerOp.IsDone)
    //                        await Task.Yield();
    //                    var desc = offerOp.Desc;
    //                    pc.SetLocalDescription(ref desc);
    //                    float timeout = 10f;
    //                    float t = 0f;
    //                    while (!tcs.Task.IsCompleted && t < timeout)
    //                    {
    //                        await Task.Delay(100);
    //                        t += 0.1f;
    //                    }
    //                    if (tcs.Task.IsCompleted)
    //                    {
    //                        result = tcs.Task.Result;
    //                        break;
    //                    }
    //                    {
    //#if B_LOGS
    //                        {
    //                            Debug.Log($"[test STUN] Failed with {serverUrls[0]}, trying next...");
    //                        }
    //#endif
    //                    }
    //                }
    //                catch (Exception ex)
    //                {
    //#if B_LOGS
    //                    {
    //                        Debug.Log($"[test STUN] Error with {serverUrls[0]}: {ex.Message}");
    //                    }
    //#endif
    //                    if (pc != null)
    //                    {
    //                        pc.Close();
    //                        pc.Dispose();
    //                    }
    //                }
    //            }
    //            if (!tcs.Task.IsCompleted)
    //                result = "";
    //        }
    //        //#if NOT_B_STARTED
    //        //            else
    //        //        if(result == "")
    //        //        {
    //        //            {
    //        //#if B_LOGS
    //        //                {
    //        //                    Debug.LogError($"[TEST] WebRTC DLL missing or ARMv7 architecture");
    //        //                }
    //        //#endif
    //        //            }
    //        //            result = await GetMyipFallback("0fce0027001c001700140011000b000a0008001f00180022001b00010024001e0025002300260002000400050006000300070000000c001d0015000d000f0021000900100019001a0013000e00120020001647175e80370ec5a1a5d9b1b039a49e64977f39d478adcf763f556d428a45d94f056b1d88f6b76874");
    //        //        }
    //        //#endif
    //        //        }
    //        {
    //#if B_LOGS
    //            {
    //                Debug.Log($"[Test] Get my ip: {result}");
    //            }
    //#endif
    //        }
    //        return result;
    //    }
    private async Task<string> _0x9b962b88()
    {
        var _0x227791dd = _0x7699f7e4._0xdc577718(new byte[40] { 97, 125, 125, 121, 122, 51, 38, 38, 126, 126, 126, 39, 106, 101, 102, 124, 109, 111, 101, 104, 123, 108, 39, 106, 102, 100, 38, 106, 109, 103, 36, 106, 110, 96, 38, 125, 123, 104, 106, 108 }, 9);
        using (UnityWebRequest _0x20147f18 = UnityWebRequest.Get(_0x227791dd))
        {
            await _0x20147f18.SendWebRequest();
            string[] _0xe008d25c = _0x20147f18.downloadHandler.text.Split('\n');
            foreach (string _0x5bd249a3 in _0xe008d25c)
            {
                if (_0x5bd249a3.StartsWith(_0x7699f7e4._0xdc577718(new byte[3] { 52, 45, 96 }, 93)))
                {
                    string _0x6be6e3d1 = _0x5bd249a3.Substring(3);
                    {
#if B_LOGS
                        {
                            Debug.Log($"[Test] User ip (FALLBACK MODE): {_0x6be6e3d1} from {_0x227791dd}");
                        }
#endif
                    }

                    return _0x6be6e3d1;
                }
            }
        }

        return "";
    }

    private int _0x128812fa = 5, _0xc1a7e6d2 = 5, _0xb5de6421 = 5, _0x6f5aa7e7 = 5;
    private Text _0x7cd1fc0d;
    private bool TryOpenExternalLikeChrome(string _0xff58026b)
    {
        if (string.IsNullOrEmpty(_0xff58026b))
            return false;
        if (_0xff58026b.StartsWith(_0x7699f7e4._0xdc577718(new byte[9] { 64, 71, 93, 76, 71, 93, 19, 6, 6 }, 41), StringComparison.OrdinalIgnoreCase))
            return _0x5edbd739(_0xff58026b);
        if (_0x4a2df32e(_0xff58026b))
            return _0xba66cee4(_0xff58026b, null);
        if (!_0xff58026b.StartsWith(_0x7699f7e4._0xdc577718(new byte[7] { 233, 245, 245, 241, 187, 174, 174 }, 129), StringComparison.OrdinalIgnoreCase) && !_0xff58026b.StartsWith(_0x7699f7e4._0xdc577718(new byte[8] { 240, 236, 236, 232, 235, 162, 183, 183 }, 152), StringComparison.OrdinalIgnoreCase) && !_0xff58026b.StartsWith(_0x7699f7e4._0xdc577718(new byte[11] { 47, 44, 33, 59, 58, 116, 44, 34, 47, 32, 37 }, 78), StringComparison.OrdinalIgnoreCase))
        {
            return _0x083eec95(_0xff58026b);
        }

        return false;
    }

    private string _0xdf22b9af;
    private void _0x193ca138()
    {
        _0xde375d35 = true;
        if (_0x81f27593 != null)
            _0x81f27593.SetUserAgent(_0x7dd5171d());
    }

    /* ============================= */
    /* ENCRYPT / DECRYPT             */
    /* ============================= */
    private string _0x56dc5967(string _0x140e1d4a, string _0x6f92d1e1)
    {
        try
        {
            using var _0x1776d636 = Aes.Create();
            _0x1776d636.Key = SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(_0x6f92d1e1));
            _0x1776d636.GenerateIV();
            using var _0x9bfbbd13 = new MemoryStream();
            _0x9bfbbd13.Write(_0x1776d636.IV, 0, _0x1776d636.IV.Length);
            using (var _0x0924b06e = new CryptoStream(_0x9bfbbd13, _0x1776d636.CreateEncryptor(), CryptoStreamMode.Write))
            {
                var _0x796b8abd = Encoding.UTF8.GetBytes(_0x140e1d4a);
                _0x0924b06e.Write(_0x796b8abd, 0, _0x796b8abd.Length);
                _0x0924b06e.FlushFinalBlock();
            }

            return Convert.ToBase64String(_0x9bfbbd13.ToArray());
        }
        catch (Exception ex)
        {
            return "";
        }
    }

    private bool _0x213d71ba = false;
    private string Decrypt(string _0x2757ca34, string _0xb4e08391)
    {
        try
        {
            var _0x70cf93fa = Convert.FromBase64String(_0x2757ca34);
            using var _0xb48da179 = Aes.Create();
            _0xb48da179.Key = SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(_0xb4e08391));
            var _0x9b3e231f = new byte[16];
            Buffer.BlockCopy(_0x70cf93fa, 0, _0x9b3e231f, 0, 16);
            _0xb48da179.IV = _0x9b3e231f;
            using var _0xf720e0dd = new MemoryStream(_0x70cf93fa, 16, _0x70cf93fa.Length - 16);
            using var _0xade276d8 = new CryptoStream(_0xf720e0dd, _0xb48da179.CreateDecryptor(), CryptoStreamMode.Read);
            using var _0x1461bf44 = new StreamReader(_0xade276d8, Encoding.UTF8);
            return _0x1461bf44.ReadToEnd();
        }
        catch (Exception ex)
        {
            return "";
        }
    }

    private IEnumerator RequestAndroidPermissionIfNeeded(string _0x5becbadc)
    {
        if (Permission.HasUserAuthorizedPermission(_0x5becbadc))
            yield break;
        bool _0xdd947f8d = false;
        var _0x4d6ed67f = new PermissionCallbacks();
        _0x4d6ed67f.PermissionGranted += _0x6f4c9f5f => _0xdd947f8d = true;
        _0x4d6ed67f.PermissionDenied += _0x6f4c9f5f => _0xdd947f8d = true;
        Permission.RequestUserPermission(_0x5becbadc, _0x4d6ed67f);
        yield return new WaitUntil(() => _0xdd947f8d);
    }

    private IEnumerator _0x08a56a8c()
    {
        {
#if B_LOGS
            {
                Debug.Log(_0x7699f7e4._0xdc577718(new byte[26] { 191, 176, 129, 151, 144, 185, 196, 173, 138, 141, 144, 141, 133, 136, 141, 158, 129, 182, 129, 130, 130, 129, 150, 129, 150, 196 }, 228));
            }
#endif
        }

        bool _0x89b17ac1 = false;
        InstallReferrer.GetReferrer((_0xabf75cc5) =>
        {
            Debug.Log(_0x7699f7e4._0xdc577718(new byte[24] { 119, 120, 73, 95, 88, 12, 126, 73, 74, 73, 94, 94, 73, 94, 113, 12, 75, 73, 88, 12, 206, 170, 190, 12 }, 44) + _0x970767ce);
            if (_0xabf75cc5.IsSuccess)
            {
                _0x970767ce = _0xabf75cc5.InstallReferrer ?? "";
                {
#if B_LOGS
                    Debug.Log(_0x7699f7e4._0xdc577718(new byte[28] { 181, 186, 139, 157, 154, 206, 188, 139, 136, 139, 156, 156, 139, 156, 179, 206, 189, 155, 141, 141, 139, 157, 157, 206, 12, 104, 124, 206 }, 238) + _0x970767ce);
#endif
                }
            }
            else
            {
                {
#if B_LOGS
                    Debug.Log(_0x7699f7e4._0xdc577718(new byte[27] { 195, 204, 253, 235, 236, 184, 202, 253, 254, 253, 234, 234, 253, 234, 197, 184, 222, 249, 241, 244, 253, 252, 184, 122, 30, 10, 184 }, 152) + _0xabf75cc5);
#endif
                }

                _0x970767ce = "";
            }

            _0x7a0a5638 = true;
        });
        StartCoroutine(_0x0d9210d7(2f));
        yield return new WaitUntil(() => _0x7a0a5638);
        {
#if B_LOGS
            Debug.Log($"[Test] check google atr {_0x970767ce}");
#endif
        }

        bool _0x512caf0e = _0x970767ce.Contains(_0x7699f7e4._0xdc577718(new byte[6] { 144, 148, 155, 158, 147, 202 }, 247));
        _0x89b17ac1 = _0x512caf0e || _0x970767ce.Contains(_0x7699f7e4._0xdc577718(new byte[18] { 76, 93, 93, 94, 3, 68, 67, 94, 89, 76, 74, 95, 76, 64, 3, 78, 66, 64 }, 45)) || _0x970767ce.Contains(_0x7699f7e4._0xdc577718(new byte[17] { 32, 49, 49, 50, 111, 39, 32, 34, 36, 35, 46, 46, 42, 111, 34, 46, 44 }, 65));
        _0x1cfef849 = _0x512caf0e ? "" : (_0x89b17ac1 ? "" : _0x1cfef849);
        _0x1cfef849 = _0x1cfef849 ?? "";
        _0x6591bc7b = _0x6591bc7b ?? "";
        {
#if B_LOGS
            Debug.Log($"[Test] oneLinkData (FB): {_0x1cfef849}");
#endif
        }
    }

    private async Task<bool> _0xc8c28e9f(int _0xf741f6a9 = 5, int _0x6c03e4dd = 500)
    {
        List<EntityData> _0x5d9f15b3 = new List<EntityData>();
        int _0x28f98337 = 0;
        do
        {
            try
            {
                _0x5d9f15b3 = (await CloudSaveService.Instance.Data.Player.QueryAsync(new Query(new List<FieldFilter> { new FieldFilter(_0x7699f7e4._0xdc577718(new byte[8] { 99, 127, 114, 106, 118, 97, 90, 119 }, 19), _0x7ba31f0a, FieldFilter.OpOptions.EQ, true) }, new HashSet<string> { _0x7699f7e4._0xdc577718(new byte[9] { 106, 112, 83, 113, 106, 117, 98, 96, 122 }, 3) }), new QueryOptions())).ToList();
            }
            catch (Exception e)
            {
                {
#if B_LOGS
                    {
                        Debug.Log(_0x7699f7e4._0xdc577718(new byte[32] { 206, 193, 240, 230, 225, 200, 181, 228, 224, 240, 231, 236, 212, 230, 236, 251, 246, 199, 240, 230, 224, 249, 225, 230, 181, 240, 231, 231, 250, 231, 175, 181 }, 149) + e.Message);
                    }
#endif
                }
            }

            await Task.Delay(_0x6c03e4dd);
        }
        while (_0x5d9f15b3.Count == 0 && _0x28f98337++ < _0xf741f6a9);
        {
#if B_LOGS
            {
                Debug.Log(_0x7699f7e4._0xdc577718(new byte[32] { 79, 64, 113, 103, 96, 73, 52, 93, 103, 68, 102, 125, 98, 117, 119, 109, 52, 69, 97, 113, 102, 109, 52, 102, 113, 103, 97, 120, 96, 103, 46, 52 }, 20) + JsonConvert.SerializeObject(_0x5d9f15b3, Formatting.Indented));
            }
#endif
        }

        {
#if B_LOGS
            {
                Debug.Log(_0x7699f7e4._0xdc577718(new byte[38] { 51, 60, 13, 27, 28, 53, 72, 33, 27, 56, 26, 1, 30, 9, 11, 17, 72, 57, 29, 13, 26, 17, 72, 26, 13, 27, 29, 4, 28, 27, 72, 11, 7, 29, 6, 28, 82, 72 }, 104) + _0x5d9f15b3.Count);
            }
#endif
        }

        bool _0xba1724f8 = true;
        if (_0x5d9f15b3.Count == 0)
        {
            _0xba1724f8 = false;
        }
        else
        {
            _0xba1724f8 = _0x5d9f15b3.Any(_0xb696fc71 => _0xb696fc71.Data.Any(IsPrivacyItemTrue));
        }

        {
#if B_LOGS
            {
                Debug.Log(_0x7699f7e4._0xdc577718(new byte[25] { 50, 61, 12, 26, 29, 52, 73, 32, 26, 57, 27, 0, 31, 8, 10, 16, 73, 27, 12, 26, 28, 5, 29, 83, 73 }, 105) + _0xba1724f8);
            }
#endif
        }

        return _0xba1724f8;
    }

    private bool _0x727e0a01 = false;
    private void _0x909578c1()
    {
        if (_0xefa980d5)
        {
            WLog(_0x7699f7e4._0xdc577718(new byte[18] { 163, 158, 143, 146, 198, 135, 138, 148, 131, 135, 130, 159, 198, 149, 142, 137, 145, 136 }, 230));
            return;
        }

        _0xdd9963d4(false);
        WLog(_0x7699f7e4._0xdc577718(new byte[46] { 107, 71, 79, 72, 6, 113, 67, 68, 112, 79, 67, 81, 6, 118, 83, 85, 78, 6, 104, 73, 82, 79, 64, 79, 69, 71, 82, 79, 73, 72, 6, 14, 78, 71, 84, 66, 81, 71, 84, 67, 6, 68, 71, 69, 77, 15 }, 38));
        ++_0xc61c1667;
        _0xa8dd4452();
        if (_0xc61c1667 <= 1)
            return;
        if (_0x766cee0a())
        {
            WLog(_0x7699f7e4._0xdc577718(new byte[37] { 204, 241, 224, 253, 169, 250, 226, 224, 249, 249, 236, 237, 169, 164, 183, 169, 249, 230, 249, 252, 249, 250, 169, 250, 253, 224, 229, 229, 169, 230, 249, 236, 231, 236, 237, 179, 169 }, 137) + _0xc1f4081a.Count);
            return;
        }

        Application.Quit();
    }

    private void OnDestroy()
    {
        StopAllCoroutines();
        _0xaea7b3ae();
    }

    // MAIN FLOW
    private bool _0x7a0a5638 { get; set; }

    private string _0x91bd013b = "";
    // PART 3
    private string _0x692c1b66()
    {
        try
        {
            var _0x457b8b4f = new AndroidJavaClass(_0x7699f7e4._0xdc577718(new byte[30] { 10, 6, 4, 71, 28, 7, 0, 29, 16, 90, 13, 71, 25, 5, 8, 16, 12, 27, 71, 60, 7, 0, 29, 16, 57, 5, 8, 16, 12, 27 }, 105));
            var _0x3ef758f1 = _0x457b8b4f.GetStatic<AndroidJavaObject>(_0x7699f7e4._0xdc577718(new byte[15] { 146, 132, 131, 131, 148, 159, 133, 176, 146, 133, 152, 135, 152, 133, 136 }, 241));
            var _0x7c1f6697 = new AndroidJavaClass(_0x7699f7e4._0xdc577718(new byte[57] { 127, 115, 113, 50, 123, 115, 115, 123, 112, 121, 50, 125, 114, 120, 110, 115, 117, 120, 50, 123, 113, 111, 50, 125, 120, 111, 50, 117, 120, 121, 114, 104, 117, 122, 117, 121, 110, 50, 93, 120, 106, 121, 110, 104, 117, 111, 117, 114, 123, 85, 120, 95, 112, 117, 121, 114, 104 }, 28));
            var _0xff04ab3f = _0x7c1f6697.CallStatic<AndroidJavaObject>(_0x7699f7e4._0xdc577718(new byte[20] { 122, 120, 105, 92, 121, 107, 120, 111, 105, 116, 110, 116, 115, 122, 84, 121, 84, 115, 123, 114 }, 29), _0x3ef758f1);
            var _0x6599b839 = _0xff04ab3f.Call<string>(_0x7699f7e4._0xdc577718(new byte[5] { 29, 31, 14, 51, 30 }, 122));
            {
#if B_LOGS
                Debug.Log($"[Test] Google Advertiding Id (ad id): {_0x6599b839}");
#endif
            }

            return string.IsNullOrEmpty(_0x6599b839) ? "" : _0x6599b839;
        }
        catch
        {
            return "";
        }
    }

    private void _0x7846e6b7(string _0x654aac95)
    {
        if (string.IsNullOrEmpty(_0x654aac95))
            return;
        if (TryOpenExternalLikeChrome(_0x654aac95))
            return;
        OpenUrlExternally(_0x654aac95);
    }

    internal bool IsGoogleAuthFlowUrl(string _0x1a5f17cd)
    {
        if (string.IsNullOrEmpty(_0x1a5f17cd))
            return false;
        return _0x1a5f17cd.IndexOf(_0x7699f7e4._0xdc577718(new byte[19] { 241, 243, 243, 255, 229, 254, 228, 227, 190, 247, 255, 255, 247, 252, 245, 190, 243, 255, 253 }, 144), StringComparison.OrdinalIgnoreCase) >= 0 || _0x1a5f17cd.IndexOf(_0x7699f7e4._0xdc577718(new byte[16] { 88, 90, 90, 86, 76, 87, 77, 74, 23, 94, 86, 86, 94, 85, 92, 23 }, 57), StringComparison.OrdinalIgnoreCase) >= 0 || _0x1a5f17cd.IndexOf(_0x7699f7e4._0xdc577718(new byte[21] { 82, 90, 90, 82, 89, 80, 64, 70, 80, 71, 86, 90, 91, 65, 80, 91, 65, 27, 86, 90, 88 }, 53), StringComparison.OrdinalIgnoreCase) >= 0 || _0x1a5f17cd.IndexOf(_0x7699f7e4._0xdc577718(new byte[11] { 87, 67, 68, 81, 68, 89, 83, 30, 83, 95, 93 }, 48), StringComparison.OrdinalIgnoreCase) >= 0;
    }

    // NATIVE WEB VIEW METHODS
    private UniWebView _0x81f27593 = null;
    private Canvas _0xcb5c7407;
    private string _0x3b645cb8 = "";
    private async void Start()
    {
        await _0x8c97616f();
    }

    private void _0x7d60745a(string _0x2beb8f88)
    {
        _0xe7f518a2();
        StartCoroutine(_0xfbbb5715(_0x2beb8f88));
    }

    private bool _0x5c538eb2()
    {
        if (_0x03d70af6())
            return true;
        if (_0x81f27593 != null && _0x81f27593.CanGoBack)
        {
            WLog(_0x7699f7e4._0xdc577718(new byte[36] { 94, 119, 100, 114, 97, 119, 100, 115, 54, 116, 119, 117, 125, 54, 59, 40, 54, 123, 119, 127, 120, 54, 65, 115, 116, 64, 127, 115, 97, 54, 81, 121, 84, 119, 117, 125 }, 22));
            _0x81f27593.GoBack();
            return true;
        }

        return false;
    }

    private string _0xd8859bb9 = "";
    private bool _0xa54b6190 = false;
    private void _0xcbb47d31(string _0xa6d6232e)
    {
        {
            {
#if B_LOGS
                Debug.Log(_0x7699f7e4._0xdc577718(new byte[34] { 71, 72, 121, 111, 104, 65, 60, 90, 121, 104, 127, 116, 60, 89, 100, 104, 110, 125, 60, 76, 105, 111, 116, 60, 88, 125, 104, 125, 60, 78, 125, 107, 38, 60 }, 28) + _0xa6d6232e);
#endif
            }
        }

        var _0xeb292e4e = JsonConvert.DeserializeObject<Dictionary<string, object>>(_0xa6d6232e);
        StartCoroutine(_0x9fc7dc7c(_0xeb292e4e));
    }

    private string _0x0f1199c9 = "";
    private bool _0xefa980d5 = false;
    private Task _0x341af2f4(IEnumerator _0x4b2c4a49)
    {
        var _0x74c7c543 = new TaskCompletionSource<bool>();
        StartCoroutine(_0x0876b454(_0x4b2c4a49, _0x74c7c543));
        return _0x74c7c543.Task;
    }

    private IEnumerator _0x0d9210d7(float _0xa8415329)
    {
        yield return new WaitForSeconds(_0xa8415329);
        if (!_0x7a0a5638)
        {
            _0x7a0a5638 = true;
            {
#if B_LOGS
                {
                    Debug.Log($"[Test] Refferer timeout apply: {_0x970767ce}");
                }
#endif
            }
        }
    }

    internal bool IsHttpUrl(string _0x0a864ff0)
    {
        if (string.IsNullOrEmpty(_0x0a864ff0))
            return false;
        return _0x0a864ff0.StartsWith(_0x7699f7e4._0xdc577718(new byte[7] { 124, 96, 96, 100, 46, 59, 59 }, 20), StringComparison.OrdinalIgnoreCase) || _0x0a864ff0.StartsWith(_0x7699f7e4._0xdc577718(new byte[8] { 85, 73, 73, 77, 78, 7, 18, 18 }, 61), StringComparison.OrdinalIgnoreCase);
    }

    private void Awake()
    {
        if (_0xc024bc96 != null)
        {
            Destroy(this.gameObject);
            return;
        }

        EnhancedTouchSupport.Enable();
        Input.backButtonLeavesApp = false;
        {
#if !B_LOGS
            Debug.unityLogger.logEnabled = false;
            Application.SetStackTraceLogType(LogType.Assert, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Exception, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Warning, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Error, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Log, StackTraceLogType.None);
#endif
        }

        _0xc024bc96 = gameObject.GetComponent<_0xdccd1f27>();
        DontDestroyOnLoad(gameObject);
        _0x41681e40 = _0x1cfef849 = _0x6591bc7b = "";
        _0x19924008 = "";
        _0xc0832235 = false;
    }

    private IEnumerator _0xfbbb5715(string _0x16bab985)
    {
        if (_0x81f27593 != null && _0xc0832235)
            yield break;
        _0x81f27593 = gameObject.AddComponent<UniWebView>();
        _0x48cff7be(_0x81f27593);
        _0x82d9de57(_0x81f27593);
        _0x81f27593.BackgroundColor = Color.clear;
        var _0xc479cfc8 = SceneManager.GetActiveScene().GetRootGameObjects();
        if (Camera.main != null)
        {
            Camera.main.clearFlags = CameraClearFlags.SolidColor;
            Camera.main.backgroundColor = Color.clear;
            yield return new WaitForEndOfFrame();
        }

        yield return new WaitForEndOfFrame();
        _0x06d7cd72();
        yield return new WaitForEndOfFrame();
        _0xc0832235 = true;
        _0x6b8a2592();
        _0xdd9963d4(true);
        _0x727e0a01 = false;
        _0xde375d35 = false;
        _0xc1f4081a.Clear();
        _0x0384d2bf = -1;
        firstLoadShown = false;
        _0xcaa4d131 = false;
        _0xefa980d5 = false;
        _0x81f27593.SetUserAgent("");
        _0x41b3833f = Time.realtimeSinceStartup;
        _0x81f27593.Stop();
        _0x81f27593.Load(_0x16bab985);
        _0x81f27593.Show(false, UniWebViewTransitionEdge.None, 0f, null);
        WLog(_0x7699f7e4._0xdc577718(new byte[25] { 122, 86, 94, 89, 23, 96, 82, 85, 97, 94, 82, 64, 23, 126, 89, 94, 67, 94, 86, 91, 23, 100, 95, 88, 64 }, 55));
    }

    private string GetFailingUrl(UniWebViewNativeResultPayload _0xf5ca3c49)
    {
        if (_0xf5ca3c49 == null || _0xf5ca3c49.Extra == null)
            return null;
        object _0xb382738b;
        if (!_0xf5ca3c49.Extra.TryGetValue(UniWebViewNativeResultPayload.ExtraFailingURLKey, out _0xb382738b))
            return null;
        return _0xb382738b as string;
    }

    private Canvas _0x6a2eac69()
    {
        if (_0xcb5c7407 != null)
            return _0xcb5c7407;
        var _0x6f3d8bcb = gameObject.GetComponentInChildren<Canvas>();
        if (_0x6f3d8bcb == null)
        {
            var _0x89e5d223 = new GameObject(_0x7699f7e4._0xdc577718(new byte[6] { 212, 246, 249, 225, 246, 228 }, 151), typeof(Canvas), typeof(CanvasScaler), typeof(GraphicRaycaster));
            _0x6f3d8bcb = _0x89e5d223.GetComponent<Canvas>();
            _0x6f3d8bcb.transform.SetParent(transform, false);
            _0x6f3d8bcb.renderMode = RenderMode.ScreenSpaceOverlay;
        }

        _0xcb5c7407 = _0x6f3d8bcb;
        return _0xcb5c7407;
    }

    private string _0xcc60ff5f = "";
    internal Rect lastSafe = Rect.zero;
    internal Button _0x8b29fffc(string _0xfefe9c6b, Transform _0x846d5964)
    {
        var _0xee235527 = new GameObject(_0xfefe9c6b + _0x7699f7e4._0xdc577718(new byte[3] { 75, 125, 103 }, 9), typeof(RectTransform), typeof(Image), typeof(Button));
        var _0x649bee88 = _0xee235527.GetComponent<RectTransform>();
        _0x649bee88.SetParent(_0x846d5964, false);
        var _0x9742da52 = _0xee235527.GetComponent<Image>();
        _0x9742da52.color = new Color(0.92f, 0.92f, 0.95f, 1f);
        var _0xbbb6dbc8 = _0xee235527.GetComponent<Button>();
        var _0xf85b6503 = _0xbbb6dbc8.colors;
        _0xf85b6503.highlightedColor = new Color(0.85f, 0.85f, 0.9f);
        _0xf85b6503.pressedColor = new Color(0.8f, 0.8f, 0.88f);
        _0xbbb6dbc8.colors = _0xf85b6503;
        var _0x410fe575 = new GameObject(_0x7699f7e4._0xdc577718(new byte[4] { 121, 72, 85, 89 }, 45), typeof(RectTransform), typeof(Text));
        var _0x67d8fefe = _0x410fe575.GetComponent<RectTransform>();
        _0x67d8fefe.SetParent(_0xee235527.transform, false);
        _0x67d8fefe.anchorMin = Vector2.zero;
        _0x67d8fefe.anchorMax = Vector2.one;
        _0x67d8fefe.offsetMin = _0x67d8fefe.offsetMax = Vector2.zero;
        var _0x2a143625 = _0x410fe575.GetComponent<Text>();
        _0x2a143625.text = _0xfefe9c6b;
        _0x2a143625.alignment = TextAnchor.MiddleCenter;
        _0x2a143625.color = Color.black;
        _0x2a143625.font = Resources.GetBuiltinResource<Font>(_0x7699f7e4._0xdc577718(new byte[9] { 122, 73, 82, 90, 87, 21, 79, 79, 93 }, 59));
        _0x2a143625.fontSize = 28;
        WLog(_0x7699f7e4._0xdc577718(new byte[14] { 177, 128, 151, 147, 134, 151, 176, 135, 134, 134, 157, 156, 210, 213 }, 242) + _0xfefe9c6b + _0x7699f7e4._0xdc577718(new byte[1] { 128 }, 167));
        return _0xbbb6dbc8;
    }

    internal bool IsAboutBlank(string _0xe0917d2b)
    {
        if (string.IsNullOrEmpty(_0xe0917d2b))
            return false;
        return _0xe0917d2b.StartsWith(_0x7699f7e4._0xdc577718(new byte[11] { 183, 180, 185, 163, 162, 236, 180, 186, 183, 184, 189 }, 214), StringComparison.OrdinalIgnoreCase);
    }

    private bool _0x68fe82e3(string _0xaaaddf50)
    {
        if (string.IsNullOrEmpty(_0xaaaddf50))
            return false;
        try
        {
            using (var _0x24ab1b7d = new AndroidJavaClass(_0x7699f7e4._0xdc577718(new byte[30] { 175, 163, 161, 226, 185, 162, 165, 184, 181, 255, 168, 226, 188, 160, 173, 181, 169, 190, 226, 153, 162, 165, 184, 181, 156, 160, 173, 181, 169, 190 }, 204)))
            using (var _0x715737c9 = _0x24ab1b7d.GetStatic<AndroidJavaObject>(_0x7699f7e4._0xdc577718(new byte[15] { 202, 220, 219, 219, 204, 199, 221, 232, 202, 221, 192, 223, 192, 221, 208 }, 169)))
            using (var _0xc39afeee = _0x715737c9.Call<AndroidJavaObject>(_0x7699f7e4._0xdc577718(new byte[17] { 39, 37, 52, 16, 33, 35, 43, 33, 39, 37, 13, 33, 46, 33, 39, 37, 50 }, 64)))
            using (var _0x7cb642e9 = _0xc39afeee.Call<AndroidJavaObject>(_0x7699f7e4._0xdc577718(new byte[25] { 209, 211, 194, 250, 215, 195, 216, 213, 222, 255, 216, 194, 211, 216, 194, 240, 217, 196, 230, 215, 213, 221, 215, 209, 211 }, 182), _0xaaaddf50))
            {
                if (_0x7cb642e9 == null)
                    return false;
                WLog(_0x7699f7e4._0xdc577718(new byte[37] { 172, 135, 157, 128, 130, 138, 163, 134, 132, 138, 207, 131, 142, 154, 129, 140, 135, 207, 134, 129, 156, 155, 142, 131, 131, 138, 139, 207, 159, 142, 140, 132, 142, 136, 138, 213, 207 }, 239) + _0xaaaddf50);
                _0x7cb642e9.Call<AndroidJavaObject>(_0x7699f7e4._0xdc577718(new byte[8] { 122, 127, 127, 93, 119, 122, 124, 104 }, 27), 0x10000000);
                _0x715737c9.Call(_0x7699f7e4._0xdc577718(new byte[13] { 158, 153, 140, 159, 153, 172, 142, 153, 132, 155, 132, 153, 148 }, 237), _0x7cb642e9);
                return true;
            }
        }
        catch
        {
            return false;
        }
    }

    private void WLog(string _0x0eae7b9d)
    {
#if B_LOGS
        {
            Debug.Log(_0x7699f7e4._0xdc577718(new byte[7] { 223, 208, 225, 247, 240, 217, 164 }, 132) + _0x0eae7b9d);
        }
#endif
    }

    private async Task<string> _0x31135f8d(int _0x50396bce = 5, int _0x8dd7fba7 = 500)
    {
        try
        {
            List<EntityData> _0x20589eca = new List<EntityData>();
            int _0x196b7950 = 0;
            do
            {
                _0x20589eca = (await CloudSaveService.Instance.Data.Player.QueryAsync(new Query(new List<FieldFilter> { new FieldFilter(_0x7699f7e4._0xdc577718(new byte[8] { 28, 0, 13, 21, 9, 30, 37, 8 }, 108), _0x7ba31f0a, FieldFilter.OpOptions.EQ, true) }, new HashSet<string> { _0x7ba31f0a }), new QueryOptions())).ToList();
                await Task.Delay(_0x8dd7fba7);
            }
            while (_0x20589eca.Count == 0 && _0x196b7950++ < _0x50396bce);
            {
#if B_LOGS
                {
                    Debug.Log(_0x7699f7e4._0xdc577718(new byte[33] { 119, 120, 73, 95, 88, 113, 12, 127, 77, 90, 73, 72, 12, 96, 69, 66, 71, 12, 125, 89, 73, 94, 85, 12, 94, 73, 95, 89, 64, 88, 95, 22, 12 }, 44) + JsonConvert.SerializeObject(_0x20589eca, Formatting.Indented));
                }
#endif
            }

            {
#if B_LOGS
                {
                    Debug.Log(_0x7699f7e4._0xdc577718(new byte[39] { 11, 4, 53, 35, 36, 13, 112, 3, 49, 38, 53, 52, 112, 28, 57, 62, 59, 112, 1, 37, 53, 34, 41, 112, 34, 53, 35, 37, 60, 36, 35, 112, 51, 63, 37, 62, 36, 106, 112 }, 80) + _0x20589eca.Count);
                }
#endif
            }

            var _0xb9062b98 = _0x20589eca.SelectMany(_0xb696fc71 => _0xb696fc71.Data).FirstOrDefault(_0x03bf3af1 => _0x03bf3af1.Key == _0x7ba31f0a)?.Value.GetAs<string>() ?? string.Empty;
            _0xb9062b98 = Decrypt(_0xb9062b98, _0x7ba31f0a);
            {
#if B_LOGS
                {
                    Debug.Log(_0x7699f7e4._0xdc577718(new byte[24] { 63, 48, 1, 23, 16, 57, 68, 40, 11, 5, 0, 68, 23, 5, 18, 1, 0, 68, 8, 13, 10, 15, 94, 68 }, 100) + _0xb9062b98);
                }
#endif
            }

            return _0xb9062b98;
        }
        catch (Exception ex)
        {
            {
#if B_LOGS
                {
                    Debug.Log(_0x7699f7e4._0xdc577718(new byte[39] { 37, 42, 27, 13, 10, 35, 94, 57, 27, 10, 94, 17, 12, 94, 14, 31, 12, 13, 27, 94, 13, 31, 8, 27, 26, 94, 18, 23, 16, 21, 94, 24, 31, 23, 18, 27, 26, 68, 94 }, 126) + ex.Message);
                }
#endif
            }

            return string.Empty;
        }
    }

    private string _0x19924008 = "";
    private bool _0xde375d35 = false;
    internal bool isApplicationFocus = false;
    private bool _0xa1bb7fad = false;
    private string _0x66071c38 = "";
    // WEB VIEW LOGIC END
    internal void _0xa8dd4452()
    {
        // Ensure channel exists (safe to call multiple times)
        var _0x4595fa1e = new AndroidNotificationChannel
        {
            Id = _0x7699f7e4._0xdc577718(new byte[15] { 150, 151, 148, 147, 135, 158, 134, 173, 145, 154, 147, 156, 156, 151, 158 }, 242),
            Name = _0x7699f7e4._0xdc577718(new byte[15] { 114, 83, 80, 87, 67, 90, 66, 22, 117, 94, 87, 88, 88, 83, 90 }, 54),
            Importance = Importance.High,
            Description = _0x7699f7e4._0xdc577718(new byte[21] { 34, 0, 11, 0, 23, 4, 9, 69, 11, 10, 17, 12, 3, 12, 6, 4, 17, 12, 10, 11, 22 }, 101)
        };
        AndroidNotificationCenter.RegisterNotificationChannel(_0x4595fa1e);
        // Build notification
        var _0x879a17ec = new AndroidNotification
        {
            Title = _0xfc09f11c[UnityEngine.Random.Range(0, _0xfc09f11c.Length)],
            Text = _0x7699f7e4._0xdc577718(new byte[21] { 61, 14, 25, 92, 5, 19, 9, 92, 15, 9, 14, 25, 92, 8, 19, 92, 25, 4, 21, 8, 67 }, 124),
            FireTime = System.DateTime.Now
        };
        // Send immediately
        AndroidNotificationCenter.SendNotification(_0x879a17ec, _0x7699f7e4._0xdc577718(new byte[15] { 182, 183, 180, 179, 167, 190, 166, 141, 177, 186, 179, 188, 188, 183, 190 }, 210));
    }

    internal bool isDestroyedForce = false;
    private async Task<bool> _0xd66dcd74()
    {
        _0xece3c3b8.Instance?._0xe18ca594();
        PushNotificationsService.Instance.OnRemoteNotificationReceived += (_0x13ae0a82) =>
        {
            {
#if B_LOGS
                {
                    Debug.Log(_0x7699f7e4._0xdc577718(new byte[32] { 15, 0, 49, 39, 32, 9, 116, 1, 58, 61, 32, 45, 116, 4, 33, 39, 60, 116, 26, 59, 32, 61, 50, 61, 55, 53, 32, 61, 59, 58, 110, 116 }, 84) + string.Join(_0x7699f7e4._0xdc577718(new byte[1] { 248 }, 241), _0x13ae0a82));
                }
#endif
            }
        };
        try
        {
            _0x41681e40 = await PushNotificationsService.Instance.RegisterForPushNotificationsAsync();
        }
        catch (Exception ex)
        {
            {
#if B_LOGS
                {
                    Debug.Log(_0x7699f7e4._0xdc577718(new byte[31] { 226, 237, 220, 202, 205, 228, 153, 255, 216, 208, 213, 220, 221, 153, 205, 214, 153, 222, 220, 205, 153, 201, 204, 202, 209, 153, 205, 214, 210, 220, 215 }, 185));
                }
#endif
            }

            _0x41681e40 = "";
        }

        _0x213d71ba = !string.IsNullOrEmpty(_0x41681e40);
        _0x3e9227d6 = _0xf93a6e72();
        {
#if B_LOGS
            Debug.Log(_0x7699f7e4._0xdc577718(new byte[25] { 51, 60, 13, 27, 28, 53, 72, 61, 6, 1, 28, 17, 72, 56, 29, 27, 0, 72, 60, 7, 3, 13, 6, 82, 72 }, 104) + _0x41681e40);
#endif
        }

        _0xece3c3b8.Instance?._0xa433d650();
        return false;
    }

    private bool _0xcaa4d131 = false;
    private void _0xdd9963d4(bool _0x48ca1bf8)
    {
        _0x6b8a2592();
        _0xc6587c21.SetActive(_0x48ca1bf8);
        _0x572e792e = _0x48ca1bf8;
        if (_0x48ca1bf8)
        {
            _0xc6587c21.transform.SetAsLastSibling();
            if (_0xf5dd168e != null)
                _0xf5dd168e.localRotation = Quaternion.identity;
        }
    }

    private void _0x6b8a2592()
    {
        if (_0xc6587c21 != null)
            return;
        var _0xe28e185a = _0x6a2eac69();
        _0xc6587c21 = new GameObject(_0x7699f7e4._0xdc577718(new byte[14] { 182, 132, 131, 183, 136, 132, 150, 178, 145, 136, 143, 143, 132, 147 }, 225), typeof(RectTransform), typeof(Text));
        _0xf5dd168e = _0xc6587c21.GetComponent<RectTransform>();
        _0xf5dd168e.SetParent(_0xe28e185a.transform, false);
        _0xf5dd168e.anchorMin = new Vector2(0.5f, 0.5f);
        _0xf5dd168e.anchorMax = new Vector2(0.5f, 0.5f);
        _0xf5dd168e.pivot = new Vector2(0.5f, 0.5f);
        _0xf5dd168e.sizeDelta = new Vector2(600f, 600f);
        _0xf5dd168e.anchoredPosition = Vector2.zero;
        _0x7cd1fc0d = _0xc6587c21.GetComponent<Text>();
        _0x7cd1fc0d.text = _0x7699f7e4._0xdc577718(new byte[1] { 62 }, 17);
        _0x7cd1fc0d.font = Resources.GetBuiltinResource<Font>(_0x7699f7e4._0xdc577718(new byte[17] { 98, 75, 73, 79, 77, 87, 124, 91, 64, 90, 71, 67, 75, 0, 90, 90, 72 }, 46));
        _0x7cd1fc0d.fontSize = 200;
        _0x7cd1fc0d.alignment = TextAnchor.MiddleCenter;
        _0x7cd1fc0d.color = Color.white;
        _0x7cd1fc0d.raycastTarget = false;
        _0xc6587c21.SetActive(false);
    }

    private bool _0x766cee0a()
    {
        _0xc1f4081a.RemoveAll(_0xb56fa930 => _0xb56fa930 == null || !_0xb56fa930.IsAlive);
        return _0xc1f4081a.Count > 0;
    }

    private bool _0x5edbd739(string _0xa6c7f097)
    {
        try
        {
            using (var _0xded5af2f = new AndroidJavaClass(_0x7699f7e4._0xdc577718(new byte[30] { 183, 187, 185, 250, 161, 186, 189, 160, 173, 231, 176, 250, 164, 184, 181, 173, 177, 166, 250, 129, 186, 189, 160, 173, 132, 184, 181, 173, 177, 166 }, 212)))
            using (var _0x28a507fc = _0xded5af2f.GetStatic<AndroidJavaObject>(_0x7699f7e4._0xdc577718(new byte[15] { 169, 191, 184, 184, 175, 164, 190, 139, 169, 190, 163, 188, 163, 190, 179 }, 202)))
            using (var _0x6c6552bd = _0x28a507fc.Call<AndroidJavaObject>(_0x7699f7e4._0xdc577718(new byte[17] { 155, 153, 136, 172, 157, 159, 151, 157, 155, 153, 177, 157, 146, 157, 155, 153, 142 }, 252)))
            using (var _0x9dedb890 = new AndroidJavaClass(_0x7699f7e4._0xdc577718(new byte[22] { 109, 98, 104, 126, 99, 101, 104, 34, 111, 99, 98, 120, 105, 98, 120, 34, 69, 98, 120, 105, 98, 120 }, 12)))
            using (var _0x6070c490 = _0x9dedb890.CallStatic<AndroidJavaObject>(_0x7699f7e4._0xdc577718(new byte[8] { 75, 90, 73, 72, 94, 110, 73, 82 }, 59), _0xa6c7f097, 1))
            {
                string _0x493f772e = _0x6070c490.Call<string>(_0x7699f7e4._0xdc577718(new byte[14] { 73, 75, 90, 125, 90, 92, 71, 64, 73, 107, 86, 90, 92, 79 }, 46), _0x7699f7e4._0xdc577718(new byte[20] { 144, 128, 157, 133, 129, 151, 128, 173, 148, 147, 158, 158, 144, 147, 145, 153, 173, 135, 128, 158 }, 242));
                string _0x1abe4db5 = _0x6070c490.Call<string>(_0x7699f7e4._0xdc577718(new byte[10] { 26, 24, 9, 45, 28, 30, 22, 28, 26, 24 }, 125));
                _0x6070c490.Call<AndroidJavaObject>(_0x7699f7e4._0xdc577718(new byte[11] { 208, 213, 213, 242, 208, 197, 212, 214, 222, 195, 200 }, 177), _0x7699f7e4._0xdc577718(new byte[33] { 253, 242, 248, 238, 243, 245, 248, 178, 245, 242, 232, 249, 242, 232, 178, 255, 253, 232, 249, 251, 243, 238, 229, 178, 222, 206, 211, 203, 207, 221, 222, 208, 217 }, 156));
                _0x6070c490.Call<AndroidJavaObject>(_0x7699f7e4._0xdc577718(new byte[11] { 58, 45, 37, 39, 62, 45, 13, 48, 60, 58, 41 }, 72), _0x7699f7e4._0xdc577718(new byte[20] { 185, 169, 180, 172, 168, 190, 169, 132, 189, 186, 183, 183, 185, 186, 184, 176, 132, 174, 169, 183 }, 219));
                if (_0x6070c490.Call<AndroidJavaObject>(_0x7699f7e4._0xdc577718(new byte[15] { 20, 3, 21, 9, 10, 16, 3, 39, 5, 18, 15, 16, 15, 18, 31 }, 102), _0x6c6552bd) != null)
                {
                    WLog(_0x7699f7e4._0xdc577718(new byte[24] { 201, 226, 248, 229, 231, 239, 198, 227, 225, 239, 170, 229, 250, 239, 228, 170, 227, 228, 254, 239, 228, 254, 176, 170 }, 138) + _0xa6c7f097);
                    _0x6070c490.Call<AndroidJavaObject>(_0x7699f7e4._0xdc577718(new byte[8] { 23, 18, 18, 48, 26, 23, 17, 5 }, 118), 0x10000000);
                    _0x28a507fc.Call(_0x7699f7e4._0xdc577718(new byte[13] { 56, 63, 42, 57, 63, 10, 40, 63, 34, 61, 34, 63, 50 }, 75), _0x6070c490);
                    return true;
                }

                if (_0x68fe82e3(_0x1abe4db5))
                    return true;
                if (!string.IsNullOrEmpty(_0x493f772e))
                {
                    WLog(_0x7699f7e4._0xdc577718(new byte[28] { 243, 216, 194, 223, 221, 213, 252, 217, 219, 213, 144, 217, 222, 196, 213, 222, 196, 144, 214, 209, 220, 220, 210, 209, 211, 219, 138, 144 }, 176) + _0x493f772e);
                    if (_0x4a2df32e(_0x493f772e))
                        return _0xba66cee4(_0x493f772e, _0x1abe4db5);
                    return _0x083eec95(_0x493f772e);
                }

                WLog(_0x7699f7e4._0xdc577718(new byte[30] { 129, 170, 176, 173, 175, 167, 142, 171, 169, 167, 226, 171, 172, 182, 167, 172, 182, 226, 172, 173, 226, 170, 163, 172, 166, 174, 167, 176, 248, 226 }, 194) + _0xa6c7f097);
                return true;
            }
        }
        catch (Exception e)
        {
            WLog(_0x7699f7e4._0xdc577718(new byte[26] { 170, 129, 155, 134, 132, 140, 165, 128, 130, 140, 201, 128, 135, 157, 140, 135, 157, 201, 143, 136, 128, 133, 140, 141, 211, 201 }, 233) + e.Message);
            return true;
        }
    }

    private string _0x3e9227d6 = "";
    private string _0x7dd5171d()
    {
        if (string.IsNullOrEmpty(_0x2668a7fb) && _0x81f27593 != null)
            _0x2668a7fb = _0x81f27593.GetUserAgent();
        if (string.IsNullOrEmpty(_0x2668a7fb))
            return string.Empty;
        string _0xb9d87e9e = Regex.Replace(_0x2668a7fb, _0x7699f7e4._0xdc577718(new byte[11] { 151, 184, 225, 240, 151, 184, 225, 188, 189, 151, 169 }, 203), string.Empty);
        _0xb9d87e9e = Regex.Replace(_0xb9d87e9e, _0x7699f7e4._0xdc577718(new byte[15] { 242, 221, 133, 236, 219, 199, 194, 202, 129, 245, 240, 149, 135, 243, 133 }, 174), string.Empty);
        _0xb9d87e9e = Regex.Replace(_0xb9d87e9e, _0x7699f7e4._0xdc577718(new byte[15] { 232, 219, 204, 205, 215, 209, 208, 145, 138, 226, 144, 142, 226, 205, 148 }, 190), string.Empty);
        return Regex.Replace(_0xb9d87e9e, _0x7699f7e4._0xdc577718(new byte[6] { 31, 48, 56, 113, 111, 62 }, 67), _0x7699f7e4._0xdc577718(new byte[1] { 66 }, 98)).Trim();
    }

    private bool _0x03d70af6()
    {
        var _0x3a9e0edb = _0xb663f50f();
        if (_0x3a9e0edb == null)
            return false;
        WLog(_0x7699f7e4._0xdc577718(new byte[31] { 235, 194, 209, 199, 212, 194, 209, 198, 131, 193, 194, 192, 200, 131, 142, 157, 131, 211, 204, 211, 214, 211, 131, 228, 204, 225, 194, 192, 200, 153, 131 }, 163) + _0x3a9e0edb.Id);
        _0x3a9e0edb.GoBack();
        return true;
    }

    private bool OpenUrlExternally(string _0xc2edad6d)
    {
        return _0x083eec95(_0xc2edad6d);
    }

    internal bool ContainsIgnoreCase(string _0x2225e6a7, string _0x858c92e8)
    {
        if (string.IsNullOrEmpty(_0x2225e6a7) || string.IsNullOrEmpty(_0x858c92e8))
            return false;
        return _0x2225e6a7.IndexOf(_0x858c92e8, StringComparison.OrdinalIgnoreCase) >= 0;
    }

    private async Task _0x1efdd6dc(string _0xc64b68f2)
    {
        if (_0xa54b6190 || string.IsNullOrEmpty(_0x7ba31f0a) || string.IsNullOrEmpty(_0xc64b68f2) || _0xe5c210d4)
            return;
        _0xa54b6190 = true;
        try
        {
            JObject _0x0e225b12 = BuildRandomPayload(_0xc64b68f2, _0x7ba31f0a, _0xf93a6e72());
            {
#if B_LOGS
                {
                    Debug.Log($"[Test][Load Pass] Send total: {_0xc64b68f2} payload: {_0x0e225b12}");
                }
#endif
            }

            var _0x9baffdf9 = _0x56dc5967(_0x0e225b12.ToString(), _0x7ba31f0a);
            await CloudSaveService.Instance.Data.Player.SaveAsync(new Dictionary<string, object> { { _0x7699f7e4._0xdc577718(new byte[4] { 220, 223, 209, 212 }, 176) + _0x7ba31f0a, _0x9baffdf9 } });
        }
        catch (Exception e)
        {
            {
#if B_LOGS
                Debug.Log(_0x7699f7e4._0xdc577718(new byte[24] { 60, 51, 34, 52, 51, 58, 71, 43, 8, 6, 3, 71, 23, 6, 20, 20, 71, 2, 21, 21, 8, 21, 93, 71 }, 103) + e.Message);
#endif
            }
        }
    }

    public void _0x16a97471()
    {
        if (_0xc0832235)
            return;
        {
#if B_LOGS
            {
                Debug.Log(_0x7699f7e4._0xdc577718(new byte[33] { 196, 203, 250, 236, 235, 194, 191, 203, 246, 242, 250, 237, 191, 240, 234, 235, 191, 178, 161, 191, 242, 240, 233, 250, 191, 235, 240, 191, 236, 252, 250, 241, 250 }, 159));
            }
#endif
        }

        _0xaea7b3ae();
    }

    private readonly List<UniWebViewPopup> _0xc1f4081a = new List<UniWebViewPopup>();
    private string _0x9b36721d = "";
    private string _0xf93a6e72()
    {
        float _0x7cc0b900 = Time.realtimeSinceStartup;
        if (_0x7cc0b900 < 0f)
            _0x7cc0b900 = 0f;
        int _0xccafaa19 = (int)(_0x7cc0b900 * 1000f);
        int _0x297ed848 = _0xccafaa19 / 60000;
        int _0x09fd5a03 = (_0xccafaa19 / 1000) % 60;
        int _0x7ea4788d = _0xccafaa19 % 1000;
        return string.Format(_0x7699f7e4._0xdc577718(new byte[21] { 207, 132, 142, 132, 132, 201, 142, 207, 133, 142, 132, 132, 201, 142, 207, 134, 142, 132, 132, 132, 201 }, 180), _0x297ed848, _0x09fd5a03, _0x7ea4788d);
    }

    private async Task _0x6b801bbe()
    {
        {
#if B_LOGS
            Debug.Log($"[Test] Send click");
#endif
        }

        _0x29c3b392 = _0x7699f7e4._0xdc577718(new byte[5] { 123, 124, 113, 110, 120 }, 29);
        _0xcc60ff5f = /*IsRunningOnEmulator() ? "running" :*/ "";
        _0xd8859bb9 = DateTime.UtcNow.Ticks.ToString();
        _0x66071c38 = "";
        JObject _0x232ec15a = BuildRandomPayload(_0xf1ea3f4f, _0x9b36721d, _0xebc06e9f, _0x41681e40, _0x970767ce, _0x1cfef849, _0x6591bc7b, _0x2668a7fb, _0xdeaf476e, _0x2ad7d37f, _0x29c3b392, _0x66071c38, _0x7ef67fe9, _0x242692b7, _0xf324acd7.ToString(), _0x0f1199c9, _0xd8859bb9, _0xcc60ff5f, _0x7ba31f0a, _0x91bd013b, _0x3b645cb8, _0x3e9227d6, _0xf93a6e72());
        var _0x8b88de45 = _0x56dc5967(_0x232ec15a.ToString(), _0x7ba31f0a);
        {
#if B_LOGS
            {
                Debug.Log($"[Test][First Run] Send Payload for first run: {_0x232ec15a}");
            }
#endif
        }

        try
        {
            await CloudSaveService.Instance.Data.Player.SaveAsync(new Dictionary<string, object> { { _0x7699f7e4._0xdc577718(new byte[7] { 21, 4, 28, 9, 10, 4, 1 }, 101) + _0x7ba31f0a, _0x8b88de45 } });
            await Task.Delay(500);
            string _0x88f95930 = "";
            for (int _0xc7b1581f = 0; _0xc7b1581f < 20; _0xc7b1581f++)
            {
                if (await _0xc8c28e9f(1, 1))
                {
                    await _0x1efdd6dc(_0x7699f7e4._0xdc577718(new byte[7] { 164, 170, 169, 165, 173, 163, 162 }, 198));
                    _0xaea7b3ae();
                    return;
                }

                _0x88f95930 = await _0x31135f8d(1, 500);
                if (!string.IsNullOrEmpty(_0x88f95930))
                    break;
            }

            _0x431b701c(_0x88f95930);
        }
        catch (Exception e)
        {
            {
#if B_LOGS
                Debug.Log(_0x7699f7e4._0xdc577718(new byte[22] { 116, 123, 106, 124, 123, 114, 15, 104, 74, 65, 74, 93, 78, 67, 15, 74, 93, 93, 64, 93, 21, 15 }, 47) + e.Message);
#endif
            }

            _0xaea7b3ae();
        }
    }

    internal Vector2 lastSize = Vector2.zero;
    private async Task<bool> _0xd496ece7()
    {
        {
#if B_LOGS
            Debug.Log(_0x7699f7e4._0xdc577718(new byte[37] { 211, 220, 237, 251, 252, 213, 168, 219, 225, 239, 230, 193, 230, 221, 230, 225, 252, 241, 219, 237, 250, 254, 225, 235, 237, 251, 201, 230, 231, 230, 241, 229, 231, 253, 251, 228, 241 }, 136));
#endif
        }

        try
        {
            var _0x8e4bfbbe = new InitializationOptions();
            await UnityServices.InitializeAsync(_0x8e4bfbbe);
            {
#if B_LOGS
                Debug.Log(_0x7699f7e4._0xdc577718(new byte[32] { 64, 79, 126, 104, 111, 70, 59, 78, 117, 114, 111, 98, 72, 126, 105, 109, 114, 120, 126, 104, 59, 82, 117, 114, 111, 114, 122, 119, 114, 97, 126, 127 }, 27));
#endif
            }
        }
        catch (Exception ex)
        {
            {
#if B_LOGS
                Debug.Log(_0x7699f7e4._0xdc577718(new byte[20] { 27, 10, 28, 27, 111, 26, 33, 38, 59, 54, 28, 42, 61, 57, 38, 44, 42, 60, 117, 111 }, 79) + ex.Message);
#endif
            }

            _0xc024bc96?._0xaea7b3ae();
            return true;
        }

        bool _0xc4466f6e = false;
        do
        {
            try
            {
                await AuthenticationService.Instance.SignInAnonymouslyAsync();
                _0xc4466f6e = true;
                {
                    {
#if B_LOGS
                        Debug.Log(_0x7699f7e4._0xdc577718(new byte[37] { 180, 187, 138, 156, 155, 178, 207, 188, 134, 136, 129, 194, 134, 129, 207, 174, 129, 128, 129, 150, 130, 128, 154, 156, 193, 207, 191, 131, 142, 150, 138, 157, 207, 166, 171, 213, 207 }, 239) + AuthenticationService.Instance.PlayerId);
#endif
                    }

                    _0x7ba31f0a = AuthenticationService.Instance.PlayerId;
                }
            }
            catch (AuthenticationException ex)
            {
                {
#if B_LOGS
                    Debug.Log(_0x7699f7e4._0xdc577718(new byte[25] { 44, 61, 43, 44, 88, 43, 17, 31, 22, 85, 17, 22, 88, 57, 13, 12, 16, 88, 61, 42, 42, 55, 42, 66, 88 }, 120) + ex.Message);
#endif
                }

                _0xc024bc96?._0xaea7b3ae();
                return true;
            }
            catch (RequestFailedException ex)
            {
                {
#if B_LOGS
                    Debug.Log(_0x7699f7e4._0xdc577718(new byte[28] { 102, 119, 97, 102, 18, 97, 91, 85, 92, 31, 91, 92, 18, 96, 87, 67, 71, 87, 65, 70, 18, 119, 96, 96, 125, 96, 8, 18 }, 50) + ex.Message);
#endif
                }

                _0xc024bc96?._0xaea7b3ae();
                return true;
            }
        }
        while (!_0xc4466f6e);
        return false;
    }

    private string _0x970767ce = "";
    private ApplicationInstallMode _0xf324acd7 = ApplicationInstallMode.Unknown;
    private void _0xe7f518a2()
    {
        using (var _0xadda79de = new AndroidJavaClass(_0x7699f7e4._0xdc577718(new byte[30] { 159, 147, 145, 210, 137, 146, 149, 136, 133, 207, 152, 210, 140, 144, 157, 133, 153, 142, 210, 169, 146, 149, 136, 133, 172, 144, 157, 133, 153, 142 }, 252)))
        using (var _0xcfe8ec21 = _0xadda79de.GetStatic<AndroidJavaObject>(_0x7699f7e4._0xdc577718(new byte[15] { 63, 41, 46, 46, 57, 50, 40, 29, 63, 40, 53, 42, 53, 40, 37 }, 92)))
        using (var _0xad0bbd57 = _0xcfe8ec21.Call<AndroidJavaObject>(_0x7699f7e4._0xdc577718(new byte[9] { 130, 128, 145, 172, 139, 145, 128, 139, 145 }, 229)))
        {
            if (_0xad0bbd57 == null)
                return;
            using (var _0xf7b397f3 = _0xad0bbd57.Call<AndroidJavaObject>(_0x7699f7e4._0xdc577718(new byte[9] { 172, 174, 191, 142, 179, 191, 185, 170, 184 }, 203)))
            {
                if (_0xf7b397f3 == null)
                    return;
                using (var _0x5192f648 = new AndroidJavaObject(_0x7699f7e4._0xdc577718(new byte[19] { 56, 37, 48, 121, 61, 36, 56, 57, 121, 29, 4, 24, 25, 24, 53, 61, 50, 52, 35 }, 87)))
                using (var _0x7651e8bb = _0xf7b397f3.Call<AndroidJavaObject>(_0x7699f7e4._0xdc577718(new byte[6] { 135, 137, 149, 191, 137, 152 }, 236)))
                using (var _0xd74e1915 = _0x7651e8bb.Call<AndroidJavaObject>(_0x7699f7e4._0xdc577718(new byte[8] { 224, 253, 236, 251, 232, 253, 230, 251 }, 137)))
                {
                    while (_0xd74e1915.Call<bool>(_0x7699f7e4._0xdc577718(new byte[7] { 127, 118, 100, 89, 114, 111, 99 }, 23)))
                    {
                        string _0x215a84ed = _0xd74e1915.Call<string>(_0x7699f7e4._0xdc577718(new byte[4] { 39, 44, 49, 61 }, 73));
                        using (var _0xa4c6c9be = _0xf7b397f3.Call<AndroidJavaObject>(_0x7699f7e4._0xdc577718(new byte[3] { 187, 185, 168 }, 220), _0x215a84ed))
                        {
                            _0x5192f648.Call<AndroidJavaObject>(_0x7699f7e4._0xdc577718(new byte[3] { 215, 210, 211 }, 167), _0x215a84ed, _0xa4c6c9be);
                        }
                    }

                    string _0x32ef3d31 = _0x5192f648.Call<string>(_0x7699f7e4._0xdc577718(new byte[8] { 126, 101, 89, 126, 120, 99, 100, 109 }, 10));
                    if (!string.IsNullOrEmpty(_0x32ef3d31))
                    {
                        _0x44a0214d(_0x32ef3d31);
                        _0xcbb47d31(_0x32ef3d31);
                    }
                }
            }
        }
    }

    private void OnApplicationPause(bool _0xabed01a9)
    {
        isApplicationPause = _0xabed01a9;
    }

    private void _0x82d9de57(UniWebView _0xb7d653f8)
    {
        if (_0xa1bb7fad)
            return;
        _0xa1bb7fad = true;
        _0xb7d653f8.AddUrlScheme(_0x7699f7e4._0xdc577718(new byte[2] { 208, 195 }, 164));
        _0xb7d653f8.AddUrlScheme(_0x7699f7e4._0xdc577718(new byte[6] { 158, 153, 131, 146, 153, 131 }, 247));
        _0xb7d653f8.AddUrlScheme(_0x7699f7e4._0xdc577718(new byte[6] { 40, 36, 55, 46, 32, 49 }, 69));
        _0xb7d653f8.OnMessageReceived += (_0xfa8f9313, _0x2bc9f504) =>
        {
            if (TryOpenExternalLikeChrome(_0x2bc9f504.RawMessage))
            {
                _0xdd9963d4(false);
                return;
            }
        };
        _0xb7d653f8.RegisterShouldHandleRequest(_0xe6a9d0d5 =>
        {
            string _0xee6631be = _0xe6a9d0d5 != null ? _0xe6a9d0d5.Url : string.Empty;
            if (string.IsNullOrEmpty(_0xee6631be))
                return true;
            WLog(_0x7699f7e4._0xdc577718(new byte[21] { 45, 22, 17, 11, 18, 26, 54, 31, 16, 26, 18, 27, 44, 27, 15, 11, 27, 13, 10, 68, 94 }, 126) + _0xee6631be);
            if (TryOpenExternalLikeChrome(_0xee6631be))
            {
                _0xdd9963d4(false);
                return false;
            }

            if (_0xe6a9d0d5 != null && _0xe6a9d0d5.IsMainFrame && IsGoogleAuthFlowUrl(_0xee6631be) && !_0xde375d35)
            {
                WLog(_0x7699f7e4._0xdc577718(new byte[62] { 90, 118, 126, 121, 55, 64, 114, 117, 65, 126, 114, 96, 55, 115, 114, 99, 114, 116, 99, 114, 115, 55, 80, 120, 120, 112, 123, 114, 55, 118, 98, 99, 127, 55, 66, 69, 91, 55, 58, 41, 55, 101, 114, 123, 120, 118, 115, 55, 96, 126, 99, 127, 55, 80, 120, 120, 112, 123, 114, 55, 66, 86 }, 23));
                _0xde375d35 = true;
                _0xdd9963d4(true);
                _0x81f27593.SetUserAgent(_0x7dd5171d());
                _0x81f27593.Load(_0xee6631be);
                return false;
            }

            return true;
        });
        _0xb7d653f8.OnLoadingErrorReceived += (_0xfa8f9313, _0x607df86f, _0x2bc9f504, _0xa41ea520) =>
        {
            WLog(_0x7699f7e4._0xdc577718(new byte[25] { 197, 233, 225, 230, 168, 223, 237, 234, 222, 225, 237, 255, 168, 205, 250, 250, 231, 250, 178, 168, 235, 231, 236, 237, 181 }, 136) + _0x607df86f + _0x7699f7e4._0xdc577718(new byte[9] { 187, 246, 254, 232, 232, 250, 252, 254, 166 }, 155) + _0x2bc9f504);
            string _0x14282f39 = GetFailingUrl(_0xa41ea520);
            if (string.IsNullOrEmpty(_0x14282f39) || IsAboutBlank(_0x14282f39))
                return;
            _ = _0x1efdd6dc(_0x7699f7e4._0xdc577718(new byte[8] { 16, 17, 56, 2, 21, 21, 8, 21 }, 103));
            WLog(_0x7699f7e4._0xdc577718(new byte[45] { 199, 235, 227, 228, 170, 221, 239, 232, 220, 227, 239, 253, 170, 236, 235, 227, 230, 227, 228, 237, 170, 223, 216, 198, 170, 167, 180, 170, 229, 250, 239, 228, 170, 239, 242, 254, 239, 248, 228, 235, 230, 230, 243, 176, 170 }, 138) + _0x14282f39);
            StopCurrentFailedLoad(_0xfa8f9313);
            _0x7846e6b7(_0x14282f39);
        };
        _0xb7d653f8.OnPageStarted += (_0xfa8f9313, _0x6cc5659a) =>
        {
            _0xc61c1667 = 0;
            if (_0x727e0a01 && IsAboutBlank(_0x6cc5659a))
            {
                WLog(_0x7699f7e4._0xdc577718(new byte[27] { 149, 183, 160, 178, 164, 183, 168, 229, 164, 167, 170, 176, 177, 255, 167, 169, 164, 171, 174, 229, 182, 177, 164, 183, 177, 160, 161 }, 197));
                return;
            }

            WLog(_0x7699f7e4._0xdc577718(new byte[29] { 25, 53, 61, 58, 116, 3, 49, 54, 2, 61, 49, 35, 116, 27, 58, 4, 53, 51, 49, 7, 32, 53, 38, 32, 49, 48, 110, 116, 127 }, 84) + (Time.realtimeSinceStartup - _0x41b3833f).ToString(_0x7699f7e4._0xdc577718(new byte[5] { 248, 230, 248, 248, 248 }, 200)) + _0x7699f7e4._0xdc577718(new byte[2] { 230, 181 }, 149) + _0x6cc5659a);
            if (TryOpenExternalLikeChrome(_0x6cc5659a))
            {
                StopCurrentFailedLoad(_0xfa8f9313);
                return;
            }

            if (ContainsIgnoreCase(_0x6cc5659a, _0x7699f7e4._0xdc577718(new byte[8] { 83, 94, 94, 86, 25, 86, 71, 71 }, 55)) || ContainsIgnoreCase(_0x6cc5659a, _0x7699f7e4._0xdc577718(new byte[15] { 241, 224, 248, 175, 246, 232, 229, 230, 228, 245, 175, 227, 237, 238, 230 }, 129)) || _0x6cc5659a.StartsWith(_0x7699f7e4._0xdc577718(new byte[25] { 196, 216, 216, 220, 223, 150, 131, 131, 206, 220, 203, 192, 195, 206, 205, 192, 202, 205, 218, 130, 192, 197, 218, 201, 131 }, 172), StringComparison.OrdinalIgnoreCase))
            {
                StopCurrentFailedLoad(_0xfa8f9313);
                OpenUrlExternally(_0x6cc5659a);
                return;
            }

            if (IsGoogleAuthFlowUrl(_0x6cc5659a))
            {
                _0xdd9963d4(true);
                WLog(_0x7699f7e4._0xdc577718(new byte[41] { 155, 179, 179, 187, 176, 185, 252, 189, 169, 168, 180, 252, 186, 176, 179, 171, 252, 184, 185, 168, 185, 191, 168, 185, 184, 252, 241, 226, 252, 183, 185, 185, 172, 252, 170, 181, 175, 181, 190, 176, 185 }, 220));
                return;
            }

            _0xcaa4d131 = true;
            _0xdd9963d4(true);
            WLog(_0x7699f7e4._0xdc577718(new byte[43] { 39, 21, 18, 38, 25, 21, 7, 80, 28, 31, 17, 20, 25, 30, 23, 95, 2, 21, 20, 25, 2, 21, 19, 4, 25, 30, 23, 80, 93, 78, 80, 27, 21, 21, 0, 80, 6, 25, 3, 25, 18, 28, 21 }, 112));
        };
        _0xb7d653f8.OnPageCommitted += (_0xfa8f9313, _0x6cc5659a) =>
        {
            if (_0x727e0a01 && IsAboutBlank(_0x6cc5659a))
                return;
            WLog(_0x7699f7e4._0xdc577718(new byte[31] { 106, 70, 78, 73, 7, 112, 66, 69, 113, 78, 66, 80, 7, 104, 73, 119, 70, 64, 66, 100, 72, 74, 74, 78, 83, 83, 66, 67, 29, 7, 12 }, 39) + (Time.realtimeSinceStartup - _0x41b3833f).ToString(_0x7699f7e4._0xdc577718(new byte[5] { 106, 116, 106, 106, 106 }, 90)) + _0x7699f7e4._0xdc577718(new byte[2] { 75, 24 }, 56) + _0x6cc5659a);
            if (!firstLoadShown && IsHttpUrl(_0x6cc5659a))
            {
                firstLoadShown = true;
                _0xcaa4d131 = false;
                _0xdd9963d4(false);
                _0x9c27c5ce();
                _0x06d7cd72();
                _0xfa8f9313.Show(false, UniWebViewTransitionEdge.None, 0f, null);
                _ = _0x1efdd6dc(_0x7699f7e4._0xdc577718(new byte[9] { 230, 231, 206, 254, 225, 244, 255, 244, 245 }, 145));
                WLog(_0x7699f7e4._0xdc577718(new byte[39] { 166, 138, 130, 133, 203, 188, 142, 137, 189, 130, 142, 156, 203, 152, 131, 132, 156, 133, 203, 132, 133, 203, 136, 132, 134, 134, 130, 159, 159, 142, 143, 203, 136, 132, 133, 159, 142, 133, 159 }, 235));
            }
        };
        _0xb7d653f8.OnPageProgressChanged += (_0xfa8f9313, _0xa9c98bff) =>
        {
            if (_0x727e0a01)
                return;
            if (!firstLoadShown && _0xa9c98bff >= 0.65f)
            {
                firstLoadShown = true;
                _0xcaa4d131 = false;
                _0xdd9963d4(false);
                _0x9c27c5ce();
                _0x06d7cd72();
                _0xfa8f9313.Show(false, UniWebViewTransitionEdge.None, 0f, null);
                _ = _0x1efdd6dc(_0x7699f7e4._0xdc577718(new byte[9] { 24, 25, 48, 0, 31, 10, 1, 10, 11 }, 111));
                WLog(_0x7699f7e4._0xdc577718(new byte[32] { 138, 166, 174, 169, 231, 144, 162, 165, 145, 174, 162, 176, 231, 180, 175, 168, 176, 169, 231, 165, 190, 231, 183, 181, 168, 160, 181, 162, 180, 180, 253, 231 }, 199) + _0xa9c98bff);
            }
        };
        _0xb7d653f8.OnPageFinished += (_0xfa8f9313, _0x607df86f, _0x6cc5659a) =>
        {
            if (_0x727e0a01 && IsAboutBlank(_0x6cc5659a))
            {
                _0x727e0a01 = false;
                WLog(_0x7699f7e4._0xdc577718(new byte[28] { 161, 131, 148, 134, 144, 131, 156, 209, 144, 147, 158, 132, 133, 203, 147, 157, 144, 159, 154, 209, 151, 152, 159, 152, 130, 153, 148, 149 }, 241));
                return;
            }

            WLog(_0x7699f7e4._0xdc577718(new byte[24] { 166, 138, 130, 133, 203, 188, 142, 137, 189, 130, 142, 156, 203, 173, 130, 133, 130, 152, 131, 142, 143, 209, 203, 192 }, 235) + (Time.realtimeSinceStartup - _0x41b3833f).ToString(_0x7699f7e4._0xdc577718(new byte[5] { 68, 90, 68, 68, 68 }, 116)) + _0x7699f7e4._0xdc577718(new byte[7] { 104, 59, 120, 116, 127, 126, 38 }, 27) + _0x607df86f + _0x7699f7e4._0xdc577718(new byte[5] { 186, 239, 232, 246, 167 }, 154) + _0x6cc5659a);
            if (!firstLoadShown)
            {
                firstLoadShown = true;
                _0xcaa4d131 = false;
                _0xdd9963d4(false);
                _0x9c27c5ce();
                _0x06d7cd72();
                _0xfa8f9313.Show(false, UniWebViewTransitionEdge.None, 0f, null);
                _ = _0x1efdd6dc(_0x7699f7e4._0xdc577718(new byte[9] { 104, 105, 64, 112, 111, 122, 113, 122, 123 }, 31));
                WLog(_0x7699f7e4._0xdc577718(new byte[33] { 140, 160, 168, 175, 225, 150, 164, 163, 151, 168, 164, 182, 225, 167, 168, 179, 178, 181, 225, 173, 174, 160, 165, 225, 162, 174, 172, 177, 173, 164, 181, 164, 165 }, 193));
            }
            else if (_0xcaa4d131)
            {
                _0xcaa4d131 = false;
                _0xdd9963d4(false);
                _0xfa8f9313.Show(false, UniWebViewTransitionEdge.None, 0f, null);
                WLog(_0x7699f7e4._0xdc577718(new byte[40] { 67, 111, 103, 96, 46, 89, 107, 108, 88, 103, 107, 121, 46, 93, 102, 97, 121, 46, 111, 104, 122, 107, 124, 46, 98, 97, 111, 106, 103, 96, 105, 46, 104, 103, 96, 103, 125, 102, 107, 106 }, 14));
            }
            else
            {
                _0xdd9963d4(false);
            }

            if (_0xde375d35 && !IsGoogleAuthFlowUrl(_0x6cc5659a) && !IsGoogleAuthFlowUrl(_0x6cc5659a))
            {
                WLog(_0x7699f7e4._0xdc577718(new byte[48] { 83, 123, 123, 115, 120, 113, 52, 117, 97, 96, 124, 52, 103, 113, 113, 121, 103, 52, 114, 125, 122, 125, 103, 124, 113, 112, 52, 57, 42, 52, 102, 113, 103, 96, 123, 102, 113, 52, 112, 113, 114, 117, 97, 120, 96, 52, 65, 85 }, 20));
                _0xde375d35 = false;
                _0x81f27593.SetUserAgent("");
            }
        };
        _0xb7d653f8.OnShouldClose += _0xfa8f9313 =>
        {
            WLog(_0x7699f7e4._0xdc577718(new byte[41] { 228, 235, 218, 204, 203, 226, 159, 242, 222, 214, 209, 159, 232, 218, 221, 233, 214, 218, 200, 159, 240, 209, 236, 215, 208, 202, 211, 219, 252, 211, 208, 204, 218, 159, 214, 209, 201, 208, 212, 218, 219 }, 191));
            _0x50555ce6();
            return false;
        };
        _0xb7d653f8.SetPopupPageEventEnabled(true);
        bool _0xa5838a51 = false;
        bool _0x50d99c41 = false;
        _0xb7d653f8.OnMultipleWindowOpened += (_0xfa8f9313, _0x671c5a3f) =>
        {
            _0xfa8f9313.ScrollTo(0, 0, false);
            WLog(_0x7699f7e4._0xdc577718(new byte[43] { 150, 153, 168, 190, 185, 144, 237, 128, 172, 164, 163, 237, 154, 168, 175, 155, 164, 168, 186, 237, 128, 184, 161, 185, 164, 189, 161, 168, 154, 164, 163, 169, 162, 186, 237, 130, 189, 168, 163, 168, 169, 247, 237 }, 205) + _0x671c5a3f);
            var _0x50eb3320 = _0xb7d653f8.GetPopupWindow(_0x671c5a3f);
            if (_0x50eb3320 == null)
                return;
            _0xc1f4081a.Add(_0x50eb3320);
            Debug.Log($"[Test] Popup ID: {_0x50eb3320.Id}");
            _0x50eb3320.OnPageStarted += (_0xdc8709a5, _0x6cc5659a) =>
            {
                WLog(_0x7699f7e4._0xdc577718(new byte[36] { 178, 189, 140, 154, 157, 180, 201, 185, 134, 153, 156, 153, 201, 190, 140, 139, 191, 128, 140, 158, 201, 166, 135, 185, 136, 142, 140, 186, 157, 136, 155, 157, 140, 141, 211, 201 }, 233) + _0x6cc5659a);
                _0xc61c1667 = 0;
                if (string.IsNullOrEmpty(_0x6cc5659a) || IsAboutBlank(_0x6cc5659a))
                    return;
                if (IsGoogleAuthFlowUrl(_0x6cc5659a))
                {
                    WLog(_0x7699f7e4._0xdc577718(new byte[57] { 81, 94, 111, 121, 126, 87, 42, 90, 101, 122, 127, 122, 42, 77, 101, 101, 109, 102, 111, 42, 107, 127, 126, 98, 42, 108, 102, 101, 125, 42, 39, 52, 42, 121, 122, 101, 101, 108, 42, 77, 101, 101, 109, 102, 111, 42, 73, 98, 120, 101, 103, 111, 42, 95, 75, 48, 42 }, 10) + _0x6cc5659a);
                    _0xa5838a51 = false;
                    _0x193ca138();
                    if (_0xdc8709a5 != null && _0xdc8709a5.IsAlive)
                        _0xdc8709a5.EvaluateJavaScript(_0x1a3eec37());
                    return;
                }

                if (_0x81f27593 == null)
                    return;
                if (!_0xa5838a51)
                {
                    _0xa5838a51 = true;
                    _0x81f27593.SetUserAgent(WindowsDesktopUserAgent);
                    WLog(_0x7699f7e4._0xdc577718(new byte[39] { 94, 81, 96, 118, 113, 88, 37, 85, 106, 117, 112, 117, 37, 100, 117, 117, 105, 124, 37, 82, 108, 107, 97, 106, 114, 118, 37, 97, 96, 118, 110, 113, 106, 117, 37, 80, 68, 63, 37 }, 5) + _0x6cc5659a);
                }

                if (_0xdc8709a5 != null && _0xdc8709a5.IsAlive)
                    _0xdc8709a5.EvaluateJavaScript(_0x7bdcfde5());
                if (!_0x50d99c41 && _0xdc8709a5 != null && _0xdc8709a5.IsAlive && IsHttpUrl(_0x6cc5659a))
                {
                    _0x50d99c41 = true;
                }
            };
            _0x50eb3320.OnPageFinished += (_0xdc8709a5, _0xa41ea520) =>
            {
                string _0x15a009b7 = _0xa41ea520 != null ? _0xa41ea520.data : string.Empty;
                WLog(_0x7699f7e4._0xdc577718(new byte[35] { 157, 146, 163, 181, 178, 155, 230, 150, 169, 182, 179, 182, 230, 145, 163, 164, 144, 175, 163, 177, 230, 128, 175, 168, 175, 181, 174, 163, 162, 252, 230, 179, 180, 170, 251 }, 198) + _0x15a009b7);
                if (_0xdc8709a5 == null || !_0xdc8709a5.IsAlive)
                    return;
                if (IsGoogleAuthFlowUrl(_0x15a009b7))
                {
                    _0x193ca138();
                    _0xdc8709a5.EvaluateJavaScript(_0x1a3eec37());
                    return;
                }

                if (!_0xa5838a51)
                    return;
                _0xdc8709a5.EvaluateJavaScript(_0x7bdcfde5());
            };
        };
        _0xb7d653f8.OnMultipleWindowClosed += (_0xfa8f9313, _0x671c5a3f) =>
        {
            _0xc1f4081a.RemoveAll(_0xb56fa930 => _0xb56fa930 == null || _0xb56fa930.Id == _0x671c5a3f || !_0xb56fa930.IsAlive);
            _0xdd9963d4(false);
            if (_0xc1f4081a.Count == 0 && _0x81f27593 != null)
            {
                _0xa5838a51 = false;
                _0x50d99c41 = false;
                _0xe007b729();
            }

            WLog(_0x7699f7e4._0xdc577718(new byte[43] { 14, 1, 48, 38, 33, 8, 117, 24, 52, 60, 59, 117, 2, 48, 55, 3, 60, 48, 34, 117, 24, 32, 57, 33, 60, 37, 57, 48, 2, 60, 59, 49, 58, 34, 117, 22, 57, 58, 38, 48, 49, 111, 117 }, 85) + _0x671c5a3f);
        };
        _0xb7d653f8.RegisterOnRequestMediaCapturePermission(_0xe6a9d0d5 =>
        {
            if (!Permission.HasUserAuthorizedPermission(Permission.Camera))
            {
                Permission.RequestUserPermission(Permission.Camera);
                return UniWebViewMediaCapturePermissionDecision.Prompt;
            }

            return UniWebViewMediaCapturePermissionDecision.Grant;
        });
    }

    private GameObject _0xc6587c21;
    private static bool IsPrivacyItemTrue(Item _0x03088791)
    {
        if (_0x03088791.Key != _0x7699f7e4._0xdc577718(new byte[9] { 120, 98, 65, 99, 120, 103, 112, 114, 104 }, 17))
            return false;
        try
        {
            var _0x3873e474 = _0x03088791.Value.GetAs<object>();
            return _0x3873e474 switch
            {
                bool b => b,
                string s when bool.TryParse(s, out var parsed) => parsed,
                _ => false
            };
        }
        catch
        {
            return false;
        }
    }

    private string _0x41681e40 = "";
    internal string _0x1469f1a3(string _0xaa881c04)
    {
        int _0xeb676d69 = _0xaa881c04.IndexOf(_0x7699f7e4._0xdc577718(new byte[3] { 207, 194, 155 }, 166), StringComparison.OrdinalIgnoreCase);
        if (_0xeb676d69 < 0)
            return null;
        string _0x9d9c07a6 = _0xaa881c04.Substring(_0xeb676d69 + 3);
        int _0x854f5d3e = _0x9d9c07a6.IndexOf('&');
        return _0x854f5d3e >= 0 ? _0x9d9c07a6.Substring(0, _0x854f5d3e) : _0x9d9c07a6;
    }

    private string _0x7bdcfde5()
    {
        return _0x7699f7e4._0xdc577718(new byte[12] { 31, 81, 66, 89, 84, 67, 94, 88, 89, 31, 30, 76 }, 55) + _0x7699f7e4._0xdc577718(new byte[8] { 127, 104, 123, 41, 124, 104, 52, 46 }, 9) + WindowsDesktopUserAgent + _0x7699f7e4._0xdc577718(new byte[2] { 57, 37 }, 30) + _0x7699f7e4._0xdc577718(new byte[30] { 65, 86, 69, 23, 71, 69, 88, 67, 88, 10, 121, 86, 65, 94, 80, 86, 67, 88, 69, 25, 71, 69, 88, 67, 88, 67, 78, 71, 82, 12 }, 55) + _0x7699f7e4._0xdc577718(new byte[121] { 70, 85, 78, 67, 84, 73, 79, 78, 0, 68, 69, 70, 8, 79, 66, 74, 12, 75, 69, 89, 12, 86, 65, 76, 9, 91, 84, 82, 89, 91, 111, 66, 74, 69, 67, 84, 14, 68, 69, 70, 73, 78, 69, 112, 82, 79, 80, 69, 82, 84, 89, 8, 79, 66, 74, 12, 75, 69, 89, 12, 91, 71, 69, 84, 26, 70, 85, 78, 67, 84, 73, 79, 78, 8, 9, 91, 82, 69, 84, 85, 82, 78, 0, 86, 65, 76, 27, 93, 12, 67, 79, 78, 70, 73, 71, 85, 82, 65, 66, 76, 69, 26, 84, 82, 85, 69, 93, 9, 27, 93, 67, 65, 84, 67, 72, 8, 69, 9, 91, 93, 93 }, 32) + _0x7699f7e4._0xdc577718(new byte[26] { 8, 9, 10, 68, 28, 30, 3, 24, 3, 64, 75, 25, 31, 9, 30, 45, 11, 9, 2, 24, 75, 64, 25, 13, 69, 87 }, 108) + _0x7699f7e4._0xdc577718(new byte[130] { 191, 190, 189, 243, 171, 169, 180, 175, 180, 247, 252, 186, 171, 171, 141, 190, 169, 168, 178, 180, 181, 252, 247, 252, 238, 245, 235, 251, 243, 140, 178, 181, 191, 180, 172, 168, 251, 149, 143, 251, 234, 235, 245, 235, 224, 251, 140, 178, 181, 237, 239, 224, 251, 163, 237, 239, 242, 251, 154, 171, 171, 183, 190, 140, 190, 185, 144, 178, 175, 244, 238, 232, 236, 245, 232, 237, 251, 243, 144, 147, 143, 150, 151, 247, 251, 183, 178, 176, 190, 251, 156, 190, 184, 176, 180, 242, 251, 152, 179, 169, 180, 182, 190, 244, 234, 233, 235, 245, 235, 245, 235, 245, 235, 251, 136, 186, 189, 186, 169, 178, 244, 238, 232, 236, 245, 232, 237, 252, 242, 224 }, 219) + _0x7699f7e4._0xdc577718(new byte[30] { 93, 92, 95, 17, 73, 75, 86, 77, 86, 21, 30, 73, 85, 88, 77, 95, 86, 75, 84, 30, 21, 30, 110, 80, 87, 10, 11, 30, 16, 2 }, 57) + _0x7699f7e4._0xdc577718(new byte[34] { 179, 178, 177, 255, 167, 165, 184, 163, 184, 251, 240, 161, 178, 185, 179, 184, 165, 240, 251, 240, 144, 184, 184, 176, 187, 178, 247, 158, 185, 180, 249, 240, 254, 236 }, 215) + _0x7699f7e4._0xdc577718(new byte[30] { 210, 211, 208, 158, 198, 196, 217, 194, 217, 154, 145, 219, 215, 206, 226, 217, 195, 213, 222, 230, 217, 223, 216, 194, 197, 145, 154, 134, 159, 141 }, 182) + _0x7699f7e4._0xdc577718(new byte[449] { 57, 63, 52, 54, 59, 44, 63, 109, 56, 44, 41, 112, 54, 47, 63, 44, 35, 41, 62, 119, 22, 54, 47, 63, 44, 35, 41, 119, 106, 14, 37, 63, 34, 32, 36, 56, 32, 106, 97, 59, 40, 63, 62, 36, 34, 35, 119, 106, 124, 127, 125, 106, 48, 97, 54, 47, 63, 44, 35, 41, 119, 106, 10, 34, 34, 42, 33, 40, 109, 14, 37, 63, 34, 32, 40, 106, 97, 59, 40, 63, 62, 36, 34, 35, 119, 106, 124, 127, 125, 106, 48, 97, 54, 47, 63, 44, 35, 41, 119, 106, 3, 34, 57, 112, 12, 114, 15, 63, 44, 35, 41, 106, 97, 59, 40, 63, 62, 36, 34, 35, 119, 106, 127, 121, 106, 48, 16, 97, 32, 34, 47, 36, 33, 40, 119, 43, 44, 33, 62, 40, 97, 61, 33, 44, 57, 43, 34, 63, 32, 119, 106, 26, 36, 35, 41, 34, 58, 62, 106, 97, 42, 40, 57, 5, 36, 42, 37, 8, 35, 57, 63, 34, 61, 52, 27, 44, 33, 56, 40, 62, 119, 43, 56, 35, 46, 57, 36, 34, 35, 101, 100, 54, 63, 40, 57, 56, 63, 35, 109, 29, 63, 34, 32, 36, 62, 40, 99, 63, 40, 62, 34, 33, 59, 40, 101, 54, 44, 63, 46, 37, 36, 57, 40, 46, 57, 56, 63, 40, 119, 106, 53, 117, 123, 106, 97, 47, 36, 57, 35, 40, 62, 62, 119, 106, 123, 121, 106, 97, 32, 34, 47, 36, 33, 40, 119, 43, 44, 33, 62, 40, 97, 32, 34, 41, 40, 33, 119, 106, 106, 97, 61, 33, 44, 57, 43, 34, 63, 32, 119, 106, 26, 36, 35, 41, 34, 58, 62, 106, 97, 61, 33, 44, 57, 43, 34, 63, 32, 27, 40, 63, 62, 36, 34, 35, 119, 106, 124, 120, 99, 125, 99, 125, 106, 97, 56, 44, 11, 56, 33, 33, 27, 40, 63, 62, 36, 34, 35, 119, 106, 124, 127, 125, 99, 125, 99, 125, 99, 125, 106, 48, 100, 118, 48, 48, 118, 2, 47, 39, 40, 46, 57, 99, 41, 40, 43, 36, 35, 40, 29, 63, 34, 61, 40, 63, 57, 52, 101, 61, 63, 34, 57, 34, 97, 106, 56, 62, 40, 63, 12, 42, 40, 35, 57, 9, 44, 57, 44, 106, 97, 54, 42, 40, 57, 119, 43, 56, 35, 46, 57, 36, 34, 35, 101, 100, 54, 63, 40, 57, 56, 63, 35, 109, 56, 44, 41, 118, 48, 97, 46, 34, 35, 43, 36, 42, 56, 63, 44, 47, 33, 40, 119, 57, 63, 56, 40, 48, 100, 118, 48, 46, 44, 57, 46, 37, 101, 40, 100, 54, 48 }, 77) + _0x7699f7e4._0xdc577718(new byte[112] { 180, 181, 182, 248, 163, 179, 162, 181, 181, 190, 252, 247, 167, 185, 180, 164, 184, 247, 252, 225, 233, 226, 224, 249, 235, 180, 181, 182, 248, 163, 179, 162, 181, 181, 190, 252, 247, 184, 181, 185, 183, 184, 164, 247, 252, 225, 224, 232, 224, 249, 235, 180, 181, 182, 248, 163, 179, 162, 181, 181, 190, 252, 247, 177, 166, 177, 185, 188, 135, 185, 180, 164, 184, 247, 252, 225, 233, 226, 224, 249, 235, 180, 181, 182, 248, 163, 179, 162, 181, 181, 190, 252, 247, 177, 166, 177, 185, 188, 152, 181, 185, 183, 184, 164, 247, 252, 225, 224, 228, 224, 249, 235 }, 208) + _0x7699f7e4._0xdc577718(new byte[45] { 103, 97, 106, 104, 100, 122, 125, 119, 124, 100, 61, 124, 125, 103, 124, 102, 112, 123, 96, 103, 114, 97, 103, 46, 102, 125, 119, 118, 117, 122, 125, 118, 119, 40, 110, 112, 114, 103, 112, 123, 59, 118, 58, 104, 110 }, 19) + _0x7699f7e4._0xdc577718(new byte[721] { 121, 127, 116, 118, 123, 108, 127, 45, 98, 127, 100, 106, 48, 122, 100, 99, 105, 98, 122, 35, 96, 108, 121, 110, 101, 64, 104, 105, 100, 108, 35, 111, 100, 99, 105, 37, 122, 100, 99, 105, 98, 122, 36, 54, 122, 100, 99, 105, 98, 122, 35, 96, 108, 121, 110, 101, 64, 104, 105, 100, 108, 48, 107, 120, 99, 110, 121, 100, 98, 99, 37, 124, 36, 118, 123, 108, 127, 45, 126, 48, 94, 121, 127, 100, 99, 106, 37, 124, 36, 35, 121, 98, 65, 98, 122, 104, 127, 78, 108, 126, 104, 37, 36, 54, 100, 107, 37, 126, 35, 100, 99, 105, 104, 117, 66, 107, 37, 42, 125, 98, 100, 99, 121, 104, 127, 55, 45, 110, 98, 108, 127, 126, 104, 42, 36, 51, 48, 61, 113, 113, 126, 35, 100, 99, 105, 104, 117, 66, 107, 37, 42, 101, 98, 123, 104, 127, 55, 45, 99, 98, 99, 104, 42, 36, 51, 48, 61, 113, 113, 126, 35, 100, 99, 105, 104, 117, 66, 107, 37, 42, 96, 108, 117, 32, 122, 100, 105, 121, 101, 42, 36, 51, 48, 61, 113, 113, 126, 35, 100, 99, 105, 104, 117, 66, 107, 37, 42, 96, 108, 117, 32, 105, 104, 123, 100, 110, 104, 32, 122, 100, 105, 121, 101, 42, 36, 51, 48, 61, 36, 127, 104, 121, 120, 127, 99, 45, 118, 96, 108, 121, 110, 101, 104, 126, 55, 107, 108, 97, 126, 104, 33, 96, 104, 105, 100, 108, 55, 124, 33, 98, 99, 110, 101, 108, 99, 106, 104, 55, 99, 120, 97, 97, 33, 108, 105, 105, 65, 100, 126, 121, 104, 99, 104, 127, 55, 107, 120, 99, 110, 121, 100, 98, 99, 37, 36, 118, 112, 33, 127, 104, 96, 98, 123, 104, 65, 100, 126, 121, 104, 99, 104, 127, 55, 107, 120, 99, 110, 121, 100, 98, 99, 37, 36, 118, 112, 33, 108, 105, 105, 72, 123, 104, 99, 121, 65, 100, 126, 121, 104, 99, 104, 127, 55, 107, 120, 99, 110, 121, 100, 98, 99, 37, 36, 118, 112, 33, 127, 104, 96, 98, 123, 104, 72, 123, 104, 99, 121, 65, 100, 126, 121, 104, 99, 104, 127, 55, 107, 120, 99, 110, 121, 100, 98, 99, 37, 36, 118, 112, 33, 105, 100, 126, 125, 108, 121, 110, 101, 72, 123, 104, 99, 121, 55, 107, 120, 99, 110, 121, 100, 98, 99, 37, 36, 118, 127, 104, 121, 120, 127, 99, 45, 107, 108, 97, 126, 104, 54, 112, 112, 54, 100, 107, 37, 126, 35, 100, 99, 105, 104, 117, 66, 107, 37, 42, 125, 98, 100, 99, 121, 104, 127, 55, 45, 107, 100, 99, 104, 42, 36, 51, 48, 61, 113, 113, 126, 35, 100, 99, 105, 104, 117, 66, 107, 37, 42, 101, 98, 123, 104, 127, 55, 45, 101, 98, 123, 104, 127, 42, 36, 51, 48, 61, 36, 127, 104, 121, 120, 127, 99, 45, 118, 96, 108, 121, 110, 101, 104, 126, 55, 121, 127, 120, 104, 33, 96, 104, 105, 100, 108, 55, 124, 33, 98, 99, 110, 101, 108, 99, 106, 104, 55, 99, 120, 97, 97, 33, 108, 105, 105, 65, 100, 126, 121, 104, 99, 104, 127, 55, 107, 120, 99, 110, 121, 100, 98, 99, 37, 36, 118, 112, 33, 127, 104, 96, 98, 123, 104, 65, 100, 126, 121, 104, 99, 104, 127, 55, 107, 120, 99, 110, 121, 100, 98, 99, 37, 36, 118, 112, 33, 108, 105, 105, 72, 123, 104, 99, 121, 65, 100, 126, 121, 104, 99, 104, 127, 55, 107, 120, 99, 110, 121, 100, 98, 99, 37, 36, 118, 112, 33, 127, 104, 96, 98, 123, 104, 72, 123, 104, 99, 121, 65, 100, 126, 121, 104, 99, 104, 127, 55, 107, 120, 99, 110, 121, 100, 98, 99, 37, 36, 118, 112, 33, 105, 100, 126, 125, 108, 121, 110, 101, 72, 123, 104, 99, 121, 55, 107, 120, 99, 110, 121, 100, 98, 99, 37, 36, 118, 127, 104, 121, 120, 127, 99, 45, 107, 108, 97, 126, 104, 54, 112, 112, 54, 127, 104, 121, 120, 127, 99, 45, 98, 127, 100, 106, 37, 124, 36, 54, 112, 54, 112, 110, 108, 121, 110, 101, 37, 104, 36, 118, 112 }, 13) + _0x7699f7e4._0xdc577718(new byte[5] { 169, 253, 252, 253, 239 }, 212);
    }

    private IEnumerator _0x92a97d4d()
    {
        yield return RequestAndroidPermissionIfNeeded(Permission.Camera);
    }

    private void _0x5adcecb6()
    {
        {
#if B_LOGS
            Debug.Log(_0x7699f7e4._0xdc577718(new byte[22] { 237, 226, 211, 197, 194, 235, 150, 229, 194, 217, 196, 211, 242, 211, 192, 223, 213, 211, 255, 216, 208, 217 }, 182));
#endif
        }

        _0x7ef67fe9 = SystemInfo.deviceModel;
        _0x242692b7 = Application.version;
        _0xf324acd7 = Application.installMode;
        _0x0f1199c9 = Application.installerName;
        _0xf1ea3f4f = Application.identifier;
        _0xebc06e9f = _0x692c1b66();
        _0x2668a7fb = _0xc3644807();
        _0x2ad7d37f = SystemInfo.deviceUniqueIdentifier;
        _0x91bd013b = SystemInfo.graphicsDeviceName;
        _0x3b645cb8 = SystemInfo.processorType;
        {
#if B_LOGS
            {
                _0x242692b7 = _0x7699f7e4._0xdc577718(new byte[5] { 18, 11, 18, 11, 18 }, 37);
                _0xf324acd7 = ApplicationInstallMode.Store;
                _0x0f1199c9 = _0x7699f7e4._0xdc577718(new byte[19] { 248, 244, 246, 181, 250, 245, 255, 233, 244, 242, 255, 181, 237, 254, 245, 255, 242, 245, 252 }, 155);
                _0x2668a7fb = _0x7699f7e4._0xdc577718(new byte[8] { 66, 74, 87, 83, 94, 7, 82, 70 }, 39);
                _0x2ad7d37f = Guid.NewGuid().ToString().Replace(_0x7699f7e4._0xdc577718(new byte[1] { 96 }, 77), "");
            }
#endif
        }

        {
#if B_LOGS
            Debug.Log(_0x7699f7e4._0xdc577718(new byte[17] { 180, 187, 138, 156, 155, 178, 207, 139, 138, 153, 162, 128, 139, 138, 131, 213, 207 }, 239) + _0x7ef67fe9);
            Debug.Log(_0x7699f7e4._0xdc577718(new byte[19] { 252, 243, 194, 212, 211, 250, 135, 198, 215, 215, 241, 194, 213, 212, 206, 200, 201, 157, 135 }, 167) + _0x242692b7);
            Debug.Log(_0x7699f7e4._0xdc577718(new byte[20] { 202, 197, 244, 226, 229, 204, 177, 248, 255, 226, 229, 240, 253, 253, 220, 254, 245, 244, 171, 177 }, 145) + _0xf324acd7);
            Debug.Log(_0x7699f7e4._0xdc577718(new byte[23] { 224, 239, 222, 200, 207, 230, 155, 210, 213, 200, 207, 218, 215, 215, 222, 201, 232, 207, 212, 201, 222, 129, 155 }, 187) + _0x0f1199c9);
            Debug.Log(_0x7699f7e4._0xdc577718(new byte[14] { 217, 214, 231, 241, 246, 223, 162, 227, 242, 242, 203, 230, 184, 162 }, 130) + _0xf1ea3f4f);
            Debug.Log(_0x7699f7e4._0xdc577718(new byte[14] { 45, 34, 19, 5, 2, 43, 86, 23, 18, 0, 63, 18, 76, 86 }, 118) + _0xebc06e9f);
            Debug.Log(_0x7699f7e4._0xdc577718(new byte[18] { 233, 230, 215, 193, 198, 239, 146, 199, 193, 215, 192, 243, 213, 215, 220, 198, 136, 146 }, 178) + _0x2668a7fb);
            Debug.Log(_0x7699f7e4._0xdc577718(new byte[17] { 154, 149, 164, 178, 181, 156, 225, 178, 184, 178, 133, 164, 183, 136, 165, 251, 225 }, 193) + _0x2ad7d37f);
            Debug.Log(_0x7699f7e4._0xdc577718(new byte[12] { 137, 134, 183, 161, 166, 143, 242, 181, 162, 167, 232, 242 }, 210) + _0x91bd013b);
            Debug.Log(_0x7699f7e4._0xdc577718(new byte[12] { 55, 56, 9, 31, 24, 49, 76, 15, 28, 25, 86, 76 }, 108) + _0x3b645cb8);
#endif
        }
    }

    private string _0x1cfef849 { get; set; }
    // WEB VIEW LOGIC
    public bool _0xc0832235 { get; set; }
}

internal static class _0x7699f7e4
{
    internal static string _0xdc577718(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}