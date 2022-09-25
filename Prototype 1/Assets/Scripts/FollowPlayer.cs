using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    public KeyCode switchKey = KeyCode.F;
    
    private List<Vector3> offsets = new List<Vector3>
    {
        new Vector3(0, 5, -7),
        new Vector3(0, 2.5f, 0.5f)
    };
    private int offsetId = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(switchKey))
            offsetId = (offsetId + 1) % offsets.Count;
    }

    // LastUpdate is called once per frame, after Update
    void LateUpdate()
    {
        transform.position = player.transform.position + offsets[offsetId];
    }
}
