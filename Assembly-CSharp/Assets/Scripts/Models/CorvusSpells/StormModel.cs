namespace Assets.Scripts.Models.CorvusSpells;

[Implementation(typeof(Storm), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class StormModel : CorvusContinuousSpellModel
{
	public AttackModel attack; //Field offset: 0xA0

	public StormModel(string name, int unlocksAtLevel, SpriteReference icon, int initialManaCost, PrefabReference placingPrefabReference, int corvusAnimationState, int spiritAnimationState, EffectModel corvusEffectModel, EffectModel spiritEffectModel, SoundModel soundModel, int ongoingManaCost, float manaDrainInterval, EffectModel effectDuringCorvusModel, EffectModel effectDuringSpiritModel, AttackModel attack) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

