using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBackground : MonoBehaviour
{
    private Vector3 startPosition;
    private float offSet;
    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;
        offSet = GetComponent<BoxCollider>().size.x / 2;
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < startPosition.x - offSet)
        {
            transform.position = startPosition;
        }
    }
}
