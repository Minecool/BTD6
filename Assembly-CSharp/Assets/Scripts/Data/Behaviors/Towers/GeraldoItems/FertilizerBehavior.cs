namespace Assets.Scripts.Data.Behaviors.Towers.GeraldoItems;

[CreateAssetMenu(fileName = "FertilizerBehavior", menuName = "BTD6/Behaviors/Towers/GeraldoItems/FertilizerBehavior")]
public class FertilizerBehavior : GeraldoItemBehavior
{
	public float cashScale; //Field offset: 0x28
	public float cashIncrement; //Field offset: 0x2C
	public int rounds; //Field offset: 0x30
	public int path1TierLimit; //Field offset: 0x34
	public int path2TierLimit; //Field offset: 0x38
	public int path3TierLimit; //Field offset: 0x3C
	public PrefabReference buffDisplay; //Field offset: 0x40
	public string buffLocsName; //Field offset: 0x48
	public string buffIconName; //Field offset: 0x50
	public PrefabReference effectAtTower; //Field offset: 0x58

	public virtual GeraldoItemBehaviorModel Def
	{
		 get { } //Length: 267
	}

	public FertilizerBehavior() { }

	public virtual GeraldoItemBehaviorModel get_Def() { }

}

