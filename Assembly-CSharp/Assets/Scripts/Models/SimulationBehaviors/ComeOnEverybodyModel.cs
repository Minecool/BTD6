namespace Assets.Scripts.Models.SimulationBehaviors;

[Implementation(typeof(ComeOnEverybody), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class ComeOnEverybodyModel : SimulationBehaviorModel
{
	internal class PriceMutatorClass : BehaviorMutator
	{

		public PriceMutatorClass(bool isUnique, string mutatorId, int priority, BuffIndicatorModel buffIndicatorModel) { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}

	internal class RateMutatorClass : BehaviorMutator
	{
		private readonly float multiplier; //Field offset: 0x70

		public RateMutatorClass(bool isUnique, string mutatorId, float multiplier, int priority, BuffIndicatorModel buffIndicatorModel) { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}

	public const string RateMutatorId = "ComeOnEverybodyRate"; //Field offset: 0x0
	public const string PriceMutatorId = "ComeOnEverybodyPrice"; //Field offset: 0x0
	public float discountMultiplier; //Field offset: 0x30
	public float rateMultiplier; //Field offset: 0x34
	public string buffLocsNameRate; //Field offset: 0x38
	public string buffIconNameRate; //Field offset: 0x40
	public string buffLocsNamePrice; //Field offset: 0x48
	public string buffIconNamePrice; //Field offset: 0x50
	private RateMutatorClass rateMutator; //Field offset: 0x58
	private PriceMutatorClass priceMutator; //Field offset: 0x60

	public PriceMutatorClass PriceMutator
	{
		 get { } //Length: 250
	}

	public RateMutatorClass RateMutator
	{
		 get { } //Length: 282
	}

	public ComeOnEverybodyModel(string name, float discountMultiplier, float rateMultiplier, string buffLocsNameRate, string buffIconNameRate, string buffLocsNamePrice, string buffIconNamePrice) { }

	public virtual Model Clone() { }

	public PriceMutatorClass get_PriceMutator() { }

	public RateMutatorClass get_RateMutator() { }

	public BuffIndicatorModel GetBuffIndicatorModel(string buffName) { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

