using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContDesignator : MonoBehaviour {

	//Use this to update the Eye use counter immediately as it is used
    void CallController()
    {
        Controller.cont.getCurrentMap();
        Controller.cont.eyeUsedCounter++;
        Controller.cont.fc.SetIntegerVariable("eyeUsedCounter", Controller.cont.eyeUsedCounter);
    }

	void ColleenCallController()
	{
		Controller.cont.getCurrentMap();
		Controller.cont.spokeToColleen = true;
		Controller.cont.fc.SetBooleanVariable("spokeToColleen", Controller.cont.spokeToColleen);
	}

	void ColleenConfessionCallController()
	{
		Controller.cont.getCurrentMap();
		Controller.cont.colleenConfessed = true;
		Controller.cont.fc.SetBooleanVariable("colleenConfessed", Controller.cont.colleenConfessed);
	}

	void EllenCallController()
	{
		Controller.cont.getCurrentMap();
		Controller.cont.spokeToEllen = true;
		Controller.cont.fc.SetBooleanVariable("spokeToEllen", Controller.cont.spokeToColleen);
	}




	//Use this when starting a new scene to update the value for how often the Eye has been used from previous scenes
    void UpdateCounter()
    {
        Controller.cont.getCurrentMap();
        Controller.cont.fc.SetIntegerVariable("eyeUsedCounter", Controller.cont.eyeUsedCounter);
    }

	void ColleenUpdateCounter()
	{
		Controller.cont.getCurrentMap();
		Controller.cont.fc.SetBooleanVariable("spokeToColleen", Controller.cont.spokeToColleen);
	}

	void ColleenConfessionUpdateCounter()
	{
		Controller.cont.getCurrentMap();
		Controller.cont.fc.SetBooleanVariable("colleenConfessed", Controller.cont.colleenConfessed);
	}

	void EllenUpdateCounter()
	{
		Controller.cont.getCurrentMap();
		Controller.cont.fc.SetBooleanVariable("spokeToEllen", Controller.cont.spokeToEllen);
	}

}
