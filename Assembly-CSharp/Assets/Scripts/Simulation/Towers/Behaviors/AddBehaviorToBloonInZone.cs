namespace Assets.Scripts.Simulation.Towers.Behaviors;

public class AddBehaviorToBloonInZone : TowerBehavior
{
	public AddBehaviorToBloonInZoneModel addBehaviorToBloonInZoneModel; //Field offset: 0x68
	private List<RootBehavior> createdBehaviors; //Field offset: 0x70

	public AddBehaviorToBloonInZone() { }

	public virtual void Attatched() { }

	private bool FilterBloon(RootBehavior behavior) { }

	public float GetRange() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	private void RemoveMutator(Bloon behavior) { }

	private void TestBehavior(Bloon bloon) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

