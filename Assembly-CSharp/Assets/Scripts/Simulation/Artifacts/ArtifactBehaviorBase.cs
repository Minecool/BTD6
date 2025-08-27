namespace Assets.Scripts.Simulation.Artifacts;

public abstract class ArtifactBehaviorBase : RootBehavior
{
	public ArtifactBase artifactBase; //Field offset: 0x58
	public ArtifactBehaviorModelBase artifactBehaviorBaseModel; //Field offset: 0x60

	protected ArtifactBehaviorBase() { }

	public override float GetDiscount(Tower tower, int path, int tier) { }

	public override int GetInstaCooldownAddition(string towerType) { }

	public override void GetModifiedPlacementModel(ref TowerModel clonedTowerModel) { }

	public override ProjectileModel GetModifiedTowerEmittedProjectileModel(ProjectileModel projectileModel, Tower tower, Weapon entityWeapon) { }

	public override void GetPreModifiedPlacementModel(ref TowerModel clonedTowerModel) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public override bool IsChangingPlacementModel(TowerModel towerModel) { }

}

