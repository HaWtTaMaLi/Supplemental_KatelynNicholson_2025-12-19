using UnityEngine;
using UnityEngine.Playables;

public class lightsOn : MonoBehaviour
{
    public PlayableDirector lightsOnEvent;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            lightsOnEvent.Play();
        }
    }
}
