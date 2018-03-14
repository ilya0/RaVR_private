using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {

    public GameObject[] UserList;
    private float speed = 2;
    private float mod = 0.01F;
    float mover;
    float timer = 5;
    


    // Use this for initialization
    void Start () {
        mover = Random.value * 1 - 0.5F;
    }
	
	// Update is called once per frame
	void Update () {
        float step = speed * Time.deltaTime;
        transform.Rotate(new Vector3(2,1,1));
        transform.SetPositionAndRotation(new Vector3(transform.position.x + mover*0.1F, transform.position.y, transform.position.z+step), transform.rotation);
    }
}
