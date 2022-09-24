using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getPoints : MonoBehaviour
{
    public static int Score = 0;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "teste")
        {
            KeepScore.Score += 100;
            Debug.Log("Yeah");
            Destroy(collision.gameObject);
        }
    }
}


