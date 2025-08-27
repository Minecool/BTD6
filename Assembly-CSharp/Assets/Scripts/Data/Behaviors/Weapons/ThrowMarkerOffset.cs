namespace Assets.Scripts.Data.Behaviors.Weapons;

[CreateAssetMenu(fileName = "ThrowMarkerOffset", menuName = "BTD6/Behaviors/Weapons/ThrowMarkerOffset")]
public class ThrowMarkerOffset : WeaponBehavior
{
	public OffsetPosition offset; //Field offset: 0x30

	public virtual WeaponBehaviorModel Def
	{
		 get { } //Length: 215
	}

	public ThrowMarkerOffset() { }

	public virtual WeaponBehaviorModel get_Def() { }

}

