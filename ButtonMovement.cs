using UnityEngine;
using System.Collections;

public class ButtonMovement : TouchManager {
    public enum type {LeftButton, RightButton, AttackButton };
    public type buttonType;
    public GameObject playerObject = null;
    public GUITexture buttonTexture = null;
    Rigidbody2D playerRigidbody;
    public float moveSpeed;
	// Use this for initialization
	void Start () {
        playerRigidbody = playerObject.GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        TouchInput(buttonTexture);
	}
    void OnFirstTouch()
    {
        switch(buttonType)
        {
            case type.AttackButton:
                break;
            case type.LeftButton:
                playerObject.transform.Translate(-Vector2.right * moveSpeed * Time.deltaTime);
                break;
            case type.RightButton:
                playerObject.transform.Translate(Vector2.right * moveSpeed * Time.deltaTime);
                break;
        }
    }
    void OnSecondaryTouch()
    {
        switch (buttonType)
        {
            case type.AttackButton:
                break;
            case type.LeftButton:
                playerObject.transform.Translate(-Vector2.right * moveSpeed * Time.deltaTime);
                break;
            case type.RightButton:
                playerObject.transform.Translate(Vector2.right * moveSpeed * Time.deltaTime);
                break;
        }
    }
}
