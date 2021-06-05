using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void GoToScene(string name){
        SceneManager.LoadScene(name);
    }
    public void ClickQuit(){
        Application.Quit();
        print("Berhasil Quit");
    }
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
