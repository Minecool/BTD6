namespace Assets.Scripts.Simulation.Towers.Behaviors.Abilities.Behaviors;

public class ArcaneMetamorphosis : MagusPerfectusAbilityBehavior
{
	public class MutatorTower : BehaviorMutator
	{
		private AssetPathModel display; //Field offset: 0x70

		public MutatorTower(AssetPathModel display) { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}

	public ArcaneMetamorphosisModel behaviourModel; //Field offset: 0x68
	private MutatorTower mutator; //Field offset: 0x70
	private int morphedUntil; //Field offset: 0x78
	private bool isCurrentlyMorphed; //Field offset: 0x7C
	private MagusPerfectusGraveyardStateManager stateManager; //Field offset: 0x80

	public ArcaneMetamorphosis() { }

	public virtual void Activate() { }

	public virtual bool CanUseAbility() { }

	private AssetPathModel GetDisplayDegree() { }

	public virtual void GetSaveMetaData(Dictionary<String, String> metaData) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual bool IsActive() { }

	public virtual void LateSetSaveMetaData(Dictionary<String, String> metaData) { }

	private void Morph(int morphedUntilFromSave = -1) { }

	public void Process(int elapsed) { }

	private void Unmorph() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

