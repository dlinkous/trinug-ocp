using System;

namespace Game2.Domain.Weapons
{
	public class AutocannonWeapon : IWeapon
	{
		public FireResult Fire(int quantity, int heat)
		{
			const int overheatJamThreshold = 100;
			if (heat < overheatJamThreshold)
			{
				return new FireResult() { HeatGenerated = quantity, PowerDrained = 0, Incapacitate = false };
			}
			else
			{
				return new FireResult() { HeatGenerated = 0, PowerDrained = 0, Incapacitate = false };
			}
		}
	}
}
