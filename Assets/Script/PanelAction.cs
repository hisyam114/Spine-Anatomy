﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelAction : MonoBehaviour
{
    public GameObject Panel;
    public void OpenPanel(){
        if(Panel != null){
            bool isActive = Panel.activeSelf;
            Panel.SetActive(!isActive);
        }
    }
    public void ClosePanel(){
        if(Panel != null){
            Panel.SetActive(false);
        }
        //Panel.gameObject.SetActive (false);
    }
}
