namespace Assets.Scripts.Simulation.Towers.Projectiles.Behaviors;

public class AddBehaviorModifierForTag : ProjectileBehavior
{
	public AddBehaviorModifierForTagModel addBehaviorModifierForTagModel; //Field offset: 0x68

	public AddBehaviorModifierForTag() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

