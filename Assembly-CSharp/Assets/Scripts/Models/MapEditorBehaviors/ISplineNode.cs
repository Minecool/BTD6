namespace Assets.Scripts.Models.MapEditorBehaviors;

public interface ISplineNode
{

	public Vector3 LeftTangentPosition
	{
		 get { } //Length: 0
	}

	public Vector3 Position
	{
		 get { } //Length: 0
	}

	public Vector3 RightTangentPosition
	{
		 get { } //Length: 0
	}

	public Vector3 get_LeftTangentPosition() { }

	public Vector3 get_Position() { }

	public Vector3 get_RightTangentPosition() { }

}

