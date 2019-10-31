using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Passer : MonoBehaviour
{
    public static int k;
//    DontDestroyOnLoad(this.gameObject);
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     public void Pass_Sofa1(){
        HideObject.k = 0 ;
    }
    public void Pass_Arm1(){
        HideObject.k = 1 ;
        

    
    }
}
