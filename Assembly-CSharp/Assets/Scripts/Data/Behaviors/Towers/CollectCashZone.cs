namespace Assets.Scripts.Data.Behaviors.Towers;

[CreateAssetMenu(fileName = "CollectCashZone", menuName = "BTD6/Behaviors/Towers/CollectCashZone")]
public class CollectCashZone : TowerBehavior
{
	public float attractRange; //Field offset: 0x30
	public float collectRange; //Field offset: 0x34
	public float speed; //Field offset: 0x38
	public string filterTower; //Field offset: 0x40
	public bool useTowerRange; //Field offset: 0x48
	public bool dontCountCollectedCash; //Field offset: 0x49
	public bool dontAnimateTower; //Field offset: 0x4A
	public bool dontRotate; //Field offset: 0x4B

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 259
	}

	public CollectCashZone() { }

	public virtual TowerBehaviorModel get_Def() { }

}

