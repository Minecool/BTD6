namespace Assets.Scripts.Simulation.Towers.Weapons.Behaviors;

public class SwapProjectile : WeaponBehavior
{
	public SwapProjectileModel swapProjectileModel; //Field offset: 0x68
	private bool isProjectileBActive; //Field offset: 0x70
	private AirUnit airUnit; //Field offset: 0x78
	public bool emitBoth; //Field offset: 0x80
	private int lastWeaponSwapAt; //Field offset: 0x84
	private TSMInfoModel newInfo; //Field offset: 0x88

	public bool IsProjectileBActive
	{
		 get { } //Length: 5
	}

	public SwapProjectile() { }

	public virtual Nullable<Vector3> EmitPosition() { }

	public bool get_IsProjectileBActive() { }

	private Vector3 GetEmitPositionForProjectile(bool forProjectileB) { }

	public virtual ProjectileModel GetProjectile(ProjectileModel currentProjectileDef, bool doubleShot = false) { }

	public virtual void GetSaveMetaData(Dictionary<String, String> metaData) { }

	public virtual void GetTsmThemeInfo(out TSMInfoModel info, out string infoId) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void OnTsmThemeAction(string themeId, string buttonId, object info) { }

	private void PlayHeroVoice() { }

	private void PlaySoundOnProjectileCreated() { }

	public virtual void ProjectilesCreated(List<Projectile> projectiles) { }

	public virtual void SetSaveMetaData(Dictionary<String, String> metaData) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

