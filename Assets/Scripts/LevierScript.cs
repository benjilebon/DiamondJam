﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class LevierScript : MonoBehaviour
{
    public bool Activation = false;
    [SerializeField] private Transform ObjetInteragir;
    [SerializeField] private Sas_Script sas_Script;

    // Start is called before the first frame update
    void Start()
    {
        //sas_Script = ObjetInteragir.GetComponent<Sas_Script>();

        Debug.Log(sas_Script);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void InteractionSas()
    {
        if (!sas_Script.Ouvert)
        {
            sas_Script.Ouvert = true;
        }
        else
        {
            sas_Script.Ouvert = false;
        }

    }
}
