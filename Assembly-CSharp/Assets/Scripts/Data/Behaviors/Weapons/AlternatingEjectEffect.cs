namespace Assets.Scripts.Data.Behaviors.Weapons;

[CreateAssetMenu(fileName = "AlternatingEjectEffect", menuName = "BTD6/Behaviors/Weapons/AlternatingEjectEffect")]
public class AlternatingEjectEffect : EjectEffect
{
	public PrefabReference secondDisplay; //Field offset: 0x50
	public Effect secondEffect; //Field offset: 0x58
	public float secondEffectLifespan; //Field offset: 0x60

	public virtual WeaponBehaviorModel Def
	{
		 get { } //Length: 505
	}

	public AlternatingEjectEffect() { }

	public virtual WeaponBehaviorModel get_Def() { }

}

