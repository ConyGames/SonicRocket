using UnityEngine;

public class PlayerCollitionSystem : MonoBehaviour
{
    private PlayerDamageCal playerDamageCal;
    private float obstecleDamage = 20f;
    private void Start() {
        playerDamageCal = GameObject.Find("LocalPlayer").GetComponent<PlayerDamageCal>();
    }
    void OnTriggerEnter2D(Collider2D CollitionInfo)
    {
        switch (CollitionInfo.tag){
            case "obstecle":
                GameObject objectToDestroy = CollitionInfo.gameObject;
                playerDamageCal.TakeDamage(ref obstecleDamage);
                DestroyTheObejct(ref objectToDestroy);
                break;
            default:
                break;
        }
    }
    private void DestroyTheObejct(ref GameObject objectToDestroy){
        Destroy(objectToDestroy);
    }
}
