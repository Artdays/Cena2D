using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimentação : MonoBehaviour
{
	public int speed;
	private float moveH, moveV;
	private Rigidbody2D player;
	void Start()
	{
		player = GetComponent<Rigidbody2D>();
	}

	// Update is called once per frame
	void Update()
	{
		moveH = Input.GetAxis("Horizontal");
		player.velocity = new Vector2(moveH * speed, moveV * speed);
	}
}
