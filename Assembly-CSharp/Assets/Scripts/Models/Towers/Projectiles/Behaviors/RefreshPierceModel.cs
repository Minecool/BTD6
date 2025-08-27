namespace Assets.Scripts.Models.Towers.Projectiles.Behaviors;

[Implementation(typeof(RefreshPierce), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class RefreshPierceModel : ProjectileBehaviorModel
{
	[SerializeField]
	private float interval; //Field offset: 0x38
	public int intervalFrames; //Field offset: 0x3C
	public bool isBuffedByRate; //Field offset: 0x40

	public RefreshPierceModel(string name, float interval, bool isBuffedByRate) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

