namespace Assets.Scripts.Data.Behaviors.Bloons;

[CreateAssetMenu(fileName = "IncreaseWorthTextEffect", menuName = "BTD6/Behaviors/Bloons/IncreaseWorthTextEffect")]
public class IncreaseWorthTextEffect : BloonBehavior
{
	public float lifespan; //Field offset: 0x30
	public bool displayFullPayout; //Field offset: 0x34
	public PrefabReference display; //Field offset: 0x38

	public virtual BloonBehaviorModel Def
	{
		 get { } //Length: 148
	}

	public IncreaseWorthTextEffect() { }

	public virtual BloonBehaviorModel get_Def() { }

}

