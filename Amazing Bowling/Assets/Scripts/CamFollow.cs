using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollow : MonoBehaviour
{
    public enum State { 
        Idle, Ready, Tracking
    
    }

    private State state
    {
        set 
        {
            switch (value)
            {
                case State.Idle:
                    targetZoomSize = roundReadyZoomSize;
                    break;
                case State.Ready:
                    targetZoomSize = readyShotZoomSize;
                    break;
                case State.Tracking:
                    targetZoomSize = trackingZoomSize;
                    break;
                default:
                    break;
            
            }
        
        }
    }

    private Transform target;

    public float smoothTime = 0.2f;
    private Vector3 lastMovingVelocity;
    private Vector3 targetPosition;
    private Camera cam;
    private float targetZoomSize = 5f;

    private const float roundReadyZoomSize = 14.5f;
    private const float readyShotZoomSize = 5.0f;
    private const float trackingZoomSize = 10f;

    private float lastZoomSpeed;

    private void Awake()
    {
        cam = GetComponentInChildren<Camera>();
        state = State.Idle; //변수의 값을 조절하는것 처럼 보이지만 위의 State의 set에서 value로 idle이 들어가고 switch 동작함 

    }

    private void Move()
    {
        targetPosition = target.transform.position; // 타겟의 위치 가져오기 

        Vector3 smoothPosition = Vector3.SmoothDamp(transform.position, targetPosition, ref lastMovingVelocity, smoothTime); // 타겟의 위치로 스무스하게 이동경로 좌표 얻기

        transform.position = smoothPosition; // 좌표로 이동 
    }

    private void Zoom()
    {
        float smoothZoomSize = Mathf.SmoothDamp(cam.orthographicSize, targetZoomSize, ref lastZoomSpeed,smoothTime);
        cam.orthographicSize = smoothZoomSize;
    
    }

    private void FixedUpdate()
    {
        if (target != null)
        {
            Move();
            Zoom();
        }
    }

    public void Reset()
    {
        state = State.Idle;
    }

    public void SetTarget(Transform newTarget, State newState)
    {
        target = newTarget;
        state = newState;
    }
}
