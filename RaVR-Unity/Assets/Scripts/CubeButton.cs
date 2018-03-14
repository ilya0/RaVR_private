using HoloToolkit.Unity.InputModule;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CubeButton : MonoBehaviour, IInputClickHandler {

    public int buttonNum; //sets which button this is
    public GameObject player;

    public void OnInputClicked(InputClickedEventData eventData)
    {
        print("OIRJG");

        int set = 0;
        if (buttonNum + 1 > player.GetComponent<AudioManager>().oneDClip.Length / 2)
            set = 1;

        StartCoroutine(player.GetComponent<AudioManager>().setClip(set, (int)(buttonNum / 2)));
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
