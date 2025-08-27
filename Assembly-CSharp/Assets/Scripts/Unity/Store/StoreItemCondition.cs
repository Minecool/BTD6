namespace Assets.Scripts.Unity.Store;

public abstract class StoreItemCondition
{

	protected StoreItemCondition() { }

	public override bool CanShowInStore(StoreItem storeItem, int rank) { }

	public override bool IsAlreadyPurchased(StoreItem storeItem) { }

}

