﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField] GameObject projectile, gun;
    AttackerSpawner myLaneSpawner;
   public void Fire()
    {
        Instantiate(projectile, gun.transform.position, gun.transform.rotation);
    }

    public void Start()
    {
        SetLaneSpawner();
    }
    public void Update()
    {
        if(IsAttackerInLane())
        {
            Debug.Log("shoot pew pew");
            // Change animation state to shooting
        }
        else
        {
            Debug.Log("sit and wait"); 
            // change animation state to idle animation
        }
    }

    private void SetLaneSpawner()
    {
        AttackerSpawner[] spawners = FindObjectsOfType<AttackerSpawner>();

        foreach(AttackerSpawner spawner in spawners)
        {
            bool IsCloseEnough = (Mathf.Abs(spawner.transform.position.y - transform.position.y) <= Mathf.Epsilon);
            if (IsCloseEnough)
            {
                myLaneSpawner = spawner;
            }
        }
    }

    private bool IsAttackerInLane()
    {
        if(myLaneSpawner.transform.childCount <= 0)
        {
            return false;
        }
        else
        {
            return true;
        }
    }
}
