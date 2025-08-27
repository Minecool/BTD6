namespace Assets.Scripts.Simulation.Bloons.Behaviors.Actions;

public class GenerateShieldAction : BloonBehaviorAction
{
	public GenerateShieldActionModel generateShieldActionModel; //Field offset: 0x78

	public GenerateShieldAction() { }

	private void AddArmour() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	public virtual void OnSpawn() { }

	public virtual void PerformAction() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

