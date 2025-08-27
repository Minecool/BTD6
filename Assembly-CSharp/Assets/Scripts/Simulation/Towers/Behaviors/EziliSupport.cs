namespace Assets.Scripts.Simulation.Towers.Behaviors;

public class EziliSupport : TowerBehavior
{
	public EziliSupportModel eziliSupportModel; //Field offset: 0x68
	private Zoned<Tower> zone; //Field offset: 0x70

	public EziliSupport() { }

	private void AddMutator(Tower behavior) { }

	public virtual void Attatched() { }

	private bool FilterTower(RootBehavior behavior) { }

	public float GetRange() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	private void InitialiseZone() { }

	protected virtual void OnDestroy() { }

	private void RemoveMutator(Tower behavior) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

