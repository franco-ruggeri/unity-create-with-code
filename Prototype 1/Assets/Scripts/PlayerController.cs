using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public enum InputScheme { Keys, Arrows };
    public InputScheme input = InputScheme.Keys;

    private string horizontalName, verticalName;
    private float horizontalInput, verticalInput;

    public float forwardSpeed = 20.0f;
    public float turnSpeed = 45.0f;

    // Start is called before the first frame update
    void Start()
    {
        switch (input)
        {
            case InputScheme.Keys:
                horizontalName = "Horizontal Keys";
                verticalName = "Vertical Keys";
                break;
            case InputScheme.Arrows:
                horizontalName = "Horizontal Arrows";
                verticalName = "Vertical Arrows";
                break;
            default:
                Debug.LogError("Unknown input scheme!");
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        // Move the vehicle forward
        verticalInput = Input.GetAxis(verticalName);
        transform.Translate(Vector3.forward * Time.deltaTime * forwardSpeed * verticalInput);

        // Turn the vehicle
        horizontalInput = Input.GetAxis(horizontalName);
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
        
        Debug.Log("vertical " + verticalInput);
        Debug.Log("horizontal " + horizontalInput);
    }
}
