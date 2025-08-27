namespace Assets.Scripts.Unity.UI_New.InGame.StoreMenu;

public interface IDisablable
{

	public bool IsDisabled
	{
		 get { } //Length: 0
	}

	public void DisableButton() { }

	public void EnableButton() { }

	public bool get_IsDisabled() { }

}

