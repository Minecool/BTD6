namespace Assets.Scripts.Models.Towers.Projectiles.Behaviors;

[Implementation(typeof(FadeProjectile), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class FadeProjectileModel : ProjectileBehaviorModel
{
	[SerializeField]
	private float startFadingAt; //Field offset: 0x38
	public int startFadingAtFrames; //Field offset: 0x3C

	public FadeProjectileModel(string name, float startFadingAt) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

