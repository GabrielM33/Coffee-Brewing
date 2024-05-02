using UnityEngine;

public class BubblePop : MonoBehaviour
{
    [SerializeField] private AudioSource popSound;
    [SerializeField] private AudioSource bgm;
    [SerializeField] private GameObject workArea;
    [SerializeField] private GameObject tools;
    [SerializeField] private GameObject ui;
    
    public void OnTriggerEnter(Collider other)
    {
        // if hand collides with bubble, pop bubble
        if (other.gameObject.CompareTag("Hand"))
        {
            PopBubble();
        }
    }

    public void PopBubble()
    {
        gameObject.SetActive(false);
        popSound.Play();
        tools.SetActive(true);
        ui.SetActive(true);
        workArea.SetActive(true);
        bgm.Play();

    }
}
