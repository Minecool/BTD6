namespace Assets.Scripts.Simulation.Towers.Mutators;

public class ProjectileSpeedTowerMutator : TowerMutator
{
	public class Mutator : BaseMutator
	{
		public ProjectileSpeedTowerMutatorModel speedModel; //Field offset: 0x78

		public Mutator(ProjectileSpeedTowerMutatorModel model) { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}

	public ProjectileSpeedTowerMutatorModel projectileSpeedModel; //Field offset: 0x68

	public ProjectileSpeedTowerMutator() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

