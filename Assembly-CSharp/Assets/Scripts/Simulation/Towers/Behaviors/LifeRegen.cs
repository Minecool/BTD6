namespace Assets.Scripts.Simulation.Towers.Behaviors;

public class LifeRegen : TowerBehavior
{
	public LifeRegenModel lifeRegenModel; //Field offset: 0x68

	public LifeRegen() { }

	public virtual void Attatched() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	private void RegenLives(int round) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

