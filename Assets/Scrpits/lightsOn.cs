using UnityEngine;
using UnityEngine.Playables;

public class lightsOn : MonoBehaviour
{
    public PlayableDirector hallLights;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            hallLights.Play();
        }
    }
}
