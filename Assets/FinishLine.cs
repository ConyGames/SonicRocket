using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    public int LoadSceneIndex;

    private void OnCollisionEnter2D(Collision2D collisionInfo)
    {
        Debug.Log("Colider Name : " + collisionInfo.collider.name);
        if (collisionInfo.collider.name == "Player"){
            Debug.Log("Colider Name : " + collisionInfo.collider.name);
            SceneManager.LoadScene(LoadSceneIndex, LoadSceneMode.Single);
        }
    }
}
