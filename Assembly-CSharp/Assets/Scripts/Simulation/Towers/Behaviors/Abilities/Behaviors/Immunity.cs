namespace Assets.Scripts.Simulation.Towers.Behaviors.Abilities.Behaviors;

public class Immunity : AbilityBehavior
{
	public ImmunityModel immunityModel; //Field offset: 0x68
	private int startedAt; //Field offset: 0x70
	private List<Entity> effects; //Field offset: 0x78
	private String[] immunityFromBloonType; //Field offset: 0x80

	public Immunity() { }

	public virtual void Activate() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual bool IsActive() { }

	protected virtual void OnDestroy() { }

	public void Process(int elasped) { }

	private void RemoveImmunity() { }

	private void SpawnEffects() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

