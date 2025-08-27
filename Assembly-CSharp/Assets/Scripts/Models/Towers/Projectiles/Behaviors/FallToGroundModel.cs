namespace Assets.Scripts.Models.Towers.Projectiles.Behaviors;

[Implementation(typeof(FallToGround), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class FallToGroundModel : ProjectileBehaviorModel
{
	public float timeToTake; //Field offset: 0x38
	public bool expireOnContact; //Field offset: 0x3C
	public float groundOffset; //Field offset: 0x40

	public FallToGroundModel(string name, float timeToTake, bool expireOnContact, float groundOffset) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

