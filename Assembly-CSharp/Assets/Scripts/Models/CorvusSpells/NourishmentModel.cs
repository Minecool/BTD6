namespace Assets.Scripts.Models.CorvusSpells;

[Implementation(typeof(Nourishment), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class NourishmentModel : CorvusInstantSpellModel
{
	public float xpPerMana; //Field offset: 0xA0
	public float cashPerManaAtMaxLevel; //Field offset: 0xA4

	public NourishmentModel(string name, int unlocksAtLevel, SpriteReference icon, int initialManaCost, PrefabReference placingPrefabReference, int corvusAnimationState, int spiritAnimationState, EffectModel corvusEffectModel, EffectModel spiritEffectModel, SoundModel soundModel, EffectModel effectDuringCorvusModel, EffectModel effectDuringSpiritModel, float duration, float cooldown, float xpPerMana, float cashPerManaAtMaxLevel) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

