using UnityEngine;

public class AddPrefab : MonoBehaviour
{
    public GameObject LocalPlayer;
    void Start()
    {
        Instantiate(LocalPlayer, Vector3.zero, transform.rotation);
    }


}
