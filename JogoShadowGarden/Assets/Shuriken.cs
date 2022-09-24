using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shuriken : MonoBehaviour
{

    GameObject shurikenPosObj;
    Vector3 shurikenPos;
    bool isMoving;
    Vector3 startMarker;
    public float speed = 5;
    float startTime;
    float journeyLength;
    bool collected;


    private void Update()
    {
        if (isMoving)
        {
            float distCovered = (Time.time - startTime) * speed;


            float fractionOfJourney = distCovered / journeyLength;
            transform.position = Vector3.Lerp(startMarker, shurikenPosObj.transform.position, fractionOfJourney);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Collect(other);
    }

    private void Collect(Collider other)
    {
        if (collected)
            return;

        if (other.gameObject.CompareTag("Player"))
        {
            collected = true;
            shurikenPosObj = GameObject.FindGameObjectWithTag("ShurikenPos");
            shurikenPos.Set(shurikenPosObj.transform.position.x, shurikenPosObj.transform.position.y, shurikenPosObj.transform.position.z);
            startMarker = transform.position;
            startTime = Time.time;
            journeyLength = Vector3.Distance(startMarker, shurikenPosObj.transform.position);
            isMoving = true;
            Destroy(gameObject, 1);
            Collider[] colliders = GetComponents<Collider>();
            for (int i = 0; i < colliders.Length; i++)
            {
                colliders[i].enabled = false;
            }
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        Collect(collision.collider);
    }
}

/*
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shuriken : MonoBehaviour
{
    
    Vector3 shurikenPos;
    GameObject shurikenPosObj;
    bool isMoving;

    Vector3 startMarker;
    Vector3 endMarker;

    public float speed = 1.0F;

    float startTime;

    float journeyLength;

    private void Update()
    {
        if (isMoving)
            {
                float distCovered = (Time.time - startTime) * speed;

                float fractionOfJourney = distCovered / journeyLength;

                transform.position = Vector3.Lerp(startMarker.position, endMarker.position, fractionOfJourney);
             }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            shurikenPosObj = GameObject.FindGameObjectWithTag("ShurikenPos");
            shurikenPos.Set(shurikenPosObj.transform.position.x, shurikenPosObj.transform.position.y, shurikenPosObj.transform.position.z);
            startMaker = shurikenPos;
            startTime = Time.time;
            journeyLength = Vector3.Distance(startMarker.position, endMarker.position);
        }
    }
}
*/