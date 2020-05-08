﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VirtualButtonScript : MonoBehaviour, IVirtualButtonEventHandler
{
  public GameObject cube;
  VirtualButtonBehaviour vrb;

    // Start is called before the first frame update
    void Start()
    {
     vrb= GetComponentInChildren<VirtualButtonBehaviour>();
     vrb.RegisterEventHandler(this);
     cube.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
      cube.SetActive(true);
    }
    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
      cube.SetActive(false);
    }
}
