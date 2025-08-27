namespace Newtonsoft.Json.UnityConverters;

public static class UnityConverterInitializer
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<ConverterConfig, Type> <>9__14_0; //Field offset: 0x8
		public static Func<ConverterConfig, Type> <>9__14_1; //Field offset: 0x10
		public static Func<ConverterConfig, Type> <>9__14_2; //Field offset: 0x18
		public static Func<Assembly, IEnumerable`1<Type>> <>9__16_0; //Field offset: 0x20
		public static Func<Type, Boolean> <>9__17_0; //Field offset: 0x28
		public static Func<Type, String> <>9__17_1; //Field offset: 0x30
		public static Func<ConverterConfig, Boolean> <>9__18_0; //Field offset: 0x38
		public static Func<ConverterConfig, Type> <>9__18_1; //Field offset: 0x40
		public static Func<Type, Boolean> <>9__18_2; //Field offset: 0x48

		private static <>c() { }

		public <>c() { }

		internal bool <ApplyConfigFilter>b__18_0(ConverterConfig o) { }

		internal Type <ApplyConfigFilter>b__18_1(ConverterConfig o) { }

		internal bool <ApplyConfigFilter>b__18_2(Type o) { }

		internal bool <FilterToJsonConvertersAndOrder>b__17_0(Type type) { }

		internal string <FilterToJsonConvertersAndOrder>b__17_1(Type type) { }

		internal IEnumerable<Type> <FindConverters>b__16_0(Assembly dll) { }

		internal Type <FindGroupedConverters>b__14_0(ConverterConfig x) { }

		internal Type <FindGroupedConverters>b__14_1(ConverterConfig x) { }

		internal Type <FindGroupedConverters>b__14_2(ConverterConfig x) { }

	}

	private static bool _shouldAddConvertsToDefaultSettings; //Field offset: 0x0
	[CompilerGenerated]
	private static JsonSerializerSettings <defaultUnityConvertersSettings>k__BackingField; //Field offset: 0x8

	public static JsonSerializerSettings defaultUnityConvertersSettings
	{
		[CompilerGenerated]
		 get { } //Length: 79
		[CompilerGenerated]
		 set { } //Length: 85
	}

	public static bool shouldAddConvertsToDefaultSettings
	{
		 get { } //Length: 78
		 set { } //Length: 89
	}

	private static UnityConverterInitializer() { }

	private static IEnumerable<Type> ApplyConfigFilter(IEnumerable<Type> types, bool useAll, IEnumerable<ConverterConfig> configs) { }

	private static JsonConverter CreateConverter(Type jsonConverterType) { }

	internal static List<JsonConverter> CreateConverters(UnityConvertersConfig config) { }

	private static JsonSerializerSettings CreateJsonSettingsWithFreslyLoadedConfig() { }

	private static IEnumerable<Type> FilterToJsonConvertersAndOrder(IEnumerable<Type> types) { }

	internal static IEnumerable<Type> FindConverters() { }

	internal static ConverterGrouping FindGroupedConverters(UnityConvertersConfig config) { }

	[CompilerGenerated]
	public static JsonSerializerSettings get_defaultUnityConvertersSettings() { }

	public static bool get_shouldAddConvertsToDefaultSettings() { }

	internal static JsonSerializerSettings GetExistingDefaultUnitySettings() { }

	private static Type GetTypeOrLog(string name, string assemblyName) { }

	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType::BeforeSceneLoad (1))]
	internal static void Init() { }

	public static void RefreshSettingsFromConfig() { }

	[CompilerGenerated]
	public static void set_defaultUnityConvertersSettings(JsonSerializerSettings value) { }

	public static void set_shouldAddConvertsToDefaultSettings(bool value) { }

	private static void UpdateDefaultSettings() { }

}

