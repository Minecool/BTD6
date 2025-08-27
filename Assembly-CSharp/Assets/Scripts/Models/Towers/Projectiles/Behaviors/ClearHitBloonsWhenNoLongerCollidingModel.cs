namespace Assets.Scripts.Models.Towers.Projectiles.Behaviors;

[Implementation(typeof(ClearHitBloonsWhenNoLongerColliding), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class ClearHitBloonsWhenNoLongerCollidingModel : ProjectileBehaviorModel
{
	[SerializeField]
	private float interval; //Field offset: 0x38
	public int intervalFrames; //Field offset: 0x3C

	public ClearHitBloonsWhenNoLongerCollidingModel(string name, float interval) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

