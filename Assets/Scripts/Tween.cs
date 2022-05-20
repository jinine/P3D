using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tween : MonoBehaviour
{
    public GameObject OpenMenu;

    public void CloseMenu(){
         LeanTween.moveX(OpenMenu,170.0f, 1.0f);
    }
}
