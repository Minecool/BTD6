namespace Unity.Services.Analytics.Internal;

internal interface IConsentTracker
{

	public void FinishOptOutProcess() { }

	public bool IsConsentGiven() { }

	public bool IsGeoIpChecked() { }

	public bool IsOptingOutInProgress() { }

}

