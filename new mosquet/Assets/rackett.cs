using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rackett : MonoBehaviour {

    public GameObject[] rackets;
    // Use this for initialization
    void Start()
    {

        for (int i = 0; i < rackets.Length; i++)
        {
            rackets[i].SetActive(false);
        }

        Debug.Log(PlayerPrefs.GetInt("racket"));
        rackets[PlayerPrefs.GetInt("racket") - 1].SetActive(true);

    }

    // Update is called once per frame
    void Update()
    {

    }
}
