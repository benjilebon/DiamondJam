﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pnj_Trigger : MonoBehaviour
{
    public Pnj pnj;                 //Choix du pnj 
    public SphereCollider sphere;   //Collider désigné
    public Vector3 scale;           //Taille de la zone dangereuse
    

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(pnj.transform.position.x, pnj.transform.position.y, pnj.transform.position.z);
        sphere = GetComponent<SphereCollider>();
        this.transform.localScale = scale;
    }

    // Update is called once per frame
    void Update()
    {
        Follow();
    }


    public void Follow()
    {
        transform.position = new Vector3(pnj.transform.position.x, pnj.transform.position.y, pnj.transform.position.z);
    }
    

}
