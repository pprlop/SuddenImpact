using UnityEngine;
using Photon.Pun;

public class PlayerSpawner : MonoBehaviourPunCallbacks
{
    [SerializeField] private GameObject playerPrefab;
    [SerializeField] private PlayerRegistry playerRegistry;

    public override void OnJoinedRoom()
    {
        var go = PhotonNetwork.Instantiate(playerPrefab.name, Vector3.zero, Quaternion.identity);
        playerRegistry.Register(go.GetComponent<PlayerController>());
    }

}
