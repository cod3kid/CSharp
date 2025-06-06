﻿
using System;

namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            var processor = new PhotoProcessor();
            var filters = new PhotoFilters();
           // PhotoProcessor.PhotoFilterHandler filterHandler = filters.ApplyBrightness;
           // Better Approach, use Generic Delegate
            Action<Photo> filterHandler = filters.ApplyBrightness;
            filterHandler += filters.ApplyContrast;
            filterHandler += RemoveRedEyeFilter;

            processor.Process("photo.jpg", filterHandler);
        }

        static void RemoveRedEyeFilter(Photo photo)
        {
            Console.WriteLine("Apply RemoveRedEye");
            
        }
    }
}
