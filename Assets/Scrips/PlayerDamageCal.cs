using UnityEngine;
using UnityEngine.UI;

public class PlayerDamageCal : MonoBehaviour 
{
    
    /*
     * Class To Calculate and store the damage tacken by obstacles
     */

    // min ship bigining helth for all lavel it can be bit higher depend upon the design of the lavel
    [SerializeField]
    private float ShipDamage = 100; 
    private bool ShipDead = false;
    [SerializeField] private Text ShipDamageShow;
    private GameObject LocalPlayer;

    private void Start() {
        Debug.Log( "Now Ship Damage : " + this.ShipDamage.ToString() );
        ShipDamageShow.text = this.ShipDamage.ToString();
        LocalPlayer = GameObject.FindGameObjectWithTag("player");
    }

    public void TakeDamage(ref float damage){
        if (ShipDamage <= 0 || ShipDamage <= damage){
            ShipDead = true; // ship is dead Destroy the SHip
            DestroyTheObejct();
        }else {
            this.ShipDamage -= damage;
        }
        Debug.Log("Now Ship Damage : " + this.ShipDamage.ToString());
        ShipDamageShow.text = this.ShipDamage.ToString();
    }

    public ref bool isShipDead(){
        return ref ShipDead;
    }

    private void DestroyTheObejct(){
        // gameObject.hideFlags = HideFlags.HideInInspector;
        Destroy(LocalPlayer); // our localplayr
        return;
    }
}
