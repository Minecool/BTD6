namespace Assets.Scripts.Data.Behaviors.Towers;

[CreateAssetMenu(fileName = "HexManager", menuName = "BTD6/Behaviors/Towers/HexManager")]
public class HexManager : TowerBehavior
{
	public Hex hex; //Field offset: 0x30
	public string overlayType; //Field offset: 0x38
	public int overlaysLayer; //Field offset: 0x40

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 237
	}

	public HexManager() { }

	public virtual TowerBehaviorModel get_Def() { }

}

