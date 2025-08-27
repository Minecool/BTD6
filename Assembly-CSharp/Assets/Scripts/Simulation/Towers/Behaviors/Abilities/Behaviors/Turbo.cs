namespace Assets.Scripts.Simulation.Towers.Behaviors.Abilities.Behaviors;

public class Turbo : AbilityBehavior
{
	public TurboModel turboModel; //Field offset: 0x68
	public TurboMutator mutator; //Field offset: 0x70
	private string mutatorId; //Field offset: 0x78

	public Turbo() { }

	public virtual void Activate() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual bool IsActive() { }

	protected virtual void OnDestroy() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

