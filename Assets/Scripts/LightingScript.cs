using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightingScript : MonoBehaviour
{
    public bool active;
    public GameObject lightingWindow;

    public void OpenAndClose(){
        if(active == false){
            lightingWindow.transform.gameObject.SetActive(true);
            active = true;
        } 
        else{
            lightingWindow.transform.gameObject.SetActive(false);
            active=false;
        }
    }

}
