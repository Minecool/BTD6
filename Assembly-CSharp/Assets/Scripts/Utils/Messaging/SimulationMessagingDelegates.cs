namespace Assets.Scripts.Utils.Messaging;

public static class SimulationMessagingDelegates
{
	internal sealed class OnAbilityActivated : MulticastDelegate
	{

		public OnAbilityActivated(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(Ability ability, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(Ability ability) { }

	}

	internal sealed class OnBloonDamaged : MulticastDelegate
	{

		public OnBloonDamaged(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(Projectile projectile, long damage, Bloon bloon, Tower poppedBy, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(Projectile projectile, long damage, Bloon bloon, Tower poppedBy) { }

	}

	internal sealed class OnBloonDegrade : MulticastDelegate
	{

		public OnBloonDegrade(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(Projectile projectile, Bloon bloon, Tower poppedBy, DamageResult damageResult, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(Projectile projectile, Bloon bloon, Tower poppedBy, DamageResult damageResult) { }

	}

	internal sealed class OnBloonDestroy : MulticastDelegate
	{

		public OnBloonDestroy(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(Projectile projectile, Bloon bloon, Tower poppedBy, DamageResult damageResult, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(Projectile projectile, Bloon bloon, Tower poppedBy, DamageResult damageResult) { }

	}

	internal sealed class OnBloonLeaked : MulticastDelegate
	{

		public OnBloonLeaked(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(Bloon bloon, float livesBefore, float livesAfter, float manaShieldBefore, float manaShieldAfter, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(Bloon bloon, float livesBefore, float livesAfter, float manaShieldBefore, float manaShieldAfter) { }

	}

	internal sealed class OnBloonSpawned : MulticastDelegate
	{

		public OnBloonSpawned(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(Bloon bloon, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(Bloon bloon) { }

	}

	internal sealed class OnBroadcastSignal : MulticastDelegate
	{

		public OnBroadcastSignal(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(String[] signals, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(String[] signals) { }

	}

	internal sealed class OnCustomUIChanged : MulticastDelegate
	{

		public OnCustomUIChanged(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(Tower tower, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(Tower tower) { }

	}

	internal sealed class OnGoldenBloonDegradeEvent : MulticastDelegate
	{

		public OnGoldenBloonDegradeEvent(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(Bloon bloon, int monkeyMoneyReward, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(Bloon bloon, int monkeyMoneyReward) { }

	}

	internal sealed class OnGoldenBloonLeakedEvent : MulticastDelegate
	{

		public OnGoldenBloonLeakedEvent(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(Bloon bloon, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(Bloon bloon) { }

	}

	internal sealed class OnGoldenBloonSpawnedEvent : MulticastDelegate
	{

		public OnGoldenBloonSpawnedEvent(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(Bloon bloon, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(Bloon bloon) { }

	}

	internal sealed class OnPostPropDestroyed : MulticastDelegate
	{

		public OnPostPropDestroyed(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(PropBase prop, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(PropBase prop) { }

	}

	internal sealed class OnPrimeCustomAbilityInput : MulticastDelegate
	{

		public OnPrimeCustomAbilityInput(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(Ability ability, string className, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(Ability ability, string className) { }

	}

	internal sealed class OnProjectileExhausted : MulticastDelegate
	{

		public OnProjectileExhausted(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(Projectile projectile, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(Projectile projectile) { }

	}

	internal sealed class OnPropDestroyed : MulticastDelegate
	{

		public OnPropDestroyed(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(PropBase prop, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(PropBase prop) { }

	}

	internal sealed class OnPropPlaced : MulticastDelegate
	{

		public OnPropPlaced(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(PropBase prop, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(PropBase prop) { }

	}

	internal sealed class OnPropSold : MulticastDelegate
	{

		public OnPropSold(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(PropBase prop, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(PropBase prop) { }

	}

	internal sealed class OnRedrawCustomMapTextureEvent : MulticastDelegate
	{

		public OnRedrawCustomMapTextureEvent(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(List<CustomRemoveable> customRemovables, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(List<CustomRemoveable> customRemovables) { }

	}

	internal sealed class OnRemoveablePropSold : MulticastDelegate
	{

		public OnRemoveablePropSold(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(PropBase mapProp, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(PropBase mapProp) { }

	}

	internal sealed class OnSelectionChanged : MulticastDelegate
	{

		public OnSelectionChanged(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(ISelectable selected, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(ISelectable selected) { }

	}

	internal sealed class OnTargetTypeChanged : MulticastDelegate
	{

		public OnTargetTypeChanged(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(Tower tower, TargetType targetType, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(Tower tower, TargetType targetType) { }

	}

	internal sealed class OnTempleCreated : MulticastDelegate
	{

		public OnTempleCreated(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(Tower tower, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(Tower tower) { }

	}

	internal sealed class OnTowerAreaChanged : MulticastDelegate
	{

		public OnTowerAreaChanged(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(Tower tower, ObjectId previousAreaID, ObjectId areaID, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(Tower tower, ObjectId previousAreaID, ObjectId areaID) { }

	}

	internal sealed class OnTowerAttack : MulticastDelegate
	{

		public OnTowerAttack(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(Tower tower, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(Tower tower) { }

	}

	internal sealed class OnTowerCreated : MulticastDelegate
	{

		public OnTowerCreated(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(Tower tower, TowerModel def, float upgradeCost, bool isFromSave, double cashBefore, double cashAfter, bool isInsta, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(Tower tower, TowerModel def, float upgradeCost, bool isFromSave, double cashBefore, double cashAfter, bool isInsta) { }

	}

	internal sealed class OnTowerDestroyed : MulticastDelegate
	{

		public OnTowerDestroyed(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(Tower tower, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(Tower tower) { }

	}

	internal sealed class OnTowerMutated : MulticastDelegate
	{

		public OnTowerMutated(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(Tower tower, BehaviorMutator mutator, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(Tower tower, BehaviorMutator mutator) { }

	}

	internal sealed class OnTowerSacrificed : MulticastDelegate
	{

		public OnTowerSacrificed(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(Tower tower, Tower sacrificedTo, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(Tower tower, Tower sacrificedTo) { }

	}

	internal sealed class OnTowerSetChanged : MulticastDelegate
	{

		public OnTowerSetChanged(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(Tower tower, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(Tower tower) { }

	}

	internal sealed class OnTowerSold : MulticastDelegate
	{

		public OnTowerSold(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(Tower tower, float sellWorth, double cashBefore, double cashAfter, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(Tower tower, float sellWorth, double cashBefore, double cashAfter) { }

	}

	internal sealed class OnTowerTransformed : MulticastDelegate
	{

		public OnTowerTransformed(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(Tower tower, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(Tower tower) { }

	}

	internal sealed class OnTowerUpgraded : MulticastDelegate
	{

		public OnTowerUpgraded(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(Tower tower, TowerModel def, float upgradeCost, int pathUpgraded, double cashBefore, double cashAfter, bool playUpgradeEffect, bool isParagon, bool leveledFromEndOfRoundXp, double nonUpgradeCashInvestment, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(Tower tower, TowerModel def, float upgradeCost, int pathUpgraded, double cashBefore, double cashAfter, bool playUpgradeEffect, bool isParagon, bool leveledFromEndOfRoundXp, double nonUpgradeCashInvestment) { }

	}

	internal sealed class OnTowerXpUpdated : MulticastDelegate
	{

		public OnTowerXpUpdated(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(Tower tower, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(Tower tower) { }

	}

	internal sealed class OnUpgradePricesChanged : MulticastDelegate
	{

		public OnUpgradePricesChanged(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(Tower tower, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(Tower tower) { }

	}


}

