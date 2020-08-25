using System;
using System.Collections.Generic;
using System.Text;

namespace oop_6115261027_w08
{
    class Musiclabel
    {
        private string name;
        private string addass;
        private string executive;
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
        public string Executive
        {
            get { return executive; }
            set { executive = value; }
        }
        public Singer SingerMusic
        {
            get { return singerMusic; }
            set { singerMusic = value; }
        }
        public Musiclabel() { }
        public Musiclabel(string n, string ad, string ec, Singer sm)
        {
            this.name = n;
            this.addass = ad;
            this.executive = ec;
            this.singerMusic = sm;

        }
        public override string ToString()
        {
            return this.Name + " " +
                 this.Addass + " " +
                 this.executive + " " +
                 this.SingerMusic.Name + " " +
                 this.SingerMusic.NickName;

        }
    }
}
