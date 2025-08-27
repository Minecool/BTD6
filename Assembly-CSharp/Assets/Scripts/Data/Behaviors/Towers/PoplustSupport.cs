namespace Assets.Scripts.Data.Behaviors.Towers;

[CreateAssetMenu(fileName = "PoplustSupport", menuName = "BTD6/Behaviors/Towers/PoplustSupport")]
public class PoplustSupport : TowerBehaviorBuff
{
	public string mutatorId; //Field offset: 0x38
	public int maxStacks; //Field offset: 0x40
	public float ratePercentIncrease; //Field offset: 0x44
	public float piercePercentIncrease; //Field offset: 0x48

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 239
	}

	public PoplustSupport() { }

	public virtual TowerBehaviorModel get_Def() { }

}

