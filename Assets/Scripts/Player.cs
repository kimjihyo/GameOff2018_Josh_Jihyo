using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    public bool isPlayerOne;
    public TurnManager turnManager;
	public int hp;
	private int strength;
    public Vector2 currentPosition;
    public Vector2 futurePosition;

    private void Start(){
    }

    private void Update()
    {
        if (isPlayerOne)
        {
            turnManager.GetPlayer1Input();
        }
        else
        {
            turnManager.GetPlayer2Input();
        }
        //turnManager.GetPlayer1Input();
    }

    void MovePlayer(int x, int y)
    {
        transform.position += new Vector3(x, y, 0);
    }
}




