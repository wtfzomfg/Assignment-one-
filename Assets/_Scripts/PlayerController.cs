using UnityEngine;
using System.Collections;



public class PlayerController : MonoBehaviour {

    // the player can max top left is -110(x),70(y)
    // max bottem right is 20(x),

    public float speed;
    public Boundary boundary;

    //shooting
    public float fireRate;
    public GameObject shot;
    public Transform shotSpawn;

    /// PRIVATE INSTANCE VARIABLES
    private Vector2 _newPosition = new Vector2(0.0f, 0.0f);
    private float nextFire;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        this._CheckInput();
        if (Input.GetButton("Fire1") && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
            //GetComponent<AudioSource>().Play();
        }

    }

    private void _CheckInput()
    {
        this._newPosition = gameObject.GetComponent<Transform>().position; // current position

        if (Input.GetAxis("Horizontal") > 0)
        {
            this._newPosition.x += this.speed; // add move value to current position to move forward
        }

        if (Input.GetAxis("Horizontal") < 0)
        {
            this._newPosition.x -= this.speed; // subtract move value to current position to move backwards
        }

        if (Input.GetAxis("Vertical") > 0)
        {
            this._newPosition.y += this.speed; // add move value to current position to an upward location of the screne 
        }

        if (Input.GetAxis("Vertical") < 0)
        {
            this._newPosition.y -= this.speed; // subtract move value to current position to move downwards
        }

        this._BoundaryCheck();// To always see if the player is within the boundary 

        gameObject.GetComponent<Transform>().position = this._newPosition;
    }

    private void _BoundaryCheck()// this boundary check is so the player can't move be on 
    {
        if (this._newPosition.x < this.boundary.xMin)
        {
            this._newPosition.x = this.boundary.xMin;
        }

        if (this._newPosition.x > this.boundary.xMax)
        {
            this._newPosition.x = this.boundary.xMax;
        }
        if (this._newPosition.y < this.boundary.yMin)
        {
            this._newPosition.y = this.boundary.yMin;
        }

        if (this._newPosition.y > this.boundary.yMax)
        {
            this._newPosition.y = this.boundary.yMax;
        }
    }
    //Jefferson Chin 300787653 COMP305 
}
