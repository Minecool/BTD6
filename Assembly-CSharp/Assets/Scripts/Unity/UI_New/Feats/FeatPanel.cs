namespace Assets.Scripts.Unity.UI_New.Feats;

public class FeatPanel : MonoBehaviour
{
	private LegendsFeatActive feat; //Field offset: 0x20
	public TMP_Text titleText; //Field offset: 0x28
	public TMP_Text descriptionText; //Field offset: 0x30
	public TMP_Text progressText; //Field offset: 0x38
	public Image progressImage; //Field offset: 0x40
	public Image icon; //Field offset: 0x48
	public TMP_Text subscript; //Field offset: 0x50
	public Transform inProgressGroup; //Field offset: 0x58
	public Transform claimGroup; //Field offset: 0x60
	public Transform claimedGroup; //Field offset: 0x68
	public Transform rewardsGroup; //Field offset: 0x70
	public Image panelBg; //Field offset: 0x78
	public Image rewardBg; //Field offset: 0x80
	public FeatTheme inProgressTheme; //Field offset: 0x88
	public FeatTheme claimTheme; //Field offset: 0x90
	public FeatTheme claimedTheme; //Field offset: 0x98
	public Button claimButton; //Field offset: 0xA0
	public LootPanel lootPanel; //Field offset: 0xA8
	public AudioClip collectSound; //Field offset: 0xB0

	public FeatPanel() { }

	public void Bind(LegendsFeatActive feat) { }

	public void Claim() { }

	public LegendsFeatActive GetActiveFeat() { }

	public void Refresh() { }

	private void UpdateProgress(float progress) { }

}

