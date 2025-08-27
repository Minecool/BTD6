namespace Assets.Scripts.Data.Behaviors.Towers.GeraldoItems;

[CreateAssetMenu(fileName = "BottleHotSauceBehavior", menuName = "BTD6/Behaviors/Towers/GeraldoItems/BottleHotSauceBehavior")]
public class BottleHotSauceBehavior : GeraldoItemBehavior
{
	public PrefabReference buffDisplay; //Field offset: 0x28
	public string buffLocsName; //Field offset: 0x30
	public string buffIconName; //Field offset: 0x38
	public PrefabReference effectAtTower; //Field offset: 0x40
	public int v2At; //Field offset: 0x48

	public virtual GeraldoItemBehaviorModel Def
	{
		 get { } //Length: 173
	}

	public BottleHotSauceBehavior() { }

	public virtual GeraldoItemBehaviorModel get_Def() { }

}

