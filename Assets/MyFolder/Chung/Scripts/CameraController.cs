using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private PlayerRegistry playerRegistry;

    private void Awake()
    {
        playerRegistry.OnPlayerRegistered += SetPlayer;
    }

    private void Update()
    {
        if (player == null) return;
        transform.position = player.transform.position + (Vector3.up * 10f);
    }

    private void SetPlayer(PlayerController _player)
    {
        player = _player.gameObject;
    }

}
