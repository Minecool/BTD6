namespace Assets.Scripts.Data.Behaviors;

[CreateAssetMenu(fileName = "OffsetPosition", menuName = "BTD6/Behaviors/OffsetPosition")]
public class OffsetPosition : EntityBehavior<TowerBehaviorModel>
{
	public float x; //Field offset: 0x28
	public float y; //Field offset: 0x2C
	public float z; //Field offset: 0x30
	public float rotation; //Field offset: 0x34

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 136
	}

	public bool IsValid
	{
		 get { } //Length: 45
	}

	public Vector3 Position
	{
		 get { } //Length: 51
	}

	public OffsetPosition() { }

	public virtual TowerBehaviorModel get_Def() { }

	public bool get_IsValid() { }

	public Vector3 get_Position() { }

}

