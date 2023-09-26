using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backgroudMove : MonoBehaviour
{
    public float moveSpeed;
    public GameObject obj;
    private Vector3 oldposition;
    public float moveRange;
    // Start is called before the first frame update
    void Start()
    {
        obj = gameObject;
        oldposition = obj.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(-1,0,0)*moveSpeed *Time.deltaTime);
        if(Vector3.Distance(oldposition, obj.transform.position) > moveRange)
        {
            transform.position = oldposition;
        }
    }
}
