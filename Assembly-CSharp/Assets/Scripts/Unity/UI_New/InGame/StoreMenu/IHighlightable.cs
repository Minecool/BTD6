namespace Assets.Scripts.Unity.UI_New.InGame.StoreMenu;

public interface IHighlightable
{

	public bool IsHighlighted
	{
		 get { } //Length: 0
	}

	public bool get_IsHighlighted() { }

	public void StartHighlight() { }

	public void StopHighlight() { }

}

