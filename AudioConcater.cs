

using NAudio.Dmo;
using NAudio.Wave;
using NAudio.Wave.SampleProviders;
internal class AudioConcater
    {
    public static void ConcatAudio()
    {
            var first = new AudioFileReader("sounds/testing/switch.wav");
            var playlist = new ConcatenatingSampleProvider(new[] { first, first, first });
            WaveFileWriter.CreateWaveFile16("sounds/testing/output.wav", playlist);
    }
}
