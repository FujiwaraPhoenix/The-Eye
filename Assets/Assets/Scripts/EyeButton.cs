using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EyeButton : MonoBehaviour {
    public SpriteRenderer spr;
    public Sprite normal, hovered;

	// Use this for initialization
	void Start () {
        spr = GetComponent<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnMouseOver()
    {
        spr.sprite = hovered;
    }

    private void OnMouseExit()
    {
        spr.sprite = normal;
    }
}
