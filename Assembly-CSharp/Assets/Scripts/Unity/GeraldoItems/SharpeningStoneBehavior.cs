namespace Assets.Scripts.Unity.GeraldoItems;

public class SharpeningStoneBehavior : GeraldoItemBehavior
{
	[SerializeField]
	private float pierceIncrease; //Field offset: 0x18
	[SerializeField]
	private PrefabReference buffDisplay; //Field offset: 0x20
	[SerializeField]
	private string buffLocsName; //Field offset: 0x28
	[SerializeField]
	private string buffIconName; //Field offset: 0x30
	[SerializeField]
	private PrefabReference effectAtTower; //Field offset: 0x38
	[SerializeField]
	private float bonusPierceAtLevel; //Field offset: 0x40
	[SerializeField]
	private float bonusPierce; //Field offset: 0x44
	[SerializeField]
	private int rounds; //Field offset: 0x48

	public virtual GeraldoItemBehaviorModel Def
	{
		 get { } //Length: 242
	}

	public SharpeningStoneBehavior() { }

	public virtual GeraldoItemBehaviorModel get_Def() { }

}

