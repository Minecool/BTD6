namespace Assets.Scripts.Unity.UI_New.Rewards;

public class GenericRewardPanel : BaseRewardPanel
{
	public TMP_Text caption; //Field offset: 0x38
	public TMP_Text quantity; //Field offset: 0x40
	public Image icon; //Field offset: 0x48

	public GenericRewardPanel() { }

	public virtual void Bind(BaseLoot loot) { }

	private void LoadHighResIcon(BaseLoot loot) { }

	private bool UseHighResIcon(BaseLoot loot) { }

}

