using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wallMove : MonoBehaviour
{
    public float moveSpeed;
    public GameObject obj;

    // Start is called before the first frame update
    void Start()
    {
        obj = gameObject;
        obj.transform.position = new Vector3(transform.position.x, Random.Range(-3.5f, 0.5f), 0);
    }

    // Update is called once per frame
    void Update()
    {
        obj.transform.Translate(new Vector3(-1, 0, 0) * moveSpeed * Time.deltaTime);    
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("resetwall")){
            obj.transform.position = new Vector3(11, Random.Range(-3.5f, 0.5f), 0);
            Debug.Log("da va cham");
        }
    }
}
