namespace Assets.Scripts.Models.CorvusSpells;

[Implementation(typeof(AncestralMight), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class AncestralMightModel : CorvusInstantSpellModel
{
	internal class EchoMutator : BehaviorMutator
	{
		private readonly PrefabReference display; //Field offset: 0x70
		private readonly AttackModel attackModel; //Field offset: 0x78

		public EchoMutator(PrefabReference display, AttackModel attackModel) { }

		[CompilerGenerated]
		private bool <Mutate>b__3_0(AttackModel x) { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}

	public AttackModel attack; //Field offset: 0xA0
	public float absorptionDuration; //Field offset: 0xA8
	public PrefabReference withEchoSwap; //Field offset: 0xB0
	private EchoMutator displayMutator; //Field offset: 0xB8

	public AncestralMightModel(string name, int unlocksAtLevel, SpriteReference icon, int initialManaCost, PrefabReference placingPrefabReference, int corvusAnimationState, int spiritAnimationState, EffectModel corvusEffectModel, EffectModel spiritEffectModel, SoundModel soundModel, EffectModel effectDuringCorvusModel, EffectModel effectDuringSpiritModel, float duration, float cooldown, AttackModel attack, float absorptionDuration, PrefabReference withEchoSwap) { }

	public virtual Model Clone() { }

	public EchoMutator GetDisplayMutator() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

