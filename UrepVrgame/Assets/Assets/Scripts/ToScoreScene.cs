using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToScoreScene : MonoBehaviour
{
    BallManagerScript ballManager;
    [SerializeField] GameObject returnArea;
    // Start is called before the first frame update
    public void ScoreScene()
    {
        Time.timeScale=1;
        SceneManager.LoadScene("Assets/AllScenes/Score Display");
        ballManager=returnArea.GetComponent<BallManagerScript>();
    }
}
