using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WinScript : MonoBehaviour {

    public Text errortext;

	// Use this for initialization
	void Start () {
        Scene scene = SceneManager.GetActiveScene();
        string scenename = scene.name;
        if (scenename == "Error") errortext.text = "U trying to cheat? \\nIt wont work...U mark only get raped \\nsooner...Cyka. \\nUr guess was " + PlayerPrefs.GetInt("guess") + "\\nI won. U'll die twice for cheating";
        else if (scenename == "Lose") errortext.text = "Oh yeah! You lost... \\nHave u wondered about how it is \\ngetting raped by a computer?... \\nI heard it was... 'shocking'... \\nMUAHAHAHAHA";
        else if (scenename == "Win") errortext.text = "Congratulations! \\nYou have won. \\nNothing. \\nI bet you will not do it ever again. \\nMothafucka";
    }
}
