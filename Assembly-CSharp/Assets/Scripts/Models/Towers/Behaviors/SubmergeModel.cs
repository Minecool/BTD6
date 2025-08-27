namespace Assets.Scripts.Models.Towers.Behaviors;

[Implementation(typeof(Submerge), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class SubmergeModel : TowerBehaviorBuffModel
{
	internal class SubmergeMutator : BehaviorMutator
	{
		public SubmergeModel submergeModel; //Field offset: 0x70

		public SubmergeMutator(SubmergeModel submergeModel, string mutationId) { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}

	public TowerBehaviorModel submergeAttackModel; //Field offset: 0x48
	public float abilityCooldownSpeedScale; //Field offset: 0x50
	public float abilityCooldownSpeedScaleGlobal; //Field offset: 0x54
	public float submergeDepth; //Field offset: 0x58
	public float submergeSpeed; //Field offset: 0x5C
	public float heroXpScale; //Field offset: 0x60
	public PrefabReference attackDisplayPath; //Field offset: 0x68
	public SoundModel submergeSound; //Field offset: 0x70
	public SoundModel emergeSound; //Field offset: 0x78
	public int supportMutatorPriority; //Field offset: 0x80
	public MonkeySubParagonSupportModel monkeySubParagonSupportModel; //Field offset: 0x88
	public float abilityCooldownSpeedScaleParagon; //Field offset: 0x90
	public int animateOnSubmerge; //Field offset: 0x94
	public int animateOnExitSubmerge; //Field offset: 0x98
	public EffectModel submergeEffectModel; //Field offset: 0xA0
	public EffectModel unsubmergeEffectModel; //Field offset: 0xA8

	public SubmergeModel(string name, TowerBehaviorModel submergeAttackModel, float abilityCooldownSpeedScale, float abilityCooldownSpeedScaleGlobal, float heroXpScale, PrefabReference attackDisplayPath, float submergeDepth, float submergeSpeed, SoundModel submergeSound, SoundModel emergeSound, string buffLocsName, string buffIconName, int supportMutatorPriority, MonkeySubParagonSupportModel monkeySubParagonSupportModel, float abilityCooldownSpeedScaleParagon, int animateOnSubmerge, int animateOnExitSubmerge, EffectModel submergeEffectModel, EffectModel unsubmergeEffectModel) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

