namespace Assets.Scripts.Simulation.Towers.Weapons.Behaviors;

public class FlipFollowPath : WeaponBehavior
{
	public FlipFollowPathModel flipFollowPathModel; //Field offset: 0x68
	private bool isFlipped; //Field offset: 0x70
	private TSMInfoModel newInfo; //Field offset: 0x78

	public FlipFollowPath() { }

	public virtual Nullable<Vector3> EmitPosition() { }

	private void Flip(bool setIsFlipped, bool playEffect) { }

	public virtual void GetSaveMetaData(Dictionary<String, String> metaData) { }

	public virtual void GetTsmThemeInfo(out TSMInfoModel info, out string infoId) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void OnTsmThemeAction(string themeId, string buttonId, object info) { }

	public virtual void ProjectilesCreated(List<Projectile> projectiles) { }

	public virtual void SetSaveMetaData(Dictionary<String, String> metaData) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

