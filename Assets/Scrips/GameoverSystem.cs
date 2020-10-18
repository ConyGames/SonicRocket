using UnityEngine;
using UnityEngine.UI;

public class GameoverSystem : MonoBehaviour
{
    [SerializeField] private float maxTime = 0;
    [SerializeField] private Text TimeLeft;

    // Update is called once per frame
    void Update()
    {
        maxTime -= Time.deltaTime;
        int absVal = (int)maxTime;
        TimeLeft.text = absVal.ToString();
    }
}
