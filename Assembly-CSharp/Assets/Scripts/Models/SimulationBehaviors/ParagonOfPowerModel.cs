namespace Assets.Scripts.Models.SimulationBehaviors;

[Implementation(typeof(ParagonOfPower), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class ParagonOfPowerModel : SimulationBehaviorModel
{
	internal class RateMutatorClass : BehaviorMutator
	{
		private readonly float multiplier; //Field offset: 0x70

		public RateMutatorClass(bool isUnique, string mutatorId, float multiplier, int priority, BuffIndicatorModel buffIndicatorModel) { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}

	public const string MutatorId = "ParagonOfPower"; //Field offset: 0x0
	public float rateMultiplier; //Field offset: 0x30
	public string buffLocsName; //Field offset: 0x38
	public string buffIconName; //Field offset: 0x40
	private RateMutatorClass rateMutator; //Field offset: 0x48

	public RateMutatorClass RateMutator
	{
		 get { } //Length: 498
	}

	public ParagonOfPowerModel(string name, float rateMultiplier, string buffLocsName, string buffIconName) { }

	public virtual Model Clone() { }

	public RateMutatorClass get_RateMutator() { }

	public BuffIndicatorModel GetBuffIndicatorModel(string buffName) { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

