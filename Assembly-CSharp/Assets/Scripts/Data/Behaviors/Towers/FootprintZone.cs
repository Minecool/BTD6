namespace Assets.Scripts.Data.Behaviors.Towers;

[CreateAssetMenu(fileName = "FootprintZone", menuName = "BTD6/Behaviors/Towers/FootprintZone")]
public class FootprintZone : SupportBehavior
{
	public bool isUnique; //Field offset: 0x48
	public float footprintReduction; //Field offset: 0x4C
	public string mutatorId; //Field offset: 0x50

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 256
	}

	public FootprintZone() { }

	public virtual TowerBehaviorModel get_Def() { }

}

