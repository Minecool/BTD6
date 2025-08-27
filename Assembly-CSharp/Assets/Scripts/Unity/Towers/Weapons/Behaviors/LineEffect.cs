namespace Assets.Scripts.Unity.Towers.Weapons.Behaviors;

public class LineEffect : WeaponBehavior
{
	public LineEffect parent; //Field offset: 0x90
	public GameObject lineDisplay; //Field offset: 0x98
	public GameObject expLineDisplay; //Field offset: 0xA0
	public Effect effectAtEnd; //Field offset: 0xA8
	public Effect expEffectAtEnd; //Field offset: 0xB0
	public Effect effectAtStart; //Field offset: 0xB8
	public Effect expEffectAtStart; //Field offset: 0xC0
	public bool isLineDisplayEndless; //Field offset: 0xC8
	public string expIsLineDisplayEndless; //Field offset: 0xD0
	public bool useDisplayLengthSpeed; //Field offset: 0xD8
	public string expUseDisplayLengthSpeed; //Field offset: 0xE0
	public float displayLengthSpeed; //Field offset: 0xE8
	public string expDisplayLengthSpeed; //Field offset: 0xF0
	public bool useWeaponEjectForDisplay; //Field offset: 0xF8
	public string expUseWeaponEjectForDisplay; //Field offset: 0x100
	public bool useRotateToPointer; //Field offset: 0x108
	public string expUseRotateToPointer; //Field offset: 0x110
	public bool ignoreBlockers; //Field offset: 0x118
	public string expIgnoreBlockers; //Field offset: 0x120
	public bool useLineProjectileEmissionShowEffect; //Field offset: 0x128
	public string expUseLineProjectileEmissionShowEffect; //Field offset: 0x130

	public virtual WeaponBehaviorModel Def
	{
		 get { } //Length: 724
	}

	public LineEffect() { }

	public virtual WeaponBehaviorModel get_Def() { }

}

