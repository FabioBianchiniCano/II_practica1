using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class nMovimientos : MonoBehaviour {
  public Text moveText;
  int nMovement = 0;
  // Update is called once per frame
  void Update() {
    if (Input.GetKeyDown(KeyCode.UpArrow) || 
    Input.GetKeyDown(KeyCode.DownArrow) || 
    Input.GetKeyDown(KeyCode.LeftArrow) || 
    Input.GetKeyDown(KeyCode.RightArrow) ) {
      nMovement++;
      moveText.text = nMovement.ToString();
    }
  }
}
