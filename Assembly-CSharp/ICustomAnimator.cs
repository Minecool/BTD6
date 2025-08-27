//Type is in global namespace

public interface ICustomAnimator
{

	public int currentAnimationState
	{
		 get { } //Length: 0
	}

	public int get_currentAnimationState() { }

	public void Play() { }

	public void Play(int state, bool forceInterrupt = false) { }

	public void Play(int state, int returnState, bool forceInterrupt = false) { }

	public void SetState(int state) { }

}

