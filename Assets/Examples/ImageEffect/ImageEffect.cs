using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FairyGUI;

public class ImageEffect : MonoBehaviour
{
    GComponent _mainView;
    GObject _testObj;

    // Start is called before the first frame update
    void Start()
    {
        _mainView = this.GetComponent<UIPanel>().ui;
        _testObj = _mainView.GetChild("n6");


        var dissolveFilter = new DissolveFilter();
        _testObj.filter = dissolveFilter;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
