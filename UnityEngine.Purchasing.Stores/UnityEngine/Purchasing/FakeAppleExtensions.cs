namespace UnityEngine.Purchasing;

[Nullable(0)]
[NullableContext(1)]
internal class FakeAppleExtensions : IAppleExtensions, IStoreExtension
{

	public FakeAppleExtensions() { }

	[NullableContext(2)]
	public override void RestoreTransactions(Action<Boolean, String> callback) { }

}

