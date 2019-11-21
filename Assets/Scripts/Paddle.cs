using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour { 

    [SerializeField] float screenWidthInUnits = 16f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float mousePosInUnitsInputs = Input.mousePosition.x / Screen.width * screenWidthInUnits;

        // Vector 2 defines the position of the object
        // Vector2 paddlePos = new Vector2(mousePosInUnitsInputs, transform.position.y);

        Vector2 paddlePos = new Vector2(Input.mousePosition.x, transform.position.y);

        // transform is connected to the transform settings of the object in Unity, and tells to move to the specified position 
        transform.position = paddlePos;
    }
}
