namespace Assets.Scripts.Models.Towers.Projectiles.Behaviors;

[Implementation(typeof(FollowPath), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class FollowPathModel : ProjectileBehaviorModel
{
	public Vector3[] path; //Field offset: 0x38
	public Vector3[] easePath; //Field offset: 0x40
	public bool destroyAtEndOfPath; //Field offset: 0x48
	[SerializeField]
	private float speed; //Field offset: 0x4C
	public float speedFrames; //Field offset: 0x50

	public float Speed
	{
		 get { } //Length: 6
		 set { } //Length: 19
	}

	public FollowPathModel(string name, float speed, Vector3[] path, Vector3[] easePath, bool destroyAtEndOfPath) { }

	public virtual Model Clone() { }

	public float get_Speed() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

	public void set_Speed(float value) { }

}

