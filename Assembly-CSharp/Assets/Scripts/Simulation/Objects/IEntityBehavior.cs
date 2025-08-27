namespace Assets.Scripts.Simulation.Objects;

public interface IEntityBehavior
{

	public bool IsDestroyed
	{
		 get { } //Length: 0
	}

	public Model Model
	{
		 get { } //Length: 0
	}

	public ICommonBehaviorProxy Owner
	{
		 get { } //Length: 0
	}

	public bool CanBeDepleted() { }

	public void Collide(Bloon bloon) { }

	public bool CollideMap(MapBlocker blocker) { }

	public void CollideObject(ICollidable collidable) { }

	public void Depleted() { }

	public void DoAfterMapLoad() { }

	public void Exhausted() { }

	public void Expired() { }

	public bool FilterCollision(Bloon bloon) { }

	public bool FilterMapCollision(MapBlocker blocker) { }

	public bool get_IsDestroyed() { }

	public Model get_Model() { }

	public ICommonBehaviorProxy get_Owner() { }

	public void GetSaveMetaData(Dictionary<String, String> metaData) { }

	public float GetTowerCostMultiplier(string towerId) { }

	public void GetTsmThemeInfo(out TSMInfoModel info, out string infoId) { }

	public void LateSetSaveMetaData(Dictionary<String, String> metaData) { }

	public void OnBloonCreate(Bloon bloon) { }

	public void OnBloonDamaged(Bloon bloon, float amount) { }

	public void OnBloonEnterTrack(Bloon bloon) { }

	public void OnChangeTargetPriority(TargetType targetType) { }

	public void OnDeSelected() { }

	public void OnExpire() { }

	public void OnLivesLost(bool fromLeak) { }

	public void OnPlace(bool playPlacementEffects) { }

	public void OnPreChangeTargetPriority(TargetType targetType) { }

	public void OnPreLivesLost(bool fromLeak) { }

	public void OnProjectilesCreated(List<Projectile> projectiles) { }

	public void OnRoundComplete(int roundArrayIndex) { }

	public void OnRoundStart(int roundNo) { }

	public void OnSelected() { }

	public void OnSold(float amount) { }

	public void OnTsmThemeAction(string themeId, string buttonId, object info) { }

	public void OnUpgrade(bool playEffect) { }

	public void OnUpgraded(int pathUpgraded) { }

	public void OnVisibilityToggled(bool isVisible) { }

	public float Pickup(Tower towerPickingUp) { }

	public void PostAttached() { }

	public void SetSaveMetaData(Dictionary<String, String> metaData) { }

	public void SetStartPosition(Vector3 pos) { }

	public void SetTarget(Target target) { }

	public float TransformXp(float xp) { }

}

