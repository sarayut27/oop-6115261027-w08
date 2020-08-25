using System;
using System.Collections.Generic;
using System.Text;

namespace oop_6115261027_w08
{
    class Musiclabel
    {
        private string name;
        private string addass;
        private string songWriter;
        private Singer singerMusic;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Addass
        {
            get { return addass; }
            set { addass = value; }
        }
        public string SongWriter
        {
            get { return songWriter; }
            set { songWriter = value; }
        }
        public Singer SingerMusic
        {
            get { return singerMusic; }
            set { singerMusic = value; }
        }
        public Musiclabel() { }
        public Musiclabel(string n, string ad, string sw, Singer sm)
        {
            this.name = n;
            this.addass = ad;
            this.SongWriter = sw;
            this.singerMusic = sm;

        }
        public override string ToString()
        {
            return this.Name + " " +
                 this.Addass + " " +
                 this.SongWriter + " " +
                 this.SingerMusic.Name;

        }
    }
}
