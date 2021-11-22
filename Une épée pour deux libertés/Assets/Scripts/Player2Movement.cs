using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Movement : MonoBehaviour
{
    Vector3 playerMovement;
    public float speed;

    float verticalMovement;

    private void Update()
    {
        playerMovement = new Vector3(Input.GetAxisRaw("Player 2 Horizontal"), Input.GetAxisRaw("Player 2 Vertical"), 0);
    }

    private void FixedUpdate()
    {
        transform.position += playerMovement * Time.deltaTime * speed;
    }
}
