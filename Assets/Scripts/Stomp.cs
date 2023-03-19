using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stomp : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D trigger)
    {
        if (trigger.gameObject.name == "FeetPos")
        {
            Score.currScore += 1;
            Destroy(transform.parent.gameObject);
        }
    }
}
