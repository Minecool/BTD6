namespace UnityEngine.Rendering;

public class DebugDisplaySettingsVolume : IDebugDisplaySettingsData, IDebugDisplaySettingsQuery
{
	[DisplayInfo(name = "Volume", order = 2147483647)]
	public class SettingsPanel : DebugDisplaySettingsPanel<DebugDisplaySettingsVolume>
	{
		private Table m_VolumeTable; //Field offset: 0x28

		public SettingsPanel(DebugDisplaySettingsVolume data) { }

		[CompilerGenerated]
		private void <.ctor>b__0_0(Field<Object> _, object __) { }

		[CompilerGenerated]
		private void <.ctor>b__0_1(Field<Int32> _, int __) { }

		private void Refresh() { }

	}

	private static class Strings
	{
		public static readonly string none; //Field offset: 0x0
		public static readonly string camera; //Field offset: 0x8
		public static readonly string parameter; //Field offset: 0x10
		public static readonly string component; //Field offset: 0x18
		public static readonly string debugViewNotSupported; //Field offset: 0x20
		public static readonly string parameterNotOverrided; //Field offset: 0x28
		public static readonly string volumeInfo; //Field offset: 0x30
		public static readonly string gameObject; //Field offset: 0x38
		public static readonly string resultValue; //Field offset: 0x40
		public static readonly string resultValueTooltip; //Field offset: 0x48
		public static readonly string globalDefaultValue; //Field offset: 0x50
		public static readonly string globalDefaultValueTooltip; //Field offset: 0x58
		public static readonly string qualityLevelValue; //Field offset: 0x60
		public static readonly string qualityLevelValueTooltip; //Field offset: 0x68
		public static readonly string global; //Field offset: 0x70
		public static readonly string local; //Field offset: 0x78
		public static readonly string volumeProfile; //Field offset: 0x80

		private static Strings() { }

	}

	private static class Styles
	{
		public static readonly GUIContent none; //Field offset: 0x0
		public static readonly GUIContent editorCamera; //Field offset: 0x8

		private static Styles() { }

	}

	public static class WidgetFactory
	{
		[CompilerGenerated]
		private sealed class <>c
		{
			public static readonly <>c <>9; //Field offset: 0x0
			public static Func<Object> <>9__9_2; //Field offset: 0x8

			private static <>c() { }

			public <>c() { }

			internal object <.cctor>b__11_0() { }

			internal object <GenerateTableColumns>b__9_2() { }

		}

		[CompilerGenerated]
		private sealed class <>c__DisplayClass0_0
		{
			public SettingsPanel panel; //Field offset: 0x10

			public <>c__DisplayClass0_0() { }

			internal int <CreateComponentSelector>b__0() { }

			internal void <CreateComponentSelector>b__1(int value) { }

			internal int <CreateComponentSelector>b__2() { }

			internal void <CreateComponentSelector>b__3(int value) { }

		}

		[CompilerGenerated]
		private sealed class <>c__DisplayClass1_0
		{
			public SettingsPanel panel; //Field offset: 0x10

			public <>c__DisplayClass1_0() { }

			internal object <CreateCameraSelector>b__0() { }

			internal void <CreateCameraSelector>b__1(object value) { }

			internal IEnumerable<Object> <CreateCameraSelector>b__2() { }

		}

		[CompilerGenerated]
		private sealed class <>c__DisplayClass7_0
		{
			public DebugDisplaySettingsVolume data; //Field offset: 0x10
			public float timer; //Field offset: 0x18
			public float refreshRate; //Field offset: 0x1C
			public Table table; //Field offset: 0x20
			public Volume[] volumes; //Field offset: 0x28

			public <>c__DisplayClass7_0() { }

			internal bool <CreateVolumeTable>b__0() { }

			internal bool <CreateVolumeTable>b__1() { }

		}

		[CompilerGenerated]
		private sealed class <>c__DisplayClass9_0
		{
			public DebugDisplaySettingsVolume data; //Field offset: 0x10

			public <>c__DisplayClass9_0() { }

		}

		[CompilerGenerated]
		private sealed class <>c__DisplayClass9_1
		{
			public VolumeParameterChain chain; //Field offset: 0x10
			public <>c__DisplayClass9_0 CS$<>8__locals1; //Field offset: 0x38

			public <>c__DisplayClass9_1() { }

			internal object <GenerateTableColumns>b__0() { }

			internal object <GenerateTableColumns>b__1() { }

			internal object <GenerateTableColumns>b__3() { }

		}

		private struct VolumeParameterChain
		{
			public NameAndTooltip nameAndTooltip; //Field offset: 0x0
			public VolumeProfile volumeProfile; //Field offset: 0x10
			public VolumeComponent volumeComponent; //Field offset: 0x18
			public Volume volume; //Field offset: 0x20

		}

		private static Value s_EmptyDebugUIValue; //Field offset: 0x0

		private static WidgetFactory() { }

		public static ObjectPopupField CreateCameraSelector(SettingsPanel panel, Action<Field`1<Object>, Object> refresh) { }

		public static EnumField CreateComponentSelector(SettingsPanel panel, Action<Field`1<Int32>, Int32> refresh) { }

		private static Widget CreateVolumeParameterWidget(string name, bool isResultParameter, VolumeParameter param, Func<Boolean> isHiddenCallback = null) { }

		public static Table CreateVolumeTable(DebugDisplaySettingsVolume data) { }

		private static void GenerateTableColumns(Table table, DebugDisplaySettingsVolume data, List<VolumeParameterChain> resolutionChain) { }

		private static void GenerateTableRows(Table table, List<VolumeParameterChain> resolutionChain) { }

		private static List<VolumeParameterChain> GetResolutionChain(DebugDisplaySettingsVolume data) { }

		private static VolumeComponent GetSelectedVolumeComponent(VolumeProfile profile, Type selectedType) { }

		private static void SetTableColumnVisibility(DebugDisplaySettingsVolume data, Table table) { }

	}

	private const string k_PanelTitle = "Volume"; //Field offset: 0x0
	[CompilerGenerated]
	private readonly IVolumeDebugSettings <volumeDebugSettings>k__BackingField; //Field offset: 0x10
	internal int volumeComponentEnumIndex; //Field offset: 0x18
	internal Dictionary<String, VolumeComponent> debugState; //Field offset: 0x20

	public override bool AreAnySettingsActive
	{
		 get { } //Length: 3
	}

	public IVolumeDebugSettings volumeDebugSettings
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public DebugDisplaySettingsVolume(IVolumeDebugSettings volumeDebugSettings) { }

	public override IDebugDisplaySettingsPanelDisposable CreatePanel() { }

	public override bool get_AreAnySettingsActive() { }

	[CompilerGenerated]
	public IVolumeDebugSettings get_volumeDebugSettings() { }

}

