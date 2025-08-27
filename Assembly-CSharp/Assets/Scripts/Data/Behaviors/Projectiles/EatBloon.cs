namespace Assets.Scripts.Data.Behaviors.Projectiles;

[CreateAssetMenu(fileName = "EatBloon", menuName = "BTD6/Behaviors/Projectiles/EatBloon")]
public class EatBloon : ProjectileBehavior
{
	public float rbeCapacity; //Field offset: 0x30
	public float rbeCashMultiplier; //Field offset: 0x34
	public Projectile projectile; //Field offset: 0x38
	public Emission emission; //Field offset: 0x40
	public int animationStateOpen; //Field offset: 0x48
	public int animationStateClosed; //Field offset: 0x4C
	public float timeUntilClose; //Field offset: 0x50
	public Effect effectOnEat; //Field offset: 0x58
	public Sound bloonTrapOpenSound; //Field offset: 0x60
	public Sound bloonTrapCloseSound; //Field offset: 0x68

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 554
	}

	public EatBloon() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

