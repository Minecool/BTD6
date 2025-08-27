namespace Assets.Scripts.Simulation.Towers.Weapons.Behaviors;

public class HasUpgradeableProjectiles : WeaponBehavior
{
	private readonly TSMInfoModel newInfo; //Field offset: 0x68
	private Projectile activeProjectile; //Field offset: 0x70
	private int upgradeCount; //Field offset: 0x78
	public HasUpgradeableProjectilesModel upgrades; //Field offset: 0x80

	public HasUpgradeableProjectiles() { }

	private void ActiveProjectile_OnDestroyEvent(RootObject obj) { }

	private bool CanUpgrade() { }

	public virtual void GetSaveMetaData(Dictionary<String, String> metaData) { }

	public virtual void GetTsmThemeInfo(out TSMInfoModel info, out string infoId) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	public virtual void OnTsmThemeAction(string themeId, string buttonId, object info) { }

	public virtual void ProjectilesCreated(List<Projectile> projectiles) { }

	public virtual void SetSaveMetaData(Dictionary<String, String> metaData) { }

	public virtual void UpdatedModel(Model modelToUse) { }

	private void Upgrade(int playerId) { }

}

