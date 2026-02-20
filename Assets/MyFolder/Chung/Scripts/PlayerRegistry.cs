using System;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PlayerRegistry", menuName = "SuddenImpact/PlayerRegistry")]
public class PlayerRegistry : ScriptableObject
{
    public PlayerController localPlayer;    // 로컬 플레이어를 담는 곳
    public List<PlayerController> teamA = new List<PlayerController>(); // 팀별 플레이어가 담기는 곳
    public List<PlayerController> teamB = new List<PlayerController>();

    public event Action<PlayerController> OnPlayerRegistered;

    public void Register(PlayerController player)
    {
        localPlayer = player;
        OnPlayerRegistered?.Invoke(player);
    }

    // 게임 종료 시 반드시 초기화
    public void Clear()
    {
        localPlayer = null;
        teamA.Clear();
        teamB.Clear();
    }
}