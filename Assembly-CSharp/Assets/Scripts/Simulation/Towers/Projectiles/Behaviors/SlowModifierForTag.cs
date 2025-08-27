namespace Assets.Scripts.Simulation.Towers.Projectiles.Behaviors;

public class SlowModifierForTag : ProjectileBehavior
{
	public SlowModifierForTagModel slowModifierForTagModel; //Field offset: 0x68

	public SlowModifierForTag() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

