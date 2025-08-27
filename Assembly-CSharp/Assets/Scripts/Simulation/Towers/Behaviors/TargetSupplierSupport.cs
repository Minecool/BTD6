namespace Assets.Scripts.Simulation.Towers.Behaviors;

public class TargetSupplierSupport : Support
{
	public TargetSupplierSupportModel TargetSupplierSupportModel; //Field offset: 0x90

	public TargetSupplierSupport() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

