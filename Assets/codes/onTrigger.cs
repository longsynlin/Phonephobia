using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class onTrigger : MonoBehaviour
{

    public Animator animator = null;
    private bool isOpen = false;

    void OnTriggerEnter(Collider collider)
    {
        if (collider.CompareTag("hand")){
        //if (collider.name == "Room_Traditional_Door_Handle_Knob"){
            if (isOpen){
                animator.SetBool("open", false);
            }else{
                animator.SetBool("open", true);
            }
            isOpen = !isOpen;
         }
         if (collider.name == "Plant_A"){
            //Debug.Log("hit");
            SceneManager.LoadScene("scene3");
         }
    }

}



