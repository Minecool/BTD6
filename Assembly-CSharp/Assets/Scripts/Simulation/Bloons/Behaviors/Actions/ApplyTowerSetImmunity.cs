namespace Assets.Scripts.Simulation.Bloons.Behaviors.Actions;

public class ApplyTowerSetImmunity : BloonBehaviorAction
{
	private int currentImmunityIndex; //Field offset: 0x78
	public ApplyTowerSetImmunityModel applyTowerSetImmunityModel; //Field offset: 0x80

	public ApplyTowerSetImmunity() { }

	private TowerSet GetCurrentImmunity() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	private void OnLoadedFromSave(Bloon obj) { }

	public virtual void OnSpawn() { }

	public virtual void PerformAction() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

