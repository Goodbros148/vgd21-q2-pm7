using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsMotion : MonoBehaviour
{
    public float scaler;
    private Rigidbody2D rb2;
    public float angle;
    public float puntForce;

    // Start is called before the first frame update
    void Start()
    {
        rb2 = GetComponent<Rigidbody2D>();
    }


    // Update is called once per frame
    void Update()
    {
        //Motion for character
        float inX = Time.deltaTime * scaler * Input.GetAxis("Horizontal");
        float inY = Time.deltaTime * scaler * Input.GetAxis("Vertical");
        rb2.AddForce(new Vector2(inX, inY));

       

        if (Input.GetKeyDown(KeyCode.P) && Input.GetMouseButton(1))
        {

            float fx = transform.position.x - Input.mousePosition.x;
            float fy = transform.position.y - Input.mousePosition.y;
            Vector2 launchAngle = new Vector2(fx, fy) / 10f;
            rb2.AddForce(launchAngle, ForceMode2D.Impulse);

        }

        //Listen for a Reset (ESC)S
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            transform.position = new Vector3(0, 0, 0);
            rb2.velocity = new Vector2(0, 0);

        }
    }
}
