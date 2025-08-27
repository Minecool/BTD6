namespace Assets.Scripts.Models.CorvusSpells.Instant;

[Implementation(typeof(Trample), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class TrampleModel : CorvusInstantSpellModel
{
	public float speedBonus; //Field offset: 0xA0
	public float speedBonusFrames; //Field offset: 0xA4
	public ProjectileModel projectileModel; //Field offset: 0xA8
	public SingleEmissionModel emission; //Field offset: 0xB0

	public TrampleModel(string name, int unlocksAtLevel, SpriteReference icon, int initialManaCost, PrefabReference placingPrefabReference, int corvusAnimationState, int spiritAnimationState, EffectModel corvusEffectModel, EffectModel spiritEffectModel, SoundModel soundModel, EffectModel effectDuringCorvusModel, EffectModel effectDuringSpiritModel, float duration, float cooldown, float speedBonus, ProjectileModel projectileModel) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

