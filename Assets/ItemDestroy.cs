using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDestroy : MonoBehaviour {
    public GameObject carPrefab;
    public GameObject coinPrefab;
    public GameObject conePrefab;
    private GameObject unitychan;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        this.unitychan = GameObject.Find("unitychan");
        GameObject cone = Instantiate(conePrefab) as GameObject;
        if (cone.transform.position.z < this.unitychan.transform.position.x)
        {
            Destroy(cone);
        }
        GameObject coin = Instantiate(coinPrefab) as GameObject;
        if (coin.transform.position.z < this.unitychan.transform.position.x)
        {
            Destroy(coin);
        }
        GameObject car = Instantiate(carPrefab) as GameObject;
        if (car.transform.position.z < this.unitychan.transform.position.x)
        {
            Destroy(car);
        }
       
    }
}
