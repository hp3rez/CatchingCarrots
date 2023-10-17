using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonLogic : MonoBehaviour
{
    // Start is called before the first frame update
    public void switchScene() {
        SceneManager.LoadSceneAsync(1);
    }

    public void exitGame() {
        Application.Quit();
    }
}
