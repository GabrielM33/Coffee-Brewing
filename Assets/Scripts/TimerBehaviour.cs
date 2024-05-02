using UnityEngine;
using TMPro;

public class TimerBehaviour : MonoBehaviour
{
    public TextMeshPro timerText;
    public float remainingTime;

    public void SetTimer()
    {
        remainingTime -= Time.deltaTime;
        int minutes = Mathf.FloorToInt(remainingTime / 60f);
        int seconds = Mathf.FloorToInt(remainingTime % 60f);
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
        
        if (remainingTime <= 0)
        {
            // stop counting
            timerText.text = "Target Time!";
        }
    }
}