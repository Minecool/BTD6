namespace Assets.Scripts.Simulation.Towers.Behaviors.Abilities.Behaviors;

public class SwitchDisplay : AbilityBehavior
{
	public class Mutator : BehaviorMutator
	{
		private PrefabReference display; //Field offset: 0x70

		public Mutator(PrefabReference display, string mutatorId) { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}

	public SwitchDisplayModel switchDisplayModel; //Field offset: 0x68
	private int framesAtCreation; //Field offset: 0x70
	private BehaviorMutator mutator; //Field offset: 0x78

	public SwitchDisplay() { }

	public virtual void Activate() { }

	public virtual void Attatched() { }

	public virtual void GetSaveMetaData(Dictionary<String, String> metaData) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual bool IsActive() { }

	public void OnDefeatScreen() { }

	protected virtual void OnDestroy() { }

	private void Process(int elapsed) { }

	public virtual void SetSaveMetaData(Dictionary<String, String> metaData) { }

	private void SwitchDisplays() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

