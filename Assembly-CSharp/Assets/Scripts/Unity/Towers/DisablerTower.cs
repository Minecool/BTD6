namespace Assets.Scripts.Unity.Towers;

public class DisablerTower : Disabler
{
	public string disableComponentById; //Field offset: 0xB0
	public string expDisableComponentById; //Field offset: 0xB8

	public DisablerTower() { }

	public virtual void Disable() { }

	public virtual void Enable() { }

}

