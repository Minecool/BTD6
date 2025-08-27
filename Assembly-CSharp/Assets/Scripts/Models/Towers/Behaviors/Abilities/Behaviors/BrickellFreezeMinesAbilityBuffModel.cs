namespace Assets.Scripts.Models.Towers.Behaviors.Abilities.Behaviors;

[Implementation(typeof(BrickellFreezeMinesAbilityBuff), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class BrickellFreezeMinesAbilityBuffModel : AbilityBehaviorBuffModel
{
	internal class BrickellFreezeMinesMutator : BehaviorMutator
	{
		private float multiplier; //Field offset: 0x70
		private float projectileSpeedMultiplier; //Field offset: 0x74

		public BrickellFreezeMinesMutator(BrickellFreezeMinesAbilityBuffModel parent, float multiplier, float projectileSpeedMultiplier) { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}

	public float multiplier; //Field offset: 0x48
	public float projectileSpeedMultiplier; //Field offset: 0x4C
	[SerializeField]
	private float lifespan; //Field offset: 0x50
	public int lifespanFrames; //Field offset: 0x54
	private BrickellFreezeMinesMutator mutator; //Field offset: 0x58

	public BrickellFreezeMinesMutator Mutator
	{
		 get { } //Length: 325
	}

	public BrickellFreezeMinesAbilityBuffModel(string name, float multiplier, float projectileSpeedMultiplier, float lifespan, string buffLocsName, string buffIconName) { }

	public virtual Model Clone() { }

	public BrickellFreezeMinesMutator get_Mutator() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

