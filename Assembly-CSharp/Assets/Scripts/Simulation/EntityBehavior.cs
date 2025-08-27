namespace Assets.Scripts.Simulation;

public abstract class EntityBehavior : RootBehavior, IEntityBehavior
{
	private ICommonBehaviorProxy owner; //Field offset: 0x58

	public override Model Model
	{
		 get { } //Length: 5
	}

	public override ICommonBehaviorProxy Owner
	{
		 get { } //Length: 5
	}

	public override Vector3Boxed Position
	{
		 get { } //Length: 181
	}

	protected EntityBehavior() { }

	public override bool CanBeDepleted() { }

	public virtual void Cleanup() { }

	public override void Collide(Bloon bloon) { }

	public override bool CollideMap(MapBlocker blocker) { }

	public override void CollideObject(ICollidable bloon) { }

	public override void Depleted() { }

	public override void DoAfterMapLoad() { }

	public override void Exhausted() { }

	public override void Expired() { }

	public override bool FilterCollision(Bloon bloon) { }

	public override bool FilterMapCollision(MapBlocker blocker) { }

	public override Model get_Model() { }

	public override ICommonBehaviorProxy get_Owner() { }

	public override Vector3Boxed get_Position() { }

	public override void GetSaveMetaData(Dictionary<String, String> metaData) { }

	public override float GetTowerCostMultiplier(string towerId) { }

	public override void GetTsmThemeInfo(out TSMInfoModel info, out string infoId) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public override void LateSetSaveMetaData(Dictionary<String, String> metaData) { }

	public override void OnBloonCreate(Bloon bloon) { }

	public override void OnBloonDamaged(Bloon bloon, float amount) { }

	public override void OnBloonEnterTrack(Bloon bloon) { }

	public override void OnChangeTargetPriority(TargetType targetType) { }

	public override void OnDeSelected() { }

	public override void OnExpire() { }

	public override void OnLivesLost(bool fromLeak) { }

	public override void OnPlace(bool playPlacementEffects) { }

	public override void OnPreChangeTargetPriority(TargetType targetType) { }

	public override void OnPreLivesLost(bool fromLeak) { }

	public override void OnProjectilesCreated(List<Projectile> projectiles) { }

	public override void OnRoundComplete(int roundArrayIndex) { }

	public override void OnRoundStart(int roundNo) { }

	public override void OnSelected() { }

	public override void OnSold(float amount) { }

	public override void OnTsmThemeAction(string themeId, string buttonId, object info) { }

	public override void OnUpgrade(bool playEffect) { }

	public override void OnUpgraded(int pathUpgraded) { }

	public override void OnVisibilityToggled(bool isVisible) { }

	public override float Pickup() { }

	public override void PostAttached() { }

	public override void SetSaveMetaData(Dictionary<String, String> metaData) { }

	public override void SetStartPosition(Vector3 pos) { }

	public override void SetTarget(Target target) { }

	public override float TransformXp(float xp) { }

}

