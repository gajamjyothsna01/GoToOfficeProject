using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoOfficeVectorThree : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector3 intitalPosition;
    [SerializeField]
    private Vector3 destinationPosition;
    private Vector3 distance;

    void Start()
    {
        print("Hello! Welcome to Go Home Game");
        print("Instructions how to play the Game");
        print("Press UpArrow to move Forward / Press DownArrow to move Backward");
        print("My Start Position is " + intitalPosition);
        print("My End Position is " + destinationPosition);
        distance = destinationPosition - intitalPosition;
        print("The Distance to cover is " + distance.magnitude);
        float finalDistance = distance.magnitude;
        if (finalDistance > 0)
            print("You to Move Forward");
        else if (finalDistance < 0)
            print("You to move Backward");
        else if (finalDistance == 0)
            print("You have reached the destination");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            // print("UpArrow has pressed");
            intitalPosition = intitalPosition + new Vector3(0, 1, 0);
            distance = destinationPosition - intitalPosition;
            print("The Distance to Home is" + distance);
            float finaldistance = distance.magnitude;
            if (finaldistance > 0)
                print("Please press Down Arrow to move Backward");
            else if (finaldistance < 0)
                print("Please press Up Arrow to move Forward");
            else if (finaldistance == 0)
                print("You have reached the Home");

        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            intitalPosition = intitalPosition + new Vector3(0, -1, 0);
            distance = destinationPosition - intitalPosition;
            print("The Distance to Home is" + distance);
            float finaldistance = distance.magnitude;
            if (finaldistance > 0)
                print("Please press Down Arrow to move Backward");
            else if (finaldistance < 0)
                print("Please press Up Arrow to move Forward");
            else if (finaldistance == 0)
                print("You have reached the Home");
            /* if (intitalPosition > destinationPosition)
                 print("Please press Down Arrow to move Backward");
             else if (intitalPosition < destinationPosition)
                 print("Please press Up Arrow to move Forward");
             else if (distance == 0)
                 print("You have reached the Home"); */
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            intitalPosition = intitalPosition + new Vector3(-1, 0, 0);
            distance = destinationPosition - intitalPosition;
            print("The Distance to Home is" + distance);
            float finaldistance = distance.magnitude;
            if (finaldistance > 0)
                print("Please press Down Arrow to move Backward");
            else if (finaldistance < 0)
                print("Please press Up Arrow to move Forward");
            else if (finaldistance == 0)
                print("You have reached the Home");
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            intitalPosition = intitalPosition + new Vector3(1, 0, 0);
            distance = destinationPosition - intitalPosition;
            print("The Distance to Home is" + distance);
            float finaldistance = distance.magnitude;
            if (finaldistance > 0)
                print("Please press Down Arrow to move Backward");
            else if (finaldistance < 0)
                print("Please press Up Arrow to move Forward");
            else if (finaldistance == 0)
                print("You have reached the Home");
        }
        if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            intitalPosition = intitalPosition + new Vector3(0, 0, 1);
            distance = destinationPosition - intitalPosition;
            print("The Distance to Home is" + distance);
            float finaldistance = distance.magnitude;
            if (finaldistance > 0)
                print("Please press Down Arrow to move Backward");
            else if (finaldistance < 0)
                print("Please press Up Arrow to move Forward");
            else if (finaldistance == 0)
                print("You have reached the Home");
        }
        if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            intitalPosition = intitalPosition + new Vector3(0, 0, -1);
            distance = destinationPosition - intitalPosition;
            print("The Distance to Home is" + distance);
            float finaldistance = distance.magnitude;
            if (finaldistance > 0)
                print("Please press Down Arrow to move Backward");
            else if (finaldistance < 0)
                print("Please press Up Arrow to move Forward");
            else if (finaldistance == 0)
                print("You have reached the Home");
        }

    }
}
