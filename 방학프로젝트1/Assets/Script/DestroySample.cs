using UnityEngine;

public class DestroySample : MonoBehaviour
{
    [SerializeField]
    private GameObject playerObject;

    private void Awake()
    {
        Destroy(playerObject.GetComponent<PlayerController>());
    }
}
