namespace Assets.Scripts.Unity.GeraldoItems;

public class FertilizerBehavior : GeraldoItemBehavior
{
	[SerializeField]
	private float cashScale; //Field offset: 0x10
	[SerializeField]
	private float cashIncrement; //Field offset: 0x14
	[SerializeField]
	private int rounds; //Field offset: 0x18
	[SerializeField]
	private int path1TierLimit; //Field offset: 0x1C
	[SerializeField]
	private int path2TierLimit; //Field offset: 0x20
	[SerializeField]
	private int path3TierLimit; //Field offset: 0x24
	[SerializeField]
	private PrefabReference buffDisplay; //Field offset: 0x28
	[SerializeField]
	private string buffLocsName; //Field offset: 0x30
	[SerializeField]
	private string buffIconName; //Field offset: 0x38
	[SerializeField]
	private PrefabReference effectAtTower; //Field offset: 0x40

	public virtual GeraldoItemBehaviorModel Def
	{
		 get { } //Length: 267
	}

	public FertilizerBehavior() { }

	public virtual GeraldoItemBehaviorModel get_Def() { }

}

