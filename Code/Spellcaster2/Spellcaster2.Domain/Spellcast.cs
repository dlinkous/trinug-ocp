using System;

namespace Spellcaster2.Domain
{
    internal abstract class Spellcast
    {
		private readonly IMessager messager;
		private readonly ILogger logger;
		protected abstract string GetBeginCastMessage(ICharacter source, ICharacter target);
		protected abstract void AffectSource(ICharacter source);
		protected abstract void AffectTarget(ICharacter target);

		protected Spellcast(IMessager messager, ILogger logger)
		{
			this.messager = messager;
			this.logger = logger;
		}

		internal void Cast(ICharacter source, ICharacter target)
		{
			source.SuspendInput();
			messager.WriteLine(GetBeginCastMessage(source, target));
			AffectSource(source);
			AffectTarget(target);
			source.ResumeInput();
			logger.Log($"[{DateTime.UtcNow.ToString("o")}]:SpellCast:{source.GetName()}:{target.GetName()}");
		}
    }
}
