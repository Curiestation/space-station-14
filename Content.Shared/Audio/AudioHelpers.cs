using Content.Shared.GameObjects.Components.Sound;
using Robust.Shared.Audio;
using Robust.Shared.GameObjects;
using Robust.Shared.Interfaces.Random;
using Robust.Shared.IoC;
using Robust.Shared.Random;

namespace Content.Shared.Audio
{
    public static class AudioHelpers{
        /// <summary>
        ///     Returns a random pitch.
        /// </summary>
        public static AudioParams WithVariation(float amplitude)
        {
            var scale = amplitude * IoCManager.Resolve<IRobustRandom>().NextGaussian();
            return AudioParams.Default.WithPitchScale((float)scale);
        }
    }
}