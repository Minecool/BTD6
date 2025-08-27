namespace Assets.Scripts.Simulation.Towers.Behaviors.Abilities.Behaviors;

public class AbilityCreateTower : AbilityBehavior
{
	public AbilityCreateTowerModel createTowerModel; //Field offset: 0x68
	private Tower createdTower; //Field offset: 0x70
	private string prevID; //Field offset: 0x78
	private int prevIndex; //Field offset: 0x80

	public AbilityCreateTower() { }

	public virtual void Activate() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	private void OnCreatedTowerDestroyed(RootObject _) { }

	protected virtual void OnDestroy() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

