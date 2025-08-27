namespace Assets.Scripts.Simulation.Towers.Pets;

public abstract class PetBehavior : RootBehavior
{
	public Pet pet; //Field offset: 0x58

	protected PetBehavior() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public override void OnPlace() { }

	public override void OnSold() { }

	public override void RotateAroundPivot(Vector2 pivotPoint, float rotation) { }

}

