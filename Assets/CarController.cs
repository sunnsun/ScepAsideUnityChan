using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour {

    public GameObject mainCamera;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        this.mainCamera = GameObject.Find("Main Camera");
        if (gameObject.transform.position.z < this.mainCamera.transform.position.z)
        {
            Destroy(gameObject);
        }
    }
}
