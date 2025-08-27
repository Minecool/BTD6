namespace Assets.Scripts.Simulation.Bloons.Behaviors;

public class StunTowersInRadiusAction : BloonBehaviorAction
{
	public StunTowersInRadiusActionModel modl; //Field offset: 0x78

	public StunTowersInRadiusAction() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void PerformAction() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

