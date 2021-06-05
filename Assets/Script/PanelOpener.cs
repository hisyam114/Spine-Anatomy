using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelOpener : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Panel;
    public GameObject Button;
    public void OpenPanel()
    {
        if (Panel != null)
        {
            bool isActive = Panel.activeSelf;
            Panel.SetActive(!isActive);
            Button.SetActive(isActive);
        }
    }

    // public void OpenPanelHideBack()
    // {
    //     if (Panel != null)
    //     {
    //         bool isActive = Panel.activeSelf;
    //         Panel.SetActive(!isActive);
    //         button.SetActive(!isActive);
    //     }
    // }
}
