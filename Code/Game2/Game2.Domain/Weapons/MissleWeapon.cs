using System;

namespace Game2.Domain.Weapons
{
	public class MissleWeapon : IWeapon
	{
		public FireResult Fire(int quantity, int heat)
		{
			const int overheatIncapacitateThreshold = 75;
			const int heatMultiplier = 3;
			if (heat < overheatIncapacitateThreshold)
			{
				return new FireResult() { HeatGenerated = quantity * heatMultiplier, PowerDrained = quantity, Incapacitate = false };
			}
			else
			{
				return new FireResult() { HeatGenerated = quantity * heatMultiplier, PowerDrained = quantity, Incapacitate = true };
			}
		}
	}
}
