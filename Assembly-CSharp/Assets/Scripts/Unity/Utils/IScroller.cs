namespace Assets.Scripts.Unity.Utils;

public interface IScroller
{

	public bool DragEnabled
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public float horizontalNormalizedPosition
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public float verticalNormalizedPosition
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public void CancelDrag() { }

	public bool get_DragEnabled() { }

	public float get_horizontalNormalizedPosition() { }

	public float get_verticalNormalizedPosition() { }

	public void set_DragEnabled(bool value) { }

	public void set_horizontalNormalizedPosition(float value) { }

	public void set_verticalNormalizedPosition(float value) { }

}

