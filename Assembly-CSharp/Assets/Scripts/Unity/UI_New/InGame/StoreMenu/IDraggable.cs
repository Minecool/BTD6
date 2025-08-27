namespace Assets.Scripts.Unity.UI_New.InGame.StoreMenu;

public interface IDraggable
{

	public bool IsBeingDragged
	{
		 get { } //Length: 0
	}

	public bool get_IsBeingDragged() { }

	public void StartDragging() { }

	public void StopDragging() { }

}

