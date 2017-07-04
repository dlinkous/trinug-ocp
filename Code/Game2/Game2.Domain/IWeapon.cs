using System;

namespace Game2.Domain
{
	public interface IWeapon
    {
		FireResult Fire(int quantity, int heat);
    }
}
