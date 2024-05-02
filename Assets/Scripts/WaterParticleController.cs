using UnityEngine;
using System.Collections;

public class ParticleController : MonoBehaviour
{
    public ParticleSystem particleSystem; // Your Particle System

    private IEnumerator OnEnable()
    {
        particleSystem.Play(); // Play the Particle System

        yield return new WaitForSeconds(10); // Wait for 10 seconds

        particleSystem.Stop(); // Stop the Particle System
    }
}