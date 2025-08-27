namespace Assets.Scripts.Models.Towers.Behaviors;

[Implementation(typeof(StartOfRoundRateBuff), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class StartOfRoundRateBuffModel : TowerBehaviorModel
{
	internal class RateMutator : BehaviorMutator
	{
		private readonly StartOfRoundRateBuffModel startOfRoundRateBuffModel; //Field offset: 0x70

		public RateMutator(StartOfRoundRateBuffModel startOfRoundRateBuffModel) { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}

	public float modifier; //Field offset: 0x30
	[SerializeField]
	private float duration; //Field offset: 0x34
	public bool isUnique; //Field offset: 0x38
	public int durationFrames; //Field offset: 0x3C
	public string mutatorId; //Field offset: 0x40
	private RateMutator _mutator; //Field offset: 0x48

	public float Duration
	{
		 get { } //Length: 6
		 set { } //Length: 21
	}

	public RateMutator mutator
	{
		 get { } //Length: 231
	}

	public StartOfRoundRateBuffModel(string name, float modifier, float duration, bool isUnique = true, string mutatorId = "StartOfRoundRateBuff") { }

	public virtual Model Clone() { }

	public float get_Duration() { }

	public RateMutator get_mutator() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

	public void set_Duration(float value) { }

}

