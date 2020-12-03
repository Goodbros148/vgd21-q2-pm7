using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grow : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale = new Vector2(size, size);

        if (Input.GetKeyDown(KeyCode.O))
        {
            //Splitting Code
            transform.position = new Vector2(transform.position.x - -splitDistance, transform.position.y);
            GameObject newSnowball = Instantiate(myPrefab, new Vector2(0f, 0f), Quaternion.identity);
            newSnowball.transform.position = new Vector2(transform.position.x + SplitDistance, transform.position.y);

            size /= 2f;
            newSnowball.GetComponent<Grow>().size = size;
        }
    }

    private Rigidbody2D rb;
    private float size = 1f;
    private float growRate = 0.1f;
    private float shrinkRate = 0.1f;

    public float splitDistance = 0.2f;
    public float SplitDistance = -0.2f;
    public GameObject myPrefab;


    private void OnCollisionStay2D(Collision2D col)
    {
        //Growing Code
        if (col.gameObject.CompareTag("Snow") && Mathf.Abs(rb.velocity.x) > 1f)
        {
            size += growRate * Time.deltaTime;
        }
    }

    private void OnTriggerStay2D(Collider2D col)
    {
 
        //Melting Code
        if (col.gameObject.CompareTag("Fire"))
        {
            Debug.Log("Test");
            size -= shrinkRate * Time.deltaTime;
        }
    }
}