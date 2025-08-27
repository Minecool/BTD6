namespace Assets.Scripts.Simulation.Bloons.Behaviors;

public class BuffBloonsInRadiusAction : BloonBehaviorAction
{
	public BuffBloonsInRadiusActionModel modl; //Field offset: 0x78

	public BuffBloonsInRadiusAction() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void PerformAction() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

