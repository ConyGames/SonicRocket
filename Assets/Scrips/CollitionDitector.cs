using UnityEngine;

public class CollitionDitector : MonoBehaviour
{
    public GameObject ObjectToDestroy;

    private void OnCollisionEnter2D(Collision2D collitionInfo) {
        if (collitionInfo.collider.name == "Player"){ // mean colided with localplayer
            Destroy(ObjectToDestroy);
        }
    }
}
