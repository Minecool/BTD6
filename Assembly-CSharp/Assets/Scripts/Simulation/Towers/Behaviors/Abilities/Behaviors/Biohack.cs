namespace Assets.Scripts.Simulation.Towers.Behaviors.Abilities.Behaviors;

public class Biohack : AbilityBehavior
{
	public BiohackModel biohackModel; //Field offset: 0x68

	public Biohack() { }

	public virtual void Activate() { }

	public virtual bool CanUseAbility() { }

	public bool FilterTower(Tower t) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

