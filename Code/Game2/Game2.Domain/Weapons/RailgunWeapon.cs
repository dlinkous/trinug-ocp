using System;

namespace Game2.Domain.Weapons
{
	public class RailgunWeapon : IWeapon
	{
		public FireResult Fire(int quantity, int heat)
		{
			const int multifireThreshold = 2;
			const int powerMultiplier = 50;
			if (quantity < multifireThreshold)
			{
				const int heatMultiplier = 5;
				return new FireResult() { HeatGenerated = quantity * heatMultiplier, PowerDrained = quantity * powerMultiplier, Incapacitate = true };
			}
			else
			{
				const int heatMultiplier = 10;
				return new FireResult() { HeatGenerated = quantity * heatMultiplier, PowerDrained = quantity * powerMultiplier, Incapacitate = true };
			}
		}
	}
}
