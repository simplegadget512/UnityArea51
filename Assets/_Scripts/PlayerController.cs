using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public bool debugging = false;
    public GameObject subject;
    public float speedMultiplier = 1f;

    void Start()
    {
        subject = GetComponent<GameObject>();
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxisRaw("Horizontal");
        float moveVertical = Input.GetAxisRaw("Vertical");

        if (debugging)
        {
            if (!Mathf.Approximately(moveHorizontal, 0f))
            {
                Debug.Log("X: " + moveHorizontal.ToString());
            }
            if (!Mathf.Approximately(moveVertical, 0f))
            {
                Debug.Log("Z: " + moveVertical.ToString());
            }
        }
        Vector3 newPosition = new Vector3(
                                  subject.transform.position.x + moveHorizontal,
                                  subject.transform.position.y + moveVertical,
                                  0f
                              );
        subject.transform.position = newPosition;
    }
}
