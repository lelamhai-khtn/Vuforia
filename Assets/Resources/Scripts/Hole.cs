using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hole : MonoBehaviour {
    public GameObject mole;
    public float aliveTime = 1f;

    public int intervalMin = 2;
    public int intervalMax = 10;
	// Use this for initialization
	void Start () {
        Invoke("Spawn", Random.Range(intervalMin, intervalMax));
    }
	
	void Spawn()
    {
        GameObject g = (GameObject)Instantiate(mole, transform.position, Quaternion.identity);
        Destroy(g, aliveTime);
        Invoke("Spawn", Random.Range(intervalMin, intervalMax));
    }
}
