using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {

    public GameObject[] UserList;
    private GameObject target;
    private float speed = 1;
    private float mod = 0.01F;


	// Use this for initialization
	void Start () {
        target = UserList[(int)(Random.value * UserList.Length)];
        transform.LookAt(target.transform);
    }
	
	// Update is called once per frame
	void Update () {
        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, target.transform.position, step);
        transform.Rotate(new Vector3(2,1,3));
        transform.SetPositionAndRotation(new Vector3(transform.position.x + (Random.value * 2 - 1)*mod, transform.position.y + (Random.value * 2 - 1) * mod, transform.position.z + (Random.value * 2 - 1) * mod), transform.rotation);
    }
}
