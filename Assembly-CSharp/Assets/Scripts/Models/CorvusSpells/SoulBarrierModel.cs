namespace Assets.Scripts.Models.CorvusSpells;

[Implementation(typeof(SoulBarrier), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class SoulBarrierModel : CorvusInstantSpellModel
{
	public int manaPerLifeAbsorbed; //Field offset: 0xA0
	public int maxLivesAbsorbed; //Field offset: 0xA4

	public SoulBarrierModel(string name, int unlocksAtLevel, SpriteReference icon, int initialManaCost, PrefabReference placingPrefabReference, int corvusAnimationState, int spiritAnimationState, EffectModel corvusEffectModel, EffectModel spiritEffectModel, SoundModel soundModel, EffectModel effectDuringCorvusModel, EffectModel effectDuringSpiritModel, float duration, float cooldown, int manaPerLifeAbsorbed, int maxLivesAbsorbed) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

