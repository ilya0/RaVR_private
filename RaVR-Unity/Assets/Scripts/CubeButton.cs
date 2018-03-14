using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeButton : MonoBehaviour {

    public int buttonNum; //sets which button this is
    public GameObject player;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnMouseDown()
    {
        int set = 0;
        if (buttonNum + 1 > player.GetComponent<AudioManager>().oneDClip.Length / 2)
            set = 1;

        StartCoroutine(player.GetComponent<AudioManager>().setClip(set,(int)(buttonNum/2)));
    }
}
