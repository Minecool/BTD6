namespace UnityEngine.Purchasing;

public class StandardPurchasingModule : AbstractPurchasingModule, IAndroidStoreSelection, IStoreConfiguration
{
	private class MicrosoftConfiguration : IMicrosoftConfiguration, IStoreConfiguration
	{
		private readonly StandardPurchasingModule module; //Field offset: 0x10

		public MicrosoftConfiguration(StandardPurchasingModule module) { }

	}

	public class StoreInstance
	{
		[CompilerGenerated]
		private readonly string <storeName>k__BackingField; //Field offset: 0x10
		[CompilerGenerated]
		private readonly IStore <instance>k__BackingField; //Field offset: 0x18

		internal IStore instance
		{
			[CompilerGenerated]
			internal get { } //Length: 5
		}

		internal string storeName
		{
			[CompilerGenerated]
			internal get { } //Length: 5
		}

		internal StoreInstance(string name, IStore instance) { }

		[CompilerGenerated]
		internal IStore get_instance() { }

		[CompilerGenerated]
		internal string get_storeName() { }

	}

	private static StandardPurchasingModule ModuleInstance; //Field offset: 0x0
	private static readonly Dictionary<AppStore, String> AndroidStoreNameMap; //Field offset: 0x8
	internal readonly string k_Version; //Field offset: 0x18
	private readonly INativeStoreProvider m_NativeStoreProvider; //Field offset: 0x20
	private readonly RuntimePlatform m_RuntimePlatform; //Field offset: 0x28
	[CompilerGenerated]
	private IUtil <util>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private ILogger <logger>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	private StoreInstance <storeInstance>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	private ITelemetryMetricsInstanceWrapper <telemetryMetricsInstanceWrapper>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	private ITelemetryDiagnosticsInstanceWrapper <telemetryDiagnosticsInstanceWrapper>k__BackingField; //Field offset: 0x50
	[CompilerGenerated]
	private AppStore <appStore>k__BackingField; //Field offset: 0x58
	[CompilerGenerated]
	private FakeStoreUIMode <useFakeStoreUIMode>k__BackingField; //Field offset: 0x5C
	[CompilerGenerated]
	private bool <useFakeStoreAlways>k__BackingField; //Field offset: 0x60
	private WinRTStore windowsStore; //Field offset: 0x68

	public private override AppStore appStore
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	internal ILogger logger
	{
		[CompilerGenerated]
		internal get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 5
	}

	internal StoreInstance storeInstance
	{
		[CompilerGenerated]
		internal get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 5
	}

	internal ITelemetryDiagnosticsInstanceWrapper telemetryDiagnosticsInstanceWrapper
	{
		[CompilerGenerated]
		internal get { } //Length: 5
		[CompilerGenerated]
		internal set { } //Length: 5
	}

	internal ITelemetryMetricsInstanceWrapper telemetryMetricsInstanceWrapper
	{
		[CompilerGenerated]
		internal get { } //Length: 5
		[CompilerGenerated]
		internal set { } //Length: 5
	}

	public bool useFakeStoreAlways
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public FakeStoreUIMode useFakeStoreUIMode
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	internal IUtil util
	{
		[CompilerGenerated]
		internal get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 5
	}

	private static StandardPurchasingModule() { }

	internal StandardPurchasingModule(IUtil util, ILogger logger, INativeStoreProvider nativeStoreProvider, RuntimePlatform platform, AppStore android, ITelemetryDiagnosticsInstanceWrapper telemetryDiagnosticsInstanceWrapper, ITelemetryMetricsInstanceWrapper telemetryMetricsInstanceWrapper) { }

	private void BindGoogleConfiguration(GooglePlayConfiguration googlePlayConfiguration) { }

	private void BindGoogleExtension(GooglePlayStoreExtensions googlePlayStoreExtensions) { }

	private IGooglePlayStoreService BuildAndInitGooglePlayStoreServiceAar(IGooglePurchaseCallback googlePurchaseCallback, IGoogleProductCallback googleProductCallback, IGooglePurchaseStateEnumProvider googlePurchaseStateEnumProvider) { }

	private static GooglePlayConfiguration BuildGooglePlayStoreConfiguration(IGooglePlayStoreService googlePlayStoreService, IGooglePurchaseCallback googlePurchaseCallback, IGoogleProductCallback googleProductCallback) { }

	public virtual void Configure() { }

	[CompilerGenerated]
	public override AppStore get_appStore() { }

	[CompilerGenerated]
	internal ILogger get_logger() { }

	[CompilerGenerated]
	internal StoreInstance get_storeInstance() { }

	[CompilerGenerated]
	internal ITelemetryDiagnosticsInstanceWrapper get_telemetryDiagnosticsInstanceWrapper() { }

	[CompilerGenerated]
	internal ITelemetryMetricsInstanceWrapper get_telemetryMetricsInstanceWrapper() { }

	[CompilerGenerated]
	public bool get_useFakeStoreAlways() { }

	[CompilerGenerated]
	public FakeStoreUIMode get_useFakeStoreUIMode() { }

	[CompilerGenerated]
	internal IUtil get_util() { }

	private INativeStore GetAndroidNativeStore(JSONStore store) { }

	public static StandardPurchasingModule Instance() { }

	public static StandardPurchasingModule Instance(AppStore androidStore) { }

	private IStore InstantiateAndroid() { }

	private IStore InstantiateAndroidHelper(JSONStore store) { }

	private IStore InstantiateApple() { }

	private IStore InstantiateFakeStore() { }

	private IStore InstantiateGoogleStore() { }

	private StoreInstance InstantiateStore() { }

	private IStore InstantiateUDP() { }

	private IStore instantiateWindowsStore() { }

	[CompilerGenerated]
	private void set_appStore(AppStore value) { }

	[CompilerGenerated]
	private void set_logger(ILogger value) { }

	[CompilerGenerated]
	private void set_storeInstance(StoreInstance value) { }

	[CompilerGenerated]
	internal void set_telemetryDiagnosticsInstanceWrapper(ITelemetryDiagnosticsInstanceWrapper value) { }

	[CompilerGenerated]
	internal void set_telemetryMetricsInstanceWrapper(ITelemetryMetricsInstanceWrapper value) { }

	[CompilerGenerated]
	public void set_useFakeStoreAlways(bool value) { }

	[CompilerGenerated]
	public void set_useFakeStoreUIMode(FakeStoreUIMode value) { }

	[CompilerGenerated]
	private void set_util(IUtil value) { }

}

