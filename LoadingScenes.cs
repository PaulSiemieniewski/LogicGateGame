using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LoadingScenes : MonoBehaviour
{
	public void LoadByIndex(int sceneIndex)
	{
		SceneManager.LoadScene(sceneIndex);
	}
}