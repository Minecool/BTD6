namespace Assets.Scripts.Data.Behaviors.Towers;

[CreateAssetMenu(fileName = "MutationImunityTower", menuName = "BTD6/Behaviors/Towers/MutationImunityTower")]
public class MutationImunityTower : TowerBehavior
{
	public string mutationId; //Field offset: 0x30
	public float effectScale; //Field offset: 0x38
	public bool modifyEffectScale; //Field offset: 0x3C
	public float durationScale; //Field offset: 0x40
	public bool modifyDurationScale; //Field offset: 0x44
	public bool preventMutation; //Field offset: 0x45

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 348
	}

	public MutationImunityTower() { }

	public virtual TowerBehaviorModel get_Def() { }

}

