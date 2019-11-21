using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {

    [SerializeField] float minX = 1f;
    [SerializeField] float maxX = 15f;
    [SerializeField] float screenWidthInUnits = 16f;


    // Start is called before the first frame update
    void Start()
    {
        // transform.position = new Vector2(8f, 0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        float mousePosInUnits = Input.mousePosition.x / Screen.width * screenWidthInUnits;

        // Vector 2 defines the position of the object

        

        Vector2 paddlePos = new Vector2();


        if (mousePosInUnits < minX)
        {
            mousePosInUnits = minX;
        }
        else if (mousePosInUnits > maxX)
        {
            mousePosInUnits = maxX;
        }


        paddlePos.x = mousePosInUnits;
        // paddlePos.x = Mathf.Clamp(mousePosInUnits, minX, maxX);
        paddlePos.y = transform.position.y;

        Debug.Log("BEFORE --- Mouse " + mousePosInUnits + " PX " + paddlePos.x);

        

        /* 
        if (paddlePos.x < minX)
        {
            paddlePos.x = minX;
        }
        else if (paddlePos.x > maxX)
        {
            paddlePos.x = maxX;
        } 

        

        Debug.Log("AFTER --- Mouse " + mousePosInUnits + " PX " + paddlePos.x);
        */


        // transform is connected to the transform settings of the object in Unity, and tells to move to the specified position 
        transform.position = paddlePos;
    }
}
