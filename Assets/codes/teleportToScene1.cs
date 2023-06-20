using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class teleportToScene1 : MonoBehaviour
{
    
    void OnTriggerEnter(Collider collider)
    {
         if (collider.name == "collide"){
            Debug.Log("hit");
            SceneManager.LoadScene("3-0HomeScene");
         }
    }

}



