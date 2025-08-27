namespace Assets.Scripts.Simulation.Artifacts.Behaviors;

public class ArtifactDamageModifierIncludeDots : ItemArtifactBehavior
{
	public ArtifactDamageModifierIncludeDotsModel artifactDamageModifierIncludeDotsModel; //Field offset: 0x78

	public ArtifactDamageModifierIncludeDots() { }

	private void CheckTower(Tower updatedTower = null) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	private void OnTowerCreated(Tower tower, TowerModel def, float upgradeCost, bool isFromSave, double cashBefore, double cashAfter, bool isInsta) { }

	private void OnTowerSetChanged(Tower tower) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

