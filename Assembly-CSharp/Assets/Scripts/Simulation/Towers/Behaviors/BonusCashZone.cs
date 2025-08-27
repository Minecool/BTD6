namespace Assets.Scripts.Simulation.Towers.Behaviors;

public class BonusCashZone : TowerBehavior
{
	public class Mutator : BehaviorMutator
	{
		public float multiplier; //Field offset: 0x70

		public Mutator(bool isUnique, string mutationId, float multiplier) { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}

	public BonusCashZoneModel bounsBonusCashZoneModel; //Field offset: 0x68
	private BehaviorMutator mutator; //Field offset: 0x70
	private Zoned<Bloon> zone; //Field offset: 0x78

	public BonusCashZone() { }

	public virtual void Attatched() { }

	private bool FilterBloon(RootBehavior behavior) { }

	public float GetRange() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	private void InitialiseZone() { }

	protected virtual void OnDestroy() { }

	private void RemoveMutator(Bloon behavior) { }

	private void TestBehavior(Bloon bloon) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

