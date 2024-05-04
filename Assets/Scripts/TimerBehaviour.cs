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
        timerText.text = $"{minutes:00}:{seconds:00}";
        
        if (remainingTime <= 0)
        {
            Debug.Log("Timer was called");
            // stop counting
            timerText.text = "End";
        }
    }
}