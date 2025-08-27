namespace UnityEngine.Purchasing;

public interface IAppleExtensions : IStoreExtension
{

	public void RestoreTransactions(Action<Boolean, String> callback) { }

}

