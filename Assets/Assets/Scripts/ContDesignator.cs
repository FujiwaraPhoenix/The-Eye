using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContDesignator : MonoBehaviour {

    void CallController()
    {
        Controller.cont.getCurrentMap();
        Controller.cont.eyeUsedCounter++;
        Controller.cont.fc.SetIntegerVariable("eyeUsedCounter", Controller.cont.eyeUsedCounter);
    }

    void UpdateCounter()
    {
        Controller.cont.getCurrentMap();
        Controller.cont.fc.SetIntegerVariable("eyeUsedCounter", Controller.cont.eyeUsedCounter);
    }
}
