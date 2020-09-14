using UnityEngine;
using UnityEngine.SceneManagement;



public class UIButtonsScript : MonoBehaviour
{
    Scene scene;
    private GameObject LocalPlayer;
    private ShipMovement shipMovement;
    void Start()
    {
        scene = SceneManager.GetActiveScene();
        LocalPlayer = GameObject.FindGameObjectWithTag("player");
        shipMovement = LocalPlayer.GetComponent<ShipMovement>();
    }
    public void PlayButton(){
        Debug.Log("Current Scence Index : " + scene.buildIndex + " and Name : " + scene.name);
        Debug.Log("Scence Loading : " + scene.name);
        int NextScenceIndex = scene.buildIndex + 1;
        SceneManager.LoadScene(NextScenceIndex, LoadSceneMode.Single);
    }

    /*
     * Button Functions to move the ship
     */
    public void MoveLeft( bool pressed ){
        if (pressed){
            shipMovement.moveDirection = MoveSideWays.MoveLeft;
        }else {
            shipMovement.moveDirection = MoveSideWays.None;
        }
        
    }

    public void MoveRight( bool pressed ){
        if (pressed){
            shipMovement.moveDirection = MoveSideWays.MoveRight;
        }else {
            shipMovement.moveDirection = MoveSideWays.None;
        }
    }
}
