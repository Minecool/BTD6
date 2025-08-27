namespace Assets.Scripts.Models.Towers.Projectiles.Behaviors;

[Implementation(typeof(CollideExtraPierceReduction), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class CollideExtraPierceReductionModel : ProjectileBehaviorModel
{
	public string bloonTag; //Field offset: 0x38
	public int extraAmount; //Field offset: 0x40
	public bool destroyProjectileIfPierceNotEnough; //Field offset: 0x44

	public CollideExtraPierceReductionModel(string name, string bloonTag, int extraAmount, bool destroyProjectileIfPierceNotEnough) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

