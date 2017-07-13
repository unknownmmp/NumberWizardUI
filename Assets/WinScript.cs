using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinScript : MonoBehaviour {

    public Text errortext;

	// Use this for initialization
	void Start () {
        errortext.text = "U trying to cheat? \\nIt wont work...U mark only get killed \\nsooner...Cyka. \\nUr guess was " + PlayerPrefs.GetInt("guess") + "\\nI won. U'll die twice for cheating";
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
