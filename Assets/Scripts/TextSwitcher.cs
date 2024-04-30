using UnityEngine;
using TMPro;

public class TextSwitcherReverse : MonoBehaviour
{
    public GameObject[] texts;
    private int _currentIndex = -1;

    void Start()
    {
        // Initialize by showing the first text
        //ShowText(currentIndex);
    }

    public void SwitchText()
    {
        // Decrement the index
        _currentIndex = (_currentIndex - 1) % texts.Length;

        // Show the next text
        ShowText(_currentIndex);
    }

    void ShowText(int index)
    {
        // Hide all texts
        foreach (var text in texts)
        {
            text.gameObject.SetActive(false);
        }

        // Show the current text
        texts[index].gameObject.SetActive(true);
    }
}