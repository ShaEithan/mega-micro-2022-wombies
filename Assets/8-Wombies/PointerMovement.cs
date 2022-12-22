using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Script to Move The Pointer from Each Hat
namespace Wombies
{
    public class PointerMovement : MonoBehaviour
    {
        Vector2 newPosition;
        private float moveXAmount = 4;
        private int currentPosition = 1;

        // Start is called before the first frame update
        void Start()
        {
            // initialize vector 
            newPosition = transform.position;
        }

        // Update is called once per frame

        void Update()
        {
            // move position of pointer right to next
            // hat
            if ((Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D)) && currentPosition < 2)
            {
                // move along x axis by how ever much
                // in our case 4 units (right)
                newPosition.x += moveXAmount;
                transform.position = newPosition;
                currentPosition++;
            }

            // move position of pointer to left 
            if ((Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A)) && currentPosition > 0)
            {
                newPosition.x -= moveXAmount;
                transform.position = newPosition;
                currentPosition--;
            }
        }

    }
}
