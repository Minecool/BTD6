namespace Assets.Scripts.Simulation.Towers.Behaviors;

public class SkimBloons : TowerBehavior
{
	public SkimBloonsModel skimBloonsModel; //Field offset: 0x68

	public SkimBloons() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void OnBloonCreate(Bloon bloon) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

