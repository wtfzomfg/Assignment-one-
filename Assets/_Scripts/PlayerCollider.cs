using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerCollider : MonoBehaviour
{

    //PUBLIC INSTANCE VARIABLES
    public Text scoreLabel;
    public Text healthLabel;
    public Text gameOverLabel;
    public Text finalScoreLabel;
    public Text restartLabel;
    public int scoreValue = 0;//at the start of the game the player will have 0 score
    public int healthValue = 100; // start at 100% Health
    

    //PRIVATE INSTANCE VARIABLES
    private AudioSource[] _audioSources; // an array of AudioSources
    private AudioSource _HazardAudioSource, _PickUpAudioSource;
    private bool _isColliding;
    //private bool endgame;


    // Use this for initialization
    void Start()
    {
        this._audioSources = this.GetComponents<AudioSource>();
        this._HazardAudioSource = this._audioSources[0];//
        this._PickUpAudioSource = this._audioSources[1];
        //this._endAudioSource = this._audioSources[3];
        this._isColliding = false;
        //this.endgame = false;

        this._SetScore();
        this.gameOverLabel.enabled = false;//the game will not start displaying the score till the game is over
        this.finalScoreLabel.enabled = false; // for final score
        this.restartLabel.enabled = false; //for press R to restart


      
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D otherGameObject)
    {
        if (!this._isColliding) {
            if (otherGameObject.tag == "PickUp")
            {
                this._PickUpAudioSource.Play(); // play yay sound
                                                //this.scoreValue += 100; // add 100 points
                Debug.Log("Collider with pink");
                this._isColliding = true;

                this.scoreValue += 5;// gives the player 1 score for each pick up

            }
            if (otherGameObject.tag == "Hazard")
            {
                this._HazardAudioSource.Play(); // play thunder sound
                                                //
                Debug.Log("Collider with blue");
                this._isColliding = true;

                this.healthValue -= 20; // remove 20% Health
                if(this.healthValue <= 0)
                {
                    this._EndGame();
                    
                }
            }
        }
        
        this._SetScore();// always updates the score per frame
    }
    void OnTriggerExit2D(Collider2D otherGameObject)
    {
        this._isColliding = false;
    }

    // PRIVATE METHODS
    private void _SetScore()
    {
        this.scoreLabel.text = "Score: " + this.scoreValue;// this will display as Score
        this.healthLabel.text = "Health: " + this.healthValue;
    }

    private void _EndGame()
    {
        //this._endAudioSource.Play();
        this.scoreLabel.enabled = false;
        this.healthLabel.enabled = false;
        this.gameOverLabel.enabled = true;
        this.finalScoreLabel.enabled = true;
        this.restartLabel.enabled = true;
        this.finalScoreLabel.text = "Score: " + this.scoreValue;
        //this.endgame = true;


        
    }

}//Jefferson Chin 300787653 COMP305 