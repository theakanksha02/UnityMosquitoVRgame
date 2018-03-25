using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flyingmosquito : MonoBehaviour
{

    private Vector3 target;
    private float timer;
    private int sec;


    private float xScreen = 8.0f;// Half of Left to right 
    private float yScreen = 2.0f;// Half of top to bottom
    private float zScreen = 8.0f;// Half of Front to back

    void Start()
    {
        target = ResetTarget();
        sec = ResetSec();

    }
    void destroyObj()
    {
        Destroy(gameObject);
    }



    void Update()
    {
        //Debug.Log("Before"+transform.position);
        Vector3 beforePosition = transform.position;
        timer += Time.deltaTime;
        if (timer > sec)
        {
            target = ResetTarget();
            sec = ResetSec();

        }
        Vector3 translatePos = target * 5 * Time.deltaTime;
        Vector3 afterPos = translatePos + beforePosition;
        if (afterPos.y < 1.5f)
        {
            translatePos.y = 0.00000001f;
        }
        if (afterPos.y > yScreen)
        {
            translatePos.y = -0.00000001f;
        }
        if (afterPos.x > xScreen)
        {
            translatePos.x = -0.00000001f;
        }
        if (afterPos.x < -xScreen)
        {
            translatePos.x = 0.00000001f;
        }

        if (afterPos.z > zScreen)
        {
            translatePos.z = -0.00000001f;
        }
        if (afterPos.z < -zScreen)
        {
            translatePos.z = 0.00000001f;
        }

        transform.Translate(translatePos);
        //Debug.Log("After" + transform.position);
    }
    Vector3 ResetTarget()
    {
        return new Vector3(Random.Range(-1.0f, 1.0f), Random.Range(-1.0f, 1.0f), Random.Range(-1.0f, 1.0f));
        //return new Vector3(Random.Range(-1.0f, 1.0f), Random.Range(-1.0f, 1.0f), 0);
    }
    int ResetSec()
    {
        timer = 0;
        return Random.Range(1, 3);
    }
}


