using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBorder : MonoBehaviour
{

    public ePlayer Player;
    public Score score;

    void OnCollisionEnter(Collision col)
    {

        Ball ball = col.gameObject.GetComponent<Ball>();
        if (ball != null)
        {
            ball.transform.position = new Vector3(0f, 1f, 0f);
            if (Player == ePlayer.Right) score.scorePlayerLeft++;
            if (Player == ePlayer.Left) score.scorePlayerRight++;
        }
    }
}
