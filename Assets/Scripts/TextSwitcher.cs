using UnityEngine;

public class TextSwitcherForward : MonoBehaviour
{
    public TextManager textManager;
    private Animator _animator;

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

        _animator.Play(textManager.animations[index].name);
    }
}