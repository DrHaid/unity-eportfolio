using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
  public GameObject plane;
  public GameObject start;
  public GameObject sphere;

  // Start is called before the first frame update
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {
    if (Input.GetButtonDown("Cancel"))
    {
      sphere.transform.position = start.transform.position;
      plane.GetComponent<Renderer>().material.color = Color.white;
    }
  }

  void OnCollisionEnter()
  {
    Debug.Log("Trigger");
    plane.GetComponent<Renderer>().material.color = Color.green;
  }
}
