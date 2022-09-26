using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float horizontalInput;

    public float speed = 10.0f;
    public float xRange = 10.0f;
    public GameObject projectilePrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");

        // keep the player in bounds
        float newX = transform.position.x + horizontalInput * speed * Time.deltaTime;
        if (newX < -xRange) 
            newX = -xRange;
        else if (newX > xRange) 
            newX = xRange;
        
        transform.position = new Vector3(newX, transform.position.y, transform.position.z);

        // launch projectile
        if (Input.GetKeyDown(KeyCode.Space))
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);

    }
}
