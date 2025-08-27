namespace Assets.Scripts.Simulation.Towers.Behaviors.Abilities.Behaviors;

public class ActivateAttackSwitch : AbilityBehavior
{
	public ActivateAttackSwitchModel activateAttackSwitchModel; //Field offset: 0x68
	private List<RootBehavior> attacks; //Field offset: 0x70
	private Attack firstAttack; //Field offset: 0x78
	private Attack secondAttack; //Field offset: 0x80
	public int lifespan; //Field offset: 0x88
	private int nextAttackIndex; //Field offset: 0x8C

	public int NextAttackIndex
	{
		 get { } //Length: 7
		 set { } //Length: 7
	}

	public ActivateAttackSwitch() { }

	public virtual void Activate() { }

	public virtual void Attatched() { }

	public int get_NextAttackIndex() { }

	public virtual void GetSaveMetaData(Dictionary<String, String> metaData) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual bool IsActive() { }

	private void Process(int elapsed) { }

	public void set_NextAttackIndex(int value) { }

	public virtual void SetSaveMetaData(Dictionary<String, String> metaData) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

