using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinHole : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collider)
    {
        BallControlScript.setWinningState();
    }
}
