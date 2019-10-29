using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colorchanger : MonoBehaviour
{
    public Material Velvet;
    public Material Leathery;
    private Renderer rend; 
    [SerializeField]

    public void ToWhite(){
        rend = GetComponent<Renderer>();
        rend.material.color = Color.white;
    }
    public void ToRosy(){
        rend = GetComponent<Renderer>();
        rend.material.color = Color.red;
    }

    public void MakeVelvet(){
        GetComponent<Renderer>().materials[0]=Velvet;
    }
     public void MakeLeather(){
        GetComponent<Renderer>().materials[0]=Leathery;
    }
}
