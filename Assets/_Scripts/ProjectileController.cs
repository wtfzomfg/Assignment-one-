using UnityEngine;
using System.Collections;

public class ProjectileController : MonoBehaviour {
    public float speed;
    public Boundary boundary;
    public SpriteRenderer shot;
    void Start()
    {
        //GetComponent<Rigidbody2D>speed;
    }

    void update()
        //moves the object to
    {
        Vector2 currentPosition = gameObject.GetComponent<Transform>().position;

        currentPosition.x -= speed;//
        gameObject.GetComponent<Transform>().position = currentPosition;
        if (currentPosition.x <= 640)
        {
            Destroy(gameObject);
        }
    }
}//Jefferson Chin 300787653 COMP305 
