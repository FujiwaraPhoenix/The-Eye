using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class Controller : MonoBehaviour {
    public Flowchart fc;
    public static Controller cont;
    public Clickable2D c2d;
    public int eyeUsedCounter;
	// Use this for initialization
    public void getCurrentMap()
    {
        GameObject go = GameObject.FindGameObjectWithTag("Flowchart");
        fc = go.GetComponent<Flowchart>();
        GameObject eye = GameObject.FindGameObjectWithTag("Eye");
        c2d = eye.GetComponent<Clickable2D>();
    }

    void Awake()
    {
        if (cont == null)
        {
            DontDestroyOnLoad(gameObject);
            cont = this;
        }
        else if (cont != this)
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update () {
        if (fc != null)
        {
            eyeUsedCounter = fc.GetIntegerVariable("eyeUsedCounter");
        }
        else
        {
            getCurrentMap();
        }
        if (c2d != null)
        {
            bool tempBool = fc.GetBooleanVariable("hideEye");
            SpriteRenderer sr = c2d.GetComponent<SpriteRenderer>();
            sr.enabled = !tempBool;
        }
    }
}
