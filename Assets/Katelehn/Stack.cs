using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stack : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private Rigidbody2D rb;
    public GameObject myPrefab;

    private void OnCollisionStay2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Snow") && Mathf.Abs(rb.velocity.x) > 1f)
        {
            
        }
    }
    // Update is called once per frame
    void Update()
    {
       
    }
}
