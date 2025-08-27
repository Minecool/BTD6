namespace Assets.Scripts.Simulation.Towers.Behaviors;

public class SelfStackingSupport : TowerBehavior
{
	public SelfStackingSupportModel selfStackingSupportModel; //Field offset: 0x68
	protected BehaviorMutator mutator; //Field offset: 0x70
	private Zoned<Tower> zone; //Field offset: 0x78
	public string thisUniqueMutatorId; //Field offset: 0x80

	public SelfStackingSupport() { }

	public virtual void Attatched() { }

	private void CheckTower(Tower towerInZone) { }

	protected override void CreateMutator(string mutatorIdToUse) { }

	public float GetRange() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	private void RemoveMutator(Tower towerInZone) { }

	public void RunZone() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

