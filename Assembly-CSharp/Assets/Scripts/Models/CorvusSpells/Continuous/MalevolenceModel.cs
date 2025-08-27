namespace Assets.Scripts.Models.CorvusSpells.Continuous;

[Implementation(typeof(Malevolence), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class MalevolenceModel : CorvusContinuousSpellModel
{
	public AttackModel attack; //Field offset: 0xA0
	public float absorptionDuration; //Field offset: 0xA8

	public MalevolenceModel(string name, int unlocksAtLevel, SpriteReference icon, int initialManaCost, PrefabReference placingPrefabReference, int corvusAnimationState, int spiritAnimationState, EffectModel corvusEffectModel, EffectModel spiritEffectModel, SoundModel soundModel, int ongoingManaCost, float manaDrainInterval, EffectModel effectDuringCorvusModel, EffectModel effectDuringSpiritModel, AttackModel attack, float absorptionDuration) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

