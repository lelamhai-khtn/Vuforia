using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mole : MonoBehaviour {
    public GameObject onHit;
    private void OnMouseDown()
    {
        GameObject g = (GameObject)Instantiate(onHit,transform.position,Quaternion.identity);
        Destroy(g, 0.2f);
    }
}
