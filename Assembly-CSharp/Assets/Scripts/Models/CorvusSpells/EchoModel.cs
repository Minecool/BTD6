namespace Assets.Scripts.Models.CorvusSpells;

[Implementation(typeof(Echo), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class EchoModel : CorvusInstantSpellModel
{
	public TowerModel duplicateSpiritModel; //Field offset: 0xA0

	public EchoModel(string name, int unlocksAtLevel, SpriteReference icon, int initialManaCost, PrefabReference placingPrefabReference, int corvusAnimationState, int spiritAnimationState, EffectModel corvusEffectModel, EffectModel spiritEffectModel, SoundModel soundModel, EffectModel effectDuringCorvusModel, EffectModel effectDuringSpiritModel, float duration, float cooldown, TowerModel duplicateSpiritModel) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

