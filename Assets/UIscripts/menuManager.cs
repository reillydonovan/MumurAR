using UnityEngine;
using System.Collections;

public class menuManager : MonoBehaviour {

	public Menu CurrentMenu;

	public void Start() {
		ShowMenu (CurrentMenu);
	}

	public void ShowMenu(Menu menu) {
		if (CurrentMenu != null)
			CurrentMenu.IsOpen = false;

		CurrentMenu = menu;
		CurrentMenu.IsOpen = true;
	}
}
