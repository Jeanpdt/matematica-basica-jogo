﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveOnlyOnXDirection : MonoBehaviour
{
    public GameObject Target;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Target.transform.position.Set(Target.transform.position.x, 0.0f, Target.transform.position.z);
    }
}
