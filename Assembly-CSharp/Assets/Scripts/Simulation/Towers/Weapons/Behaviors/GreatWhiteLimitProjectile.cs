namespace Assets.Scripts.Simulation.Towers.Weapons.Behaviors;

public class GreatWhiteLimitProjectile : WeaponBehavior
{
	public GreatWhiteLimitProjectileModel greatWhiteLimitProjectileModel; //Field offset: 0x68
	public GreatWhiteEffect currentEffect; //Field offset: 0x70
	private Projectile travelingProjectile; //Field offset: 0x78
	private Projectile attachedProjectile; //Field offset: 0x80
	private int limitUntil; //Field offset: 0x88

	public Projectile AttachedProjectile
	{
		 get { } //Length: 37
	}

	public bool IsInCooldown
	{
		 get { } //Length: 44
	}

	public GreatWhiteLimitProjectile() { }

	public void ClearCooldown() { }

	private void ClearEffect() { }

	public virtual bool FilterEmission() { }

	public Projectile get_AttachedProjectile() { }

	public bool get_IsInCooldown() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	private void OnAttachedProjectileDestroyed(RootObject obj) { }

	protected virtual void OnDestroy() { }

	private void OnRoundEnd(int obj) { }

	private void OnSandboxBloonsCleared() { }

	private void OnTowerUpgraded(Tower tower, TowerModel def, float upgradeCost, int pathUpgraded, double cashBefore, double cashAfter, bool playUpgradeEffect, bool isParagon, bool leveledFromEndOfRoundXp, double nonUpgradeCashInvestment) { }

	private void OnTravelingProjectileDestroyed(RootObject obj) { }

	public virtual void ProjectilesCreated(List<Projectile> projectiles) { }

	public void SetAttachedProjectile(Projectile attachedProjectile) { }

	public void SetCooldown(float cooldown) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

