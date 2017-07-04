using System;
using Game2.Domain;

namespace Game2.Domain.Tests.Unit
{
	internal class WeaponMock : IWeapon
	{
		internal FireResult FireResult;

		public FireResult Fire(int quantity, int heat)
		{
			return FireResult;
		}
	}
}
