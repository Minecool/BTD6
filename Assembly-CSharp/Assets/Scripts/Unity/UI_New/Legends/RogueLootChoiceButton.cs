namespace Assets.Scripts.Unity.UI_New.Legends;

public class RogueLootChoiceButton : MonoBehaviour
{
	public Button selectBtn; //Field offset: 0x20
	public NK_TextMeshProUGUI titleTxt; //Field offset: 0x28
	public Image lootIcon; //Field offset: 0x30
	public Image rarityBG; //Field offset: 0x38
	public GameObject selectionFx; //Field offset: 0x40

	private LegendsDataModel LegendsData
	{
		private get { } //Length: 81
	}

	private RogueGameSaveData RogueSaveData
	{
		private get { } //Length: 227
	}

	public RogueLootChoiceButton() { }

	public void Bind(RogueInstaMonkey insta, int index) { }

	public void Bind(ArtifactLoot artifact, int index) { }

	private LegendsDataModel get_LegendsData() { }

	private RogueGameSaveData get_RogueSaveData() { }

	private SpriteReference GetPowerIcon(string baseId) { }

}

