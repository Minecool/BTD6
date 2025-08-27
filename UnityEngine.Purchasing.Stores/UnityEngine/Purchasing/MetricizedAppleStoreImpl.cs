namespace UnityEngine.Purchasing;

[Nullable(0)]
[NullableContext(1)]
internal class MetricizedAppleStoreImpl : AppleStoreImpl
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass10_0
	{
		[Nullable(0)]
		public MetricizedAppleStoreImpl <>4__this; //Field offset: 0x10
		[Nullable(new IL2CPP_TYPE_U1[] {0, 1}])]
		public ReadOnlyCollection<ProductDefinition> products; //Field offset: 0x18

		public <>c__DisplayClass10_0() { }

		internal void <RetrieveProducts>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass11_0
	{
		[Nullable(0)]
		public MetricizedAppleStoreImpl <>4__this; //Field offset: 0x10
		[Nullable(0)]
		public ProductDefinition product; //Field offset: 0x18
		[Nullable(0)]
		public string developerPayload; //Field offset: 0x20

		public <>c__DisplayClass11_0() { }

		internal void <Purchase>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass6_0
	{
		[Nullable(0)]
		public MetricizedAppleStoreImpl <>4__this; //Field offset: 0x10
		[Nullable(new IL2CPP_TYPE_U1[] {0, 2}])]
		public Action<Boolean, String> callback; //Field offset: 0x18

		public <>c__DisplayClass6_0() { }

		internal void <RestoreTransactions>b__0() { }

	}

	private readonly ITelemetryMetricsService m_TelemetryMetricsService; //Field offset: 0xD0

	public MetricizedAppleStoreImpl(IUtil util, ITelemetryDiagnostics telemetryDiagnostics, ITelemetryMetricsService telemetryMetricsService) { }

	[CompilerGenerated]
	[DebuggerHidden]
	[NullableContext(2)]
	private void <>n__4(Action<Boolean, String> callback) { }

	[CompilerGenerated]
	[DebuggerHidden]
	[NullableContext(0)]
	private void <>n__6(ReadOnlyCollection<ProductDefinition> products) { }

	[CompilerGenerated]
	[DebuggerHidden]
	[NullableContext(0)]
	private void <>n__7(ProductDefinition product, string developerPayload) { }

	public virtual void Purchase(ProductDefinition product, string developerPayload) { }

	[NullableContext(2)]
	public virtual void RestoreTransactions(Action<Boolean, String> callback) { }

	public virtual void RetrieveProducts(ReadOnlyCollection<ProductDefinition> products) { }

}

