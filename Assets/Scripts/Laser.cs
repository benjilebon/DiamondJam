﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    public bool activation = false;
    private LineRenderer lr;

    // Start is called before the first frame update
    void Start()
    {
        lr = GetComponent<LineRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (activation)
        {
            lr.enabled = true;
            lr.SetPosition(0, transform.position);
            RaycastHit hit;
            if (Physics.Raycast(transform.position, transform.forward, out hit))
            {
                if (hit.collider)
                {
                    lr.SetPosition(1, hit.point);

                    if(hit.collider.tag == "Pnj")
                    {
                        
                        hit.collider.gameObject.transform.GetComponent<Pnj>().timeDead = hit.collider.gameObject.transform.GetComponent<Pnj>().timeLaserDeath;
                        hit.collider.gameObject.transform.GetComponent<Pnj>().laser =  true;
                        
                    }

                    if(hit.collider.tag == "Player")
                    {
                        Debug.Log("Touché Player");
                        hit.collider.gameObject.transform.GetComponent<Player>().enVie = false;
                    }
                }
            }
            else lr.SetPosition(1, transform.position + (transform.forward * 5000));
        }
        else
        {
            lr.enabled = false;
        }
    }
    
}

