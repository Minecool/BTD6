namespace Assets.Scripts.Unity.Towers.Behaviors;

public class VigilanteTowerBehavior : TowerBehavior
{
	public VigilanteTowerBehavior parent; //Field offset: 0x98
	public float loseLifeAttackSpeedBuff; //Field offset: 0xA0
	public string expLoseLifeAttackSpeedBuff; //Field offset: 0xA8
	public float loseLifeRangeBuff; //Field offset: 0xB0
	public string expLoseLifeRangeBuff; //Field offset: 0xB8
	public float loseLifeBuffDuration; //Field offset: 0xC0
	public string expLoseLifeBuffDuration; //Field offset: 0xC8
	public float loseLifeBuffCooldown; //Field offset: 0xD0
	public string expLoseLifeBuffCooldown; //Field offset: 0xD8
	public string buffLocsName; //Field offset: 0xE0
	public string expBuffLocsName; //Field offset: 0xE8
	public GameObject buffDisplay; //Field offset: 0xF0
	public GameObject expBuffDisplay; //Field offset: 0xF8
	public string oneHealthHighestBloon; //Field offset: 0x100
	public string expOneHealthHighestBloon; //Field offset: 0x108
	public float bloonLeakValueModifier; //Field offset: 0x110
	public string expBloonLeakValueModifier; //Field offset: 0x118

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 353
	}

	public VigilanteTowerBehavior() { }

	public virtual TowerBehaviorModel get_Def() { }

}

