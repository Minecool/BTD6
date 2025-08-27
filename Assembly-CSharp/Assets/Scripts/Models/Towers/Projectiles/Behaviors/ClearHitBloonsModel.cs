namespace Assets.Scripts.Models.Towers.Projectiles.Behaviors;

[Implementation(typeof(ClearHitBloons), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class ClearHitBloonsModel : ProjectileBehaviorModel
{
	[SerializeField]
	private float interval; //Field offset: 0x38
	public int intervalFrames; //Field offset: 0x3C

	public ClearHitBloonsModel(string name, float interval) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

