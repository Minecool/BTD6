namespace Assets.Scripts.Unity.Map;

internal class AnimatorWeightedRandomStateBehavior : StateMachineBehaviour
{
	[Comment("This script allows you to control an animator, enabling it to choose a random\n animation to switch to based off a % chance. Make sure the state transition\nto and from this 'Animation Controler' has the folloing properties\n\n - 'Has Exit Time' unticked\n - 'Fixed Duration' is set ticked\n - 'Transition Duration' is set to 0\n - 'Transition Offset' is set to '0'\n - 'Interruption Source' is set to 'None' \n\nEach animation needs to have a 'Conditions' added to its transition from this\n'Controller' to the aniamtion. Add a condition with the '+' symbol, change the\n first drop down box to 'Animation' or whatever you set the string field\n'Animation Variable Name' to. Set the value to be the same as the array list\n'element' number for the corresponding percent chance", null, 200)]
	[Header("-= How to Guide =-")]
	[Space(5)]
	[Space(5)]
	public int textbox; //Field offset: 0x18
	[Header("-= Paramaters Required =-")]
	[Space(5)]
	[Space(5)]
	public string weightedVariableName; //Field offset: 0x20
	[Header("-= Random Chance Array =-")]
	[Space(10)]
	[Space(5)]
	public Single[] PercentChance; //Field offset: 0x28
	[Comment("The last element in the list will be the default animation state\nE.g. 'Idle Animation' and should always be set to 1", null, 30)]
	[Header("-= Important =-")]
	[Space(5)]
	[Space(5)]
	public int textbox2; //Field offset: 0x30
	private float weightedNum; //Field offset: 0x34

	public AnimatorWeightedRandomStateBehavior() { }

	public virtual void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

}

