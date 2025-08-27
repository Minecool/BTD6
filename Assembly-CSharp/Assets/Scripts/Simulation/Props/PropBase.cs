namespace Assets.Scripts.Simulation.Props;

public class PropBase : CommonBehaviorProxy<IEntityBehavior>
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<AnimationSpecialEffect, Boolean> <>9__69_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <get_IsParticleEffectProp>b__69_0(AnimationSpecialEffect behavior) { }

	}

	private const string previewAnimTrigger = "Preview"; //Field offset: 0x0
	private const string placeAnimTrigger = "Place"; //Field offset: 0x0
	private const string showAnimTrigger = "Remove"; //Field offset: 0x0
	public PropModel propModel; //Field offset: 0x150
	public int customModelPropIndex; //Field offset: 0x158
	public ObjectId parentTowerId; //Field offset: 0x15C
	public float worth; //Field offset: 0x160
	public long damageDealt; //Field offset: 0x168
	public long cashEarned; //Field offset: 0x170
	public Vector3 rotation3D; //Field offset: 0x178
	public List<RootBehavior> modelBehaviors; //Field offset: 0x188
	public RootObjectLockList<BloonBehavior> bloonBehaviors; //Field offset: 0x190
	public RootObjectLockList<WeaponBehavior> weaponBehaviors; //Field offset: 0x198
	public RootObjectLockList<AttackBehavior> attackBehaviors; //Field offset: 0x1A0
	public RootObjectLockList<ProjectileBehavior> projectileBehaviors; //Field offset: 0x1A8
	public RootObjectLockList<IEntityBehavior> entityBehaviors; //Field offset: 0x1B0
	public string uniqueId; //Field offset: 0x1B8
	public int originalOwner; //Field offset: 0x1C0
	public Action<Entity, ObjectId, ObjectId> OnAreaChanged; //Field offset: 0x1C8
	public ObjectId AreaPlacedOn; //Field offset: 0x1D0
	public bool isSelectionBlocked; //Field offset: 0x1D4
	public List<Area> areaReferences; //Field offset: 0x1D8
	[CompilerGenerated]
	private bool <AreAreaBlockersDisabled>k__BackingField; //Field offset: 0x1E0
	[CompilerGenerated]
	private bool <IsCustomProp>k__BackingField; //Field offset: 0x1E1
	[CompilerGenerated]
	private bool <LockTargetTypeSwitching>k__BackingField; //Field offset: 0x1E2
	private Nullable<Boolean> _isDisabled; //Field offset: 0x1E3
	public PositionalData pd; //Field offset: 0x1E8
	public int groupLayer; //Field offset: 0x1F0
	public bool inPreviewMode; //Field offset: 0x1F4
	private string lostTargetType; //Field offset: 0x1F8
	private string loadedTargetType; //Field offset: 0x200
	private Nullable<Boolean> _isParticleEffectProp; //Field offset: 0x208

	public private bool AreAreaBlockersDisabled
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public virtual RootObjectLockList<IEntityBehavior> Behaviors
	{
		 get { } //Length: 8
	}

	public bool HasAnimatorController
	{
		 get { } //Length: 52
	}

	public bool IsAnimating
	{
		 get { } //Length: 153
	}

	public bool IsCustomProp
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 7
	}

	public bool IsDisabled
	{
		 get { } //Length: 299
	}

	public bool IsParticleEffectProp
	{
		 get { } //Length: 409
	}

	public bool IsSelectable
	{
		 get { } //Length: 36
	}

	public private bool LockTargetTypeSwitching
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public PropBase() { }

	public virtual void Attatched() { }

	private void CheckPreviewAnimatorMode() { }

	protected void Exhausted() { }

	public virtual void Expire() { }

	protected void Expired() { }

	[CompilerGenerated]
	public bool get_AreAreaBlockersDisabled() { }

	public virtual RootObjectLockList<IEntityBehavior> get_Behaviors() { }

	public bool get_HasAnimatorController() { }

	public bool get_IsAnimating() { }

	[CompilerGenerated]
	public bool get_IsCustomProp() { }

	public bool get_IsDisabled() { }

	public bool get_IsParticleEffectProp() { }

	public bool get_IsSelectable() { }

	[CompilerGenerated]
	public bool get_LockTargetTypeSwitching() { }

	public int GetAnimLength() { }

	public string GetAreaName() { }

	public string GetRemovableCostKey() { }

	public double GetRemovealCost() { }

	public PropSaveDataModel GetSaveData() { }

	public override void Hilight() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public void OnAddAreas(bool destroyTowersInsideArea = true) { }

	protected virtual void OnDestroy() { }

	public void OnExpire() { }

	public void OnPlace() { }

	public virtual void OnProjectilesCreated(List<Projectile> projectiles) { }

	public void OnSold(float amount) { }

	public virtual float Pickup(Tower towerPickingUp) { }

	public override void Selected() { }

	[CompilerGenerated]
	private void set_AreAreaBlockersDisabled(bool value) { }

	[CompilerGenerated]
	public void set_IsCustomProp(bool value) { }

	[CompilerGenerated]
	private void set_LockTargetTypeSwitching(bool value) { }

	public void SetHeight(float value) { }

	public void SetPitch(float value) { }

	public void SetRoll(float value) { }

	private void SetRotation(Vector3 rotation) { }

	public void SetSaveData(PropSaveDataModel saveData) { }

	public void SetTargetType(TargetType type) { }

	public void SetTransform(PositionalData pd) { }

	public void SetYaw(float value) { }

	public void ToggleAnimation(bool isOn) { }

	private void ToggledDisabledState(bool disabled) { }

	public void ToggleMapEditorVisibility(int propCategoryIndex, bool isVisible, bool isSpecialEffectPropLayer) { }

	public void ToggleSightAndPlacementBlocking(bool isOn, bool destroyTowersInsideArea = true) { }

	public void ToggleVisibilityAndActivation(bool show, bool ignoreCost = true, bool destroyTowersInsideArea = true) { }

	public void TriggerPlacementAnimation() { }

	public void TriggerPreviewAnimator() { }

	public override void UnHighlight() { }

	public override void UnSelected() { }

	public virtual void UpdatedModel(Model modelToUse) { }

	private void UpdateTargetType() { }

	public void UpdateThrowCache() { }

	public void UpdateThrowLocation() { }

}

