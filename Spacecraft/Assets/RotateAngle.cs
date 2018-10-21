using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAngle : MonoBehaviour {
    // Use this for initialization
    public GameObject box;
    public bool ischecked;
	void Start () {

	}
    float angle = -0.2f;
	// Update is called once per frame
	void Update() {
        if (Input.GetKeyDown("space"))
        {
            angle = -angle;
        }
        transform.RotateAround(box.transform.position, transform.forward, angle);
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Collision");
        ischecked = !ischecked;
    }
}
