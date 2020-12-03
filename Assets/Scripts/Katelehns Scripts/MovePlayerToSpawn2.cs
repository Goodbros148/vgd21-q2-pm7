using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayerToSpawn2 : MonoBehaviour
{

    public GameObject objectToMove;
    public GameObject locationToMoveTo;
    private Rigidbody2D rb2;


    // Start is called before the first frame update
    void Start()
    {
        rb2 = objectToMove.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            rb2.velocity = Vector2.zero;
            objectToMove.transform.position = locationToMoveTo.transform.position;
        }
    }
}
