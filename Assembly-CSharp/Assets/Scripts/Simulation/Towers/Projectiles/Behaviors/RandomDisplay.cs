namespace Assets.Scripts.Simulation.Towers.Projectiles.Behaviors;

public class RandomDisplay : ProjectileBehavior
{
	public RandomDisplayModel rdModel; //Field offset: 0x68

	public RandomDisplay() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void PostAttached() { }

	public void SetSpecificDisplay(int index) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

