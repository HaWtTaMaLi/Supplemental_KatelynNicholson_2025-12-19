using UnityEngine;
using UnityEngine.Playables;

public class WiggleDoor : MonoBehaviour
{
    public PlayableDirector wiggleDoor;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            wiggleDoor.Play();
        }
    }
}
