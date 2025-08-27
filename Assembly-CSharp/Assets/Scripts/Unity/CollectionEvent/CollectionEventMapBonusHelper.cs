namespace Assets.Scripts.Unity.CollectionEvent;

public class CollectionEventMapBonusHelper
{
	[CompilerGenerated]
	private static readonly CollectionEventMapBonusHelper <instance>k__BackingField; //Field offset: 0x0
	private int hoursUntilReroll; //Field offset: 0x10
	private bool isMapBonusActive; //Field offset: 0x14

	public static CollectionEventMapBonusHelper instance
	{
		[CompilerGenerated]
		 get { } //Length: 78
	}

	private DateTime Now
	{
		private get { } //Length: 7
	}

	private static CollectionEventMapBonusHelper() { }

	public CollectionEventMapBonusHelper() { }

	public bool DoesEventHaveMapBonus() { }

	public bool DoesTrackHaveBonus(string trackName) { }

	[CompilerGenerated]
	public static CollectionEventMapBonusHelper get_instance() { }

	private DateTime get_Now() { }

	private bool IsSameAsCurrent(MapDetails mapDetails) { }

	private bool NeedsUpdate() { }

	public void OnMapCompleted(string trackName) { }

	public void Reset() { }

	public void SyncToSku() { }

	public bool UpdateBonuses() { }

}

