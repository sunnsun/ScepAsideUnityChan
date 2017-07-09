using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinController : MonoBehaviour {

    public GameObject mainCamera;

    // Use this for initialization
    void Start() {
        this.transform.Rotate(0, Random.Range(0, 360), 0);

    }

    // Update is called once per frame
    void Update() {
        this.transform.Rotate(0, 3, 0);
        this.mainCamera = GameObject.Find("Main Camera");
        
        if(gameObject.transform.position.z < this.mainCamera.transform.position.z)
        {
            Destroy(gameObject);
        }
    }
}