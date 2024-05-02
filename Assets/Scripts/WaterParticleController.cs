using UnityEngine;
using System.Collections;

public class ParticleController : MonoBehaviour
{
    public new ParticleSystem particleSystem; // Your Particle System

    public void OnEnable()
    {
        StartCoroutine((RunWater()));
    }

    private IEnumerator RunWater()
    {
        particleSystem.Play(); // Play the Particle System

        yield return new WaitForSeconds(5); // Wait for 5 seconds

        particleSystem.Stop(); // Stop the Particle System
    }
}