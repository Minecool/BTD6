namespace Assets.Scripts.Unity.Store;

public class FastTrackUnlockCondition : StoreItemCondition
{

	public FastTrackUnlockCondition() { }

	public virtual bool IsAlreadyPurchased(StoreItem storeItem) { }

}

