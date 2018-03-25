using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnmosquito : MonoBehaviour {


    public GameObject mosq;                // The mosquito prefab to be spawned.
    public float spawnTime =3f;            // How long between each spawn.
    public Transform[] spawnPoints;     // An array of the spawn points this mosquito can spawn from.
    Vector3[] spawnPosition;
    void Start()
    {
        
        // Call the Spawn function after a delay of the spawnTime and then continue to call after the same amount of time.
        InvokeRepeating("Spawn", spawnTime, spawnTime);
      
        
    }

    void Spawn() 
    {
       // spawnPosition = new Vector3(-9.75f, 0.9f, -0.69f);
        // Find a random index between zero and one less than the number of spawn points.
        
        int spawnPointIndex = Random.Range(0, spawnPoints.Length);
        Debug.Log(spawnPointIndex + " " + spawnPoints[spawnPointIndex].transform.position);
        Instantiate(mosq, spawnPoints[spawnPointIndex].position, Quaternion.identity);
        //Debug.Log(Instantiate(mosq, spawnPoints[spawnPointIndex].transform.position, spawnPoints[spawnPointIndex].transform.rotation));
        //Debug.Log(spawnPoints[spawnPointIndex].transform.position);
        // Create an instance of the enemy prefab at the randomly selected spawn point's position and rotation.

    }

}
