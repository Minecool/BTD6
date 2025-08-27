namespace Assets.Scripts.Data.Behaviors.Weapons;

[CreateAssetMenu(fileName = "LineEffect", menuName = "BTD6/Behaviors/Weapons/LineEffect")]
public class LineEffect : WeaponBehavior
{
	public AssetPath lineDisplay; //Field offset: 0x30
	public Effect effectAtEnd; //Field offset: 0x38
	public Effect effectAtStart; //Field offset: 0x40
	public bool isLineDisplayEndless; //Field offset: 0x48
	public bool useDisplayLengthSpeed; //Field offset: 0x49
	public float displayLengthSpeed; //Field offset: 0x4C
	public bool useWeaponEjectForDisplay; //Field offset: 0x50
	public bool useRotateToPointer; //Field offset: 0x51
	public bool ignoreBlockers; //Field offset: 0x52
	public bool useLineProjectileEmissionShowEffect; //Field offset: 0x53
	public float displayLength; //Field offset: 0x54

	public virtual WeaponBehaviorModel Def
	{
		 get { } //Length: 474
	}

	public LineEffect() { }

	public virtual WeaponBehaviorModel get_Def() { }

}

