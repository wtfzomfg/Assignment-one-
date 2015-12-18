using UnityEngine;
using System.Collections;

public class BackGround : MonoBehaviour {
    // The Background will will scroll from 1100(x)200(y) to -500(x)200(y) 

    //Public Instance variable
    public float speed; //This changes how fast the background will pan

	// Use this for initialization
	void Start () {
        this._Reset(); //Anytime the game start the reset will tigger
	
	}
	
	// Update is called once per frame
	void Update () {
        Vector2 currentPosition = gameObject.GetComponent<Transform>().position;
        currentPosition.x -= speed;
        gameObject.GetComponent<Transform>().position = currentPosition;
        if (currentPosition.x <= -500)// when the map moves to -500 on its x axis it will then be rested back
        {
            this._Reset();
        }
    }

    //reset the game object 
    private void _Reset()
    {
        Vector2 resetPosition = new Vector2(1100.0f, 200.0f);
        gameObject.GetComponent<Transform>().position = resetPosition;
    }
}//Jefferson Chin 300787653 COMP305 
