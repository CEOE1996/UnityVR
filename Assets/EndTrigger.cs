using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndTrigger : MonoBehaviour {

	void OnTriggerEnter()
    {
        CompleteLevel();
    }

    public void CompleteLevel()
    {
        Debug.Log("Finish!");
        SceneManager.LoadScene("Finish");
    }

}
