using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchInput : MonoBehaviour
{

    private Ray touchPosition;
    private Rigidbody rb;
    private Vector3 direction;
    private float moveSpeed = 10f;
    public bool Vertical;
    public bool Horizontal;
    RaycastHit hit;
    Vector3 temp;
    private void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }
    // Update is called once per frame
    void Update()
    {
        if(Input.touchCount > 0)
        {
           Touch touch= Input.GetTouch(0);
           touchPosition = Camera.main.ScreenPointToRay(touch.position);

            if (Physics.Raycast(touchPosition, out hit))
            {
                if (hit.transform == transform)
                {
                    rb.isKinematic = false;
                    temp = hit.point;

                    if (Vertical == true)
                    {
                        transform.Translate(0f, 0f, temp.z - transform.position.z);
                    }
                    if (Horizontal == true)
                    {
                        transform.Translate(temp.x - transform.position.x, 0f, 0f);
                    }

                    if (touch.phase == TouchPhase.Ended)
                    {
                        rb.velocity = Vector3.zero;
                        rb.isKinematic = true;
                    }
                }
            }
        }
    }
}
