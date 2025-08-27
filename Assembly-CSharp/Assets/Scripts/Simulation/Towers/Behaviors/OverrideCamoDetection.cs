namespace Assets.Scripts.Simulation.Towers.Behaviors;

public class OverrideCamoDetection : TowerBehavior
{
	public class MutatorTower : BehaviorMutator
	{
		private bool detectCamo; //Field offset: 0x70

		public MutatorTower(bool isUnique, string mutatorId, bool detectCamo) { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}

	public OverrideCamoDetectionModel overrideCamoDetectionModel; //Field offset: 0x68
	private MutatorTower mutator; //Field offset: 0x70
	public bool previousDetectCamo; //Field offset: 0x78

	public OverrideCamoDetection() { }

	public void FirstUpdate(int elapsed) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

