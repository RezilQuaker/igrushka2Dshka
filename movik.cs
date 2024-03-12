using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movik : MonoBehaviour
{
    public float directionX = 1;
    public float directionY = 1;
    public float Speed = 2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 movement = new Vector2(directionX, directionY);
        transform.Translate(movement * Speed * Time.deltaTime);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "floor") 
        {
            directionX = directionX * -1;
            directionY = directionY * -1;
        }
    }
}
