using UnityEngine;

public class TextSwitcherReverse : MonoBehaviour
{
    public TextManager textManager;

    public void SwitchTextBackwards()
    {
        // Decrement the index
        textManager.currentIndex = (textManager.currentIndex - 1 + textManager.texts.Length) % textManager.texts.Length;

        // Show the previous text
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
    }
}