namespace Assets.Scripts.Unity.GeraldoItems;

public class BottleHotSauceBehavior : GeraldoItemBehavior
{
	[SerializeField]
	private PrefabReference buffDisplay; //Field offset: 0x10
	[SerializeField]
	private string buffLocsName; //Field offset: 0x18
	[SerializeField]
	private string buffIconName; //Field offset: 0x20
	[SerializeField]
	private PrefabReference effectAtTower; //Field offset: 0x28
	[SerializeField]
	private int v2At; //Field offset: 0x30

	public virtual GeraldoItemBehaviorModel Def
	{
		 get { } //Length: 173
	}

	public BottleHotSauceBehavior() { }

	public virtual GeraldoItemBehaviorModel get_Def() { }

}

