using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {

	public Texture backgroundTexture;

	void OnGUI(){
		//display background texture
		GUI.DrawTexture(new Rect(0,0,Screen.width,Screen.height), backgroundTexture);
	}
}
