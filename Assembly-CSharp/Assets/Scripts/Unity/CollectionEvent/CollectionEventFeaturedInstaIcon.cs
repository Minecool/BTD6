namespace Assets.Scripts.Unity.CollectionEvent;

public class CollectionEventFeaturedInstaIcon : MonoBehaviour
{
	public Image iconImage; //Field offset: 0x20
	public TMP_Text iconTextField; //Field offset: 0x28
	public GameObject selected; //Field offset: 0x30
	public TowerImageLoader towerImageLoader; //Field offset: 0x38
	private string towerId; //Field offset: 0x40
	private int index; //Field offset: 0x48
	private CollectionEventFeaturedInstas featuredInstas; //Field offset: 0x50

	public int Index
	{
		 get { } //Length: 4
	}

	public string TowerId
	{
		 get { } //Length: 5
	}

	public CollectionEventFeaturedInstaIcon() { }

	public int get_Index() { }

	public string get_TowerId() { }

	public void OnClicked() { }

	public void SetInfo(string towerId, int index) { }

	public void Start() { }

}

