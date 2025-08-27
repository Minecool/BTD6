namespace Assets.Scripts.Models.Towers.Projectiles.Behaviors;

[Implementation(typeof(TravelAlongPath), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class TravelAlongPathModel : ProjectileBehaviorModel
{
	public float range; //Field offset: 0x38
	public bool reverse; //Field offset: 0x3C
	public bool disableRotateWithPathDirection; //Field offset: 0x3D
	[SerializeField]
	private float speed; //Field offset: 0x40
	public float speedFrames; //Field offset: 0x44
	[SerializeField]
	private float lifespan; //Field offset: 0x48
	public int lifespanFrames; //Field offset: 0x4C
	public float rotationLerp; //Field offset: 0x50

	public TravelAlongPathModel(string name, float speed, float lifespan, bool reverse, bool disableRotateWithPathDirection, float rotationLerp) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

