using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if(other.GameObject.CompareTag("Player"))
        {
          Debug.Log("Player collected a coin");
          Destroy(this.GameObject);
        }
    }

   
}