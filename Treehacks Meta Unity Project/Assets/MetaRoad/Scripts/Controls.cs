using UnityEngine;
using System.Collections;
using Meta;
public class Controls : MonoBehaviour {
	public enum Mode
	{
		Menu,
		Playing
	}
	public Mode mode;
	public GameObject player;
	public int playerScore = 0;
	public GameObject roadSectionPrefab;
	public GameObject currentSection;
	public float newSectionThreshold = 0.4f;
	public float distance = 0f;
	public GameObject menuGO;

	public MetaBody leftHandle;
	public MetaBody rightHandle;

	public bool CheckHandlebars()
	{
		if(leftHandle.grabbed && rightHandle.grabbed){
		//if (Meta.Hands.left.isValid && Meta.Hands.right.isValid) {
			return true;
		} else
			return false;
	}
	// Use this for initialization
	void Start () {  
		menuGO = GameObject.Find ("MenuGO");
		menuGO.SetActive (true);
	} 
	public void Play()
	{
		mode = Mode.Playing;
	}
	
	// Update is called once per frame
	void Update () {
		if (mode == Mode.Playing) {
			menuGO.SetActive(false);
			float speedPerUpdate = -Time.deltaTime;
			if (Input.GetKey (KeyCode.W) || CheckHandlebars()) {
				player.transform.Translate (player.transform.forward * speedPerUpdate);
				distance += -speedPerUpdate;
			}
			if (distance >= newSectionThreshold) {
				GameObject newSection = Instantiate (roadSectionPrefab) as GameObject;
				newSection.transform.position = currentSection.GetComponentInChildren<SectionPivotPoint> ().transform.position;
				currentSection = newSection;
			}
		}
	}
}
