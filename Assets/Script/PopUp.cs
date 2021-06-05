using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopUp : MonoBehaviour
{
    public GameObject pop;
    public GameObject tulang;
    public bool aktif;
    public bool aktifTulang;
    float tanda = 0;
    float rotSpeed = 20;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void OnMouseDown(){
        if(tanda == 1){
        pop.SetActive(aktif);
        tulang.SetActive(aktifTulang);
        }
    }

    void OnMouseDrag(){
        if(tanda == 0){
        float rotX = Input.GetAxis ("Mouse X")*rotSpeed*Mathf.Deg2Rad;
        float rotY = Input.GetAxis ("Mouse Y")*rotSpeed*Mathf.Deg2Rad;

        transform.RotateAround(Vector3.up, -rotX);
        transform.RotateAround(Vector3.up, -rotY);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
