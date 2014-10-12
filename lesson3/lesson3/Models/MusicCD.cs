using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace lesson3.Models
{
    public class MusicCD:Product
    {

        private string artist, label;
        private short released;
        private List<string> track=new List<string>();

        public string Artist{
            get { return artist; }
            set { artist = value; } 
        }
        public string Lable
        {
            get { return artist; }
            set { artist = value; }
        }
        public short Released
        {
            get { return released; }
            set { released = value; }
        }

        public  List<string> Tracks {
            get { return track;}
            set{track=value;} 
        
        
        }
        public MusicCD(short released, string lable,string artist)
        {
            this.released = released;
            this.label = lable;
            this.artist = artist;


        }
        public  void  AddTrack(string track)
        {

            
            
            this.track.Add(track);
            
           
            
        }
    }
}