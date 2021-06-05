using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelClose : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Panel;
    public GameObject Button;
    public void OpenPanel()
    {
        if (Panel != null)
        {
            Panel.SetActive(false);
            Button.SetActive(true);
        }
    }
}
