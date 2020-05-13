using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathHole : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collider)
    {
        BallControlScript.setBallDeath();
    }
}
