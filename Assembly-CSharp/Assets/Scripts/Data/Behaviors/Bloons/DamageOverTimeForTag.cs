namespace Assets.Scripts.Data.Behaviors.Bloons;

[CreateAssetMenu(fileName = "DamageOverTimeForTag", menuName = "BTD6/Behaviors/Bloons/DamageOverTimeForTag")]
public class DamageOverTimeForTag : BloonBehavior
{
	public int damage; //Field offset: 0x30
	public float interval; //Field offset: 0x34
	public string damageType; //Field offset: 0x38
	public string bloonTag; //Field offset: 0x40

	public virtual BloonBehaviorModel Def
	{
		 get { } //Length: 370
	}

	public DamageOverTimeForTag() { }

	public virtual BloonBehaviorModel get_Def() { }

}

