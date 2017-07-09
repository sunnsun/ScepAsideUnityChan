using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGenerator : MonoBehaviour {
    public GameObject carPrefab;
    public GameObject coinPrefab;
    public GameObject conePrefab;
    private int startPos = -160;
    private int goalPos = 120;
    private float posRange = 3.4f;

    //public GameObject unitychan;
    //public GameObject gameobject;

  

    

	// Use this for initialization
	void Start () {

        for (int i = startPos; i < goalPos; i += 15) 
        {
            int num = Random.Range(0, 10);
            if(num <= 1)
            {
                for(float j = -1;j <= 1; j += 0.4f)
                {
                    GameObject cone = Instantiate(conePrefab) as GameObject;
                    cone.transform.position = new Vector3(4 * j, cone.transform.position.y, i);
                    

                }
            }
            else
            {
                for(int j = -1;j < 2; j++)
                {
                    int item = Random.Range(1, 11);
                    int offsetZ = Random.Range(-5, 6);
                    if(1 <= item && item <= 6)  //１以上６以下の数字の場合、
                    {
                        GameObject coin = Instantiate(coinPrefab) as GameObject;
                        coin.transform.position = new Vector3(posRange * j, coin.transform.position.y, i + offsetZ);

                    }else if (7 <= item && item <= 9)
                    {
                        GameObject car = Instantiate(carPrefab) as GameObject;
                        car.transform.position = new Vector3(posRange * j, car.transform.position.y, i + offsetZ);
                        
                    }
                }
            }
        }
		
	}

    // Update is called once per frame
    void Update() { }
   // { //this.unitychan = GameObject.Find("unitychan");
        //GameObject coin = Instantiate(coinPrefab) as GameObject;
        //if(this.coinPrefab.transform.position.z < this.unitychan.transform.position.z)
       // {
        //    Destroy(this.coinPrefab);
        //}
    //
        //GameObject car = Instantiate(carPrefab) as GameObject;
       // GameObject cone = Instantiate(conePrefab) as GameObject;
       // GameObject gameobject = Instantiate(None(GameObject)) as GameObject;
        
        
        //this.gameobject = GameObject.Find("carPrefab,coinPrefab,TraffiConePrefab");
        
        //if(gameobject.transform.position.z < this.unitychan.transform.position.z);
        //{
        //    Destroy(gameobject);

        }
    
  

        //this.unitychan = GameObject.Find("unitychan");
        //Debug.Log(unitychan.transform.position.z);

        //this.carPrefab = GameObject.Find("carPrefab");
        //Debug.Log(carPrefab.transform.position.z);
        //if(gameObject.transform.position.z < this.unitychan.transform.position.z)
        //{
        //    Destroy(gameObject);
        //}


        //if(carPrefab.transform.position.z < this.unitychan.transform.position.z)
        //{
        //    Destroy(gameObject);
  