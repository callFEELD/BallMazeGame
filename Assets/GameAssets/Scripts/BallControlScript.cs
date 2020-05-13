using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using System;

public class BallControlScript : MonoBehaviour
{
	private Rigidbody2D rb;
	private float dirX;
	private float dirY;
	private float moveSpeed = 10f;
	private static bool isBallDead;

	private static bool wonGame;

	public GameObject winScreen;

	// Use this for initialization
	void Start()
	{
		isBallDead = false;
		wonGame = false;
		rb = GetComponent<Rigidbody2D>();
	}

	// Update is called once per frame
	void Update()
	{
		getSensorAcceleration();

		// first check if the ball is dead
		if (isBallDead == true)
		{
			Scene scene = SceneManager.GetActiveScene();
			SceneManager.LoadScene(scene.name);
		}

		if (wonGame == true)
        {
			winScreen.SetActive(true);
			rb.velocity = new Vector2(0, 0);
		}
	}

	void FixedUpdate()
	{
		// adding a force to the ball instead of the velocity
		rb.AddForce(new Vector2(dirX, dirY));
	}

	private void getSensorAcceleration()
	{
		/// <summary>
		/// Gets the current Acceleration of the smartphone
		/// </summary>
		dirX = Input.acceleration.x * moveSpeed;
		dirY = Input.acceleration.y * moveSpeed;
	}

	public static void setBallDeath()
    {
		/// <summary>
        /// Sets the ball status to Dead
        /// </summary>
        isBallDead = true;
    }

	public static void setWinningState()
	{
		/// <summary>
		/// Sets the game status to Won
		/// </summary>
		wonGame = true;
	}
}
