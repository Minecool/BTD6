namespace Assets.Scripts.Simulation.Towers.Behaviors.Abilities.Behaviors;

public class ChangeDamageType : AbilityBehavior
{
	public ChangeDamageTypeModel changeDamageTypeModel; //Field offset: 0x68
	private string mutatorId; //Field offset: 0x70

	public ChangeDamageType() { }

	public virtual void Activate() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual bool IsActive() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

