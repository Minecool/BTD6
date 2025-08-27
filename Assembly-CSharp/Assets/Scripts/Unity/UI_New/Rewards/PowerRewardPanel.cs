namespace Assets.Scripts.Unity.UI_New.Rewards;

public class PowerRewardPanel : BaseRewardPanel
{
	public TMP_Text quantity; //Field offset: 0x38
	public TMP_Text caption; //Field offset: 0x40
	public GameObject defaultBackground; //Field offset: 0x48
	public GameObject iapBackground; //Field offset: 0x50
	public Image icon; //Field offset: 0x58

	public PowerRewardPanel() { }

	public virtual void Bind(BaseLoot loot) { }

}

