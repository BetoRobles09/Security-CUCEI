using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour {

    public GameObject prefab;
    public Transform head;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        
        if (Input.GetButton("Fire1"))
        {
            GameObject.Instantiate(prefab, head.position, head.rotation);
        }
	}
}
