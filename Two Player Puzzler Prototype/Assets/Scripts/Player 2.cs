using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : PlayerController
{
    // Start is called before the first frame update
    void Start()
    {
        cc = gameObject.GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        moveFB = Input.GetAxis("VerticalP2") * speed;
        moveLR = Input.GetAxis("HorizontalP2") * speed * -1;

        Vector3 movement = new Vector3(moveLR, 0, moveFB);
        movement = transform.rotation * movement;
        transform.position = movement;

        cc.Move(movement * Time.deltaTime);
    }
}
