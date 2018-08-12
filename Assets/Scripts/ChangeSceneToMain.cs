using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ChangeSceneToMain : MonoBehaviour {

	public void ChangeToMain(){
		Debug.Log("Click");
		SceneManager.LoadScene("Main");
	}
}
