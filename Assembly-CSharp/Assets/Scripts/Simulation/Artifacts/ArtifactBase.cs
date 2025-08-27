namespace Assets.Scripts.Simulation.Artifacts;

public class ArtifactBase : RootBehavior
{
	public Simulation sim; //Field offset: 0x58
	public ArtifactModelBase artifactBaseModel; //Field offset: 0x60
	private readonly List<RootBehavior> modelBehaviors; //Field offset: 0x68
	public readonly List<ArtifactBehaviorBase> artifactBaseBehaviors; //Field offset: 0x70

	public ArtifactBase() { }

	public float GetDiscount(Tower tower, int path, int tier) { }

	public int GetInstaCooldownAddition(string towerType) { }

	public void GetModifiedPlacementModel(ref TowerModel clonedTowerModel) { }

	public ProjectileModel GetModifiedTowerEmittedProjectileModel(ProjectileModel projectileModel, Tower tower, Weapon entityWeapon) { }

	public void GetPreModifiedPlacementModel(ref TowerModel clonedTowerModel) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public bool IsChangingPlacementModel(TowerModel towerModel) { }

	protected virtual void OnDestroy() { }

}

