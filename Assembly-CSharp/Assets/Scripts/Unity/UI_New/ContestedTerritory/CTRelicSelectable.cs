namespace Assets.Scripts.Unity.UI_New.ContestedTerritory;

public class CTRelicSelectable : MonoBehaviour
{
	public Image icon; //Field offset: 0x20
	public GameObject selectedObj; //Field offset: 0x28
	public GameObject bannedObj; //Field offset: 0x30
	public Button button; //Field offset: 0x38
	private RelicKnowledgeItemBase relic; //Field offset: 0x40
	private SubGameType subGameType; //Field offset: 0x48

	public RelicKnowledgeItemBase GetRelic
	{
		 get { } //Length: 5
	}

	public CTRelicSelectable() { }

	public RelicKnowledgeItemBase get_GetRelic() { }

	public void Init(RelicKnowledgeItemBase relic, SubGameType subGameType) { }

	public bool RelicAvailable() { }

}

