namespace shoppingAPI.Data.Entity.Guitar
{
    public class AcousticGuitar
    {
        public int AcousticGuitarId { get; set; }
        public string BodyShape { get; set; }
        public string Top { get; set; }
        public string Back { get; set; }
        public string Sides { get; set; } //Bên hông
        public string Binding { get; set; } // Đường viền
        public string Roset { get; set; } // Đường viền lỗ thoát âm
        public string Neck { get; set; } // Cần đàn
        public string Fingerboard { get; set; } // mặt cần đàn
        public string FingerboardInlay { get; set; } //  họa tiết mặt cần đàn
        public int NumberOfFrets { get; set; } //Số ngăn phím
        public string NutAndSaddle { get; set; } //Lược đàn & Lưng ngựa đàn
        public double NutWidth { get; set; } // Độ rộng của lược đàn
        public string Trussrod { get; set; } //Trục chỉnh cần
        public string Bridge { get; set; } //	Ngựa đàn
        public string Color { get; set; }
        public bool SpeakerSystem { get; set; }
        public string Finish { get; set; } //bóng/ mờ
    }
}