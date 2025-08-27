namespace Assets.Scripts.Unity.UI_New;

public interface IButtonProxy
{

	public bool interactable
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public ButtonClickedEvent onClick
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public bool get_interactable() { }

	public ButtonClickedEvent get_onClick() { }

	public void set_interactable(bool value) { }

	public void set_onClick(ButtonClickedEvent value) { }

}

