//Type is in global namespace

public class MapSelectDisplay : MonoBehaviour
{
	[SerializeField]
	private GameObject normalDefeatedIcon; //Field offset: 0x20
	[SerializeField]
	private GameObject eliteDefeatedIcon; //Field offset: 0x28
	[HideInInspector]
	public bool defeatedNormal; //Field offset: 0x30
	[HideInInspector]
	public bool defeatedElite; //Field offset: 0x31
	public Button button; //Field offset: 0x38
	public string displayedMap; //Field offset: 0x40
	public Image displayImage; //Field offset: 0x48

	public MapSelectDisplay() { }

	public void SetDefeated(bool normal, bool elite) { }

}

