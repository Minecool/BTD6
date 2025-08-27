namespace Assets.Scripts.Models.Store.Loot;

public abstract class BaseQuantityLoot : BaseLoot
{
	public int quantity; //Field offset: 0x20
	public Nullable<Int32> bonusQuantity; //Field offset: 0x24

	public BaseQuantityLoot(int quantity) { }

	public BaseQuantityLoot(String[] param) { }

	public BaseQuantityLoot() { }

	public virtual Nullable<Int32> GetBonusQuantity() { }

	public virtual int GetQuantity() { }

	public virtual void Serialize(StringBuilder sb) { }

	public virtual string ToString() { }

}

