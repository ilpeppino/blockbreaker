using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {

    [SerializeField] float minore = 1f;
    [SerializeField] float maggiore = 15f;
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

        Vector2 paddlePos = new Vector2();
        paddlePos.x = Mathf.Clamp(mousePosInUnits, minore, maggiore);
        paddlePos.y = transform.position.y;

        transform.position = paddlePos;

        // Vector 2 defines the position of the object
        // Debug.Log("BEFORE --- Mouse " + mousePosInUnits + " ABS " + Input.mousePosition.x);
        /*
        if (mousePosInUnits < minore)
        {
            mousePosInUnits = minore;
        }
        else if (mousePosInUnits > maggiore)
        {
            mousePosInUnits = maggiore;
        }
        */
        // Debug.Log("AFTER --- Mouse " + mousePosInUnits + " ABS " + Input.mousePosition.x);
        // paddlePos.x = mousePosInUnits;







        // transform is connected to the transform settings of the object in Unity, and tells to move to the specified position 

    }
}
