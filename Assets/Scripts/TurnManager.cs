using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnManager : MonoBehaviour {

    public Player playerOne;
    public Player playerTwo;

    public void GetPlayer1Input()
    {
        int maxMoves = 5
        int numOfMoves = 0;
        int left = 0;
        int right = 0;
        int up = 0;
        int down = 0;
        playerOne.futurePosition = playerOne.currentPosition;
        playerTwo.futurePosition = playerTwo.currentPosition;
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            if (down > 0)
            {
               numOfMoves--;
               down--;
               playerOne.futurePosition += new Vector2(0, 1);
            }
                else if (numOfMoves < maxMoves)
            {

            }
            }
                
        
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
           
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
           
        }
    }

    public Vector2 GetPlayer2Input()
    {

        return Vector2.zero;
    }
}
