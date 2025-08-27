namespace Assets.Scripts.Models.MapEditorBehaviors;

[CanvasModel("Prop Model")]
[Implementation(typeof(Prop), True, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(PropCollidable), typeof(PropBase)}])]
public class PropModel : EditorItemModel, IPlaceableEntity
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Predicate<AreaModel> <>9__34_0; //Field offset: 0x8
		public static Predicate<AreaModel> <>9__34_1; //Field offset: 0x10
		public static Predicate<AreaModel> <>9__34_2; //Field offset: 0x18

		private static <>c() { }

		public <>c() { }

		internal bool <.ctor>b__34_0(AreaModel x) { }

		internal bool <.ctor>b__34_1(AreaModel x) { }

		internal bool <.ctor>b__34_2(AreaModel x) { }

	}

	public MapEditorItemTag tags; //Field offset: 0x80
	public String[] collections; //Field offset: 0x88
	public AreaType[] areaTypes; //Field offset: 0x90
	public AreaModel[] areas; //Field offset: 0x98
	public bool loadedFromSave; //Field offset: 0xA0
	public string areaName; //Field offset: 0xA8
	public string propSelectionMenuThemeId; //Field offset: 0xB0
	public FootprintModel footprint; //Field offset: 0xB8
	public PropSetType propSetType; //Field offset: 0xC0
	public string linkedToTrophyStoreItemId; //Field offset: 0xC8
	public bool hasAnimationController; //Field offset: 0xD0
	public bool isSightAndPlacementBlockingDisabled; //Field offset: 0xD1
	public bool isAnimatorDisabledByDefault; //Field offset: 0xD2
	public DisplayModel displayModel; //Field offset: 0xD8
	public bool dontDestroyTowers; //Field offset: 0xE0
	public TargetType[] targetTypes; //Field offset: 0xE8
	[CompilerGenerated]
	private readonly bool <IsBlocking>k__BackingField; //Field offset: 0xF0
	[CompilerGenerated]
	private readonly bool <IsPlatform>k__BackingField; //Field offset: 0xF1
	[CompilerGenerated]
	private readonly bool <IgnorePropForSelection>k__BackingField; //Field offset: 0xF2
	[CompilerGenerated]
	private readonly bool <HasAreaPlatforms>k__BackingField; //Field offset: 0xF3
	[CompilerGenerated]
	private readonly bool <IsRemoveableProp>k__BackingField; //Field offset: 0xF4
	[CompilerGenerated]
	private readonly bool <IsSpecialEffectProp>k__BackingField; //Field offset: 0xF5

	public bool HasAreaPlatforms
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public bool IgnorePropForSelection
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public bool IsBlocking
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public bool IsPlatform
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public bool IsRemoveableProp
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public bool IsSpecialEffectProp
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public TargetType[] TargetTypes
	{
		 get { } //Length: 29
		 set { } //Length: 14
	}

	public PropModel(string name, int id, MapEditorItemTag tags, SpriteReference icon, PrefabReference display, AreaModel[] areas, PropSetType propSetType, string linkedToTrophyStoreItemId, bool hasAnimationController, bool isSightAndPlacementBlockingDisabled, String[] collections, bool isNewItem, bool isPremiumItem, ItemVarientData itemVarientData, Model[] behaviors = null, bool dontDestroyTowers = false, float radius = 5) { }

	public virtual Model Clone() { }

	public override bool ContainsAreaType(AreaType areaType) { }

	[CompilerGenerated]
	public bool get_HasAreaPlatforms() { }

	[CompilerGenerated]
	public bool get_IgnorePropForSelection() { }

	[CompilerGenerated]
	public bool get_IsBlocking() { }

	[CompilerGenerated]
	public bool get_IsPlatform() { }

	[CompilerGenerated]
	public bool get_IsRemoveableProp() { }

	[CompilerGenerated]
	public bool get_IsSpecialEffectProp() { }

	public TargetType[] get_TargetTypes() { }

	public override bool IsAmphibiousBased() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

	public override bool IsPlaceableInAreaType(AreaType areaType) { }

	public override bool IsWaterBased() { }

	public void set_TargetTypes(TargetType[] value) { }

	public void UpdateTargetProviders() { }

}

