namespace Assets.Scripts.Unity.Towers.Behaviors;

public class MutationImunityTower : TowerBehavior
{
	public MutationImunityTower parent; //Field offset: 0x98
	public string mutationId; //Field offset: 0xA0
	public string expMutationId; //Field offset: 0xA8
	public float effectScale; //Field offset: 0xB0
	public string expEffectScale; //Field offset: 0xB8
	public bool modifyEffectScale; //Field offset: 0xC0
	public string expModifyEffectScale; //Field offset: 0xC8
	public float durationScale; //Field offset: 0xD0
	public string expDurationScale; //Field offset: 0xD8
	public bool modifyDurationScale; //Field offset: 0xE0
	public string expModifyDurationScale; //Field offset: 0xE8
	public bool preventMutation; //Field offset: 0xF0
	public string expPreventMutation; //Field offset: 0xF8

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 366
	}

	public MutationImunityTower() { }

	public virtual TowerBehaviorModel get_Def() { }

}

