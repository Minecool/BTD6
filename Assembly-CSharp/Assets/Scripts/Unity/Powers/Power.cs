namespace Assets.Scripts.Unity.Powers;

public class Power : MonoBehaviour
{
	public int cost; //Field offset: 0x20
	public bool canBeActivatedBetweenRounds; //Field offset: 0x24
	public GameObject icon; //Field offset: 0x28
	public Tower tower; //Field offset: 0x30
	public bool isHidden; //Field offset: 0x38
	public bool showBuffsForTower; //Field offset: 0x39
	public int quantity; //Field offset: 0x3C
	public bool saveImmediately; //Field offset: 0x40
	public string storeNavigateToId; //Field offset: 0x48
	public int orderPriority; //Field offset: 0x50
	public bool alwaysPlaceAtScreenCentre; //Field offset: 0x54
	private PowerModel def; //Field offset: 0x58

	public PowerModel Def
	{
		 get { } //Length: 722
	}

	public Power() { }

	public PowerModel get_Def() { }

}

