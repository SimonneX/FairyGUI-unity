using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FairyGUI;

public sealed class DissolveFilter : IFilter
{
    [Range(0, 1)]
    public float threshold = 0.0f;

    Material _mat;

    DisplayObject _target;

    public DisplayObject target
    {
        get { return _target; }

        set
        {
            _target = value;

            _mat = new Material(ShaderConfig.GetShader("FairyGUIExt/Dissolve"));
            _target.graphics.material = _mat;
            // _mat.hideFlags = DisplayObject.hideFlags;
        }
    }

    /// <summary>
    /// 
    /// </summary>
    public void Update()
    {

    }

    /// <summary>
    /// 
    /// </summary>
    public void Dispose()
    {
        _target = null;
    }

}
