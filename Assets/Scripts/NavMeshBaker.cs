﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class NavMeshBaker : MonoBehaviour
{

    [SerializeField]
    NavMeshSurface[] navMeshSurfaces;
    // Use this for initialization
    void Start()
    {
        for(int i = 0; i < navMeshSurfaces.Length; i++)
        {
            navMeshSurfaces[i].BuildNavMesh() ;
        }
    }

}