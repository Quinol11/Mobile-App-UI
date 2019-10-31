using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideObject : MonoBehaviour
{
    public GameObject[] Furnitures;
    public static int k;//k is the index of the number that is actually shown
    
    // Start is called before the first frame update
    void Start()
    {
    
        
    }

    // Update is called once per frame
    void Update()
    {
        for(int i = 0; i < 2; i++){
         Furnitures[i].GetComponent<Renderer>().enabled = false;
        }

        Show_Object(k);
    }

    void Show_Object(int k){
        Furnitures[k].GetComponent<Renderer>().enabled = true ;
    }
}
