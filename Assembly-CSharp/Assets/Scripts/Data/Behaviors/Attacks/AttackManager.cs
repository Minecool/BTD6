namespace Assets.Scripts.Data.Behaviors.Attacks;

[CreateAssetMenu(fileName = "AttackManager", menuName = "BTD6/Behaviors/Attacks/AttackManager")]
public class AttackManager : ScriptableObject
{
	public Attack attack; //Field offset: 0x18
	public string enabledOnlyWhile; //Field offset: 0x20

	public AttackManager() { }

}

