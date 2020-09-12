﻿using UnityEngine;

enum MoveSideWays : int {
    None = 0,
    MoveLeft,
    MoveRight,
}

public class ShipMovement : MonoBehaviour
{
    private Rigidbody2D LocalPlayer;
    private Vector2 Force; // force for player to move
    [SerializeField] ShipData ShipData; // shipdata to handle ship
    private MoveSideWays moveDirection; // The Direction to change the direction
    

    void Start( ){
        Force = new Vector2(); // force for player to move
        moveDirection = MoveSideWays.None; // The Direction to change the direction
        LocalPlayer = GetComponent<Rigidbody2D>(); // Oun object rigid body
         
    }

    void Update( ){
        CalForce( );
        MovePlayer( );
        TransformShip( );
    }

    void MovePlayer( ){
        LocalPlayer.AddForce( Force );
    }

    /*
     * Calculating force where the player actually want to move
     */
    void CalForce( ){
        switch(moveDirection){
            case MoveSideWays.None:
                Force.Set(0,ShipData.InitialShipSpeed);
                ShipData.InitialShipSpeed += ShipData.ShipAccelarationFactor;
                break;
            case MoveSideWays.MoveLeft:
                Force.Set(ShipData.ShipSideMove * -1, ShipData.InitialShipSpeed);
                break;
            case MoveSideWays.MoveRight:
                Force.Set(ShipData.ShipSideMove * 1, ShipData.InitialShipSpeed);
                break;
        }
    }

    void TransformShip( ){
        if (transform.position.x > -100f){
            transform.position = Vector3.right * -175f +
                    Vector3.up * transform.position.y +
                    Vector3.forward *  transform.position.z;
        }else if (transform.position.x < -175f){
            transform.position = Vector3.right * -100f +
                    Vector3.up * transform.position.y +
                    Vector3.forward *  transform.position.z;
        }
    }
    /*
     * Button Functions to move the ship
     */
    public void MoveLeft( bool pressed ){
        if (pressed){
            moveDirection = MoveSideWays.MoveLeft;
        }else {
            moveDirection = MoveSideWays.None;
        }
        
    }

    public void MoveRight( bool pressed ){
        if (pressed){
            moveDirection = MoveSideWays.MoveRight;
        }else {
            moveDirection = MoveSideWays.None;
        }
    }
    // End Button Functions
}