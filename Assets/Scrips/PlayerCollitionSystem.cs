using UnityEngine;

public class PlayerCollitionSystem : MonoBehaviour
{
    private playerScore playerDamageCal;
    [SerializeField] private Rigidbody2D playerRigidBody;
    private float obstecleDamage = 20f;
    private void Start() {
        playerDamageCal = GameObject.Find("LocalPlayer").GetComponent<playerScore>();
    }
    void OnTriggerEnter2D(Collider2D CollitionInfo)
    {
        switch (CollitionInfo.tag){
            case "obstecle":
                GameObject objectToDestroy = CollitionInfo.gameObject;
                playerDamageCal.TakeDamage(ref obstecleDamage);
                Vector2 reverce_force = new Vector2();
                reverce_force.Set(0,-10000);
                playerRigidBody.AddForce(  reverce_force );
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
