namespace Assets.Scripts.Unity.Map;

public class Removeable : MonoBehaviour
{
	public GameObject removeableObject; //Field offset: 0x20
	public bool isActive; //Field offset: 0x28
	public string menuName; //Field offset: 0x30
	public string menuDescription; //Field offset: 0x38
	public int removealCost; //Field offset: 0x40
	public AreaType defaultTerrianType; //Field offset: 0x44
	public bool denySellIfStackedTowers; //Field offset: 0x48
	public bool destroyArea; //Field offset: 0x49
	public string textKey; //Field offset: 0x50
	public string modPathId; //Field offset: 0x58
	public string modPathBloonHeightOffset; //Field offset: 0x60
	public string modPathMoabHeightOffset; //Field offset: 0x68
	public string modPathBloonScale; //Field offset: 0x70
	public string modPathMoabScale; //Field offset: 0x78
	public string modPathBloonInvulnerabilitySet; //Field offset: 0x80
	public string modPathMoabInvulnerabilitySet; //Field offset: 0x88
	private RemoveableModel def; //Field offset: 0x90

	public RemoveableModel Def
	{
		 get { } //Length: 1219
	}

	public Removeable() { }

	public RemoveableModel get_Def() { }

}

