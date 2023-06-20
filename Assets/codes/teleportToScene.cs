using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class teleportToScene : MonoBehaviour
{
    
    void OnTriggerEnter(Collider collider)
    {
         if (collider.name == "Rug_Rect_Gray"){
            Debug.Log("hit");
            SceneManager.LoadScene("2StreetScene");
         }
    }

}



