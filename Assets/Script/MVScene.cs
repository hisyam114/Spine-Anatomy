using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MVScene : MonoBehaviour
{
    public void Scene(string name){   
        SceneManager.LoadScene(name);
    }
}
