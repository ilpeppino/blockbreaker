using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    [SerializeField] AudioClip breakSound;
    Level level;


    private void OnCollisionEnter2D(Collision2D collision)
    {
        DestroyBlock();

    }

    private void DestroyBlock()
    {
        AudioSource.PlayClipAtPoint(breakSound, Camera.current.transform.position);
        Destroy(gameObject);
        level.BlockDestroyed();
        FindObjectOfType<GameStatus>().AddToScore();
    }

    // Start is called before the first frame update
    void Start()
    {
        // At each instance of Block, this Start will be called and add one block through the CountBreakableBlocks function
        level = FindObjectOfType<Level>();
        level.CountBreakableBlocks();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   

}
