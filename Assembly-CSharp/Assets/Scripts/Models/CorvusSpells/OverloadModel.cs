namespace Assets.Scripts.Models.CorvusSpells;

[Implementation(typeof(Overload), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class OverloadModel : CorvusInstantSpellModel
{
	public ProjectileModel projectile; //Field offset: 0xA0
	public SingleEmissionModel emission; //Field offset: 0xA8

	public OverloadModel(string name, int unlocksAtLevel, SpriteReference icon, int initialManaCost, PrefabReference placingPrefabReference, int corvusAnimationState, int spiritAnimationState, EffectModel corvusEffectModel, EffectModel spiritEffectModel, SoundModel soundModel, EffectModel effectDuringCorvusModel, EffectModel effectDuringSpiritModel, float duration, float cooldown, ProjectileModel projectile) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

