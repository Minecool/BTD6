namespace Assets.Scripts.Data.Behaviors.Resources;

[CreateAssetMenu(fileName = "MonkeyAnimationController", menuName = "BTD6/Behaviors/Resources/MonkeyAnimationController")]
public class MonkeyAnimationController : ScriptableObject
{
	public AnimationBakerStateConfig[] animationStates; //Field offset: 0x18

	public MonkeyAnimationController() { }

}

