namespace Assets.Scripts.Simulation.Map.Actions;

public class ChangeEmitProjectileAction : MapAction
{
	public ChangeEmitProjectileActionModel changeEmitProjectileActionModel; //Field offset: 0x60

	public ChangeEmitProjectileAction() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void PerformAction() { }

}

