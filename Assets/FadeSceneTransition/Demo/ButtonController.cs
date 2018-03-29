using UnityEngine;
using System.Collections;
using TheNextFlow.UnityPlugins;

public class ButtonController : MonoBehaviour {

	public GameObject cube;

	public void OnClickEvent() {
		if (cube != null) {
			FadeSceneTransition.FadeOut(1.0f, Color.black, () => {
				cube.SetActive(!cube.activeSelf);
				FadeSceneTransition.FadeIn(1.0f, Color.black, () => {});
			});
		} else if (Application.loadedLevelName == "SourceScene") {			
			FadeSceneTransition.FadeAndLoadLevel("DestinationScene", 1.0f, Color.black, () => {
				Debug.Log("Scene changed.");
			});
		} else {
			FadeSceneTransition.FadeAndLoadLevel("SourceScene", 2.5f, Color.white, () => {
				Debug.Log("Scene changed.");
			});
		}
	}
}
