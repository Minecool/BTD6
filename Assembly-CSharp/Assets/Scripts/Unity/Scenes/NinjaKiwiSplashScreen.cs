namespace Assets.Scripts.Unity.Scenes;

[RequireComponent(typeof(Animator))]
public class NinjaKiwiSplashScreen : GenericAnimatedScene
{
	private float failsafeTimer; //Field offset: 0x28
	private bool isPaused; //Field offset: 0x2C

	public NinjaKiwiSplashScreen() { }

	public void OnAnimationPause() { }

	private void Pause(bool pause) { }

	private void Update() { }

}

