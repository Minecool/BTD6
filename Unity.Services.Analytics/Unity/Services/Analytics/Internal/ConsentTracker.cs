namespace Unity.Services.Analytics.Internal;

internal class ConsentTracker : IConsentTracker
{
	private readonly IGeoAPI m_GeoAPI; //Field offset: 0x10
	private readonly ICoreStatsHelper m_CoreStatsHelper; //Field offset: 0x18
	[CompilerGenerated]
	private ConsentStatus <optInPiplConsentStatus>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private ConsentStatus <optOutConsentStatus>k__BackingField; //Field offset: 0x24
	internal GeoIPResponse response; //Field offset: 0x28

	internal ConsentStatus optInPiplConsentStatus
	{
		[CompilerGenerated]
		internal get { } //Length: 4
		[CompilerGenerated]
		internal set { } //Length: 4
	}

	internal ConsentStatus optOutConsentStatus
	{
		[CompilerGenerated]
		internal get { } //Length: 4
		[CompilerGenerated]
		internal set { } //Length: 4
	}

	public ConsentTracker(ICoreStatsHelper coreStatsHelper) { }

	internal ConsentTracker(IGeoAPI geoApi, ICoreStatsHelper coreStatsHelper) { }

	public override void FinishOptOutProcess() { }

	[CompilerGenerated]
	internal ConsentStatus get_optInPiplConsentStatus() { }

	[CompilerGenerated]
	internal ConsentStatus get_optOutConsentStatus() { }

	public override bool IsConsentGiven() { }

	public override bool IsConsentGiven(string identifier) { }

	public override bool IsGeoIpChecked() { }

	public override bool IsOptingOutInProgress() { }

	internal void ReadOptInPiplConsentStatus() { }

	internal void ReadOptOutConsentStatus() { }

	[CompilerGenerated]
	internal void set_optInPiplConsentStatus(ConsentStatus value) { }

	[CompilerGenerated]
	internal void set_optOutConsentStatus(ConsentStatus value) { }

	private void ValidateConsentWasChecked() { }

}

