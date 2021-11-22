using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword : MonoBehaviour
{
    Vector2 mousePos;
    Camera cam;

    Rigidbody2D rb2D;

    GameObject sword;
    bool sworded;

    private void Start()
    {
        cam = Camera.main;
        rb2D = GetComponent<Rigidbody2D>();

        sword = transform.Find("Sword").gameObject;
    }

    private void Update()
    {
        mousePos = cam.ScreenToWorldPoint(new Vector2(Input.mousePosition.x, Input.mousePosition.y));
        Control();
        Throw();
    }

    void Control()
    {
        transform.rotation = Quaternion.LookRotation(Vector3.forward, (mousePos - (Vector2)transform.position));
    }

    void Throw()
    {
        if (Input.GetMouseButtonDown(0))
        {
            sword.SetActive(true);
        } else if (Input.GetMouseButtonDown(1))
        {
            sword.SetActive(false);
        }
    }
}
