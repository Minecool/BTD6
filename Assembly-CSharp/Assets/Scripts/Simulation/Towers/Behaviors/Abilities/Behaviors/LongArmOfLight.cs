namespace Assets.Scripts.Simulation.Towers.Behaviors.Abilities.Behaviors;

public class LongArmOfLight : AbilityBehavior
{
	public LongArmOfLightModel longArmOfLightModel; //Field offset: 0x68

	public LongArmOfLight() { }

	public virtual void Activate() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual bool IsActive() { }

	protected virtual void OnDestroy() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

