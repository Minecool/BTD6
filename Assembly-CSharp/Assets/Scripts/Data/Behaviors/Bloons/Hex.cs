namespace Assets.Scripts.Data.Behaviors.Bloons;

[CreateAssetMenu(fileName = "Hex", menuName = "BTD6/Behaviors/Bloons/Hex")]
public class Hex : EntityBehavior<BloonBehaviorModel>
{
	public float damagePercentOfMax; //Field offset: 0x28
	public float interval; //Field offset: 0x2C
	public float totalDuration; //Field offset: 0x30

	public virtual BloonBehaviorModel Def
	{
		 get { } //Length: 179
	}

	public Hex() { }

	public virtual BloonBehaviorModel get_Def() { }

}

