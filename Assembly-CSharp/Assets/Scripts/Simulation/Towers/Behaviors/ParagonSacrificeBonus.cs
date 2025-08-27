namespace Assets.Scripts.Simulation.Towers.Behaviors;

public class ParagonSacrificeBonus : TowerBehavior
{
	public ParagonSacrificeBonusModel paragonSacrificeBonusModel; //Field offset: 0x68

	public ParagonSacrificeBonus() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

