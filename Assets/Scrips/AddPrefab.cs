using UnityEngine;

public class AddPrefab : MonoBehaviour
{
    public GameObject LocalPlayer;
    void Start()
    {
        GameObject player = Instantiate(LocalPlayer, transform.position, transform.rotation);
    }
}
