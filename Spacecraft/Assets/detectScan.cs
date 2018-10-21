using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detectScan : MonoBehaviour {

    public GameObject scanner;
    RotateAngle rotateangle;
	// Use this for initialization
	void Start () {
        rotateangle = scanner.GetComponent<RotateAngle>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Collision");
        rotateangle.ischecked = !rotateangle.ischecked;
    }
}
