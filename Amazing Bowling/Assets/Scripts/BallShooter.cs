using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallShooter : MonoBehaviour
{
    public CamFollow cam;

    public Rigidbody ball;
    public Transform firePosition;
    public Slider powerSlider;
    public AudioSource fireAudio;
    public AudioClip fireClip;
    public AudioClip chargingClip;
    public float minForce = 15f;
    public float maxForce = 30f;
    public float chargingTime = 0.75f; //min부터 max까지 차징하는데 걸리는 시간 
    private float currentForce;
    private float chargeSpeed;
    private bool fired;

    private void OnEnable()
    {
        currentForce = minForce;
        powerSlider.value = minForce;
        fired = false;
        
    }

    
    void Start()
    {
        chargeSpeed = (maxForce - minForce) / chargingTime;
    }



    void Update()
    {

        if (fired) return;

        powerSlider.value = minForce;

        if (currentForce >= maxForce && !fired)
        {
            currentForce = maxForce;
            //강제 발사처리
            Fire();
        }
        else if (Input.GetButtonDown("Fire1") && !fired) // 발사버튼을 누르는 순간 
        {
            currentForce = minForce;

            fireAudio.clip = chargingClip;
            fireAudio.Play();
        }
        else if (Input.GetButton("Fire1")) // 발사버튼을 누르는 동안 
        {
            currentForce = currentForce + chargeSpeed * Time.deltaTime;
            powerSlider.value = currentForce;
        }
        else if (Input.GetButtonUp("Fire1") && !fired) //발사버튼에 손을 떼는 순간 
        {
            //발사처리
            Fire();
        }
    }

    private void Fire()
    {
        fired = true;

        Rigidbody ballInstance = Instantiate(ball, firePosition.position, firePosition.rotation);

        ballInstance.velocity = currentForce * firePosition.forward;

        fireAudio.clip = fireClip;
        fireAudio.Play();

        currentForce = minForce;

        cam.SetTarget(ballInstance.transform, CamFollow.State.Tracking);
    }
}
