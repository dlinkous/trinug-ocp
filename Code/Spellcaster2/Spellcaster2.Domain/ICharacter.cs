using System;

namespace Spellcaster2.Domain
{
    internal interface ICharacter
    {
		string GetName();
		void AddEffect(IEffect effect);
		void AdjustHitPoints(int amount);
		void AdjustMana(int amount);
		void SuspendInput();
		void ResumeInput();
    }
}
