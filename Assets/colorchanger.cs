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
        rend.material.color = Color();
    }

    public void MakeVelvet(){
        GetComponent<Renderer>().materials[1]=Velvet;
    }
     public void MakeLeather(){
        GetComponent<Renderer>().materials[1]=Leathery;
    }
}
