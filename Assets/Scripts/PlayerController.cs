using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float moveSpeed = 20f;
    [SerializeField] float turnRate = 25f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        PlayerInput();
    }

    //Simple Control Scheme for the Prototype
    private void PlayerInput()
    {
        transform.Translate(0, 0, Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed); //Moves the player forward on Input

        if (Input.GetAxis("Vertical") > Mathf.Epsilon) //Allows proper rotation only when moving forward
        {
            transform.Rotate(0, Input.GetAxis("Horizontal") * Time.deltaTime * turnRate, 0);
        }
        else if (Input.GetAxis("Vertical") < -Mathf.Epsilon) //When moving backwards reverse the rotation for realistic effect
        {
            transform.Rotate(0, -Input.GetAxis("Horizontal") * Time.deltaTime * turnRate, 0);
        }
    }
}


