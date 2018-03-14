using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowButtonsFacing : MonoBehaviour {

    public GameObject[] children;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        for (int i = 0; i < children.Length; i++) {
            Vector3 start = transform.position;
            Vector3 end = children[i].transform.position;
            Vector3 dir = new Vector3(transform.eulerAngles.x, Vector3.Angle(start, end), transform.eulerAngles.z);

            if (Physics.Raycast(transform.position, dir, 10))
                print("There is something in front of the object!");
        }
	}
}
