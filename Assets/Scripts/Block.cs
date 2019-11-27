﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    [SerializeField] AudioClip breakSound;

    Level level;
 
    private void OnCollisionEnter2D(Collision2D collision)
    {
        AudioSource.PlayClipAtPoint(breakSound, Camera.current.transform.position);
        Destroy(gameObject);

    }

    // Start is called before the first frame update
    void Start()
    {
        level = FindObjectOfType<Level>();
        level.CountBreakableBlocks();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   

}
