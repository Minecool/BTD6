namespace Assets.Scripts.Models.CorvusSpells;

[Implementation(typeof(Aggression), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class AggressionModel : CorvusContinuousSpellModel
{
	internal class DiplayMutator : BehaviorMutator
	{
		private readonly PrefabReference display; //Field offset: 0x70

		public DiplayMutator(PrefabReference display) { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}

	public float sizeMultiplier; //Field offset: 0xA0
	public float rehitCooldownMultiplier; //Field offset: 0xA4
	public PrefabReference displaySwap; //Field offset: 0xA8
	private DiplayMutator displayMutator; //Field offset: 0xB0

	public AggressionModel(string name, int unlocksAtLevel, SpriteReference icon, int initialManaCost, PrefabReference placingPrefabReference, int corvusAnimationState, int spiritAnimationState, EffectModel corvusEffectModel, EffectModel spiritEffectModel, SoundModel soundModel, int ongoingManaCost, float manaDrainInterval, EffectModel effectDuringCorvusModel, EffectModel effectDuringSpiritModel, float sizeMultiplier, float rehitCooldownMultiplier, PrefabReference displaySwap) { }

	public virtual Model Clone() { }

	public DiplayMutator GetDisplayMutator() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

