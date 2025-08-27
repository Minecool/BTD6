namespace Assets.Scripts.Models.Bloons.Behaviors;

[Implementation(typeof(DestroyProjectilesInRadiusAction), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class DestroyProjectilesInRadiusActionModel : BloonBehaviorActionModel
{
	public float radius; //Field offset: 0x38
	public PrefabReference destroyedItemEffect; //Field offset: 0x40
	public float destroyedItemEffectTime; //Field offset: 0x48
	public bool ignorePowerProjectiles; //Field offset: 0x4C

	public DestroyProjectilesInRadiusActionModel() { }

	public DestroyProjectilesInRadiusActionModel(string name, string actionId, float radius, PrefabReference destroyedItemEffect, float destroyedItemEffectTime, bool ignorePowerProjectiles) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

