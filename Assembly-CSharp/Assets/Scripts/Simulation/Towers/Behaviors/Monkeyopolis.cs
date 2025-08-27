namespace Assets.Scripts.Simulation.Towers.Behaviors;

public class Monkeyopolis : TowerBehavior
{
	public class EmissionMutator : BehaviorMutator
	{
		private readonly int crateCount; //Field offset: 0x70
		private readonly float crateCash; //Field offset: 0x74

		public EmissionMutator(int crateCount, float crateCash, string id) { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}

	public MonkeyopolisModel monkeyopolisModel; //Field offset: 0x68
	private bool activated; //Field offset: 0x70
	private int cratesPerRound; //Field offset: 0x74
	private float cashFromCrate; //Field offset: 0x78
	private float totalCashPerCrate; //Field offset: 0x7C
	private int baseIncome; //Field offset: 0x80

	public float CashFromCrate
	{
		 get { } //Length: 6
	}

	public Monkeyopolis() { }

	public virtual void Attatched() { }

	public float get_CashFromCrate() { }

	public virtual void GetSaveMetaData(Dictionary<String, String> metaData) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public void Load(float crateCashLoaded, float totalCashPerCrateLoaded) { }

	protected virtual void OnDestroy() { }

	private void Process(int elapsed) { }

	public virtual void SetSaveMetaData(Dictionary<String, String> metaData) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

