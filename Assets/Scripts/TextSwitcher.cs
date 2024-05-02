using UnityEngine;

public class TextSwitcherForward : MonoBehaviour
{
    public TextManager textManager;
    public TimerBehaviour timer;
    private bool startTimer = false;
    
    void Update()
    {
        if (startTimer)
        {
            timer.SetTimer();
        }
    }
    
    public void SwitchText()
    {
        // Increment the index
        textManager.currentIndex = (textManager.currentIndex + 1) % textManager.texts.Length;

        // Show the next text
        ShowText(textManager.currentIndex);
    }

    void ShowText(int index)
    {
        // Hide all texts
        foreach (var text in textManager.texts)
        {
            text.gameObject.SetActive(false);
        }

        // Show the current text
        textManager.texts[index].gameObject.SetActive(true);

        // Play the animation for the current step
        string animationName = textManager.animationNames[index]; // Get the correct animation name
        textManager.animators[index].Play(animationName);

        // if index = 14, start the timer
        if (index == 14)
        {
            startTimer = true;
        }
    }
}