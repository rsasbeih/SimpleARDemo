﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Show : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Appear()
    {
        gameObject.SetActive(true);
    }
    public void Dissappear()
    {
        gameObject.SetActive(false);
    }
}
