namespace Assets.Scripts.Unity;

public abstract class Disabler : CascadingItemProxy, DisablerInterface
{
	public Disabler parent; //Field offset: 0x88
	public MonoBehaviour component; //Field offset: 0x90
	public MonoBehaviour expComponent; //Field offset: 0x98
	public bool isDisabled; //Field offset: 0xA0
	public string expIsDisabled; //Field offset: 0xA8

	public virtual Model Model
	{
		 get { } //Length: 3
	}

	protected Disabler() { }

	public abstract void Disable() { }

	public abstract void Enable() { }

	public virtual Model get_Model() { }

}

