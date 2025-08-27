namespace Assets.Scripts.Simulation.Behaviors.Events.Actions;

public class SpawnEffectAction : EntityAction
{
	public SpawnEffectActionModel spawnEffectActionModel; //Field offset: 0x68

	public SpawnEffectAction() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void PerformAction() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

