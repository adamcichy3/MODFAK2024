using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : MonoBehaviour
{
    float score = 0;
    private void OnCollisionEnter(Collision collision)
    {
       
        if (collision.gameObject.tag == "Coins")
        {
            Destroy(collision.gameObject);
            score++;
            Debug.Log("Zdobyto " + score + "punkty");
        }
    }

}
