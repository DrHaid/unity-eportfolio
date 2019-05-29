using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereMovement : MonoBehaviour
{
  public float speed;
  Rigidbody rb;
  // Start is called before the first frame update
  void Start()
  {
    rb = gameObject.GetComponent<Rigidbody>();
  }

  // Update is called once per frame
  void Update()
  {
    float vertical = Input.GetAxis("Vertical");
    float horizontal = Input.GetAxis("Horizontal");

    rb.velocity = new Vector3(horizontal * speed, rb.velocity.y, vertical * speed);
  }
}
