using UnityEngine;
using System.Collections;

public class ChangeColor : MonoBehaviour {
    Renderer render;
	// Use this for initialization
	void Start () {
        render = GetComponent<Renderer> ();
	}
	
	// Update is called once per frame
	void Update () {
	    if(Input.GetKeyDown(KeyCode.G))
        {
            render.material.color = Color.green;
        }
	}
}
