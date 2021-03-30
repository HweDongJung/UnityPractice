using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//카멜(camel낙타)명명 법 클래스의 경우 첫단어의 첫글자는 대문자, 다음단어의 첫글자도 대문자
//변수의 경우 첫단어 첫글자는 소문자로 
public class Player_script : MonoBehaviour
{
    public GameManager gameManager;

    public float speed = 10f;

    private Rigidbody playerRigidbody;

    // Start is called before the first frame update
    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (gameManager.isGameOver == true) return;
        //A <-       0       -> D
        //-1.0       0        1.0
        float inputX = Input.GetAxis("Horizontal");
        float inputZ = Input.GetAxis("Vertical");
        Vector3 velocity = new Vector3(inputX, 0, inputZ);
        velocity *= speed;
        velocity.y = playerRigidbody.velocity.y;
        playerRigidbody.velocity = velocity;
        //playerRigidbody.AddForce(inputX * speed, 0, inputZ * speed);

    }
}
