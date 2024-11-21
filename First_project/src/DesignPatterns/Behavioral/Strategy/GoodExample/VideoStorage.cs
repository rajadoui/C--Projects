using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace First_project.src.DesignPatterns.Behavioral.Strategy.GoodExample
{
    public class VideoStorage
    {
        private ICompressor _compressor;

        private IOverlay _overlay;


        public VideoStorage(ICompressor compressor, IOverlay overlay)
        {
            _compressor = compressor;

            _overlay    = overlay;
        }

        public void SetCompressor(ICompressor compressor)
         {
            _compressor = compressor;
         }

         public void SetOverlay(IOverlay overlay) 
         {
            _overlay = overlay;
         }

         public void Store(string fileName)
         {
            _compressor.Compress();
            _overlay.Apply();
            System.Console.WriteLine("Storing video to " + fileName + "." + _compressor); 
         }        
    }
}