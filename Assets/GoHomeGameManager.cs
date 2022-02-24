using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoHomeGameManager : MonoBehaviour
{
    public Vector2 intitalPosition;
    [SerializeField]
    private Vector2 destinationPosition;
    private Vector2 distance;

    // Start is called before the first frame update
    void Start()
    {
        print("Hello! Welcome to Go Home Game");
        print("Instructions how to play the Game");
        print("Press UpArrow to move Forward / Press DownArrow to move Backward");
        print("My Start Position is " + intitalPosition);
        print("My End Position is " + destinationPosition);
        distance = destinationPosition - intitalPosition;
        print("The Distance to cover is " + distance.magnitude);
        if (intitalPosition == destinationPosition)
            print("You have reached home");
        /* float finalDistance = distance.magnitude;
         if (finalDistance > 0)
             print("You to Move Forward");
         else if (finalDistance < 0)
             print("You to move Backward");
         else if (finalDistance == 0)
             print("You have reached the destination");
        */
    }

    // Update is called once per frame
    void Update()
    {
        // print("Iam in Update function");
        CheckPlayerMovement(KeyCode.UpArrow, new Vector2(0, 1));
        CheckPlayerMovement(KeyCode.DownArrow, new Vector2(0, -1));
        CheckPlayerMovement(KeyCode.LeftArrow, new Vector2(-1, 0));
        CheckPlayerMovement(KeyCode.RightArrow, new Vector2(1, 0));
    }

    private void CheckPlayerMovement(KeyCode arrow, Vector2 value)
    {
        if (Input.GetKeyDown(arrow))
        {
            // print("UpArrow has pressed");
            intitalPosition = intitalPosition + value;
            distance = destinationPosition - intitalPosition;
            print("The Distance to Home is" + distance.magnitude);
            //  float finaldistance = distance.magnitude;
            /* if (finaldistance > 0)
                 print("Please press Down Arrow to move Backward");
             else if (finaldistance < 0)
                 print("Please press Up Arrow to move Forward"); */
            if (intitalPosition == destinationPosition)
                print("You have reached the Home");

        }
    }
}
