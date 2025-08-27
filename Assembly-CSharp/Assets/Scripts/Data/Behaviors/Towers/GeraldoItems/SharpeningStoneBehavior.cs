namespace Assets.Scripts.Data.Behaviors.Towers.GeraldoItems;

[CreateAssetMenu(fileName = "SharpeningStoneBehavior", menuName = "BTD6/Behaviors/Towers/GeraldoItems/SharpeningStoneBehavior")]
public class SharpeningStoneBehavior : GeraldoItemBehavior
{
	public float pierceIncrease; //Field offset: 0x28
	public PrefabReference buffDisplay; //Field offset: 0x30
	public string buffLocsName; //Field offset: 0x38
	public string buffIconName; //Field offset: 0x40
	public PrefabReference effectAtTower; //Field offset: 0x48
	public float bonusPierceAtLevel; //Field offset: 0x50
	public float bonusPierce; //Field offset: 0x54
	public int rounds; //Field offset: 0x58

	public virtual GeraldoItemBehaviorModel Def
	{
		 get { } //Length: 242
	}

	public SharpeningStoneBehavior() { }

	public virtual GeraldoItemBehaviorModel get_Def() { }

}

