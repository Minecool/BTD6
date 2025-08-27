namespace UnityEngine.Purchasing;

public enum GooglePlayProrationMode
{
	UnknownSubscriptionUpgradeDowngradePolicy = 0,
	ImmediateWithTimeProration = 1,
	ImmediateAndChargeProratedPrice = 2,
	ImmediateWithoutProration = 3,
	Deferred = 4,
	ImmediateAndChargeFullPrice = 5,
}

