using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class cube : MonoBehaviour
{
  // Update is called once per frame
  void Update() {
    transform.Translate(Vector3.up * Time.deltaTime * Input.GetAxis("Vertical") * 100);
    transform.Translate(Vector3.right * Time.deltaTime * Input.GetAxis("Horizontal") * 100);
  }
}
