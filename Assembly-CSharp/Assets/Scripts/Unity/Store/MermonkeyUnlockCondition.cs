namespace Assets.Scripts.Unity.Store;

public class MermonkeyUnlockCondition : StoreItemCondition
{

	public MermonkeyUnlockCondition() { }

	public virtual bool IsAlreadyPurchased(StoreItem storeItem) { }

}

