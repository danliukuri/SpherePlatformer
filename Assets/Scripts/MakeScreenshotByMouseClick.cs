using UnityEngine;
using UnityEngine.SceneManagement;

public class MakeScreenshotByMouseClick : MonoBehaviour
{
	[SerializeField] Camera mainCamera;
	int counter = 1;

	private void Update()
	{
		if (Input.GetMouseButtonDown(1))
		{
			ScreenCapture.CaptureScreenshot(System.IO.Path.Combine(
				System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyPictures),
				counter.ToString("00") + "_" + mainCamera.pixelWidth + "x" + mainCamera.pixelHeight +
				"_SceneID" + SceneManager.GetActiveScene().name + "_" + System.DateTime.Now.ToString("dd-MM-yyyy-HH-mm-ss") + ".png"));
			Debug.Log(counter + " screenshot"); 
			counter++;
		}
	}
}
