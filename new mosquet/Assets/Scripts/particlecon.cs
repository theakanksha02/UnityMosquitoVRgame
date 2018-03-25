using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class particlecon : MonoBehaviour {


	void Start () {
        GetComponent<ParticleSystem>().enableEmission = true;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
