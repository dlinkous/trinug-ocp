using System;

namespace Game2.Domain
{
    public class Drone
    {
		private readonly IWeapon bay1Weapon;
		private readonly IWeapon bay2Weapon;
		public int Heat { get; private set; }
		public int Power { get; private set; }
		public bool IsIncapacitated { get; private set; }

		public Drone(IWeapon bay1Weapon, IWeapon bay2Weapon, int initialPower)
		{
			this.bay1Weapon = bay1Weapon;
			this.bay2Weapon = bay2Weapon;
			Power = initialPower;
		}

		public void FireBay1(int quantity) => FireWeapon(bay1Weapon, quantity);
		public void FireBay2(int quantity) => FireWeapon(bay2Weapon, quantity);

		private void FireWeapon(IWeapon weapon, int quantity)
		{
			if (IsIncapacitated) return;
			var fireResult = weapon.Fire(quantity, Heat);
			Heat += fireResult.HeatGenerated;
			Power -= fireResult.PowerDrained;
			IsIncapacitated = fireResult.Incapacitate;
			VerifyViability();
		}

		private void VerifyViability()
		{
			const int maximumHeat = 120;
			if (Heat > maximumHeat) Explode();
			const int minimumPower = 5;
			if (Power < minimumPower) Incapacitate();
		}

		private void Explode()
		{
			// This is no good at all.
		}

		private void Incapacitate() => IsIncapacitated = true;
	}
}
