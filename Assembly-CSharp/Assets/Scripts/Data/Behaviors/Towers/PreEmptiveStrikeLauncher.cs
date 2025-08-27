namespace Assets.Scripts.Data.Behaviors.Towers;

[CreateAssetMenu(fileName = "PreEmptiveStrikeLauncher", menuName = "BTD6/Behaviors/Towers/PreEmptiveStrikeLauncher")]
public class PreEmptiveStrikeLauncher : TowerBehavior
{
	public Projectile projectile; //Field offset: 0x30
	public Emission emission; //Field offset: 0x38
	public Effect ejectEffect; //Field offset: 0x40
	public int animationState; //Field offset: 0x48
	public int animationStateSecond; //Field offset: 0x4C
	public OffsetPosition throwMarker; //Field offset: 0x50
	public OffsetPosition throwMarkerSecond; //Field offset: 0x58

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 820
	}

	public PreEmptiveStrikeLauncher() { }

	public virtual TowerBehaviorModel get_Def() { }

}

