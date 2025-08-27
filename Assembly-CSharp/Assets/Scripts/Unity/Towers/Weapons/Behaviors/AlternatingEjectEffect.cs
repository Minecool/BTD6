namespace Assets.Scripts.Unity.Towers.Weapons.Behaviors;

public class AlternatingEjectEffect : EjectEffect
{
	public GameObject secondDisplay; //Field offset: 0x118
	public GameObject expSecondDisplay; //Field offset: 0x120
	public Effect secondEffect; //Field offset: 0x128
	public Effect expSecondEffect; //Field offset: 0x130
	public float secondEffectLifespan; //Field offset: 0x138
	public string expSecondEffectLifespan; //Field offset: 0x140

	public virtual WeaponBehaviorModel Def
	{
		 get { } //Length: 807
	}

	public AlternatingEjectEffect() { }

	public virtual WeaponBehaviorModel get_Def() { }

}

