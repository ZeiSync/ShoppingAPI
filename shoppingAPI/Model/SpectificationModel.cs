namespace shoppingAPI.Model.Profiles
{

    public class SpectificationModel
    {
        public int Height { get; set; }
        public int Width { get; set; }
        public int Length { get; set; }
        public double Weight { get; set; }
        public string Color { get; set; }

        public GrandPianoModel GrandPiano { get; set; }
        public UprightPianoModel UprightPiano { get; set; }
        public DigitalPianoModel DigitalPiano { get; set; }
    }
}