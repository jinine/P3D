using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwap : MonoBehaviour
{
    public GameObject firsPersonCameraHolder;
    public GameObject overheadCameraHolder;
    public Camera firstPersonCamera;
    public Camera overheadCamera;


   public void activate(){
       if(firstPersonCamera.enabled){
           ShowOverheadView();
       } else if(overheadCamera.enabled){
           ShowFirstPersonView();
       }
   }

    public void ShowOverheadView() {
        firstPersonCamera.enabled = false;
        firsPersonCameraHolder.SetActive (false);
        overheadCamera.enabled = true;
        overheadCameraHolder.SetActive (true);
    }
    
    public void ShowFirstPersonView() {
        firstPersonCamera.enabled = true;
        firsPersonCameraHolder.SetActive (true);
        overheadCamera.enabled = false;
        overheadCameraHolder.SetActive (false);
    }
}
