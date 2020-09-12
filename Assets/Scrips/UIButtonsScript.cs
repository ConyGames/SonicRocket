using UnityEngine;
using UnityEngine.SceneManagement;
public class UIButtonsScript : MonoBehaviour
{
    Scene scene;

    void Start()
    {
        scene = SceneManager.GetActiveScene();
    }
    public void PlayButton(){
        Debug.Log("Current Scence Index : " + scene.buildIndex + " and Name : " + scene.name);
        Debug.Log("Scence Loading : " + scene.name);
        int NextScenceIndex = scene.buildIndex + 1;
        SceneManager.LoadScene(NextScenceIndex, LoadSceneMode.Single);
    }
}
