using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnmos : MonoBehaviour {

    public GameObject[] mos;
    public Transform spawnPos;
    int RandMos;

   
    private void Update()
    {
        SpawnRandom();
    }

    void SpawnRandom()
    {
        RandMos = Random.Range(30, 40);
        Instantiate(mos[RandMos], spawnPos.position, spawnPos.rotation);
    }
}
