namespace Assets.Scripts.Models.CorvusSpells;

[Implementation(typeof(Haste), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class HasteModel : CorvusInstantSpellModel
{
	public float orbitSpeedMultiplier; //Field offset: 0xA0
	public float turnSpeedMultiplier; //Field offset: 0xA4

	public HasteModel(string name, int unlocksAtLevel, SpriteReference icon, int initialManaCost, PrefabReference placingPrefabReference, int corvusAnimationState, int spiritAnimationState, EffectModel corvusEffectModel, EffectModel spiritEffectModel, SoundModel soundModel, EffectModel effectDuringCorvusModel, EffectModel effectDuringSpiritModel, float duration, float cooldown, float orbitSpeedMultiplier, float turnSpeedMultiplier) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

