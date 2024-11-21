using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace First_project.src.DesignPatterns.Behavioral.Strategy
{
    public class VideoStorage
    {
        private Compressors _compressor;

        private Overlays _overlay;


        public VideoStorage(Compressors compressor, Overlays overlay = Overlays.None)
        {
            _compressor = compressor;

            _overlay    = overlay;
        }

        public void SetCompressor(Compressors compressor)
         {
            _compressor = compressor;
         }

         public void SetOverlay(Overlays overlay) 
         {
            _overlay = overlay;
         }

         public void Store(string fileName)
         {
            if (_compressor == Compressors.MOV)
            {
                System.Console.WriteLine("Compressing using MOV");
            } else if (_compressor == Compressors.MP4 )

            {
                System.Console.WriteLine("Compressing using MP4");
            } else if (_compressor == Compressors.WEBM)
            {
                System.Console.WriteLine("Compressing using WEBM");
            }
         }

         
    }
}