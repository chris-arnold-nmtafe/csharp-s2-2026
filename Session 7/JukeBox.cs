using System;
using System.Collections.Generic;
using System.Text;

namespace Session_7 {
    internal class JukeBox {
        public bool Digital { get; set; }
        public string Colour { get; set; }

        public void Play() { }
        public void Pause() { }
        public void SelectSong(int song) { }
        public void SelectAlbum(string album) { }
    }
}
