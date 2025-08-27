namespace Assets.Scripts.Data.Behaviors.Towers;

[CreateAssetMenu(fileName = "AttackBloonOnEntrance", menuName = "BTD6/Behaviors/Towers/AttackBloonOnEntrance")]
public class AttackBloonOnEntrance : TowerBehavior
{
	public OffsetPosition throwMarker; //Field offset: 0x30
	public Projectile projectile; //Field offset: 0x38
	public Emission emission; //Field offset: 0x40
	public Effect ejectEffect; //Field offset: 0x48
	public int animationState; //Field offset: 0x50
	public string bloonTags; //Field offset: 0x58

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 406
	}

	public AttackBloonOnEntrance() { }

	public virtual TowerBehaviorModel get_Def() { }

}

