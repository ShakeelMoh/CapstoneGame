using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;

public class ApplicationManager : MonoBehaviour {
    //public Slider slider;
    //public Text progressText;
    public Button playButton;

    /*bool bPlay;
    AsyncOperation operation;*/

    private void Start()
    {
        EventSystem.current.SetSelectedGameObject(playButton.gameObject);
    }

    public void Quit () 
	{
        #if UNITY_EDITOR
		UnityEditor.EditorApplication.isPlaying = false;
        #else
		Application.Quit();
        #endif
	}

    public void Play()
    {
        SceneManager.LoadScene("PortalBalls");

    }

    /*IEnumerator LoadAsynchronously(string screenName)
    {
        operation = SceneManager.LoadSceneAsync(screenName);
        operation.allowSceneActivation = false;
        while (!operation.isDone)
        {
            if (operation.progress < 0.9f)
            {
                float progress = Mathf.Clamp01(operation.progress / 0.9f);
                slider.value = progress;
                progressText.text = progress * 100f + "%";
            }
            else
            {
                playButton.interactable = true;
            }
            
        }
        yield return null;
    }*/

}
