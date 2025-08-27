namespace Assets.Scripts.Unity.CollectionEvent;

public class CollectionEventFeaturedInstasHelper
{
	public const int numberOfFeaturedInstas = 4; //Field offset: 0x0
	private int timeBetweenPagesInSeconds; //Field offset: 0x10
	private List<String> instaMonkeysTypeList; //Field offset: 0x18
	private bool doesPageChangeThisFrame; //Field offset: 0x20

	public bool DoesPageChangeThisFrame
	{
		 get { } //Length: 5
	}

	public CollectionEventFeaturedInstasHelper() { }

	public bool get_DoesPageChangeThisFrame() { }

	public int GetCurrentPageNumber() { }

	public List<String> GetPossibleInstaMonkeys() { }

	public TimeSpan GetTimeUntilNextChange() { }

	public void Process() { }

	public void Refresh() { }

	public void RestockCharges() { }

}

