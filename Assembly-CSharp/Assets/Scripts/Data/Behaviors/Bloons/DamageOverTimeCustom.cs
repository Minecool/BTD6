namespace Assets.Scripts.Data.Behaviors.Bloons;

[CreateAssetMenu(fileName = "DamageOverTimeCustom", menuName = "BTD6/Behaviors/Bloons/DamageOverTimeCustom")]
public class DamageOverTimeCustom : DamageOverTime
{
	public string bloonTags; //Field offset: 0x68
	public float multiplier; //Field offset: 0x70
	public int additive; //Field offset: 0x74

	public virtual BloonBehaviorModel Def
	{
		 get { } //Length: 645
	}

	public DamageOverTimeCustom() { }

	public virtual BloonBehaviorModel get_Def() { }

}

