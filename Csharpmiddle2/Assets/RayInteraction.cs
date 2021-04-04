using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayInteraction : MonoBehaviour
{
    float distance = 10f;
    public LayerMask isTarget;

    private Camera playerCam;

    private Transform moveTarget;
    private float targetDistance;
    // Start is called before the first frame update
    void Start()
    {
        playerCam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 rayOrigin = playerCam.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, 0f));
        Vector3 rayDirection = playerCam.transform.forward;
        Ray ray = new Ray(rayOrigin, rayDirection);

        Debug.DrawRay(ray.origin, ray.direction* 100f, Color.green);

        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;

            if (Physics.Raycast(ray,out hit, distance,isTarget))
            {
                GameObject hitObject = hit.collider.gameObject;
                hitObject.GetComponent<Renderer>().material.color = Color.red;
                moveTarget = hitObject.transform;
                targetDistance = hit.distance;

                Debug.Log(hit.collider.gameObject.name);
                Debug.Log("광선 감지!");
            }
        }

        if (Input.GetMouseButtonUp(0))
        {
            if (moveTarget != null) moveTarget.GetComponent<Renderer>().material.color = Color.white;
            moveTarget = null;
        }
        if (moveTarget != null)
        {
            moveTarget.position = ray.origin + ray.direction * targetDistance;
        }

    }
}
