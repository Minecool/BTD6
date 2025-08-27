namespace Assets.Scripts.Unity.UI_New.InGame.StoreMenu;

public interface ILockable
{

	public bool IsLocked
	{
		 get { } //Length: 0
	}

	public bool get_IsLocked() { }

	public void SetLocked() { }

	public void SetUnlocked() { }

}

