namespace Assets.Scripts.Data.Behaviors.Abilities;

[CreateAssetMenu(fileName = "MoabBarrage", menuName = "BTD6/Behaviors/Abilities/MoabBarrage")]
public class MoabBarrage : AbilityBehavior
{
	public float duration; //Field offset: 0x30
	public string mutatorId; //Field offset: 0x38
	public int targets; //Field offset: 0x40
	public BloonBehavior behavior; //Field offset: 0x48

	public virtual AbilityBehaviorModel Def
	{
		 get { } //Length: 213
	}

	public MoabBarrage() { }

	public virtual AbilityBehaviorModel get_Def() { }

}

