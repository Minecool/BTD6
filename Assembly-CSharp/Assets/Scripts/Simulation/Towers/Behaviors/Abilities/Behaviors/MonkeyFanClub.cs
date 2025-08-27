namespace Assets.Scripts.Simulation.Towers.Behaviors.Abilities.Behaviors;

public class MonkeyFanClub : AbilityBehavior
{
	public class Mutator : BehaviorMutator
	{
		private MonkeyFanClubModel monkeyFanClubModel; //Field offset: 0x70
		public bool isOriginMonkey; //Field offset: 0x78
		private int tier; //Field offset: 0x7C

		public Mutator(MonkeyFanClubModel monkeyFanClubModel, string mutatorId, bool isOriginMonkey, int tier) { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}

	public const string mutatorIdNonPlasma = "MonkeyFanClub"; //Field offset: 0x0
	public const string mutatorIdPlasma = "MonkeyFanClubPlasma"; //Field offset: 0x0
	public MonkeyFanClubModel monkeyFanClubModel; //Field offset: 0x68
	private string mutatorId; //Field offset: 0x70
	private bool isPlasma; //Field offset: 0x78
	private BehaviorMutator mutator; //Field offset: 0x80
	private BehaviorMutator baseMutator; //Field offset: 0x88
	private List<TimedMutator> mutatorsToGet; //Field offset: 0x90

	public MonkeyFanClub() { }

	[CompilerGenerated]
	private int <Activate>b__11_0(Tower closestTower) { }

	public virtual void Activate() { }

	public virtual void Attatched() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public void OnDefeatScreen() { }

	protected virtual void OnDestroy() { }

	private void RemoveExistingMutators() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

