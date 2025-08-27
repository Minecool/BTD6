namespace Assets.Scripts.Models.Bloons.Behaviors;

[Implementation(typeof(ProjectileOverTime), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class ProjectileOverTimeModel : BloonBehaviorModelWithTowerTracking
{
	public ProjectileModel projectileModel; //Field offset: 0x38
	public EmissionModel emissionModel; //Field offset: 0x40
	public int intervalFrames; //Field offset: 0x48
	[SerializeField]
	private float interval; //Field offset: 0x4C
	public PrefabReference displayPath; //Field offset: 0x50
	public float displayLifetime; //Field offset: 0x58
	public bool triggerImmediate; //Field offset: 0x5C
	public bool rotateEffectWithBloon; //Field offset: 0x5D
	[SerializeField]
	private float initialDelay; //Field offset: 0x60
	public int initialDelayFrames; //Field offset: 0x64
	public bool emitOnDestroy; //Field offset: 0x68
	public bool collideWithSelf; //Field offset: 0x69

	public float Interval
	{
		 get { } //Length: 6
		 set { } //Length: 21
	}

	public ProjectileOverTimeModel() { }

	public ProjectileOverTimeModel(string name, ProjectileModel projectileModel, EmissionModel emissionModel, float interval, PrefabReference displayPath, float displayLifetime, bool triggerImmediate, ObjectId tower, bool rotateEffectWithBloon, float initialDelay, bool emitOnDestroy, bool collideWithSelf) { }

	public virtual Model Clone() { }

	public float get_Interval() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

	public void set_Interval(float value) { }

}

