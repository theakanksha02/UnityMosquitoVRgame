using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class optionsmenu : MonoBehaviour {

    public GameObject rco;
    public GameObject rct;
    public GameObject rcth;
    public void racketone()

    {
        Debug.Log("chk");
        rco.SetActive(true);
        rct.SetActive(false);
        rcth.SetActive(false);
        PlayerPrefs.SetInt("racket", 1);
        //GameObject.Find ("Hockey Gates model").GetComponentInChildren<Button> ().interactable = true;


    }

    public void rackettwo()
    {
        Debug.Log("mm");
        rct.SetActive(true);
        rco.SetActive(false);
        rcth.SetActive(false);
        PlayerPrefs.SetInt("racket", 2);
        //GameObject.Find ("TennisReket").GetComponentInChildren<Button> ().interactable = true;
    }

    public void racketthree()

    {
        Debug.Log("chk");
        rcth.SetActive(true);
        rco.SetActive(false);
        rct.SetActive(false);
     
        PlayerPrefs.SetInt("racket", 3);
        //GameObject.Find ("Hockey Gates model").GetComponentInChildren<Button> ().interactable = true;


    }
}
