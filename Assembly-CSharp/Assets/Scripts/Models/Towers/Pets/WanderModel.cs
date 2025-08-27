namespace Assets.Scripts.Models.Towers.Pets;

[Implementation(typeof(Wander), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class WanderModel : PetBehaviorModel
{
	public bool StayInArea; //Field offset: 0x30
	public float Speed; //Field offset: 0x34
	public float InnerRadius; //Field offset: 0x38
	public float OuterRadius; //Field offset: 0x3C
	public float IdleTimeMin; //Field offset: 0x40
	public float IdleTimeMax; //Field offset: 0x44
	public Keyframe[] MotionCurve; //Field offset: 0x48
	public bool startAtTower; //Field offset: 0x50
	public bool useSyncedRandom; //Field offset: 0x51

	public WanderModel(string name, bool stayInArea, float speed, float innerRadius, float outerRadius, float idleTimeMin, float idleTimeMax, Keyframe[] motionCurve, bool startAtTower, bool useSyncedRandom) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

