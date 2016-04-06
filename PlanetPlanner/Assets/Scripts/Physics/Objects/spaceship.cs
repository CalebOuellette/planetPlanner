using UnityEngine;
using System.Collections;

public class spaceship : GravityBody {

	private Transform bodyT;
	public int thrust = 10;

    //GetSprite
    public string ShipSpritePath = "Graphics/spaceShipSprites/spaceship";

    [HideInInspector] // Hides var below
    public Sprite Shipsprite;
    [HideInInspector] // Hides var below
    public Sprite ShipBoostsprite;
    
    private SpriteRenderer SR;
    



    // Use this for initialization
    void Start () {
        //Get Config Values
        Shipsprite = Resources.Load<Sprite>((ShipSpritePath));
        ShipBoostsprite = Resources.Load<Sprite>((ShipSpritePath + "_boost"));
        
        //Setup values
        SR = GetComponent<SpriteRenderer>();
        bodyT = GetComponent<Transform>();


        //Apply Values
        SR.sprite = Shipsprite;

    }
	
	// Update is called once per frame
	void Update () {
	
	}


	public void addFowardForce(){

		this.rb.AddForce(bodyT.right * thrust); //Added Force
    }

	
	public void AddFowardForce(float InputThrust){

        this.rb.AddForce(bodyT.right * InputThrust); //Added Force
	}








}
