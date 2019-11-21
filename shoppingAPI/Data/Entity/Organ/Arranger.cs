namespace shoppingAPI.Data.Entity.Organ
{
    public class Arranger
    {
        public int ArrangerId { get; set; }

        //KEYBOARD
        public string Keyboard { get; set; }

        //SOUND GENERATOR
        public string MaximumPolyphony { get; set; }

        public string Parts { get; set; }
        public int WaveMemory { get; set; }
        public string Tones { get; set; }
        public int Reverb { get; set; }
        public int Chorus { get; set; }

        //Effects
        public string Transpose { get; set; }

        public string Octave { get; set; }

        //ARRANGER
        public string Tempo { get; set; }

        public string Styles { get; set; }
        public string OneTouchSetting { get; set; }
        public string Controls { get; set; }

        //SCALE TUNINGS
        public string ScaleRecall { get; set; }

        public string UserScaleButtons { get; set; }

        //MP3 PADS
        public string MP3Pads { get; set; }

        //METRONOME
        public string Beat { get; set; }

        //SONG
        public string InternalSongs { get; set; }

        public string Recording { get; set; }
        public bool MP3playback { get; set; }
        public string RatedPowerOutput { get; set; }
        public string Controllers { get; set; }
        public string Display { get; set; }
        public string Connectors { get; set; }
    }
}