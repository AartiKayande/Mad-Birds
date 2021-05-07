﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    [SerializeField] private GameObject _cloudParticlePrefab;


    //[SerializeField] private GameObject crate;

   
   // private bool crateFallOnMonster;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Bird bird = collision.collider.GetComponent<Bird>();
        if (bird != null ) //|| crateFallOnMonster == false)

        {
            Instantiate(_cloudParticlePrefab, transform.position, Quaternion.identity);

            Destroy(gameObject);
            return;
        }
       /* elseif (crateFallOnMonster == false)
        { 
             Destroy(gameObject);
            return;
        }*/
        Enemy enemy = collision.collider.GetComponent<Enemy>();
        if(enemy != null)
        {
            return;
        }

       if(collision.contacts[0].normal.y < -0.5)
        {
            Instantiate(_cloudParticlePrefab, transform.position, Quaternion.identity);
            Destroy(gameObject);
           
        }
    }
   }
