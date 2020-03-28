using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;
public class Sex : MonoBehaviour
{
	public Button Mbutton;
	public Button Wbutton;

	void Start(){
		Mbutton = GetComponent<Button>();
		Wbutton = GetComponent<Button>();
	}
	public void OnClickM(){
		Debug.Log("男");
		Mbutton.interactable = false;
		Wbutton.interactable = true;
	}
	public void OnClickW(){
		Debug.Log("女");
		Wbutton.interactable = false;
		Mbutton.interactable = true;
	}
}









		/*var colors1 = Mbutton.colors;
        colors1.normalColor      = new Color(87, 151, 255, 255);
        colors1.highlightedColor = new Color(128, 176, 255, 255);
        colors1.pressedColor     = new Color(27, 74, 150, 255);
        colors1.selectedColor    = new Color(32, 109, 232, 255);
		Mbutton.colors = colors1;
		
		var colors2 = Wbutton.colors;
        colors2.normalColor      = new Color(252, 109, 212, 255);
        colors2.highlightedColor = new Color(255, 163, 229, 255);
        colors2.pressedColor     = new Color(133, 20, 101, 255);
        colors2.selectedColor    = new Color(194, 29, 147, 255);
		Wbutton.colors = colors2;

		Mbutton.interactable = true;
		Wbutton.interactable = true;*/