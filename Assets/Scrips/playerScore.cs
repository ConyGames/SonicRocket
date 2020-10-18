using UnityEngine;
using UnityEngine.UI;

public class playerScore : MonoBehaviour 
{
    
    // min ship bigining helth for all lavel it can be bit higher depend upon the design of the lavel
    [SerializeField] private float ShipScore = 100; 
    [SerializeField] private bool ShipDead = false;
    [SerializeField] private Text ShipScoreShow;
    private GameObject LocalPlayer;

    private void Start() {
        Debug.Log( "Now Ship Score : " + this.ShipScore.ToString() );
        ShipScoreShow.text = this.ShipScore.ToString();
        LocalPlayer = GameObject.FindGameObjectWithTag("player");
    }

    public void TakeDamage(ref float damage){
        // if (ShipScore <= 0 || ShipScore <= damage){
        //     ShipDead = true; // ship is dead Destroy the SHip
        //     DestroyPlayer();
        // }else {
            this.ShipScore += damage;
        // }
        Debug.Log("Now Ship Score : " + this.ShipScore.ToString());
        ShipScoreShow.text = this.ShipScore.ToString();
    }

    public ref bool isShipDead(){
        return ref ShipDead;
    }

    private void DestroyPlayer(){
        // gameObject.hideFlags = HideFlags.HideInInspector;
        Destroy(LocalPlayer); // our localplayr
        return;
    }
}
