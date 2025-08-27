namespace Assets.Scripts.Unity.Store;

public class BeastHandlerUnlockCondition : StoreItemCondition
{

	public BeastHandlerUnlockCondition() { }

	public virtual bool IsAlreadyPurchased(StoreItem storeItem) { }

}

