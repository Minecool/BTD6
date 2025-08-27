namespace Assets.Scripts.Data.Behaviors.Towers;

[CreateAssetMenu(fileName = "BananaCashIncreaseSupport", menuName = "BTD6/Behaviors/Towers/BananaCashIncreaseSupport")]
public class BananaCashIncreaseSupport : SupportBehavior
{
	public bool isUnique; //Field offset: 0x48
	public float multiplier; //Field offset: 0x4C
	public string mutatorId; //Field offset: 0x50
	public bool useTiers; //Field offset: 0x58
	public int firstPathTier; //Field offset: 0x5C
	public int secondPathTier; //Field offset: 0x60
	public int thirdPathTier; //Field offset: 0x64

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 308
	}

	public BananaCashIncreaseSupport() { }

	public virtual TowerBehaviorModel get_Def() { }

}

