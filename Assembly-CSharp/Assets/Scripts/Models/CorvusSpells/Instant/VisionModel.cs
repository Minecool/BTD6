namespace Assets.Scripts.Models.CorvusSpells.Instant;

[Implementation(typeof(Vision), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class VisionModel : CorvusInstantSpellModel
{

	public VisionModel(string name, int unlocksAtLevel, SpriteReference icon, int initialManaCost, PrefabReference placingPrefabReference, int corvusAnimationState, int spiritAnimationState, EffectModel corvusEffectModel, EffectModel spiritEffectModel, SoundModel soundModel, EffectModel effectDuringCorvusModel, EffectModel effectDuringSpiritModel, float duration, float cooldown) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

