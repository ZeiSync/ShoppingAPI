namespace shoppingAPI.Data.Entity.Organ
{
    public class Synthesizer
    {
        public int SynthesizerId { get; set; }
        public string SoundGenerator { get; set; }
        public string Scenes { get; set; }
        public string AnalogFilter { get; set; }
        public string Group { get; set; }
        public string Pattern { get; set; }
        public string PatrernLength { get; set; }
        public string NumberOfSamples { get; set; }
        public bool RhythmPattern { get; set; }
        public bool Arpeggiator { get; set; }
        public bool ChordMemory { get; set; }
        public string ExternalMemory { get; set; }
    }
}