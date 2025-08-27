namespace Assets.Scripts.Unity.UI_New.ContestedTerritory;

public class CTRelicSelectableRulesMenu : MonoBehaviour
{
	public Image icon; //Field offset: 0x20
	public GameObject bannedObj; //Field offset: 0x28
	public Selectable iconSelectable; //Field offset: 0x30
	public NK_TextMeshProUGUI title; //Field offset: 0x38
	private RelicKnowledgeItemBase relic; //Field offset: 0x40
	private SubGameType subGameType; //Field offset: 0x48

	public RelicKnowledgeItemBase GetRelic
	{
		 get { } //Length: 5
	}

	public CTRelicSelectableRulesMenu() { }

	public RelicKnowledgeItemBase get_GetRelic() { }

	public void Init(RelicKnowledgeItemBase relic, SubGameType subGameType) { }

	public bool RelicAvailable() { }

}

