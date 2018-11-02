using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawner : MonoBehaviour {

    public Vector3 spawnPoint;


    void SpawnPlayer()
    {
        GameObject playerQuad = GameObject.CreatePrimitive(PrimitiveType.Quad);
        playerQuad.transform.position = spawnPoint;
        Player player = playerQuad.AddComponent<Player>();
        player.currX = (int)spawnPoint.x;
        player.currY = (int)spawnPoint.y;

    }

    private void Start()
    {
        SpawnPlayer();
    }
}
