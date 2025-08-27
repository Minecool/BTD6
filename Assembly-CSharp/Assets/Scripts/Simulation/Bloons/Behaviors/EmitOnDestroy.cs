namespace Assets.Scripts.Simulation.Bloons.Behaviors;

public class EmitOnDestroy : BloonBehavior
{
	private EmitOnDestroyModel emitOnDestroyModel; //Field offset: 0x70
	private Emission emission; //Field offset: 0x78

	public EmitOnDestroy() { }

	private void Emit() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual bool LayersExhaused(DamageResult damageResult) { }

	protected virtual void OnDestroy() { }

	private void PlaySound() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

