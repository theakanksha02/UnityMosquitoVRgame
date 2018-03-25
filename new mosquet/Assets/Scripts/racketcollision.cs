using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class racketcollision : MonoBehaviour {
    private Vector3 screenPoint;
    private Vector3 offset;
    private GameObject[] mosqui;
    //public Transform spark;
    private int count;
    public GameObject counttext;
    public ParticleSystem ps;
   public bool moduleEnabled;
    public GameObject controllerLeft;
    private SteamVR_TrackedObject trackedobj;
    private SteamVR_Controller.Device device;
    float InstantiationTimer;
    public GameObject time;
    public float timeLeft;
   

    



    // Use this for initialization
    void Start()
    {
        //spark.GetComponent<ParticleSystem>().enableEmission = false;
        //counttext.GetComponent<TextMesh>();
        trackedobj = controllerLeft.GetComponent<SteamVR_TrackedObject>();
        ps = GetComponent<ParticleSystem>();
        count = 0;
        counttext.GetComponent<TextMesh>().text = "Count: " + count.ToString();
       
    }


    void Update()
    {
        if (InstantiationTimer > 0)
            ShowHaptic();
        InstantiationTimer -= Time.deltaTime;
    }

    private void FixedUpdate()
    {
        timeLeft -= Time.deltaTime;
        if(timeLeft<0)
        {
            timeLeft = 0;

            SceneManager.LoadScene("gameover");
        }
        time.GetComponent<TextMesh>().text = "Time Left: " + Mathf.RoundToInt(timeLeft);
    }

    void OnTriggerEnter(Collider TheColliderThatIWillBeCollidingWith)
    {
        if (TheColliderThatIWillBeCollidingWith.tag == "mos")
        {
            Debug.Log("destroy mos...");
            Destroy(TheColliderThatIWillBeCollidingWith.gameObject);
            count = count + 1;
            counttext.GetComponent<TextMesh>().text = "Count:" + count.ToString();
           
            // spark.GetComponent<ParticleSystem>().emission.enabled = true;
            //var emission = ps.emission;
            //emission.enabled = moduleEnabled;

            GameObject.Find("Ingredient-ExplosionType-ExplosionFlash").GetComponent<ParticleSystem>().enableEmission = true;
            //ps.Play();
            Debug.Log("destroy m...");
            StartCoroutine(stopspark());

            InstantiationTimer = 0.5f;
           
        }
       
    }

   



    IEnumerator stopspark()
    {
        yield return new WaitForSeconds(.4f);
        GameObject.Find("Ingredient-ExplosionType-ExplosionFlash").GetComponent<ParticleSystem>().enableEmission = false;

    }

    void ShowHaptic()
    {
        device = SteamVR_Controller.Input((int)trackedobj.index);
        device.TriggerHapticPulse(500);
    }

}
